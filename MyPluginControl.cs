using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Messages;
using System.ServiceModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using McTools.Xrm.Connection;

namespace DataImport
{
    public partial class MyPluginControl : PluginControlBase
    {
        // CREATE EXCEL OBJECTS.
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range xlRange;
        EntityMetadata resultsaved;
        EntityMetadata lkpresultsaved;
        RichTextBox richTextBoxErrors = new RichTextBox();
        RichTextBox richTextBoxImported = new RichTextBox();
        RichTextBox richTextBoxAll = new RichTextBox();
        RichTextBox richTextBoxWarning = new RichTextBox();
        //DataGridViewComboBoxCell dcc; //??
        string sFileName;
        bool strIsKey;
        bool IsReadyToImport = false;
        string qestr;
        int iRow, iCol = 1;
        bool flaglookup;
        int lookupscount;
        StringBuilder boxall = new StringBuilder();
        StringBuilder boxwarning = new StringBuilder();
        StringBuilder boxerror = new StringBuilder();
        StringBuilder boxsuccess = new StringBuilder();
        int successnumber = 0;
        int errornumber = 0;
        int creatednumber = 0;
        int updatednumber = 0;
        int deletednumber = 0;
        int importRunNumber = 0; // Number of times the Excel Import process has been run

        // The Settings for the import
        private Settings settings = Settings.Instance;

        // To store the table logs
        DataTable tableLogEntries = new DataTable();

        // To store the Excel Mapping once ready for import
        DataTable tableMapping = new DataTable();

        public MyPluginControl()
        {
            InitializeComponent();
        }

        // If the connection is updated and another environment is chosen.
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            InitEntities();
        }

        public void MyPluginControl_Load(object sender, System.EventArgs e)
        {
            settingsLookupFoundMultipleRecords.SelectedIndex = 0;
            settingsCrmAction.SelectedIndex = 0;
            textView.SelectedIndex = 0;
            settingsOptionSetValuesOrLabel.SelectedIndex = 0;
            settingsKeyFoundMultipleRecords.SelectedIndex = 0;
            ExecuteMethod(InitEntities);

            // Initialise the table logs
            tableLogEntries.Columns.Add("Import", typeof(int));
            tableLogEntries.Columns.Add("Line", typeof(int));
            tableLogEntries.Columns.Add("Result", typeof(string));
            tableLogEntries.Columns.Add("Updates", typeof(int));
            tableLogEntries.Columns.Add("GUID", typeof(string));
            tableLogEntries.Columns.Add("Logs", typeof(string));

            dataGridViewLogs.DataSource = tableLogEntries;

            tableMapping.TableName = "TableMapping";

            // Initialise the table mapping
            tableMapping.Columns.Add("ExcelColumn");
            tableMapping.Columns.Add("isKey", typeof(bool));
            tableMapping.Columns.Add("CRMField");
            tableMapping.Columns.Add("IsLookup");
            tableMapping.Columns.Add("lkpTargetEntity");
            tableMapping.Columns.Add("lkpTargetfield");
            tableMapping.Columns.Add("Truevalue");
            tableMapping.Columns.Add("Falsevalue");
            tableMapping.Columns.Add("DefaultValue");
            tableMapping.Columns.Add("BlankBehaviour");

            this.dataGridViewMapping.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMapping_CellValueChanged);
        }

        public void InitEntities()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting entities",
                Work = (worker, args) =>
                {
                    RetrieveAllEntitiesResponse metaDataResponse = new RetrieveAllEntitiesResponse();
                    RetrieveAllEntitiesRequest retrieveAllEntitiesRequest = new RetrieveAllEntitiesRequest
                    {
                        RetrieveAsIfPublished = true,
                        EntityFilters = EntityFilters.Attributes
                    };

                    retrieveAllEntitiesRequest.EntityFilters = EntityFilters.Entity;
                    // Execute the request.
                    args.Result = (RetrieveAllEntitiesResponse)Service.Execute(retrieveAllEntitiesRequest);


                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    settingsEntity.Items.Clear();
                    lkpTargetEntity.Items.Clear();
                    var result = args.Result as RetrieveAllEntitiesResponse;
                    if (result != null)
                    {
                        var entities = result.EntityMetadata;
                        foreach (EntityMetadata Entity in entities)
                        {
                            settingsEntity.Items.Add(Entity.LogicalName);
                            lkpTargetEntity.Items.Add(Entity.LogicalName);
                        }
                    }
                }
            });
        }
        private void StartBackgroundWork(int i)
        {
            double perr = (i - 1) / (1.0 * (xlRange.Rows.Count - 1)) * 100;

            //labelprogress.Text = "Import Progress "+perr.ToString("F") + "%";
        }

        private void InitEntityFields()
        {
            if (settingsEntity.SelectedItem == null)
            {
                //MessageBox.Show("Please load entities first and pick your entity then press this button.");
                //ExecuteMethod(InitEntities);
                return;
            }
            CRMField.Items.Clear();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting entity fields",
                Work = (worker, args) =>
                {
                    Dictionary<string, string> attributesData = new Dictionary<string, string>();
                    RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest
                    {
                        EntityFilters = EntityFilters.All,
                        LogicalName = settings.Entity
                    };

                    // Execute the request
                    args.Result = (RetrieveEntityResponse)Service.Execute(retrieveEntityRequest);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as RetrieveEntityResponse;
                    resultsaved = result.EntityMetadata;
                    if (result != null)
                    {
                        CRMField.Items.Add("");
                        foreach (object attribute in resultsaved.Attributes)
                        {
                            AttributeMetadata a = (AttributeMetadata)attribute;

                            if (a.AttributeType.ToString() == "DateTime" || a.AttributeType.ToString() == "State" || a.AttributeType.ToString() == "Memo" || a.AttributeType.ToString() == "String" || (a.AttributeType.ToString() == "Virtual" && a.SourceType == 0) || a.AttributeType.ToString() == "Picklist" || a.AttributeType.ToString() == "Boolean" || a.AttributeType.ToString() == "Integer" || a.AttributeType.ToString() == "Decimal" || a.AttributeType.ToString() == "Money" || a.AttributeType.ToString() == "Lookup" || a.AttributeType.ToString() == "Customer" || a.AttributeType.ToString() == "Uniqueidentifier" || a.AttributeType.ToString() == "Owner")
                                CRMField.Items.Add(a.LogicalName.ToString());
                        }
                        
                    }
                }
            });
        }

        private void InitLookupFields(string myentity, int thatRow)
        {

            if (myentity == null || myentity == "")
            {
                return;
            }
            //lkpTargetfield.Items.Clear();
            DataGridViewComboBoxCell datalkpfield = dataGridViewMapping.Rows[thatRow].Cells[5] as DataGridViewComboBoxCell;
            datalkpfield.Items.Clear();
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting entity fields",
                Work = (worker, args) =>
                {
                    Dictionary<string, string> attributesData = new Dictionary<string, string>();
                    RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest
                    {
                        EntityFilters = EntityFilters.All,
                        LogicalName = myentity
                    };

                    // Execute the request
                    args.Result = (RetrieveEntityResponse)Service.Execute(retrieveEntityRequest);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as RetrieveEntityResponse;
                    lkpresultsaved = result.EntityMetadata;
                    if (result != null)
                    {
                        DataGridViewComboBoxCell stateCell = (DataGridViewComboBoxCell)(dataGridViewMapping.Rows[thatRow].Cells[5]);

                        foreach (object attribute in lkpresultsaved.Attributes)
                        {
                            AttributeMetadata a = (AttributeMetadata)attribute;
                            if (a.AttributeType.ToString() == "Uniqueidentifier" || a.AttributeType.ToString() == "String" /*|| a.AttributeType.ToString() == "DateTime"  || a.AttributeType.ToString() == "Integer" || a.AttributeType.ToString() == "Decimal" || a.AttributeType.ToString() == "Money"*/)
                            {
                                stateCell.Items.Add(a.LogicalName.ToString());
                            }
                        }
                    }
                }
            });
        }

        private void TsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }


        private void TsbSample_Click(object sender, EventArgs e)
        {
            ExecuteMethod(InitEntities);
        }

        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), settings);
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // GET DATA FROM EXCEL AND POPULATE COMB0 BOX.
        private void ReadExcel(string sFile)
        {

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Reading Excel File..",
                Work = (worker, args) =>
                {
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(sFile);    // WORKBOOK TO OPEN THE EXCEL FILE.
                    xlWorkSheet = xlWorkBook.Worksheets[1];      // NAME OF THE SHEET.
                    xlRange = xlWorkSheet.UsedRange;
                },
                PostWorkCallBack = (args) =>
                {
                    for (iCol = 1; iCol <= xlRange.Columns.Count; iCol++)  // START FROM THE SECOND ROW.
                    {
                        if (xlRange.Cells[1, iCol].value == null)
                        {
                            break;      // BREAK LOOP.
                        }
                        else
                        {
                            dataGridViewMapping.Rows.Add(xlRange.Cells[1, iCol].value);
                        }
                    }

                    // Set the labels and row values to the correct values.
                    textRowCount.Text = ((xlRange.Rows.Count) - 1).ToString();
                    rowEndNum.Maximum = xlRange.Rows.Count;
                    rowEndNum.Minimum = 2;
                    rowEndNum.Value = xlRange.Rows.Count;
                    rowStartNum.Maximum = xlRange.Rows.Count;
                    rowStartNum.Value = 2;

                    xlWorkBook.Close();
                    xlApp.Quit();

                    processFieldsButton.Enabled = true;
                }
            });
        }

        private void SetTextBox1()
        {
            if (textView.SelectedItem.ToString() == "📙 ALL")
            {
                richTextBox1.Text = richTextBoxAll.Text;
            }
            else if (textView.SelectedItem.ToString() == "✓ SUCCESS")
            {
                richTextBox1.Text = richTextBoxImported.Text;
            }
            else if (textView.SelectedItem.ToString() == "❌ ERRORS")
            {
                richTextBox1.Text = richTextBoxErrors.Text;
            }
            else if (textView.SelectedItem.ToString() == "⚠ WARNINGS")
            {
                richTextBox1.Text = richTextBoxWarning.Text;
            }
            textBoxSuccess.Text = successnumber.ToString();
            textBoxError.Text = errornumber.ToString();
            textCreated.Text = creatednumber.ToString();
            textUpdated.Text = updatednumber.ToString();
            textDeleted.Text = deletednumber.ToString();

        }
        private void TextView_DropDownClosed(object sender, EventArgs e)
        {
            //SetTextBox1();

            if (textView.SelectedItem.ToString() == "📙 ALL")
            {
                richTextBox1.Text = richTextBoxAll.Text;
            }
            else if (textView.SelectedItem.ToString() == "✓ SUCCESS")
            {
                richTextBox1.Text = richTextBoxImported.Text;
            }
            else if (textView.SelectedItem.ToString() == "❌ ERRORS")
            {
                richTextBox1.Text = richTextBoxErrors.Text;
            }
            else if (textView.SelectedItem.ToString() == "⚠ WARNINGS")
            {
                richTextBox1.Text = richTextBoxWarning.Text;
            }
            textBoxSuccess.Text = successnumber.ToString();
            textBoxError.Text = errornumber.ToString();
            textCreated.Text = creatednumber.ToString();
            textUpdated.Text = updatednumber.ToString();
            textDeleted.Text = deletednumber.ToString();
        }
        private void EmptyDataGrid()
        {
            dataGridViewMapping.Rows.Clear();
            dataGridViewMapping.Columns["lkpTargetEntity"].Visible = false;
            dataGridViewMapping.Columns["lkpTargetfield"].Visible = false;
            dataGridViewMapping.Columns["Truevalue"].Visible = false;
            dataGridViewMapping.Columns["Falsevalue"].Visible = false;
            dataGridViewMapping.Columns["DefaultValue"].Visible = false;
        }

        private void GetFile()
        {
            openFileDialog1.Title = "Excel File to Import";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                EmptyDataGrid();
                string file = openFileDialog1.FileName;
                try
                {
                    sFileName = openFileDialog1.FileName;

                    if (sFileName.Trim() != "")
                    {
                        ReadExcel(sFileName);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Failed to load Excel file correctly:" + ex.Message.ToString());
                }
            }
        }
        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            GetFile();
            loadSettingsButton.Enabled = true;
        }

        private void rowStartNum_ValueChanged(object sender, EventArgs e)
        {
            // Set row end equal to start if start is after end
            if (rowEndNum.Value <= rowStartNum.Value) {
                rowEndNum.Value = rowStartNum.Value;
            }
            // Make the minimum equal to the new start
            rowEndNum.Minimum = new decimal(new int[] {
                        (int) rowStartNum.Value,
                        0,
                        0,
                        0
            });


        }

        private void ImportDataButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMapping.RowCount == 0)
            {
                MessageBox.Show("Please BROWSE EXCEL FILE first and Pick your entity and fields mapping before Lauching the Import to CRM.");
                return;
            }

            dataGridViewMapping.CurrentCell = dataGridViewMapping.Rows[0].Cells[0];

            if (settingsCrmAction.SelectedIndex != 1)
            {
                bool wehavekey = false;
                foreach (DataGridViewRow dataGridRow in dataGridViewMapping.Rows)
                {
                    if (dataGridRow.Cells["isKey"].Value != null && (bool)dataGridRow.Cells["isKey"].Value)
                    {
                        wehavekey = true;
                        break;
                    }
                }
                if (!wehavekey)
                {
                    DialogResult dialogResult = MessageBox.Show("You did not tick any Excel Column as an 'is Key' field." + Environment.NewLine + "This action will result in Updating/Deleting all of your CRM records for each excel line!" + Environment.NewLine + "We advice to end this request by clicking on 'No'. " + Environment.NewLine + "Do you still wish to go on with the CRM Import?", "Watch Out!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (IsReadyToImport)
            {
                ImportExcel();
            }
            else
            {
                MessageBox.Show("WARNING: Action will not be launched. Please press the button 'PROCESS FIELDS' before importing to CRM.");
            }
        }


        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ///CLEAR ALL

            xlWorkBook = null;
            xlWorkSheet = null;
            xlRange = null;
            xlApp = null;

            settingsEntity.SelectedItem = null;
            settingsLookupFoundMultipleRecords.Visible = false;
            settingsCrmAction.SelectedIndex = 0;
            settingsLookupFoundMultipleRecords.SelectedIndex = 0;
            settingsOptionSetValuesOrLabel.SelectedIndex = 0;
            settingsKeyFoundMultipleRecords.SelectedIndex = 0;
            settings.Reset();

            label2.Visible = false;
            settingsOptionSetValuesOrLabel.Visible = false;
            label4.Visible = false;

            EmptyDataGrid();
            CRMField.Items.Clear();
        }

        private void dataGridViewMapping_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            switch (e.ColumnIndex)
            {
                // If the user changes the CRM Field, check if it is a lookup and process it
                case 2:
                    foreach (object attribute in resultsaved.Attributes)
                    {
                        AttributeMetadata a = (AttributeMetadata)attribute;
                        if (a.LogicalName.ToString() == dataGridViewMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString())  //Find the CRM field between the metadata
                        {
                            if (a.AttributeType.ToString() == "Lookup" || a.AttributeType.ToString() == "Customer" || a.AttributeType.ToString() == "Owner") // check if the CRM field is of type Lookup
                            {
                                processLookupEntity(e.RowIndex);
                            }
                            else
                            {
                                processNonLookupEntity(e.RowIndex);
                            }
                            if (a.AttributeType.ToString() == "Boolean")
                            {
                                processBoolean(e.RowIndex);
                            }
                            if (a.AttributeType.ToString() == "Picklist" || a.AttributeType.ToString() == "State")
                            {
                                processChoice();
                            }
                        }
                    }
                    break;

                case 4:
                    dataGridViewMapping.Rows[e.RowIndex].Cells["lkpTargetfield"].Value = null;
                    processLookupField(e.RowIndex);
                    break;


            }
        }

        private void processLookupEntity(int row)
        {
            // make the lookup columns visible
            dataGridViewMapping.Columns["lkpTargetEntity"].Visible = true;
            dataGridViewMapping.Columns["lkpTargetfield"].Visible = true;
            label4.Visible = true;
            settingsLookupFoundMultipleRecords.Visible = true;
            
            //Flag row as lookup
            lookupscount++;
            dataGridViewMapping.Rows[row].Cells["IsLookup"].Value = true;

            // Unlock the lookup fields
            DataGridViewComboBoxCell data1 = dataGridViewMapping.Rows[row].Cells[4] as DataGridViewComboBoxCell;
            data1.ReadOnly = false;
            data1.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            DataGridViewComboBoxCell data2 = dataGridViewMapping.Rows[row].Cells[5] as DataGridViewComboBoxCell;
            data2.ReadOnly = false;
            data2.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
        }

        private void processLookupField(int row)
        {
            string lkpentityname = Convert.ToString((dataGridViewMapping.Rows[row].Cells[4] as DataGridViewComboBoxCell).FormattedValue.ToString());
            InitLookupFields(lkpentityname, row);
        }

        private void processNonLookupEntity(int row)
        {
            // set is Lookup to false
            dataGridViewMapping.Rows[row].Cells["IsLookup"].Value = false;

            // Lock the lookup fields
            DataGridViewComboBoxCell data1 = dataGridViewMapping.Rows[row].Cells[4] as DataGridViewComboBoxCell;
            data1.ReadOnly = true;
            data1.Value = null;
            data1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            DataGridViewComboBoxCell data2 = dataGridViewMapping.Rows[row].Cells[5] as DataGridViewComboBoxCell;
            data2.ReadOnly = true;
            data2.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            data2.Value = null;
        }

        private void processBoolean(int row)
        {
            dataGridViewMapping.Columns["Truevalue"].Visible = true;
            dataGridViewMapping.Columns["Falsevalue"].Visible = true;
            dataGridViewMapping.Columns["DefaultValue"].Visible = true;
            DataGridViewCell databooltrue = dataGridViewMapping.Rows[row].Cells["Truevalue"] as DataGridViewCell;
            databooltrue.ReadOnly = false;
            databooltrue.Style.BackColor = Color.LightGray;
            DataGridViewCell databoolfalse = dataGridViewMapping.Rows[row].Cells["Falsevalue"] as DataGridViewCell;
            databoolfalse.ReadOnly = false;
            databoolfalse.Style.BackColor = Color.LightGray;
            DataGridViewCell databooldefault = dataGridViewMapping.Rows[row].Cells["DefaultValue"] as DataGridViewCell;
            databooldefault.ReadOnly = false;
            databooldefault.Style.BackColor = Color.LightGray;

            //fetch for true and false boolean values
            RetrieveAttributeRequest retrieveAttributeRequest = new RetrieveAttributeRequest
            {
                EntityLogicalName = settingsEntity.SelectedItem.ToString(),
                LogicalName = Convert.ToString((dataGridViewMapping.Rows[row].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString()),
                RetrieveAsIfPublished = true
            };
            RetrieveAttributeResponse retrieveAttributeResponse = (RetrieveAttributeResponse)Service.Execute(retrieveAttributeRequest);
            BooleanAttributeMetadata retrievedBooleanAttributeMetadata = (BooleanAttributeMetadata)retrieveAttributeResponse.AttributeMetadata;
            string boolTextTrue = retrievedBooleanAttributeMetadata.OptionSet.TrueOption.Label.UserLocalizedLabel.Label;
            string boolTextFalse = retrievedBooleanAttributeMetadata.OptionSet.FalseOption.Label.UserLocalizedLabel.Label;
            bool boolDefault = retrievedBooleanAttributeMetadata.DefaultValue.Value;
            string boolTextDefault;

            if (boolDefault)
                boolTextDefault = boolTextTrue;
            else
                boolTextDefault = boolTextFalse;

            dataGridViewMapping.Rows[row].Cells["Truevalue"].Value = boolTextTrue;
            dataGridViewMapping.Rows[row].Cells["Falsevalue"].Value = boolTextFalse;
            dataGridViewMapping.Rows[row].Cells["DefaultValue"].Value = boolTextDefault;
        }

        private void processChoice()
        {
            label2.Visible = true;
            settingsOptionSetValuesOrLabel.Visible = true;
        }

        private void ProcessFields()
        {
            if (dataGridViewMapping.RowCount == 0)
            {
                MessageBox.Show("Please BROWSE EXCEL FILE and Pick your entity and fields mapping first.");
                return;
            }
            dataGridViewMapping.CurrentCell = dataGridViewMapping.Rows[0].Cells[0];
            string acrmfield;
            int dRow;
            lookupscount = 0;
            for (dRow = 0; dRow < dataGridViewMapping.RowCount; dRow++)
            {
                string lkpentityname = Convert.ToString((dataGridViewMapping.Rows[dRow].Cells[4] as DataGridViewComboBoxCell).FormattedValue.ToString());
                acrmfield = Convert.ToString((dataGridViewMapping.Rows[dRow].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString());
                foreach (object attribute in resultsaved.Attributes)
                {
                    AttributeMetadata a = (AttributeMetadata)attribute;
                    if (a.LogicalName.ToString() == acrmfield)  //Find the CRM field between the metadata
                    {
                        if (a.AttributeType.ToString() == "Lookup" || a.AttributeType.ToString() == "Customer" || a.AttributeType.ToString() == "Owner") // check if the CRM field is of type Lookup
                        {
                            processLookupEntity(dRow);
                            processLookupField(dRow);
                        }
                        else
                        {
                            processNonLookupEntity(dRow);
                        }
                        if (a.AttributeType.ToString() == "Boolean")
                        {
                            processBoolean(dRow);
                        }
                        if (a.AttributeType.ToString() == "Picklist" || a.AttributeType.ToString() == "State")
                        {
                            processChoice();
                        }
                    }
                }
            }
            IsReadyToImport = true;
            importDataButton.Enabled = true;
        }
        
        private void ProcessFieldsButton_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ProcessFields);
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in richTextBox1.Lines)
                sb.AppendLine(line);
            if (sb.Length != 0)
                Clipboard.SetText(sb.ToString());
            else
                MessageBox.Show("Logs are empty");
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            SetTextBox1();
            dataGridViewLogs.Refresh();
        }

        

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void blogURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.d365tips.com/home/xrmtoolbox-dataimport");
        }

        private void LogToggle_Click(object sender, EventArgs e)
        {
            if (splitContainer4.Panel2Collapsed == true)
            {
                LogTableShow();
            }
            else
            {
                LogTableHide();
            }
        }

        private void LogTableHide()
        {
            splitContainer4.Panel2Collapsed = true;
            LogToggle.Text = "Show Log Table";
            
        }

        private void LogTableShow()
        {
            splitContainer4.Panel2Collapsed = false;
            LogToggle.Text = "Hide Log Table";
        }

        private void AddToLogRow(string[] row, string log = null, string GUID = null, string result = null)
        {
            // 0 = #
            // 1 = Line
            // 2 = Result
            // 3 = Updates
            // 4 = GUID
            // 5 = Logs

            // add the GUID to the cell if GUID is not null
            if (GUID != null)
            {
                if (row[4] == null)
                {
                    row[3] = "1";
                    row[4] = GUID;
                }
                else
                {
                    row[3] = (int.Parse(row[3]) + 1).ToString();
                    row[4] += " " + GUID;
                }
            }

            // Add the logs to the log cell
            if (log != null)
            {
                if (row[5] == null)
                {
                    row[5] = log;
                }
                else
                {
                    row[5] += " | " + log;
                }
            }
            

            // If a result is provided, add it to the result cell
            if (result == null)
            { return; }
            else
            {
                row[2] = result;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            // Ensure that the mapping table in Settings reflects the current state of the table.
            SetMappingTableFromDataGridView();

            string instructions = "Enter the name of your settings file. \n It will be saved in the default settings location (XRMToolbox\\Settings)";
            string title = "Save Settings File";

            string settingsFileName = Interaction.InputBox(instructions, title);
             
            if (!string.IsNullOrEmpty(settingsFileName))
            {
                SettingsManager.Instance.Save(GetType(), settings, settingsFileName);
            }
        }

        private void loadSettingsButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Settings File";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML File|*.xml";
            // Set the default directory of the file dialog to be the current working directory / Settings
            openFileDialog1.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Settings");

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string fileName = openFileDialog1.FileName;
                try
                {
                    if (fileName.Trim() != "")
                    {
                        settings.LoadSettingsFromXML(fileName);
                        settingsEntity.SelectedItem = settings.Entity;
                        settingsCrmAction.SelectedItem = settings.CrmAction;
                        settingsKeyFoundMultipleRecords.SelectedItem = settings.KeyFoundMultipleRecords;
                        settingsLookupFoundMultipleRecords.SelectedItem = settings.LookupFoundMultipleRecords;
                        settingsOptionSetValuesOrLabel.SelectedItem = settings.OptionSetValuesOrLabel;
                        InitEntityFields();
                        dataGridViewMapping.Rows.Clear();

                        // Add rows
                        foreach (DataRow row in settings.XMLTableMapping.Table.Rows)
                        {
                            int rowIndex = dataGridViewMapping.Rows.Add(row.ItemArray);
                            foreach (DataGridViewColumn col in dataGridViewMapping.Columns)
                            {
                                if (col is DataGridViewComboBoxColumn)
                                {
                                    DataGridViewComboBoxColumn comboCol = col as DataGridViewComboBoxColumn;
                                    if (!comboCol.Items.Contains(dataGridViewMapping.Rows[rowIndex].Cells[col.Index].Value))
                                    {
                                        comboCol.Items.Add(dataGridViewMapping.Rows[rowIndex].Cells[col.Index].Value);
                                    }
                                }
                            }
                        }
                        ExecuteMethod(ProcessFields);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Failed to load Excel file correctly:" + ex.Message.ToString());
                }
            }
            
        }

        private void settingsEntity_DropDownClosed(object sender, EventArgs e)
        {
            if (settingsEntity.SelectedItem != null)
            {
                settings.Entity = settingsEntity.SelectedItem.ToString();
                for (int o = 0; o < dataGridViewMapping.RowCount; o++)
                {
                    DataGridViewComboBoxCell data = dataGridViewMapping.Rows[o].Cells[2] as DataGridViewComboBoxCell;
                    data.Value = null;
                }
                ExecuteMethod(InitEntityFields);
            }
            else if (settingsEntity.Items.Count == 0)
            {
                ExecuteMethod(InitEntities);
            }
        }

        private void settingsCrmAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.CrmAction = settingsCrmAction.SelectedItem.ToString();
            if (settings.CrmAction == "Create")
            {
                settingsKeyFoundMultipleRecords.Visible = false;
                label6.Visible = false;
                dataGridViewMapping.Columns[1].Visible = false;
            }
            else
            {
                settingsKeyFoundMultipleRecords.Visible = true;
                label6.Visible = true;
                dataGridViewMapping.Columns[1].Visible = true;
            }
        }

        private void settingsKeyFoundMultipleRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.KeyFoundMultipleRecords = settingsKeyFoundMultipleRecords.SelectedItem.ToString();
        }

        private void settingsOptionSetValuesOrLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.OptionSetValuesOrLabel = settingsOptionSetValuesOrLabel.SelectedItem.ToString();
        }

        private void settingsLookupFoundMultipleRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.LookupFoundMultipleRecords = settingsLookupFoundMultipleRecords.SelectedItem.ToString();
        }

        private void SetMappingTableFromDataGridView()
        {

            tableMapping.Clear();

            foreach (DataGridViewRow row in dataGridViewMapping.Rows)
            {
                DataRow dRow = tableMapping.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        if (cell.ColumnIndex == 1 || cell.ColumnIndex == 3)
                        {
                            dRow[cell.ColumnIndex] = false;
                        }
                        else
                        {
                            dRow[cell.ColumnIndex] = DBNull.Value;
                        }
                    }
                    else
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                }
                tableMapping.Rows.Add(dRow);
            }

            SerializableDataTable serializableMappingTable = new SerializableDataTable(tableMapping);
            settings.XMLTableMapping = serializableMappingTable;
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                DataGridView view = (DataGridView)sender;
                DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)view.Columns[e.ColumnIndex];
                string value = view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                MessageBox.Show($"Error in column '{column.Name}' at row {e.RowIndex + 1}. Value '{value}' is not valid.");
            }
        }

        private void ImportExcel()
        {
            //Verification que L'action CRM est bien choisie
            if (settingsCrmAction.SelectedItem == null)
            {
                MessageBox.Show("Please choose a CRM action before importing a file to CRM");
                return;
            }

            SetMappingTableFromDataGridView();
            DataTable dt = tableMapping;

            // Ensure all visible settings are applied
            settings.Entity = settingsEntity.SelectedItem.ToString();
            settings.CrmAction = settingsCrmAction.SelectedItem.ToString();
            settings.LookupFoundMultipleRecords = settingsLookupFoundMultipleRecords.SelectedItem.ToString();
            settings.OptionSetValuesOrLabel = settingsOptionSetValuesOrLabel.SelectedItem.ToString();
            settings.KeyFoundMultipleRecords = settingsKeyFoundMultipleRecords.SelectedItem.ToString();

            successnumber = 0;
            errornumber = 0;
            creatednumber = 0;
            updatednumber = 0;
            deletednumber = 0;
            textBoxSuccess.Text = successnumber.ToString();
            textBoxError.Text = errornumber.ToString();
            textCreated.Text = creatednumber.ToString();
            textUpdated.Text = updatednumber.ToString();
            textDeleted.Text = deletednumber.ToString();
            importDataButton.Enabled = false;
            processFieldsButton.Enabled = false;
            LogTableShow();
            importRunNumber++;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Importing...",
                Work = (wcl, e) =>
                {
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(sFileName);   // WORKBOOK TO OPEN THE EXCEL FILE.
                    xlWorkSheet = xlWorkBook.Worksheets[1];  // NAME OF THE SHEET.
                    xlRange = xlWorkSheet.UsedRange;
                    string[] logicalnm = new string[xlRange.Columns.Count];
                    Guid _recordId = new Guid();
                    bool istoimport;
                    
                    richTextBoxErrors.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine;
                    richTextBoxImported.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "✓LINE1" + " - COLUMNS HEADER";
                    richTextBoxAll.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "✓LINE1" + " - COLUMNS HEADER";
                    richTextBoxWarning.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine;
                    
                    for (iRow = (int) rowStartNum.Value; iRow <= (int) rowEndNum.Value; iRow++)  // Iterate over the selected rows
                    {
                        if (wcl.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }

                        Entity record = null;
                        record = new Entity(settings.Entity);
                        istoimport = true;
                        flaglookup = false;

                        // Add a row to the log table and set current rows
                        int rowNumber = tableLogEntries.Rows.Count + 1;
                        string[] row = { importRunNumber.ToString(), iRow.ToString(), null, null, null, null };

                    QueryExpression qe = new QueryExpression
                        {
                            EntityName = settings.Entity,
                            ColumnSet = new ColumnSet()
                        };
                        
                        for (iCol = 1; iCol <= xlRange.Columns.Count; iCol++)
                        {
                            string myfieldlabel = dt.Rows[iCol - 1][2].ToString();  //GET FIELD NAME
                            if (xlRange[1, iCol].value == null || xlRange[1,iCol].value=="" || string.IsNullOrEmpty(myfieldlabel))
                            {
                                continue;
                            }
                            //string myfieldlabel = dt.Rows[iCol - 1][2].ToString();  //GET FIELD NAME
                            //if(string.IsNullOrEmpty(myfieldlabel))
                            //    break;
                            logicalnm[iCol - 1] = myfieldlabel;
                            string myfieldtype = "";
                            if (xlRange.Cells[iRow, iCol].value == null || xlRange[1, iCol].value == "")
                            {
                                if (dt.Rows[iCol - 1][9].ToString() == "Clears CRM value")
                                {
                                    foreach (object attribute in resultsaved.Attributes)
                                    {
                                        AttributeMetadata a = (AttributeMetadata)attribute;
                                        if (a.LogicalName.ToString() == myfieldlabel)
                                        {
                                            myfieldtype = a.AttributeType.ToString();
                                            break;
                                        }
                                    }
                                    if (myfieldtype == "String" || myfieldtype == "Memo")
                                    {
                                        record[logicalnm[iCol - 1]] = "";
                                    }
                                    else if (myfieldtype == "Picklist" || myfieldtype == "DateTime" || myfieldtype == "Customer" || myfieldtype == "Lookup" || myfieldtype == "State")
                                    {
                                        record[logicalnm[iCol - 1]] = null;
                                    }
                                    else if (myfieldtype == "Owner") { }
                                    else if (myfieldtype == "Boolean")
                                    {
                                        if ((dt.Rows[iCol - 1]["DefaultValue"].ToString().ToLower()) == (dt.Rows[iCol - 1]["Truevalue"].ToString().ToLower()))
                                        {
                                            record[logicalnm[iCol - 1]] = true;
                                        }
                                        else if ((dt.Rows[iCol - 1]["DefaultValue"].ToString().ToLower()) == (dt.Rows[iCol - 1]["Falsevalue"].ToString().ToLower()))
                                        {
                                            record[logicalnm[iCol - 1]] = false;
                                        }
                                    }
                                    else if (myfieldtype == "Virtual")
                                    {
                                        OptionSetValueCollection multioptionset = new OptionSetValueCollection();
                                        record[logicalnm[iCol - 1]] = multioptionset;
                                    }

                                    if (dt.Rows[iCol - 1][1] == null)
                                        strIsKey = false;
                                    else
                                        strIsKey = Convert.ToBoolean(dt.Rows[iCol - 1][1]);

                                    if (strIsKey)
                                    {
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Null));
                                        // Update Logs
                                        AddToLogRow(row, "⚠ EXCEL LINE contains an empty key field: " + myfieldlabel);
                                        richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - EXCEL LINE contains an empty key field: " + myfieldlabel;
                                        richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - EXCEL LINE contains an empty key field: " + myfieldlabel;
                                    }
                                }
                            }
                            else //Record not empty
                            {
                                //SET UP FIELDS OF THE ENTITY
                                foreach (object attribute in resultsaved.Attributes)
                                {
                                    AttributeMetadata a = (AttributeMetadata)attribute;
                                    if (a.LogicalName.ToString() == myfieldlabel)
                                    {
                                        myfieldtype = a.AttributeType.ToString();
                                        if (myfieldtype == "Picklist")
                                        {
                                            //// OPTIONSET LABELS
                                            if (settings.OptionSetValuesOrLabel == "Labels")
                                            {

                                                var picklistMetadata = (PicklistAttributeMetadata)resultsaved.Attributes.FirstOrDefault(myattribute => String.Equals(myattribute.LogicalName, a.LogicalName, StringComparison.OrdinalIgnoreCase));
                                                var options = (from o in picklistMetadata.OptionSet.Options
                                                               select new { Value = o.Value, Text = o.Label.UserLocalizedLabel.Label }).ToList();
                                                try
                                                {
                                                    string xlvalue;
                                                    if (xlRange.Cells[iRow, iCol].value.Equals(typeof(String)))
                                                        xlvalue = xlRange.Cells[iRow, iCol].value;
                                                    else
                                                        xlvalue = xlRange.Cells[iRow, iCol].value.ToString();
                                                    int activeValue = (int)options.Where(o => o.Text == xlvalue).Select(o => o.Value).FirstOrDefault();
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(activeValue);
                                                }
                                                catch (InvalidOperationException ex)
                                                {
                                                    // Update Logs
                                                    AddToLogRow(row, "⚠ Couldnt match Optionset Label : " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2 + " - " + ex.Message.ToString());
                                                    richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match Optionset Label : " + xlRange.Cells[iRow, iCol].value + " - " + ex.Message.ToString();
                                                    richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match Optionset Label : " + xlRange.Cells[iRow, iCol].value + " - " + ex.Message.ToString();
                                                    //SetTextBox1();
                                                }



                                            }
                                            else //OPTIONSET VALUES
                                            {
                                                if (xlRange.Cells[iRow, iCol].value.Equals(typeof(String)))
                                                {
                                                    int intvaluecell = 0;
                                                    try
                                                    {
                                                        intvaluecell = System.Convert.ToInt32(xlRange.Cells[iRow, iCol].value);
                                                        record[logicalnm[iCol - 1]] = new OptionSetValue(intvaluecell);
                                                    }
                                                    catch (FormatException)
                                                    {
                                                        MessageBox.Show("Not a valid integer for an option set value field type");
                                                    }
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue();
                                                }
                                                else
                                                {
                                                    int avalue = (int)xlRange.Cells[iRow, iCol].value;
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(avalue);
                                                }
                                            }

                                            ////END OPTIONSET
                                        }
                                        else if (myfieldtype == "State")
                                        {
                                            if (xlRange.Cells[iRow, iCol].value.Equals(typeof(String)))
                                            {
                                                // Active
                                                if (xlRange.Cells[iRow, iCol].value == "0" || xlRange.Cells[iRow, iCol].value.ToLower() == "active" || xlRange.Cells[iRow, iCol].value.ToLower() == "actif")
                                                {
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(0);
                                                }

                                                // Inactive
                                                else if (xlRange.Cells[iRow, iCol].value == "1" || xlRange.Cells[iRow, iCol].value.ToLower() == "inactive" || xlRange.Cells[iRow, iCol].value.ToLower() == "inactif")
                                                {
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(1);
                                                }
                                            }
                                            else
                                            {
                                                if (xlRange.Cells[iRow, iCol].value.ToString() == "0" || xlRange.Cells[iRow, iCol].value.ToLower() == "active" || xlRange.Cells[iRow, iCol].value.ToLower() == "actif")
                                                {
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(0);
                                                }
                                                else if (xlRange.Cells[iRow, iCol].value.ToString() == "1" || xlRange.Cells[iRow, iCol].value.ToLower() == "inactive" || xlRange.Cells[iRow, iCol].value.ToLower() == "inactif")
                                                {
                                                    record[logicalnm[iCol - 1]] = new OptionSetValue(1);
                                                }
                                            }
                                        }
                                        /// if BOOLEAN
                                        else if (myfieldtype == "Boolean")
                                        {
                                            if (xlRange.Cells[iRow, iCol].value.ToString().ToLower() == (dt.Rows[iCol - 1]["Truevalue"].ToString().ToLower()))
                                            {
                                                record[logicalnm[iCol - 1]] = true;
                                            }
                                            else if (xlRange.Cells[iRow, iCol].value.ToString().ToLower() == (dt.Rows[iCol - 1]["Falsevalue"].ToString().ToLower()))
                                            {
                                                record[logicalnm[iCol - 1]] = false;
                                            }
                                            else
                                            {
                                                // Update Logs
                                                AddToLogRow(row, "⚠ Couldnt match boolean value: " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2 + " - REASON: Only available options are: " + dt.Rows[iCol - 1]["Truevalue"].ToString() + " and " + dt.Rows[iCol - 1]["Falsevalue"].ToString());
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + dt.Rows[iCol - 1]["Truevalue"].ToString() + " and " + dt.Rows[iCol - 1]["Falsevalue"].ToString();
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + dt.Rows[iCol - 1]["Truevalue"].ToString() + " and " + dt.Rows[iCol - 1]["Falsevalue"].ToString();
                                            }
                                        }
                                        else if (myfieldtype == "Virtual")
                                        {
                                            OptionSetValueCollection multioptionset = new OptionSetValueCollection();
                                            string authors;
                                            if (xlRange.Cells[iRow, iCol].Equals(typeof(String)))
                                                authors = xlRange.Cells[iRow, iCol].value.Replace(" ", "");
                                            else
                                                authors = xlRange.Cells[iRow, iCol].value.ToString().Replace(" ", "");
                                            // Split authors separated by a comma followed by space  
                                            string[] authorsList = authors.Split(';');
                                            foreach (string author in authorsList)
                                            {
                                                try
                                                { 
                                                    multioptionset.Add(new OptionSetValue(Convert.ToInt32(author))); //Swimming
                                                }
                                                catch (FormatException)
                                                {
                                                    // Update Logs
                                                    AddToLogRow(row, "⚠ MultiSelect OptionSet field : " + myfieldlabel + ": " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2.ToString() + " is not valid.");
                                                    richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - MultiSelect OptionSet field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                                    richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - MultiSelect OptionSet field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                                }
                                            }
                                            record[logicalnm[iCol - 1]] = multioptionset;
                                        }
                                        break;
                                    }
                                }
                                if (myfieldtype == "String" || myfieldtype == "Memo")
                                {
                                    if (xlRange.Cells[iRow, iCol].value.Equals(typeof(String)))
                                    {
                                        record[logicalnm[iCol - 1]] = xlRange.Cells[iRow, iCol].value;
                                    }
                                    else
                                    {
                                        record[logicalnm[iCol - 1]] = xlRange.Cells[iRow, iCol].value.ToString();
                                    }
                                }
                                    
                                else if (myfieldtype == "DateTime")
                                {
                                    if (xlRange.Cells[iRow, iCol].Equals(typeof(DateTime)))
                                    {
                                        record[logicalnm[iCol - 1]] = xlRange.Cells[iRow, iCol].value.ToDateTime();
                                    }
                                    else
                                    {
                                        try
                                        {
                                            record[logicalnm[iCol - 1]] = Convert.ToDateTime(xlRange.Cells[iRow, iCol].value);
                                        }
                                        catch (FormatException)
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "⚠ DateTime field : " + myfieldlabel + ": " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2.ToString() + " is not valid.");
                                            richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - DateTime field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                            richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - DateTime field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                        }
                                    }
                                }
                                else if (myfieldtype == "Money")
                                {

                                    if (xlRange.Cells[iRow, iCol].value.Equals(typeof(string)))
                                    {
                                        decimal currencyval = 0;
                                        try
                                        {
                                            currencyval = System.Convert.ToDecimal(xlRange.Cells[iRow, iCol].value);
                                            record[logicalnm[iCol - 1]] = new Money(currencyval);
                                        }
                                        catch (FormatException)
                                        {
                                            MessageBox.Show("NOT A VALID DECIMAL FOR A CURRENCY FIELD TYPE");
                                        }
                                    }
                                    else
                                    {
                                        decimal d = (decimal)xlRange.Cells[iRow, iCol].value / 100M;
                                        record[logicalnm[iCol - 1]] = new Money(d * 100);
                                    }
                                }
                                else if (myfieldtype == "Decimal")
                                {
                                        decimal currencyval = 0;
                                        try
                                        {
                                            currencyval = System.Convert.ToDecimal(xlRange.Cells[iRow, iCol].value);
                                            record[logicalnm[iCol - 1]] = currencyval;
                                        }
                                        catch (FormatException)
                                        {
                                            MessageBox.Show("NOT A VALID DECIMAL FOR A CURRENCY FIELD TYPE");
                                        }
                                }
                                else if (myfieldtype == "Integer")
                                {
                                    if (xlRange.Cells[iRow, iCol].value.Equals(typeof(string)))
                                    {
                                        int currencyval = 0;
                                        try
                                        {
                                            currencyval = System.Convert.ToInt64(xlRange.Cells[iRow, iCol].value);
                                            record[logicalnm[iCol - 1]] = currencyval;
                                        }
                                        catch (FormatException)
                                        {
                                            MessageBox.Show("NOT A VALID Integer FOR A CURRENCY FIELD TYPE");
                                        }
                                    }
                                    else
                                    {
                                        int d = (int)xlRange.Cells[iRow, iCol].value;
                                        record[logicalnm[iCol - 1]] = d;
                                    }
                                }
                                else if (myfieldtype == "Lookup" || myfieldtype == "Customer" || myfieldtype == "Owner")
                                {
                                    flaglookup = true;
                                }

                                //Check if IS KEY
                                strIsKey = Convert.ToBoolean((dt.Rows[iCol - 1][1]).ToString());
                                Money mymoney;
                                OptionSetValue myoptionset;
                                Boolean boolvalentity;
                                if (strIsKey)
                                {
                                    if (myfieldtype == "Money")
                                    {
                                        mymoney = (Money)record[logicalnm[iCol - 1]];
                                        qestr = mymoney.Value.ToString();
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, qestr));
                                    }
                                    else if (myfieldtype == "Picklist" || myfieldtype == "State")
                                    {
                                        myoptionset = (OptionSetValue)record[logicalnm[iCol - 1]];
                                        qestr = myoptionset.Value.ToString();
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, qestr));
                                    }
                                    else if (myfieldtype == "DateTime")
                                    {
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, record[logicalnm[iCol - 1]]));
                                    }
                                    else if (myfieldtype == "Boolean")
                                    {
                                        try
                                        {
                                            boolvalentity = Convert.ToBoolean((record[logicalnm[iCol - 1]].ToString()));
                                            qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, boolvalentity));
                                        }
                                        catch
                                        {
                                            MessageBox.Show("⚠PROCESS WILL ABORT. </br> EXCEL LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + dt.Rows[iCol - 1]["Truevalue"].ToString() + " and " + dt.Rows[iCol - 1]["Falsevalue"].ToString());
                                            return;
                                        }

                                    }
                                    else if (myfieldtype == "Uniqueidentifier")
                                    {
                                        Guid mgud = new Guid((string)(xlRange.Cells[iRow, iCol].value));
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, mgud));
                                    }
                                    else if(myfieldtype=="Virtual")
                                    {
                                        OptionSetValueCollection multioptionsetfield = new OptionSetValueCollection();
                                        string stringItem;
                                        if (xlRange.Cells[iRow, iCol].Equals(typeof(String)))
                                            stringItem = xlRange.Cells[iRow, iCol].value.Replace(" ", "");
                                        else
                                            stringItem = xlRange.Cells[iRow, iCol].value.ToString().Replace(" ", "");

                                        string[] stringList = stringItem.Split(';');
                                        int[] intValue = new int[stringList.Length];
                                        for (int aut=0;aut< stringList.Length;aut++)
                                        {
                                            try
                                            {
                                                intValue[aut]= (Convert.ToInt32(stringList[aut]));
                                            }
                                            catch (FormatException)
                                            {
                                                // Update Logs
                                                AddToLogRow(row, "⚠ MultiSelect OptionSet field : " + myfieldlabel + ": " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2.ToString() + " is not valid.");
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - MultiSelect OptionSet field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - MultiSelect OptionSet field : " + myfieldlabel + ": " + xlRange.Cells[iRow, iCol].value.ToString() + " is not valid.";
                                            }
                                        }
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.In, intValue));
                                    }
                                    else if (myfieldtype == "Lookup" || myfieldtype == "Customer" || myfieldtype == "Owner")
                                    {

                                    }
                                    else // String
                                    {
                                        qestr = record[logicalnm[iCol - 1]].ToString();
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, qestr));
                                    }

                                    /*///ADD CONDITION FOR KEY
                                    if (myfieldtype != "Lookup" && myfieldtype != "Customer" && myfieldtype != "Boolean" && myfieldtype != "Uniqueidentifier")
                                    {
                                        //dcc = (DataGridViewComboBoxCell)dataGridViewMapping.Rows[iCol - 1].Cells[2];
                                        //int indexx = dcc.Items.IndexOf(dcc.Value);
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, qestr));
                                    }*/
                                }
                            }
                        }
                        //START/////////////////////////////////////////////////////////////////////////////////////////////
                        if (flaglookup && settings.CrmAction != "Delete")
                        {
                            QueryExpression lookupquery = new QueryExpression();
                            lookupquery.ColumnSet = new ColumnSet();
                            string lookuplglname;
                            string lkpnamefield;
                            string[] vec = new string[lookupscount];
                            int veccnt = 0;
                            bool boollkp;
                            for (int q = 0; q < dt.Rows.Count; q++) //All Rows of data grid, search for IS LOOKUPS
                            {
                                boollkp = Convert.ToBoolean((dt.Rows[q][3])); // IS LOOKUP?
                                if (boollkp == true) // IS Lookup = YES
                                {
                                    lkpnamefield = Convert.ToString((dt.Rows[q][2]).ToString());

                                    vec[veccnt] = lkpnamefield;
                                    veccnt++;
                                }
                            }
                            string[] distcVec = vec.Distinct().ToArray(); //Contains only unique names of lookup fields
                            bool[] distcKeyVec = new bool[distcVec.Length];
                            for (int m = 0; m < distcVec.Length; m++) // foreach unique lookupname
                            {
                                lookupquery.Criteria.Conditions.Clear();
                                for (int n = 0; n < dt.Rows.Count; n++) // Go search for all the lines in the table containing that lookup field
                                {
                                    if (distcVec[m] == Convert.ToString((dt.Rows[n][2]).ToString())) // When we find that the name of the lookup is the same as the distinct lookup value
                                    {
                                        distcKeyVec[m] = Convert.ToBoolean((dt.Rows[n][1]));
                                        lookuplglname = Convert.ToString((dt.Rows[n][4]).ToString());
                                        lookupquery.EntityName = lookuplglname;
                                        lookupquery.Criteria.AddCondition(Convert.ToString((dt.Rows[n][5]).ToString()), ConditionOperator.Equal, xlRange.Cells[iRow, n + 1].value);
                                    }
                                }
                                //FETCH FOR THE RECORD
                                try
                                {
                                    EntityCollection mycollect = Service.RetrieveMultiple(lookupquery);
                                


                                    if (mycollect.Entities.Count > 0)
                                    {
                                        if (mycollect.Entities.Count > 1)
                                        {
                                            if (settings.LookupFoundMultipleRecords == "Import the record with the lookup blank")
                                            {
                                                record[distcVec[m]] = null;
                                                // Update Logs
                                                AddToLogRow(row, "⚠ BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.");
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.";
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.";
                                            }
                                            else if (settings.LookupFoundMultipleRecords == "Map to the first record found by the lookup")
                                            {
                                                record[distcVec[m]] = new EntityReference(mycollect[0].LogicalName, mycollect[0].Id);
                                                // Update Logs
                                                AddToLogRow(row, "⚠ LOOKUP ID: " + distcVec[m].ToString() + " = " + mycollect[0].Id.ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup and mapped the first one.");
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - LOOKUP ID: " + distcVec[m].ToString() + " = " + mycollect[0].Id.ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup and mapped the first one.";
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - LOOKUP ID: " + distcVec[m].ToString() + " = " + mycollect[0].Id.ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup and mapped the first one.";
                                                if (distcKeyVec[m])
                                                    qe.Criteria.AddCondition(distcVec[m], ConditionOperator.Equal, mycollect[0].Id);
                                            }
                                            else if (settings.LookupFoundMultipleRecords == "Skip the record and do not import it")
                                            {
                                                istoimport = false;
                                                // Update Logs
                                                AddToLogRow(row, "⚠ LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.");
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.";
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Found " + mycollect.Entities.Count.ToString() + " records to insert in lookup.";
                                            }
                                        }
                                        else // Count==1 found entity
                                        {
                                            record[distcVec[m]] = new EntityReference(mycollect[0].LogicalName, mycollect[0].Id);
                                            if (distcKeyVec[m])
                                                qe.Criteria.AddCondition(distcVec[m], ConditionOperator.Equal, mycollect[0].Id);
                                        }
                                    }
                                    else // Didn't find a match
                                    {
                                        record[distcVec[m]] = null;
                                        if (settings.LookupFoundMultipleRecords == "Import the record with the lookup blank")
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "⚠ BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.");
                                            richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                            richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - BLANK LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                        }
                                        else if (settings.LookupFoundMultipleRecords == "Map to the first record found by the lookup")
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "⚠ CLEARED LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.");
                                            richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - CLEARED LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                            richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - CLEARED LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                        }
                                        else if (settings.LookupFoundMultipleRecords == "Skip the record and do not import it")
                                        {
                                            istoimport = false;
                                            // Update Logs
                                            AddToLogRow(row, "⚠ LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.", null, "Not Imported");
                                            richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                            richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - LINE WILL NOT BE IMPORTED because of LOOKUP: " + distcVec[m].ToString() + " - REASON: Didn't find any record to insert in lookup.";
                                        }
                                    }
                                }
                                catch (FaultException<OrganizationServiceFault> ex)
                                {
                                    // Update Logs
                                    AddToLogRow(row, "❌ Something went wrong while fetching record for lookup: " + distcVec[m].ToString() + ".  Record will not be imported.  EXCEPTION MESSAGE: " + ex.Message, null, "Failed");
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record for lookup: " + distcVec[m].ToString()+".  Record will not be imported.  EXCEPTION MESSAGE: "+ ex.Message;
                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record for lookup: " + distcVec[m].ToString() + ".  Record will not be imported.  EXCEPTION MESSAGE: " + ex.Message;
                                    istoimport = false;
                                }
                            }
                        }
                        ////END/////////////////////////////////////////////////////////////     

                        if (istoimport)
                        {

                            //CREATE
                            if (settings.CrmAction == "Create")
                            {
                                try
                                {
                                    _recordId = Service.Create(record);
                                    // Update Logs
                                    AddToLogRow(row, null, _recordId.ToString(), "Imported");
                                    richTextBoxImported.Text += Environment.NewLine + "✓LINE" + iRow + " - CREATED: " + _recordId.ToString();
                                    richTextBoxAll.Text += Environment.NewLine + "✓LINE" + iRow + " - CREATED: " + _recordId.ToString();
                                    successnumber++;
                                    creatednumber++;
                                }
                                catch (FaultException<OrganizationServiceFault> ex)
                                {
                                    // Update Logs
                                    AddToLogRow(row, "❌ Exception Message for CREATE: " + (ex.Message), null, "Failed");
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for CREATE: " + (ex.Message);
                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for CREATE: " + (ex.Message);
                                    errornumber++;
                                }
                            }

                            //UPDATE
                            else if (settings.CrmAction == "Update")
                            {
                                try
                                {
                                    EntityCollection ec = Service.RetrieveMultiple(qe);
                                    if (ec.Entities.Count > 0)
                                    {
                                        if (ec.Entities.Count == 1 || settings.KeyFoundMultipleRecords == "Do action for all")
                                        {
                                            foreach (Entity entity in ec.Entities)
                                            {
                                                record.Id = entity.Id;
                                                try
                                                {
                                                    Service.Update(record);
                                                    // Update Logs
                                                    AddToLogRow(row, null, entity.Id.ToString(), "Updated");
                                                    richTextBoxImported.Text += Environment.NewLine + "✓LINE" + iRow + " - UPDATED: " + entity.Id.ToString();
                                                    richTextBoxAll.Text += Environment.NewLine + "✓LINE" + iRow + " - UPDATED: " + entity.Id.ToString();
                                                    successnumber++;
                                                    updatednumber++;
                                                }
                                                catch (FaultException<OrganizationServiceFault> ex)
                                                {
                                                    // Update Logs
                                                    AddToLogRow(row, "❌ Exception Message for UPDATE: " + (ex.Message), null, "Failed");
                                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for UPDATE: " + (ex.Message);
                                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for UPDATE: " + (ex.Message);
                                                    errornumber++;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "❌ LINE NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.", null, "Failed");
                                            richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            errornumber++;
                                        }
                                    }
                                    else
                                    {
                                        // Update Logs
                                        AddToLogRow(row, "❌ LINE NOT FOUND TO UPDATE", null, "Failed");
                                        richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT FOUND TO UPDATE";
                                        richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT FOUND TO UPDATE";
                                        errornumber++;
                                    }
                                }
                                catch (FaultException<OrganizationServiceFault> ex)
                                {
                                    // Update Logs
                                    AddToLogRow(row, "❌ Something went wrong while fetching record.  Record will not be Updated.  EXCEPTION MESSAGE: " + ex.Message, null, "Failed");
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Updated.  EXCEPTION MESSAGE: " + ex.Message;
                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Updated.  EXCEPTION MESSAGE: " + ex.Message;
                                    errornumber++;
                                }
                            }

                            //UPSERT
                            else if (settings.CrmAction == "Upsert")
                            {
                                try
                                {
                                    EntityCollection ec = Service.RetrieveMultiple(qe);
                                    if (ec.Entities.Count > 0)
                                    {
                                        if (ec.Entities.Count == 1 || settings.KeyFoundMultipleRecords == "Do action for all")
                                        {
                                            foreach (Entity entity in ec.Entities)
                                            {
                                                record.Id = entity.Id;
                                                try
                                                {
                                                    Service.Update(record);
                                                    // Update Logs
                                                    AddToLogRow(row, null, entity.Id.ToString(), "Updated");
                                                    richTextBoxImported.Text += Environment.NewLine + "✓LINE" + iRow + " - UPDATED: " + entity.Id.ToString();
                                                    richTextBoxAll.Text += Environment.NewLine + "✓LINE" + iRow + " - UPDATED: " + entity.Id.ToString();
                                                    successnumber++;
                                                    updatednumber++;
                                                }
                                                catch (FaultException<OrganizationServiceFault> ex)
                                                {
                                                    // Update Logs
                                                    AddToLogRow(row, "❌ Exception Message for UPDATE: " + (ex.Message), null, "Failed");
                                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for UPDATE: " + (ex.Message);
                                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for UPDATE: " + (ex.Message);
                                                    errornumber++;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "❌ NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.");
                                            richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            errornumber++;
                                        }
                                    }
                                    else
                                    {
                                        try
                                        {
                                            _recordId = Service.Create(record);
                                            // Update Logs
                                            AddToLogRow(row, null, _recordId.ToString(), "Created");
                                            richTextBoxImported.Text += Environment.NewLine + "✓LINE" + iRow + " - CREATED: " + _recordId.ToString();
                                            richTextBoxAll.Text += Environment.NewLine + "✓LINE" + iRow + " - CREATED: " + _recordId.ToString();
                                            successnumber++;
                                            creatednumber++;
                                        }
                                        catch (FaultException<OrganizationServiceFault> ex)
                                        {
                                            // Update Logs
                                            AddToLogRow(row, "❌ Exception Message for CREATE" + (ex.Message), null, "Failed");
                                            richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for CREATE: " + (ex.Message);
                                            richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for CREATE: " + (ex.Message);
                                            errornumber++;
                                        }

                                    }
                                }
                                catch(FaultException < OrganizationServiceFault > ex)
                                {
                                    // Update logs
                                    AddToLogRow(row, "❌ Something went wrong while fetching record.  Record will not be Upserted.  EXCEPTION MESSAGE: " + ex.Message, null, "Failed");
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Upserted.  EXCEPTION MESSAGE: " + ex.Message;
                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Upserted.  EXCEPTION MESSAGE: " + ex.Message;
                                    errornumber++;
                                }
                            }
                            else if (settings.CrmAction == "Delete")
                            {
                                try
                                {
                                    EntityCollection ec = Service.RetrieveMultiple(qe);
                                    if (ec.Entities.Count > 0)
                                    {
                                        if (ec.Entities.Count == 1 || settings.KeyFoundMultipleRecords == "Do action for all")
                                        {
                                            foreach (Entity entity in ec.Entities)
                                            {
                                                record.Id = entity.Id;
                                                try
                                                {
                                                    Service.Delete(settings.Entity, record.Id);
                                                    // Update logs
                                                    AddToLogRow(row, null, entity.Id.ToString(), "Deleted");
                                                    richTextBoxImported.Text += Environment.NewLine + "✓LINE" + iRow + " - DELETED: " + entity.Id.ToString();
                                                    richTextBoxAll.Text += Environment.NewLine + "✓LINE" + iRow + " - DELETED: " + entity.Id.ToString();
                                                    successnumber++;
                                                    deletednumber++;
                                                }
                                                catch (FaultException<OrganizationServiceFault> ex)
                                                {
                                                    // Update logs
                                                    AddToLogRow(row, "❌ Exception Message for DELETE: " + (ex.Message), null, "Failed");
                                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for DELETE: " + (ex.Message);
                                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Exception Message for DELETE: " + (ex.Message);
                                                    errornumber++;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Update logs
                                            AddToLogRow(row, "❌ NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.", null, "Failed");
                                            richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT IMPORTED: Found " + ec.Entities.Count.ToString() + " records.";
                                            errornumber++;
                                        }
                                    }
                                    else
                                    {
                                        // Update logs
                                        AddToLogRow(row, "❌ NOT FOUND TO DELETE", null, "Failed");
                                        richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT FOUND TO DELETE: LINE" + iRow;
                                        richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - NOT FOUND TO DELETE: LINE" + iRow;
                                        errornumber++;
                                    }
                                }
                                catch (FaultException < OrganizationServiceFault > ex)
                                {
                                    // Update logs
                                    AddToLogRow(row, "❌ Something went wrong while fetching record.  Record will not be Deleted.  EXCEPTION MESSAGE: " + ex.Message, null, "Failed");
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Deleted.  EXCEPTION MESSAGE: " + ex.Message;
                                    richTextBoxAll.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record.  Record will not be Deleted.  EXCEPTION MESSAGE: " + ex.Message;
                                    errornumber++;
                                }
                            }
                            
                        }
                        dataGridViewLogs.BeginInvoke(new Action(() =>
                        {
                            tableLogEntries.Rows.Add(row);
                        }));
                        double perr = (iRow - 1) / (1.0 * (xlRange.Rows.Count - 1)) * 100;
                        int perrr = Convert.ToInt32(perr);
                        wcl.ReportProgress(perrr);
                    }
                    xlWorkBook.Close();
                    xlApp.Quit();
                    if (xlRange != null) Marshal.ReleaseComObject(xlRange);
                    if (xlWorkSheet != null) Marshal.ReleaseComObject(xlWorkSheet);
                    if (xlWorkBook != null) Marshal.ReleaseComObject(xlWorkBook);
                    if (xlApp != null) Marshal.ReleaseComObject(xlApp);

                    richTextBoxImported.Text += Environment.NewLine + Environment.NewLine + settings.CrmAction + " PROCESS FINISHED ON " + DateTime.Now.ToString() + Environment.NewLine + "-----------------------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                    richTextBoxErrors.Text += Environment.NewLine + Environment.NewLine + settings.CrmAction + " PROCESS FINISHED ON " + DateTime.Now.ToString() + Environment.NewLine + "-----------------------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                    richTextBoxWarning.Text += Environment.NewLine + Environment.NewLine + settings.CrmAction + " PROCESS FINISHED ON " + DateTime.Now.ToString() + Environment.NewLine + "-----------------------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                    richTextBoxAll.Text += Environment.NewLine + Environment.NewLine + settings.CrmAction + " PROCESS FINISHED ON " + DateTime.Now.ToString() + Environment.NewLine + "-----------------------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                    
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage("Import in progress: "+e.ProgressPercentage.ToString()+"% imported.");
                },
                PostWorkCallBack = e =>
                {
                    // This code is executed in the main thread
                    importDataButton.Enabled = true;
                    processFieldsButton.Enabled = true;
                    if (textView.SelectedItem.ToString() == "📙 ALL")
                    {
                        richTextBox1.Text = richTextBoxAll.Text;
                    }
                    else if (textView.SelectedItem.ToString() == "✓ SUCCESS")
                    {
                        richTextBox1.Text = richTextBoxImported.Text;
                    }
                    else if (textView.SelectedItem.ToString() == "❌ ERRORS")
                    {
                        richTextBox1.Text = richTextBoxErrors.Text;
                    }
                    else if (textView.SelectedItem.ToString() == "⚠ WARNINGS")
                    {
                        richTextBox1.Text = richTextBoxWarning.Text;
                    }
                    textBoxSuccess.Text = successnumber.ToString();
                    textBoxError.Text = errornumber.ToString();
                    dataGridViewLogs.ResumeLayout();

                    // Ensure that we have released the Excel spreadsheet
                    if (xlRange != null) Marshal.ReleaseComObject(xlRange);
                    if (xlWorkSheet != null) Marshal.ReleaseComObject(xlWorkSheet);
                    if (xlWorkBook != null) Marshal.ReleaseComObject(xlWorkBook);
                    if (xlApp != null) Marshal.ReleaseComObject(xlApp);
                }
            });
        }
    }
}
