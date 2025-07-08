using System.Windows.Forms;

namespace DataImport
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.browseFileButton = new System.Windows.Forms.ToolStripButton();
            this.processFieldsButton = new System.Windows.Forms.ToolStripButton();
            this.importDataButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.loadSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetButton = new System.Windows.Forms.ToolStripButton();
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleInstructions = new System.Windows.Forms.ToolStripLabel();
            this.labelRowsToImportEnd = new System.Windows.Forms.Label();
            this.labelRowsToImportStart = new System.Windows.Forms.Label();
            this.rowEndNum = new System.Windows.Forms.NumericUpDown();
            this.labelRowsToImportDesc = new System.Windows.Forms.Label();
            this.rowStartNum = new System.Windows.Forms.NumericUpDown();
            this.LogToggle = new System.Windows.Forms.Button();
            this.completeRecords = new System.Windows.Forms.CheckBox();
            this.labelKeyFoundMultipleRecords = new System.Windows.Forms.Label();
            this.settingsKeyFoundMultipleRecords = new System.Windows.Forms.ComboBox();
            this.RefreshLogs = new System.Windows.Forms.Button();
            this.labelFilterLogs = new System.Windows.Forms.Label();
            this.copyText = new System.Windows.Forms.Button();
            this.textView = new System.Windows.Forms.ComboBox();
            this.labelOptionSetValuesOrLabel = new System.Windows.Forms.Label();
            this.settingsLookupFoundMultipleRecords = new System.Windows.Forms.ComboBox();
            this.labelLookupFoundMultipleRecords = new System.Windows.Forms.Label();
            this.labelCrmAction = new System.Windows.Forms.Label();
            this.labelEntity = new System.Windows.Forms.Label();
            this.settingsEntity = new System.Windows.Forms.ComboBox();
            this.settingsOptionSetValuesOrLabel = new System.Windows.Forms.ComboBox();
            this.settingsCrmAction = new System.Windows.Forms.ComboBox();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.instructionBox = new System.Windows.Forms.RichTextBox();
            this.dataGridViewMapping = new System.Windows.Forms.DataGridView();
            this.ExcelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CRMField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsLookup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lkpTargetEntity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lkpTargetfield = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Truevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falsevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankBehaviour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.Import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusRowsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRowsNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSuccessLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSuccessNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusErrorNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCreatedNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUpdatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUpdatedNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDeletedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDeletedNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowEndNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStartNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseFileButton,
            this.processFieldsButton,
            this.importDataButton,
            this.toolStripSeparator1,
            this.saveSettingsButton,
            this.loadSettingsButton,
            this.toolStripSeparator2,
            this.resetButton,
            this.closeButton,
            this.toolStripSeparator3,
            this.toggleInstructions});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(1536, 38);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // browseFileButton
            // 
            this.browseFileButton.Image = ((System.Drawing.Image)(resources.GetObject("browseFileButton.Image")));
            this.browseFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(127, 33);
            this.browseFileButton.Text = "Open Excel";
            this.browseFileButton.ToolTipText = "Choose the Excel file you want to import";
            this.browseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // processFieldsButton
            // 
            this.processFieldsButton.Enabled = false;
            this.processFieldsButton.Image = ((System.Drawing.Image)(resources.GetObject("processFieldsButton.Image")));
            this.processFieldsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.processFieldsButton.Name = "processFieldsButton";
            this.processFieldsButton.Size = new System.Drawing.Size(147, 33);
            this.processFieldsButton.Text = "Process fields";
            this.processFieldsButton.Click += new System.EventHandler(this.ProcessFieldsButton_Click);
            // 
            // importDataButton
            // 
            this.importDataButton.Enabled = false;
            this.importDataButton.Image = ((System.Drawing.Image)(resources.GetObject("importDataButton.Image")));
            this.importDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(135, 33);
            this.importDataButton.Text = "Import data";
            this.importDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Enabled = false;
            this.saveSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveSettingsButton.Image")));
            this.saveSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(144, 33);
            this.saveSettingsButton.Text = "Save settings";
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // loadSettingsButton
            // 
            this.loadSettingsButton.Enabled = false;
            this.loadSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("loadSettingsButton.Image")));
            this.loadSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadSettingsButton.Name = "loadSettingsButton";
            this.loadSettingsButton.Size = new System.Drawing.Size(146, 33);
            this.loadSettingsButton.Text = "Load settings";
            this.loadSettingsButton.ToolTipText = "Load settings. Select file to upload first.";
            this.loadSettingsButton.Click += new System.EventHandler(this.loadSettingsButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // resetButton
            // 
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 33);
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 33);
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toggleInstructions
            // 
            this.toggleInstructions.BackColor = System.Drawing.Color.NavajoWhite;
            this.toggleInstructions.Name = "toggleInstructions";
            this.toggleInstructions.Size = new System.Drawing.Size(145, 33);
            this.toggleInstructions.Text = "Hide instructions";
            this.toggleInstructions.Click += new System.EventHandler(this.toggleInstructions_Click);
            // 
            // labelRowsToImportEnd
            // 
            this.labelRowsToImportEnd.AutoSize = true;
            this.labelRowsToImportEnd.Location = new System.Drawing.Point(30, 229);
            this.labelRowsToImportEnd.Name = "labelRowsToImportEnd";
            this.labelRowsToImportEnd.Size = new System.Drawing.Size(139, 20);
            this.labelRowsToImportEnd.TabIndex = 29;
            this.labelRowsToImportEnd.Text = "Last row to import:";
            // 
            // labelRowsToImportStart
            // 
            this.labelRowsToImportStart.AutoSize = true;
            this.labelRowsToImportStart.Location = new System.Drawing.Point(30, 186);
            this.labelRowsToImportStart.Name = "labelRowsToImportStart";
            this.labelRowsToImportStart.Size = new System.Drawing.Size(139, 20);
            this.labelRowsToImportStart.TabIndex = 28;
            this.labelRowsToImportStart.Text = "First row to import:";
            // 
            // rowEndNum
            // 
            this.rowEndNum.AccessibleDescription = "The Excel line that the import should import to. By default is the last row in th" +
    "e spreadsheet.";
            this.rowEndNum.AccessibleName = "Import Excel to row number";
            this.rowEndNum.BackColor = System.Drawing.Color.White;
            this.rowEndNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.rowEndNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowEndNum.ForeColor = System.Drawing.Color.Black;
            this.rowEndNum.Location = new System.Drawing.Point(216, 225);
            this.rowEndNum.MinimumSize = new System.Drawing.Size(155, 0);
            this.rowEndNum.Name = "rowEndNum";
            this.rowEndNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rowEndNum.Size = new System.Drawing.Size(155, 26);
            this.rowEndNum.TabIndex = 4;
            this.rowEndNum.ThousandsSeparator = true;
            this.rowEndNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelRowsToImportDesc
            // 
            this.labelRowsToImportDesc.AutoSize = true;
            this.labelRowsToImportDesc.Location = new System.Drawing.Point(30, 151);
            this.labelRowsToImportDesc.Name = "labelRowsToImportDesc";
            this.labelRowsToImportDesc.Size = new System.Drawing.Size(320, 20);
            this.labelRowsToImportDesc.TabIndex = 26;
            this.labelRowsToImportDesc.Text = "3. Choose rows in the spreadsheet to import";
            // 
            // rowStartNum
            // 
            this.rowStartNum.AccessibleDescription = "The Excel line that the import should start from. By default is set to row 2, whi" +
    "ch excludes the header.";
            this.rowStartNum.AccessibleName = "Import Excel from row number";
            this.rowStartNum.BackColor = System.Drawing.Color.White;
            this.rowStartNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.rowStartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowStartNum.ForeColor = System.Drawing.Color.Black;
            this.rowStartNum.Location = new System.Drawing.Point(216, 182);
            this.rowStartNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowStartNum.MinimumSize = new System.Drawing.Size(155, 0);
            this.rowStartNum.Name = "rowStartNum";
            this.rowStartNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rowStartNum.Size = new System.Drawing.Size(155, 26);
            this.rowStartNum.TabIndex = 3;
            this.rowStartNum.ThousandsSeparator = true;
            this.rowStartNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowStartNum.ValueChanged += new System.EventHandler(this.rowStartNum_ValueChanged);
            //
            // Complete Records
            //
            this.completeRecords.Location = new System.Drawing.Point(36, 300);
            this.completeRecords.Name = "CompleteRecords";
            this.completeRecords.Text = "Complete Records";
            this.completeRecords.Size = new System.Drawing.Size(120, 32);
            this.completeRecords.MinimumSize = new System.Drawing.Size(340, 32);
            this.completeRecords.UseVisualStyleBackColor = true;
            this.completeRecords.CheckedChanged += new System.EventHandler(this.settingscompleteRecords_SelectionChanged);
            // 
            // LogToggle
            // 
            this.LogToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogToggle.Location = new System.Drawing.Point(30, 545);
            this.LogToggle.MinimumSize = new System.Drawing.Size(340, 32);
            this.LogToggle.Name = "LogToggle";
            this.LogToggle.Size = new System.Drawing.Size(340, 32);
            this.LogToggle.TabIndex = 11;
            this.LogToggle.Text = "Show Logs";
            this.LogToggle.UseVisualStyleBackColor = true;
            this.LogToggle.Click += new System.EventHandler(this.LogToggle_Click);
            // 
            // labelKeyFoundMultipleRecords
            // 
            this.labelKeyFoundMultipleRecords.AutoSize = true;
            this.labelKeyFoundMultipleRecords.Location = new System.Drawing.Point(30, 269);
            this.labelKeyFoundMultipleRecords.Name = "labelKeyFoundMultipleRecords";
            this.labelKeyFoundMultipleRecords.Size = new System.Drawing.Size(214, 20);
            this.labelKeyFoundMultipleRecords.TabIndex = 14;
            this.labelKeyFoundMultipleRecords.Text = "Filter on key found > 1 record";
            // 
            // settingsKeyFoundMultipleRecords
            // 
            this.settingsKeyFoundMultipleRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsKeyFoundMultipleRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsKeyFoundMultipleRecords.FormattingEnabled = true;
            this.settingsKeyFoundMultipleRecords.Items.AddRange(new object[] {
            "Do action for all",
            "Ignore excel line"});
            this.settingsKeyFoundMultipleRecords.Location = new System.Drawing.Point(30, 298);
            this.settingsKeyFoundMultipleRecords.MinimumSize = new System.Drawing.Size(340, 0);
            this.settingsKeyFoundMultipleRecords.Name = "settingsKeyFoundMultipleRecords";
            this.settingsKeyFoundMultipleRecords.Size = new System.Drawing.Size(340, 28);
            this.settingsKeyFoundMultipleRecords.TabIndex = 5;
            this.settingsKeyFoundMultipleRecords.SelectedIndexChanged += new System.EventHandler(this.settingsKeyFoundMultipleRecords_SelectedIndexChanged);
            // 
            // RefreshLogs
            // 
            this.RefreshLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RefreshLogs.Location = new System.Drawing.Point(296, 503);
            this.RefreshLogs.MinimumSize = new System.Drawing.Size(75, 32);
            this.RefreshLogs.Name = "RefreshLogs";
            this.RefreshLogs.Size = new System.Drawing.Size(75, 32);
            this.RefreshLogs.TabIndex = 10;
            this.RefreshLogs.Text = "↻";
            this.RefreshLogs.UseVisualStyleBackColor = true;
            this.RefreshLogs.Click += new System.EventHandler(this.RefreshLogs_Click_2);
            // 
            // labelFilterLogs
            // 
            this.labelFilterLogs.AutoSize = true;
            this.labelFilterLogs.Location = new System.Drawing.Point(30, 475);
            this.labelFilterLogs.Name = "labelFilterLogs";
            this.labelFilterLogs.Size = new System.Drawing.Size(77, 20);
            this.labelFilterLogs.TabIndex = 11;
            this.labelFilterLogs.Text = "Filter logs";
            // 
            // copyText
            // 
            this.copyText.Location = new System.Drawing.Point(215, 504);
            this.copyText.MinimumSize = new System.Drawing.Size(75, 32);
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(75, 32);
            this.copyText.TabIndex = 9;
            this.copyText.Text = "Copy";
            this.copyText.UseVisualStyleBackColor = true;
            this.copyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // textView
            // 
            this.textView.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textView.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textView.FormattingEnabled = true;
            this.textView.Items.AddRange(new object[] {
            "📙 ALL",
            "✓ SUCCESS",
            "❌ ERRORS",
            "⚠ WARNINGS"});
            this.textView.Location = new System.Drawing.Point(30, 505);
            this.textView.MinimumSize = new System.Drawing.Size(180, 0);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(180, 28);
            this.textView.TabIndex = 8;
            this.textView.DropDownClosed += new System.EventHandler(this.TextView_DropDownClosed);
            // 
            // labelOptionSetValuesOrLabel
            // 
            this.labelOptionSetValuesOrLabel.AutoSize = true;
            this.labelOptionSetValuesOrLabel.Location = new System.Drawing.Point(30, 408);
            this.labelOptionSetValuesOrLabel.Name = "labelOptionSetValuesOrLabel";
            this.labelOptionSetValuesOrLabel.Size = new System.Drawing.Size(164, 20);
            this.labelOptionSetValuesOrLabel.TabIndex = 6;
            this.labelOptionSetValuesOrLabel.Text = "OptionSet field format";
            this.labelOptionSetValuesOrLabel.Visible = false;
            // 
            // settingsLookupFoundMultipleRecords
            // 
            this.settingsLookupFoundMultipleRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsLookupFoundMultipleRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsLookupFoundMultipleRecords.FormattingEnabled = true;
            this.settingsLookupFoundMultipleRecords.Items.AddRange(new object[] {
            "Map to the first record found by the lookup",
            "Skip the record and do not import it",
            "Import the record with the lookup blank"});
            this.settingsLookupFoundMultipleRecords.Location = new System.Drawing.Point(30, 365);
            this.settingsLookupFoundMultipleRecords.MinimumSize = new System.Drawing.Size(340, 0);
            this.settingsLookupFoundMultipleRecords.Name = "settingsLookupFoundMultipleRecords";
            this.settingsLookupFoundMultipleRecords.Size = new System.Drawing.Size(340, 28);
            this.settingsLookupFoundMultipleRecords.TabIndex = 6;
            this.settingsLookupFoundMultipleRecords.Visible = false;
            this.settingsLookupFoundMultipleRecords.SelectedIndexChanged += new System.EventHandler(this.settingsLookupFoundMultipleRecords_SelectedIndexChanged);
            // 
            // labelLookupFoundMultipleRecords
            // 
            this.labelLookupFoundMultipleRecords.AutoSize = true;
            this.labelLookupFoundMultipleRecords.Location = new System.Drawing.Point(30, 342);
            this.labelLookupFoundMultipleRecords.Name = "labelLookupFoundMultipleRecords";
            this.labelLookupFoundMultipleRecords.Size = new System.Drawing.Size(215, 20);
            this.labelLookupFoundMultipleRecords.TabIndex = 8;
            this.labelLookupFoundMultipleRecords.Text = "Lookup field found > 1 record";
            this.labelLookupFoundMultipleRecords.Visible = false;
            // 
            // labelCrmAction
            // 
            this.labelCrmAction.AutoSize = true;
            this.labelCrmAction.Location = new System.Drawing.Point(30, 78);
            this.labelCrmAction.Name = "labelCrmAction";
            this.labelCrmAction.Size = new System.Drawing.Size(170, 20);
            this.labelCrmAction.TabIndex = 7;
            this.labelCrmAction.Text = "2. Choose CRM Action";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Location = new System.Drawing.Point(30, 15);
            this.labelEntity.Margin = new System.Windows.Forms.Padding(0);
            this.labelEntity.MinimumSize = new System.Drawing.Size(104, 20);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(104, 20);
            this.labelEntity.TabIndex = 5;
            this.labelEntity.Text = "1. Pick Entity";
            // 
            // settingsEntity
            // 
            this.settingsEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.settingsEntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.settingsEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsEntity.DropDownWidth = 200;
            this.settingsEntity.FormattingEnabled = true;
            this.settingsEntity.Location = new System.Drawing.Point(30, 38);
            this.settingsEntity.MinimumSize = new System.Drawing.Size(340, 0);
            this.settingsEntity.Name = "settingsEntity";
            this.settingsEntity.Size = new System.Drawing.Size(340, 28);
            this.settingsEntity.Sorted = true;
            this.settingsEntity.TabIndex = 1;
            this.settingsEntity.DropDownClosed += new System.EventHandler(this.settingsEntity_DropDownClosed);
            this.settingsEntity.DropDownStyle = ComboBoxStyle.DropDown;
            // 
            // settingsOptionSetValuesOrLabel
            // 
            this.settingsOptionSetValuesOrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsOptionSetValuesOrLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsOptionSetValuesOrLabel.FormattingEnabled = true;
            this.settingsOptionSetValuesOrLabel.Items.AddRange(new object[] {
            "Values",
            "Labels"});
            this.settingsOptionSetValuesOrLabel.Location = new System.Drawing.Point(30, 431);
            this.settingsOptionSetValuesOrLabel.MinimumSize = new System.Drawing.Size(340, 0);
            this.settingsOptionSetValuesOrLabel.Name = "settingsOptionSetValuesOrLabel";
            this.settingsOptionSetValuesOrLabel.Size = new System.Drawing.Size(340, 28);
            this.settingsOptionSetValuesOrLabel.TabIndex = 7;
            this.settingsOptionSetValuesOrLabel.Visible = false;
            this.settingsOptionSetValuesOrLabel.SelectedIndexChanged += new System.EventHandler(this.settingsOptionSetValuesOrLabel_SelectedIndexChanged);
            // 
            // settingsCrmAction
            // 
            this.settingsCrmAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsCrmAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.settingsCrmAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.settingsCrmAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsCrmAction.FormattingEnabled = true;
            this.settingsCrmAction.Items.AddRange(new object[] {
            "Upsert",
            "Create",
            "Update",
            "Delete"});
            this.settingsCrmAction.Location = new System.Drawing.Point(30, 105);
            this.settingsCrmAction.MinimumSize = new System.Drawing.Size(340, 0);
            this.settingsCrmAction.Name = "settingsCrmAction";
            this.settingsCrmAction.Size = new System.Drawing.Size(340, 28);
            this.settingsCrmAction.TabIndex = 2;
            this.settingsCrmAction.SelectedIndexChanged += new System.EventHandler(this.settingsCrmAction_SelectedIndexChanged);
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(4, 768);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(412, 375);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.Text = "";
            // 
            // instructionBox
            // 
            this.instructionBox.BulletIndent = 4;
            this.instructionBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.instructionBox.Location = new System.Drawing.Point(525, 154);
            this.instructionBox.Margin = new System.Windows.Forms.Padding(375, 0, 375, 385);
            this.instructionBox.MaximumSize = new System.Drawing.Size(784, 429);
            this.instructionBox.MinimumSize = new System.Drawing.Size(784, 429);
            this.instructionBox.Name = "instructionBox";
            this.instructionBox.ReadOnly = true;
            this.instructionBox.Size = new System.Drawing.Size(784, 429);
            this.instructionBox.TabIndex = 3;
            this.instructionBox.Text = resources.GetString("instructionBox.Text");
            // 
            // dataGridViewMapping
            // 
            this.dataGridViewMapping.AllowUserToAddRows = false;
            this.dataGridViewMapping.AllowUserToDeleteRows = false;
            this.dataGridViewMapping.ColumnHeadersHeight = 34;
            this.dataGridViewMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExcelColumn,
            this.isKey,
            this.CRMField,
            this.IsLookup,
            this.lkpTargetEntity,
            this.lkpTargetfield,
            this.Truevalue,
            this.Falsevalue,
            this.DefaultValue,
            this.BlankBehaviour,
            this.DataType});
            this.dataGridViewMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMapping.Enabled = false;
            this.dataGridViewMapping.Location = new System.Drawing.Point(423, 51);
            this.dataGridViewMapping.Name = "dataGridViewMapping";
            this.dataGridViewMapping.RowHeadersWidth = 30;
            this.dataGridViewMapping.RowTemplate.Height = 33;
            this.dataGridViewMapping.Size = new System.Drawing.Size(1110, 709);
            this.dataGridViewMapping.TabIndex = 1;
            this.dataGridViewMapping.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridViewMapping.EditingControlShowing += dataGridViewMapping_EditingControlShowing;
            // 
            // ExcelColumn
            // 
            this.ExcelColumn.DataPropertyName = "ExcelColumn";
            this.ExcelColumn.HeaderText = "Excel Column";
            this.ExcelColumn.MinimumWidth = 9;
            this.ExcelColumn.Name = "ExcelColumn";
            this.ExcelColumn.ReadOnly = true;
            this.ExcelColumn.Width = 200;
            // 
            // isKey
            // 
            this.isKey.DataPropertyName = "IsKey";
            this.isKey.HeaderText = "is Key";
            this.isKey.MinimumWidth = 9;
            this.isKey.Name = "isKey";
            this.isKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isKey.Width = 50;
            // 
            // CRMField
            // 
            this.CRMField.DataPropertyName = "CRMField";
            this.CRMField.DropDownWidth = 150;
            this.CRMField.HeaderText = "CRM Field";
            this.CRMField.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CRMField.MaxDropDownItems = 20;
            this.CRMField.MinimumWidth = 9;
            this.CRMField.Name = "CRMField";
            this.CRMField.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CRMField.Width = 200;
            // 
            // IsLookup
            // 
            this.IsLookup.DataPropertyName = "IsLookup";
            this.IsLookup.HeaderText = "Is Lookup";
            this.IsLookup.MinimumWidth = 9;
            this.IsLookup.Name = "IsLookup";
            this.IsLookup.Visible = false;
            this.IsLookup.Width = 50;
            // 
            // lkpTargetEntity
            // 
            this.lkpTargetEntity.DataPropertyName = "LkpTargetEntity";
            this.lkpTargetEntity.HeaderText = "[Lookup] Entity Name";
            this.lkpTargetEntity.MinimumWidth = 9;
            this.lkpTargetEntity.Name = "lkpTargetEntity";
            this.lkpTargetEntity.ReadOnly = true;
            this.lkpTargetEntity.Sorted = true;
            this.lkpTargetEntity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lkpTargetEntity.Visible = false;
            this.lkpTargetEntity.Width = 150;
            // 
            // lkpTargetfield
            // 
            this.lkpTargetfield.DataPropertyName = "LkpTargetField";
            this.lkpTargetfield.HeaderText = "[Lookup] Field Name";
            this.lkpTargetfield.MinimumWidth = 9;
            this.lkpTargetfield.Name = "lkpTargetfield";
            this.lkpTargetfield.ReadOnly = true;
            this.lkpTargetfield.Sorted = true;
            this.lkpTargetfield.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lkpTargetfield.Visible = false;
            this.lkpTargetfield.Width = 150;
            // 
            // Truevalue
            // 
            this.Truevalue.DataPropertyName = "TrueValue";
            this.Truevalue.HeaderText = "True Label";
            this.Truevalue.MinimumWidth = 9;
            this.Truevalue.Name = "Truevalue";
            this.Truevalue.ReadOnly = true;
            this.Truevalue.Visible = false;
            this.Truevalue.Width = 150;
            // 
            // Falsevalue
            // 
            this.Falsevalue.DataPropertyName = "FalseValue";
            this.Falsevalue.HeaderText = "False Label";
            this.Falsevalue.MinimumWidth = 9;
            this.Falsevalue.Name = "Falsevalue";
            this.Falsevalue.ReadOnly = true;
            this.Falsevalue.Visible = false;
            this.Falsevalue.Width = 150;
            // 
            // DefaultValue
            // 
            this.DefaultValue.DataPropertyName = "DefaultValue";
            this.DefaultValue.HeaderText = "Default Value";
            this.DefaultValue.MinimumWidth = 8;
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.ReadOnly = true;
            this.DefaultValue.Visible = false;
            this.DefaultValue.Width = 150;
            // 
            // BlankBehaviour
            // 
            this.BlankBehaviour.DataPropertyName = "BlankBehaviour";
            this.BlankBehaviour.HeaderText = "Blank behaviour";
            this.BlankBehaviour.Items.AddRange(new object[] {
            "Clears CRM value",
            "Keeps CRM value"});
            this.BlankBehaviour.MinimumWidth = 9;
            this.BlankBehaviour.Name = "BlankBehaviour";
            this.BlankBehaviour.Width = 150;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "Data Type";
            this.DataType.MinimumWidth = 9;
            this.DataType.Name = "DataType";
            this.DataType.Width = 150;
            this.DataType.Visible = false;
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLogs.ColumnHeadersHeight = 35;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Import,
            this.Line,
            this.Result,
            this.Updates,
            this.GUID,
            this.Logs});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(423, 766);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersVisible = false;
            this.dataGridViewLogs.RowHeadersWidth = 5;
            this.dataGridViewLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLogs.RowTemplate.Height = 20;
            this.dataGridViewLogs.Size = new System.Drawing.Size(1110, 379);
            this.dataGridViewLogs.TabIndex = 4;
            // 
            // Import
            // 
            this.Import.DataPropertyName = "Import";
            this.Import.HeaderText = "Import";
            this.Import.MinimumWidth = 8;
            this.Import.Name = "Import";
            this.Import.ReadOnly = true;
            this.Import.ToolTipText = "The run number for the import.";
            this.Import.Width = 50;
            // 
            // Line
            // 
            this.Line.DataPropertyName = "Line";
            this.Line.HeaderText = "Line";
            this.Line.MinimumWidth = 8;
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.ToolTipText = "The line in the Excel, starting from line 2";
            this.Line.Width = 50;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 8;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ToolTipText = "The final result of the process";
            this.Result.Width = 150;
            // 
            // Updates
            // 
            this.Updates.DataPropertyName = "Updates";
            this.Updates.HeaderText = "Updates";
            this.Updates.MinimumWidth = 8;
            this.Updates.Name = "Updates";
            this.Updates.ReadOnly = true;
            this.Updates.ToolTipText = "The number of records updated in Dataverse";
            this.Updates.Width = 50;
            // 
            // GUID
            // 
            this.GUID.DataPropertyName = "GUID";
            this.GUID.HeaderText = "GUID";
            this.GUID.MinimumWidth = 8;
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.ToolTipText = "The GUID(s) of each row";
            this.GUID.Width = 200;
            // 
            // Logs
            // 
            this.Logs.DataPropertyName = "Logs";
            this.Logs.HeaderText = "Logs";
            this.Logs.MinimumWidth = 8;
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.ToolTipText = "Any log notes, errors or messages";
            this.Logs.Width = 250;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer3.Size = new System.Drawing.Size(928, 652);
            this.splitContainer3.SplitterDistance = 326;
            this.splitContainer3.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "DataImportSettingsFile.xml";
            this.saveFileDialog.Filter = "XML File|*.xml";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Settings File";
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.dataGridViewMapping, 1, 0);
            this.mainTableLayout.Controls.Add(this.settingsPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.logTextBox, 0, 1);
            this.mainTableLayout.Controls.Add(this.dataGridViewLogs, 1, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.Padding = new System.Windows.Forms.Padding(0, 48, 0, 34);
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainTableLayout.Size = new System.Drawing.Size(1536, 1182);
            this.mainTableLayout.TabIndex = 5;
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.labelEntity);
            this.settingsPanel.Controls.Add(this.settingsEntity);
            this.settingsPanel.Controls.Add(this.labelCrmAction);
            this.settingsPanel.Controls.Add(this.settingsCrmAction);
            this.settingsPanel.Controls.Add(this.labelRowsToImportDesc);
            this.settingsPanel.Controls.Add(this.labelRowsToImportStart);
            this.settingsPanel.Controls.Add(this.rowStartNum);
            this.settingsPanel.Controls.Add(this.labelRowsToImportEnd);
            this.settingsPanel.Controls.Add(this.rowEndNum);
            this.settingsPanel.Controls.Add(this.labelKeyFoundMultipleRecords);
            this.settingsPanel.Controls.Add(this.settingsKeyFoundMultipleRecords);
            this.settingsPanel.Controls.Add(this.labelLookupFoundMultipleRecords);
            this.settingsPanel.Controls.Add(this.settingsLookupFoundMultipleRecords);
            this.settingsPanel.Controls.Add(this.labelOptionSetValuesOrLabel);
            this.settingsPanel.Controls.Add(this.settingsOptionSetValuesOrLabel);
            this.settingsPanel.Controls.Add(this.labelFilterLogs);
            this.settingsPanel.Controls.Add(this.textView);
            this.settingsPanel.Controls.Add(this.copyText);
            this.settingsPanel.Controls.Add(this.RefreshLogs);
            this.settingsPanel.Controls.Add(this.LogToggle);
            this.settingsPanel.Controls.Add(this.completeRecords);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Enabled = false;
            this.settingsPanel.Location = new System.Drawing.Point(0, 48);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(30, 8, 30, 8);
            this.settingsPanel.Size = new System.Drawing.Size(420, 715);
            this.settingsPanel.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusRowsLabel,
            this.toolStripStatusRowsNum,
            this.toolStripStatusSuccessLabel,
            this.toolStripStatusSuccessNum,
            this.toolStripStatusErrorLabel,
            this.toolStripStatusErrorNum,
            this.toolStripStatusCreatedLabel,
            this.toolStripStatusCreatedNum,
            this.toolStripStatusUpdatedLabel,
            this.toolStripStatusUpdatedNum,
            this.toolStripStatusDeletedLabel,
            this.toolStripStatusDeletedNum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1150);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1536, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusRowsLabel
            // 
            this.toolStripStatusRowsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusRowsLabel.Name = "toolStripStatusRowsLabel";
            this.toolStripStatusRowsLabel.Size = new System.Drawing.Size(62, 25);
            this.toolStripStatusRowsLabel.Text = "Rows:";
            // 
            // toolStripStatusRowsNum
            // 
            this.toolStripStatusRowsNum.Name = "toolStripStatusRowsNum";
            this.toolStripStatusRowsNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusRowsNum.Text = "0";
            // 
            // toolStripStatusSuccessLabel
            // 
            this.toolStripStatusSuccessLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusSuccessLabel.Name = "toolStripStatusSuccessLabel";
            this.toolStripStatusSuccessLabel.Size = new System.Drawing.Size(82, 25);
            this.toolStripStatusSuccessLabel.Text = "Success:";
            // 
            // toolStripStatusSuccessNum
            // 
            this.toolStripStatusSuccessNum.Name = "toolStripStatusSuccessNum";
            this.toolStripStatusSuccessNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusSuccessNum.Text = "0";
            // 
            // toolStripStatusErrorLabel
            // 
            this.toolStripStatusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusErrorLabel.Name = "toolStripStatusErrorLabel";
            this.toolStripStatusErrorLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusErrorLabel.Text = "Error:";
            // 
            // toolStripStatusErrorNum
            // 
            this.toolStripStatusErrorNum.Name = "toolStripStatusErrorNum";
            this.toolStripStatusErrorNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusErrorNum.Text = "0";
            // 
            // toolStripStatusCreatedLabel
            // 
            this.toolStripStatusCreatedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusCreatedLabel.Name = "toolStripStatusCreatedLabel";
            this.toolStripStatusCreatedLabel.Size = new System.Drawing.Size(83, 25);
            this.toolStripStatusCreatedLabel.Text = "Created:";
            // 
            // toolStripStatusCreatedNum
            // 
            this.toolStripStatusCreatedNum.Name = "toolStripStatusCreatedNum";
            this.toolStripStatusCreatedNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusCreatedNum.Text = "0";
            // 
            // toolStripStatusUpdatedLabel
            // 
            this.toolStripStatusUpdatedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusUpdatedLabel.Name = "toolStripStatusUpdatedLabel";
            this.toolStripStatusUpdatedLabel.Size = new System.Drawing.Size(90, 25);
            this.toolStripStatusUpdatedLabel.Text = "Updated:";
            // 
            // toolStripStatusUpdatedNum
            // 
            this.toolStripStatusUpdatedNum.Name = "toolStripStatusUpdatedNum";
            this.toolStripStatusUpdatedNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusUpdatedNum.Text = "0";
            // 
            // toolStripStatusDeletedLabel
            // 
            this.toolStripStatusDeletedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusDeletedLabel.Name = "toolStripStatusDeletedLabel";
            this.toolStripStatusDeletedLabel.Size = new System.Drawing.Size(83, 25);
            this.toolStripStatusDeletedLabel.Text = "Deleted:";
            // 
            // toolStripStatusDeletedNum
            // 
            this.toolStripStatusDeletedNum.Name = "toolStripStatusDeletedNum";
            this.toolStripStatusDeletedNum.Size = new System.Drawing.Size(22, 25);
            this.toolStripStatusDeletedNum.Text = "0";
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(DataImport.Settings);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.instructionBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTableLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1536, 769);
            this.Name = "MyPluginControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1536, 1182);
            this.TabIcon = global::DataImport.Properties.Resources.DataImportLogo;
            this.ToolName = "Data Import ++";
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowEndNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStartNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.mainTableLayout.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.DataGridView dataGridViewMapping;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox settingsCrmAction;
        private System.Windows.Forms.ComboBox settingsOptionSetValuesOrLabel;
        private System.Windows.Forms.ComboBox settingsEntity;
        private System.Windows.Forms.ToolStripButton browseFileButton;
        private System.Windows.Forms.ToolStripButton importDataButton;
        private System.Windows.Forms.Label labelEntity;
        private System.Windows.Forms.Label labelCrmAction;
        private System.Windows.Forms.Label labelOptionSetValuesOrLabel;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.ToolStripButton resetButton;
        private System.Windows.Forms.Label labelLookupFoundMultipleRecords;
        private System.Windows.Forms.ComboBox settingsLookupFoundMultipleRecords;
        private System.Windows.Forms.ToolStripButton processFieldsButton;
        private System.Windows.Forms.ComboBox textView;
        private System.Windows.Forms.Button copyText;
        private System.Windows.Forms.Label labelFilterLogs;
        private System.Windows.Forms.Button RefreshLogs;
        private System.Windows.Forms.Label labelKeyFoundMultipleRecords;
        private System.Windows.Forms.ComboBox settingsKeyFoundMultipleRecords;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Button LogToggle;
        private System.Windows.Forms.CheckBox completeRecords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveSettingsButton;
        private System.Windows.Forms.ToolStripButton loadSettingsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private NumericUpDown rowStartNum;
        private Label labelRowsToImportDesc;
        private NumericUpDown rowEndNum;
        private Label labelRowsToImportEnd;
        private Label labelRowsToImportStart;
        private DataGridViewTextBoxColumn ExcelColumn;
        private DataGridViewCheckBoxColumn isKey;
        private DataGridViewComboBoxColumn CRMField;
        private DataGridViewCheckBoxColumn IsLookup;
        private DataGridViewComboBoxColumn lkpTargetEntity;
        private DataGridViewComboBoxColumn lkpTargetfield;
        private DataGridViewTextBoxColumn Truevalue;
        private DataGridViewTextBoxColumn Falsevalue;
        private DataGridViewTextBoxColumn DefaultValue;
        private DataGridViewComboBoxColumn BlankBehaviour;
        private DataGridViewTextBoxColumn DataType;
        private RichTextBox instructionBox;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toggleInstructions;
        private TableLayoutPanel mainTableLayout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusRowsLabel;
        private ToolStripStatusLabel toolStripStatusRowsNum;
        private ToolStripStatusLabel toolStripStatusSuccessLabel;
        private ToolStripStatusLabel toolStripStatusSuccessNum;
        private ToolStripStatusLabel toolStripStatusErrorLabel;
        private ToolStripStatusLabel toolStripStatusErrorNum;
        private ToolStripStatusLabel toolStripStatusCreatedLabel;
        private ToolStripStatusLabel toolStripStatusCreatedNum;
        private ToolStripStatusLabel toolStripStatusUpdatedLabel;
        private ToolStripStatusLabel toolStripStatusUpdatedNum;
        private ToolStripStatusLabel toolStripStatusDeletedLabel;
        private ToolStripStatusLabel toolStripStatusDeletedNum;
        private Panel settingsPanel;
        private DataGridViewTextBoxColumn Import;
        private DataGridViewTextBoxColumn Line;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Updates;
        private DataGridViewTextBoxColumn GUID;
        private DataGridViewTextBoxColumn Logs;
    }
}
