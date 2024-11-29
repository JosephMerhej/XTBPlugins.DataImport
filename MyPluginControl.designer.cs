using System;
using System.Collections.Generic;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.splitContainerSideBarAndMapping = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rowEndNum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.rowStartNum = new System.Windows.Forms.NumericUpDown();
            this.LogToggle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.settingsKeyFoundMultipleRecords = new System.Windows.Forms.ComboBox();
            this.RefreshLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.copyText = new System.Windows.Forms.Button();
            this.textView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsLookupFoundMultipleRecords = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsEntity = new System.Windows.Forms.ComboBox();
            this.settingsOptionSetValuesOrLabel = new System.Windows.Forms.ComboBox();
            this.settingsCrmAction = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainerMappingAndLogging = new System.Windows.Forms.SplitContainer();
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
            this.BlankBehaviour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.Import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textDeleted = new System.Windows.Forms.TextBox();
            this.textUpdated = new System.Windows.Forms.TextBox();
            this.textCreated = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textRowCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.textBoxSuccess = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerMainAppAndProgressInfo = new System.Windows.Forms.SplitContainer();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSideBarAndMapping)).BeginInit();
            this.splitContainerSideBarAndMapping.Panel1.SuspendLayout();
            this.splitContainerSideBarAndMapping.Panel2.SuspendLayout();
            this.splitContainerSideBarAndMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowEndNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStartNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMappingAndLogging)).BeginInit();
            this.splitContainerMappingAndLogging.Panel1.SuspendLayout();
            this.splitContainerMappingAndLogging.Panel2.SuspendLayout();
            this.splitContainerMappingAndLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainAppAndProgressInfo)).BeginInit();
            this.splitContainerMainAppAndProgressInfo.Panel1.SuspendLayout();
            this.splitContainerMainAppAndProgressInfo.Panel2.SuspendLayout();
            this.splitContainerMainAppAndProgressInfo.SuspendLayout();
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
            this.closeButton});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1280, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // browseFileButton
            // 
            this.browseFileButton.Image = ((System.Drawing.Image)(resources.GetObject("browseFileButton.Image")));
            this.browseFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(94, 28);
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
            this.processFieldsButton.Size = new System.Drawing.Size(106, 28);
            this.processFieldsButton.Text = "Process fields";
            this.processFieldsButton.Click += new System.EventHandler(this.ProcessFieldsButton_Click);
            // 
            // importDataButton
            // 
            this.importDataButton.Enabled = false;
            this.importDataButton.Image = ((System.Drawing.Image)(resources.GetObject("importDataButton.Image")));
            this.importDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(97, 28);
            this.importDataButton.Text = "Import data";
            this.importDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Enabled = false;
            this.saveSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveSettingsButton.Image")));
            this.saveSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(103, 28);
            this.saveSettingsButton.Text = "Save settings";
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // loadSettingsButton
            // 
            this.loadSettingsButton.Enabled = false;
            this.loadSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("loadSettingsButton.Image")));
            this.loadSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadSettingsButton.Name = "loadSettingsButton";
            this.loadSettingsButton.Size = new System.Drawing.Size(105, 28);
            this.loadSettingsButton.Text = "Load settings";
            this.loadSettingsButton.ToolTipText = "Load settings. Select file to upload first.";
            this.loadSettingsButton.Click += new System.EventHandler(this.loadSettingsButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // resetButton
            // 
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(63, 28);
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 28);
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // splitContainerSideBarAndMapping
            // 
            this.splitContainerSideBarAndMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSideBarAndMapping.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSideBarAndMapping.IsSplitterFixed = true;
            this.splitContainerSideBarAndMapping.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSideBarAndMapping.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerSideBarAndMapping.Name = "splitContainerSideBarAndMapping";
            // 
            // splitContainerSideBarAndMapping.Panel1
            // 
            this.splitContainerSideBarAndMapping.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainerSideBarAndMapping.Panel2
            // 
            this.splitContainerSideBarAndMapping.Panel2.Controls.Add(this.splitContainerMappingAndLogging);
            this.splitContainerSideBarAndMapping.Size = new System.Drawing.Size(1280, 681);
            this.splitContainerSideBarAndMapping.SplitterDistance = 350;
            this.splitContainerSideBarAndMapping.SplitterWidth = 2;
            this.splitContainerSideBarAndMapping.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.rowEndNum);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.rowStartNum);
            this.splitContainer2.Panel1.Controls.Add(this.LogToggle);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.settingsKeyFoundMultipleRecords);
            this.splitContainer2.Panel1.Controls.Add(this.RefreshLogs);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.copyText);
            this.splitContainer2.Panel1.Controls.Add(this.textView);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.settingsLookupFoundMultipleRecords);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.settingsEntity);
            this.splitContainer2.Panel1.Controls.Add(this.settingsOptionSetValuesOrLabel);
            this.splitContainer2.Panel1.Controls.Add(this.settingsCrmAction);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(350, 681);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 107);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Last row to import:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "First row to import:";
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
            this.rowEndNum.Location = new System.Drawing.Point(272, 103);
            this.rowEndNum.Name = "rowEndNum";
            this.rowEndNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rowEndNum.Size = new System.Drawing.Size(71, 20);
            this.rowEndNum.TabIndex = 27;
            this.rowEndNum.ThousandsSeparator = true;
            this.rowEndNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "3. Choose rows in the spreadsheet to import";
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
            this.rowStartNum.Location = new System.Drawing.Point(101, 102);
            this.rowStartNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowStartNum.Name = "rowStartNum";
            this.rowStartNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rowStartNum.Size = new System.Drawing.Size(60, 20);
            this.rowStartNum.TabIndex = 25;
            this.rowStartNum.ThousandsSeparator = true;
            this.rowStartNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowStartNum.ValueChanged += new System.EventHandler(this.rowStartNum_ValueChanged);
            // 
            // LogToggle
            // 
            this.LogToggle.Location = new System.Drawing.Point(234, 265);
            this.LogToggle.Margin = new System.Windows.Forms.Padding(2);
            this.LogToggle.Name = "LogToggle";
            this.LogToggle.Size = new System.Drawing.Size(113, 23);
            this.LogToggle.TabIndex = 15;
            this.LogToggle.Text = "Show Log Table";
            this.LogToggle.UseVisualStyleBackColor = true;
            this.LogToggle.Click += new System.EventHandler(this.LogToggle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter on key found > 1 record";
            // 
            // settingsKeyFoundMultipleRecords
            // 
            this.settingsKeyFoundMultipleRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsKeyFoundMultipleRecords.FormattingEnabled = true;
            this.settingsKeyFoundMultipleRecords.Items.AddRange(new object[] {
            "Do action for all",
            "Ignore excel line"});
            this.settingsKeyFoundMultipleRecords.Location = new System.Drawing.Point(2, 146);
            this.settingsKeyFoundMultipleRecords.Margin = new System.Windows.Forms.Padding(2);
            this.settingsKeyFoundMultipleRecords.Name = "settingsKeyFoundMultipleRecords";
            this.settingsKeyFoundMultipleRecords.Size = new System.Drawing.Size(345, 21);
            this.settingsKeyFoundMultipleRecords.TabIndex = 13;
            this.settingsKeyFoundMultipleRecords.SelectedIndexChanged += new System.EventHandler(this.settingsKeyFoundMultipleRecords_SelectedIndexChanged);
            // 
            // RefreshLogs
            // 
            this.RefreshLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RefreshLogs.Location = new System.Drawing.Point(180, 265);
            this.RefreshLogs.Name = "RefreshLogs";
            this.RefreshLogs.Size = new System.Drawing.Size(49, 23);
            this.RefreshLogs.TabIndex = 12;
            this.RefreshLogs.Text = "↻";
            this.RefreshLogs.UseVisualStyleBackColor = true;
            this.RefreshLogs.Click += new System.EventHandler(this.RefreshLogs_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter logs";
            // 
            // copyText
            // 
            this.copyText.Location = new System.Drawing.Point(127, 265);
            this.copyText.Margin = new System.Windows.Forms.Padding(2);
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(50, 23);
            this.copyText.TabIndex = 10;
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
            this.textView.Location = new System.Drawing.Point(2, 266);
            this.textView.Margin = new System.Windows.Forms.Padding(2);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(121, 21);
            this.textView.TabIndex = 4;
            this.textView.DropDownClosed += new System.EventHandler(this.TextView_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OptionSet field format";
            this.label2.Visible = false;
            // 
            // settingsLookupFoundMultipleRecords
            // 
            this.settingsLookupFoundMultipleRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsLookupFoundMultipleRecords.FormattingEnabled = true;
            this.settingsLookupFoundMultipleRecords.Items.AddRange(new object[] {
            "Map to the first record found by the lookup",
            "Skip the record and do not import it",
            "Import the record with the lookup blank"});
            this.settingsLookupFoundMultipleRecords.Location = new System.Drawing.Point(2, 225);
            this.settingsLookupFoundMultipleRecords.Margin = new System.Windows.Forms.Padding(2);
            this.settingsLookupFoundMultipleRecords.Name = "settingsLookupFoundMultipleRecords";
            this.settingsLookupFoundMultipleRecords.Size = new System.Drawing.Size(345, 21);
            this.settingsLookupFoundMultipleRecords.TabIndex = 9;
            this.settingsLookupFoundMultipleRecords.Visible = false;
            this.settingsLookupFoundMultipleRecords.SelectedIndexChanged += new System.EventHandler(this.settingsLookupFoundMultipleRecords_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lookup field found > 1 record";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. Choose CRM Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Pick Entity";
            // 
            // settingsEntity
            // 
            this.settingsEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.settingsEntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.settingsEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsEntity.DropDownWidth = 200;
            this.settingsEntity.FormattingEnabled = true;
            this.settingsEntity.Location = new System.Drawing.Point(2, 19);
            this.settingsEntity.Margin = new System.Windows.Forms.Padding(2);
            this.settingsEntity.Name = "settingsEntity";
            this.settingsEntity.Size = new System.Drawing.Size(345, 21);
            this.settingsEntity.Sorted = true;
            this.settingsEntity.TabIndex = 4;
            this.settingsEntity.DropDownClosed += new System.EventHandler(this.settingsEntity_DropDownClosed);
            // 
            // settingsOptionSetValuesOrLabel
            // 
            this.settingsOptionSetValuesOrLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsOptionSetValuesOrLabel.FormattingEnabled = true;
            this.settingsOptionSetValuesOrLabel.Items.AddRange(new object[] {
            "Values",
            "Labels"});
            this.settingsOptionSetValuesOrLabel.Location = new System.Drawing.Point(2, 186);
            this.settingsOptionSetValuesOrLabel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsOptionSetValuesOrLabel.Name = "settingsOptionSetValuesOrLabel";
            this.settingsOptionSetValuesOrLabel.Size = new System.Drawing.Size(345, 21);
            this.settingsOptionSetValuesOrLabel.TabIndex = 3;
            this.settingsOptionSetValuesOrLabel.Visible = false;
            this.settingsOptionSetValuesOrLabel.SelectedIndexChanged += new System.EventHandler(this.settingsOptionSetValuesOrLabel_SelectedIndexChanged);
            // 
            // settingsCrmAction
            // 
            this.settingsCrmAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.settingsCrmAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.settingsCrmAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsCrmAction.FormattingEnabled = true;
            this.settingsCrmAction.Items.AddRange(new object[] {
            "Upsert",
            "Create",
            "Update",
            "Delete"});
            this.settingsCrmAction.Location = new System.Drawing.Point(2, 58);
            this.settingsCrmAction.Margin = new System.Windows.Forms.Padding(2);
            this.settingsCrmAction.Name = "settingsCrmAction";
            this.settingsCrmAction.Size = new System.Drawing.Size(345, 21);
            this.settingsCrmAction.TabIndex = 2;
            this.settingsCrmAction.SelectedIndexChanged += new System.EventHandler(this.settingsCrmAction_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(350, 379);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // splitContainerMappingAndLogging
            // 
            this.splitContainerMappingAndLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMappingAndLogging.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMappingAndLogging.Name = "splitContainerMappingAndLogging";
            this.splitContainerMappingAndLogging.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMappingAndLogging.Panel1
            // 
            this.splitContainerMappingAndLogging.Panel1.AutoScroll = true;
            this.splitContainerMappingAndLogging.Panel1.Controls.Add(this.dataGridViewMapping);
            // 
            // splitContainerMappingAndLogging.Panel2
            // 
            this.splitContainerMappingAndLogging.Panel2.Controls.Add(this.dataGridViewLogs);
            this.splitContainerMappingAndLogging.Panel2Collapsed = true;
            this.splitContainerMappingAndLogging.Size = new System.Drawing.Size(928, 681);
            this.splitContainerMappingAndLogging.SplitterDistance = 300;
            this.splitContainerMappingAndLogging.TabIndex = 6;
            // 
            // dataGridViewMapping
            // 
            this.dataGridViewMapping.AllowUserToAddRows = false;
            this.dataGridViewMapping.AllowUserToDeleteRows = false;
            this.dataGridViewMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.BlankBehaviour});
            this.dataGridViewMapping.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMapping.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMapping.Name = "dataGridViewMapping";
            this.dataGridViewMapping.RowHeadersWidth = 30;
            this.dataGridViewMapping.RowTemplate.Height = 33;
            this.dataGridViewMapping.Size = new System.Drawing.Size(1178, 1064);
            this.dataGridViewMapping.TabIndex = 1;
            this.dataGridViewMapping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMapping_CellContentClick);
            this.dataGridViewMapping.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // ExcelColumn
            // 
            this.ExcelColumn.DataPropertyName = "ExcelColumn";
            this.ExcelColumn.HeaderText = "Excel Column";
            this.ExcelColumn.MinimumWidth = 9;
            this.ExcelColumn.Name = "ExcelColumn";
            this.ExcelColumn.ReadOnly = true;
            this.ExcelColumn.Width = 150;
            // 
            // isKey
            // 
            this.isKey.DataPropertyName = "IsKey";
            this.isKey.HeaderText = "is Key";
            this.isKey.MinimumWidth = 9;
            this.isKey.Name = "isKey";
            this.isKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isKey.Width = 175;
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
            this.CRMField.Width = 150;
            // 
            // IsLookup
            // 
            this.IsLookup.DataPropertyName = "IsLookup";
            this.IsLookup.HeaderText = "Is Lookup";
            this.IsLookup.MinimumWidth = 9;
            this.IsLookup.Name = "IsLookup";
            this.IsLookup.Visible = false;
            this.IsLookup.Width = 175;
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
            this.Truevalue.Width = 50;
            // 
            // Falsevalue
            // 
            this.Falsevalue.DataPropertyName = "FalseValue";
            this.Falsevalue.HeaderText = "False Label";
            this.Falsevalue.MinimumWidth = 9;
            this.Falsevalue.Name = "Falsevalue";
            this.Falsevalue.ReadOnly = true;
            this.Falsevalue.Visible = false;
            this.Falsevalue.Width = 50;
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
            this.BlankBehaviour.Width = 175;
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLogs.ColumnHeadersHeight = 22;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Import,
            this.Line,
            this.Result,
            this.Updates,
            this.GUID,
            this.Logs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLogs.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.RowHeadersVisible = false;
            this.dataGridViewLogs.RowHeadersWidth = 5;
            this.dataGridViewLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLogs.RowTemplate.Height = 20;
            this.dataGridViewLogs.Size = new System.Drawing.Size(150, 46);
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
            this.GUID.Width = 250;
            // 
            // Logs
            // 
            this.Logs.DataPropertyName = "Logs";
            this.Logs.HeaderText = "Logs";
            this.Logs.MinimumWidth = 8;
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.ToolTipText = "Any log notes, errors or messages";
            this.Logs.Width = 300;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(840, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Deleted:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(681, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Updated:";
            // 
            // textDeleted
            // 
            this.textDeleted.BackColor = System.Drawing.Color.PowderBlue;
            this.textDeleted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDeleted.Cursor = System.Windows.Forms.Cursors.No;
            this.textDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDeleted.ForeColor = System.Drawing.Color.Indigo;
            this.textDeleted.Location = new System.Drawing.Point(901, 1);
            this.textDeleted.MaxLength = 100000;
            this.textDeleted.Name = "textDeleted";
            this.textDeleted.ReadOnly = true;
            this.textDeleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDeleted.Size = new System.Drawing.Size(91, 23);
            this.textDeleted.TabIndex = 22;
            // 
            // textUpdated
            // 
            this.textUpdated.BackColor = System.Drawing.Color.PowderBlue;
            this.textUpdated.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textUpdated.Cursor = System.Windows.Forms.Cursors.No;
            this.textUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUpdated.ForeColor = System.Drawing.Color.Indigo;
            this.textUpdated.Location = new System.Drawing.Point(743, 1);
            this.textUpdated.MaxLength = 100000;
            this.textUpdated.Name = "textUpdated";
            this.textUpdated.ReadOnly = true;
            this.textUpdated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textUpdated.Size = new System.Drawing.Size(91, 23);
            this.textUpdated.TabIndex = 21;
            // 
            // textCreated
            // 
            this.textCreated.BackColor = System.Drawing.Color.PowderBlue;
            this.textCreated.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textCreated.Cursor = System.Windows.Forms.Cursors.No;
            this.textCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCreated.ForeColor = System.Drawing.Color.Indigo;
            this.textCreated.Location = new System.Drawing.Point(585, 1);
            this.textCreated.MaxLength = 100000;
            this.textCreated.Name = "textCreated";
            this.textCreated.ReadOnly = true;
            this.textCreated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textCreated.Size = new System.Drawing.Size(84, 23);
            this.textCreated.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Created: ";
            // 
            // textRowCount
            // 
            this.textRowCount.BackColor = System.Drawing.Color.Thistle;
            this.textRowCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRowCount.Cursor = System.Windows.Forms.Cursors.No;
            this.textRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRowCount.ForeColor = System.Drawing.Color.Indigo;
            this.textRowCount.Location = new System.Drawing.Point(116, 1);
            this.textRowCount.MaxLength = 100000;
            this.textRowCount.Name = "textRowCount";
            this.textRowCount.ReadOnly = true;
            this.textRowCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textRowCount.Size = new System.Drawing.Size(84, 23);
            this.textRowCount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Excel Rows Count:";
            // 
            // textBoxError
            // 
            this.textBoxError.BackColor = System.Drawing.Color.LightPink;
            this.textBoxError.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxError.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxError.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxError.Location = new System.Drawing.Point(423, 1);
            this.textBoxError.MaxLength = 100000;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxError.Size = new System.Drawing.Size(93, 23);
            this.textBoxError.TabIndex = 18;
            // 
            // textBoxSuccess
            // 
            this.textBoxSuccess.BackColor = System.Drawing.Color.LightGreen;
            this.textBoxSuccess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSuccess.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuccess.ForeColor = System.Drawing.Color.Green;
            this.textBoxSuccess.Location = new System.Drawing.Point(265, 1);
            this.textBoxSuccess.MaxLength = 100000;
            this.textBoxSuccess.Name = "textBoxSuccess";
            this.textBoxSuccess.ReadOnly = true;
            this.textBoxSuccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSuccess.Size = new System.Drawing.Size(91, 23);
            this.textBoxSuccess.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Error: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sucess: ";
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
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(DataImport.Settings);
            // 
            // splitContainerMainAppAndProgressInfo
            // 
            this.splitContainerMainAppAndProgressInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainAppAndProgressInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainAppAndProgressInfo.Name = "splitContainerMainAppAndProgressInfo";
            this.splitContainerMainAppAndProgressInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainAppAndProgressInfo.Panel1
            // 
            this.splitContainerMainAppAndProgressInfo.Panel1.Controls.Add(this.splitContainerSideBarAndMapping);
            // 
            // splitContainerMainAppAndProgressInfo.Panel2
            // 
            this.splitContainerMainAppAndProgressInfo.Panel2.BackColor = System.Drawing.Color.Thistle;
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label12);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label11);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textDeleted);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textUpdated);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textCreated);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label10);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textRowCount);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label7);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textBoxError);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.textBoxSuccess);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label9);
            this.splitContainerMainAppAndProgressInfo.Panel2.Controls.Add(this.label8);
            this.splitContainerMainAppAndProgressInfo.Size = new System.Drawing.Size(1280, 720);
            this.splitContainerMainAppAndProgressInfo.SplitterDistance = 681;
            this.splitContainerMainAppAndProgressInfo.TabIndex = 4;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.splitContainerMainAppAndProgressInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MyPluginControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1280, 720);
            this.TabIcon = global::DataImport.Properties.Resources.DataImportSharpSharp;
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainerSideBarAndMapping.Panel1.ResumeLayout(false);
            this.splitContainerSideBarAndMapping.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSideBarAndMapping)).EndInit();
            this.splitContainerSideBarAndMapping.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rowEndNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowStartNum)).EndInit();
            this.splitContainerMappingAndLogging.Panel1.ResumeLayout(false);
            this.splitContainerMappingAndLogging.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMappingAndLogging)).EndInit();
            this.splitContainerMappingAndLogging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.splitContainerMainAppAndProgressInfo.Panel1.ResumeLayout(false);
            this.splitContainerMainAppAndProgressInfo.Panel2.ResumeLayout(false);
            this.splitContainerMainAppAndProgressInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainAppAndProgressInfo)).EndInit();
            this.splitContainerMainAppAndProgressInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.SplitContainer splitContainerSideBarAndMapping;
        private System.Windows.Forms.DataGridView dataGridViewMapping;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox settingsCrmAction;
        private System.Windows.Forms.ComboBox settingsOptionSetValuesOrLabel;
        private System.Windows.Forms.ComboBox settingsEntity;
        private System.Windows.Forms.ToolStripButton browseFileButton;
        private System.Windows.Forms.ToolStripButton importDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton resetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox settingsLookupFoundMultipleRecords;
        private System.Windows.Forms.ToolStripButton processFieldsButton;
        private System.Windows.Forms.ComboBox textView;
        private System.Windows.Forms.Button copyText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RefreshLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox settingsKeyFoundMultipleRecords;
        private System.Windows.Forms.TextBox textRowCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBoxSuccess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDeleted;
        private System.Windows.Forms.TextBox textUpdated;
        private System.Windows.Forms.TextBox textCreated;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button LogToggle;
        private System.Windows.Forms.SplitContainer splitContainerMappingAndLogging;
        private System.Windows.Forms.DataGridViewTextBoxColumn Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updates;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveSettingsButton;
        private System.Windows.Forms.ToolStripButton loadSettingsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLookup;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetEntity;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falsevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn BlankBehaviour;
        internal System.Windows.Forms.DataGridViewComboBoxColumn CRMField;
        private NumericUpDown rowStartNum;
        private Label label13;
        private NumericUpDown rowEndNum;
        private Label label15;
        private Label label14;
        private SplitContainer splitContainerMainAppAndProgressInfo;
    }
}
