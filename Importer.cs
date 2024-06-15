using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmToolBox.Extensibility;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Data;
using Microsoft.Xrm.Sdk.Metadata;
using System.ServiceModel;

namespace DataImport
{
    internal class Importer : PluginControlBase
    {
        RichTextBox richTextBoxErrors = new RichTextBox();
        RichTextBox richTextBoxImported = new RichTextBox();
        RichTextBox richTextBoxAll = new RichTextBox();
        RichTextBox richTextBoxWarning = new RichTextBox();
        bool flaglookup;
        bool strIsKey;
        string qestr;

        private Settings settings = Settings.Instance;

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

        internal void importTable(Excel.Range xlRange, System.Data.DataTable tableMapping, System.Data.DataTable tableLogEntries, int importRunNumber, EntityMetadata resultsaved, int lookupscount)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Importing...",
                Work = (wcl, e) =>
                {
                    string[] logicalnm = new string[xlRange.Columns.Count];
                    Guid _recordId = new Guid();
                    bool istoimport;

                    richTextBoxErrors.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine;
                    richTextBoxImported.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "✓LINE1" + " - COLUMNS HEADER";
                    richTextBoxAll.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "✓LINE1" + " - COLUMNS HEADER";
                    richTextBoxWarning.Text += "Starting " + settings.CrmAction + " action on " + DateTime.Now.ToString() + Environment.NewLine;

                    for (int iRow = 2; iRow <= xlRange.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
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

                        for (int iCol = 1; iCol <= xlRange.Columns.Count; iCol++)
                        {
                            string myfieldlabel = tableMapping.Rows[iCol - 1][2].ToString();  //GET FIELD NAME
                            if (xlRange[1, iCol].value == null || xlRange[1, iCol].value == "" || string.IsNullOrEmpty(myfieldlabel))
                            {
                                continue;
                            }
                            //string myfieldlabel = tableMapping.Rows[iCol - 1][2].ToString();  //GET FIELD NAME
                            //if(string.IsNullOrEmpty(myfieldlabel))
                            //    break;
                            logicalnm[iCol - 1] = myfieldlabel;
                            string myfieldtype = "";
                            if (xlRange.Cells[iRow, iCol].value == null || xlRange[1, iCol].value == "")
                            {
                                if (tableMapping.Rows[iCol - 1][9].ToString() == "Clears CRM value")
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
                                        if ((tableMapping.Rows[iCol - 1]["DefaultValue"].ToString().ToLower()) == (tableMapping.Rows[iCol - 1]["Truevalue"].ToString().ToLower()))
                                        {
                                            record[logicalnm[iCol - 1]] = true;
                                        }
                                        else if ((tableMapping.Rows[iCol - 1]["DefaultValue"].ToString().ToLower()) == (tableMapping.Rows[iCol - 1]["Falsevalue"].ToString().ToLower()))
                                        {
                                            record[logicalnm[iCol - 1]] = false;
                                        }
                                    }
                                    else if (myfieldtype == "Virtual")
                                    {
                                        OptionSetValueCollection multioptionset = new OptionSetValueCollection();
                                        record[logicalnm[iCol - 1]] = multioptionset;
                                    }

                                    if (tableMapping.Rows[iCol - 1][1] == null)
                                        strIsKey = false;
                                    else
                                        strIsKey = Convert.ToBoolean(tableMapping.Rows[iCol - 1][1]);

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
                                                        MessageBox.Show("NOT A VALID INTEGER FOR AN OPTIONSETVALUE FIELD TYPE");
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
                                            if (xlRange.Cells[iRow, iCol].value.ToString().ToLower() == (tableMapping.Rows[iCol - 1]["Truevalue"].ToString().ToLower()))
                                            {
                                                record[logicalnm[iCol - 1]] = true;
                                            }
                                            else if (xlRange.Cells[iRow, iCol].value.ToString().ToLower() == (tableMapping.Rows[iCol - 1]["Falsevalue"].ToString().ToLower()))
                                            {
                                                record[logicalnm[iCol - 1]] = false;
                                            }
                                            else
                                            {
                                                // Update Logs
                                                AddToLogRow(row, "⚠ Couldnt match boolean value: " + ((Excel.Range)xlRange.Cells[iRow, iCol]).Value2 + " - REASON: Only available options are: " + tableMapping.Rows[iCol - 1]["Truevalue"].ToString() + " and " + tableMapping.Rows[iCol - 1]["Falsevalue"].ToString());
                                                richTextBoxAll.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + tableMapping.Rows[iCol - 1]["Truevalue"].ToString() + " and " + tableMapping.Rows[iCol - 1]["Falsevalue"].ToString();
                                                richTextBoxWarning.Text += Environment.NewLine + "⚠LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + tableMapping.Rows[iCol - 1]["Truevalue"].ToString() + " and " + tableMapping.Rows[iCol - 1]["Falsevalue"].ToString();
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
                                strIsKey = Convert.ToBoolean((tableMapping.Rows[iCol - 1][1]).ToString());
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
                                            MessageBox.Show("⚠PROCESS WILL ABORT. </br> EXCEL LINE" + iRow + " - Couldnt match boolean value : " + xlRange.Cells[iRow, iCol].value + " - REASON: Only available options are: " + tableMapping.Rows[iCol - 1]["Truevalue"].ToString() + " and " + tableMapping.Rows[iCol - 1]["Falsevalue"].ToString());
                                            return;
                                        }

                                    }
                                    else if (myfieldtype == "Uniqueidentifier")
                                    {
                                        Guid mgud = new Guid((string)(xlRange.Cells[iRow, iCol].value));
                                        qe.Criteria.AddCondition(new ConditionExpression(logicalnm[iCol - 1], ConditionOperator.Equal, mgud));
                                    }
                                    else if (myfieldtype == "Virtual")
                                    {
                                        OptionSetValueCollection multioptionsetfield = new OptionSetValueCollection();
                                        string stringItem;
                                        if (xlRange.Cells[iRow, iCol].Equals(typeof(String)))
                                            stringItem = xlRange.Cells[iRow, iCol].value.Replace(" ", "");
                                        else
                                            stringItem = xlRange.Cells[iRow, iCol].value.ToString().Replace(" ", "");

                                        string[] stringList = stringItem.Split(';');
                                        int[] intValue = new int[stringList.Length];
                                        for (int aut = 0; aut < stringList.Length; aut++)
                                        {
                                            try
                                            {
                                                intValue[aut] = (Convert.ToInt32(stringList[aut]));
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
                            for (int q = 0; q < tableMapping.Rows.Count; q++) //All Rows of data grid, search for IS LOOKUPS
                            {
                                boollkp = Convert.ToBoolean((tableMapping.Rows[q][3])); // IS LOOKUP?
                                if (boollkp == true) // IS Lookup = YES
                                {
                                    lkpnamefield = Convert.ToString((tableMapping.Rows[q][2]).ToString());

                                    vec[veccnt] = lkpnamefield;
                                    veccnt++;
                                }
                            }
                            string[] distcVec = vec.Distinct().ToArray(); //Contains only unique names of lookup fields
                            bool[] distcKeyVec = new bool[distcVec.Length];
                            for (int m = 0; m < distcVec.Length; m++) // foreach unique lookupname
                            {
                                lookupquery.Criteria.Conditions.Clear();
                                for (int n = 0; n < tableMapping.Rows.Count; n++) // Go search for all the lines in the table containing that lookup field
                                {
                                    if (distcVec[m] == Convert.ToString((tableMapping.Rows[n][2]).ToString())) // When we find that the name of the lookup is the same as the distinct lookup value
                                    {
                                        distcKeyVec[m] = Convert.ToBoolean((tableMapping.Rows[n][1]));
                                        lookuplglname = Convert.ToString((tableMapping.Rows[n][4]).ToString());
                                        lookupquery.EntityName = lookuplglname;
                                        lookupquery.Criteria.AddCondition(Convert.ToString((tableMapping.Rows[n][5]).ToString()), ConditionOperator.Equal, xlRange.Cells[iRow, n + 1].value);
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
                                    richTextBoxErrors.Text += Environment.NewLine + "❌LINE" + iRow + " - Something went wrong while fetching record for lookup: " + distcVec[m].ToString() + ".  Record will not be imported.  EXCEPTION MESSAGE: " + ex.Message;
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
                            else if (settings.CrmAction == "UPDATE")
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
                                catch (FaultException<OrganizationServiceFault> ex)
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
                                catch (FaultException<OrganizationServiceFault> ex)
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
                    SetWorkingMessage("Import in progress: " + e.ProgressPercentage.ToString() + "% imported.");
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
                }
            });
        }
    }
}
