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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowseFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.keyRecords = new System.Windows.Forms.ComboBox();
            this.RefreshLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.copyText = new System.Windows.Forms.Button();
            this.textView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pickedEntity = new System.Windows.Forms.ComboBox();
            this.optionSetVL = new System.Windows.Forms.ComboBox();
            this.crmAction = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExcelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CRMField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsLookup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lkpTargetEntity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lkpTargetfield = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Truevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falsevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.BrowseFile,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1120, 39);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(111, 36);
            this.tsbClose.Text = "CLOSE";
            this.tsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // BrowseFile
            // 
            this.BrowseFile.Image = ((System.Drawing.Image)(resources.GetObject("BrowseFile.Image")));
            this.BrowseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(206, 36);
            this.BrowseFile.Text = "BROWSE EXCEL";
            this.BrowseFile.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(219, 36);
            this.toolStripButton2.Text = "PROCESS FIELDS";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(186, 36);
            this.toolStripButton1.Text = "IMPORT CRM";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(107, 36);
            this.toolStripButton3.Text = "RESET";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 540);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.keyRecords);
            this.splitContainer2.Panel1.Controls.Add(this.RefreshLogs);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.copyText);
            this.splitContainer2.Panel1.Controls.Add(this.textView);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.pickedEntity);
            this.splitContainer2.Panel1.Controls.Add(this.optionSetVL);
            this.splitContainer2.Panel1.Controls.Add(this.crmAction);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(388, 540);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer2_SplitterMoved);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter on key found > 1 record";
            // 
            // keyRecords
            // 
            this.keyRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyRecords.FormattingEnabled = true;
            this.keyRecords.Items.AddRange(new object[] {
            "DO ACTION FOR ALL",
            "IGNORE EXCEL LINE"});
            this.keyRecords.Location = new System.Drawing.Point(4, 181);
            this.keyRecords.Name = "keyRecords";
            this.keyRecords.Size = new System.Drawing.Size(500, 33);
            this.keyRecords.TabIndex = 13;
            // 
            // RefreshLogs
            // 
            this.RefreshLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshLogs.BackgroundImage")));
            this.RefreshLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshLogs.Location = new System.Drawing.Point(350, 409);
            this.RefreshLogs.Margin = new System.Windows.Forms.Padding(6);
            this.RefreshLogs.Name = "RefreshLogs";
            this.RefreshLogs.Size = new System.Drawing.Size(52, 44);
            this.RefreshLogs.TabIndex = 12;
            this.RefreshLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefreshLogs.UseVisualStyleBackColor = true;
            this.RefreshLogs.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter logs";
            // 
            // copyText
            // 
            this.copyText.Location = new System.Drawing.Point(250, 409);
            this.copyText.Margin = new System.Windows.Forms.Padding(4);
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(100, 44);
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
            this.textView.Location = new System.Drawing.Point(4, 411);
            this.textView.Margin = new System.Windows.Forms.Padding(4);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(238, 33);
            this.textView.TabIndex = 4;
            this.textView.SelectedIndexChanged += new System.EventHandler(this.TextView_SelectedIndexChanged);
            this.textView.DropDownClosed += new System.EventHandler(this.TextView_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "OptionSet field format";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MAP THE FIRST FOUND RECORD TO THE LOOKUP",
            "SKIP RECORD WITHOUT IMPORTING IT AT ALL",
            "IMPORT CRM RECORD WITH CLEARED LOOKUP"});
            this.comboBox1.Location = new System.Drawing.Point(4, 332);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lookup field found > 1 record";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. Choose CRM Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Pick Entity";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pickedEntity
            // 
            this.pickedEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pickedEntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pickedEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickedEntity.DropDownWidth = 200;
            this.pickedEntity.FormattingEnabled = true;
            this.pickedEntity.Location = new System.Drawing.Point(4, 31);
            this.pickedEntity.Margin = new System.Windows.Forms.Padding(4);
            this.pickedEntity.Name = "pickedEntity";
            this.pickedEntity.Size = new System.Drawing.Size(500, 33);
            this.pickedEntity.Sorted = true;
            this.pickedEntity.TabIndex = 4;
            this.pickedEntity.SelectedIndexChanged += new System.EventHandler(this.PickedEntity_SelectedIndexChanged);
            this.pickedEntity.DropDownClosed += new System.EventHandler(this.PickedEntity_DropDownClosed);
            // 
            // optionSetVL
            // 
            this.optionSetVL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionSetVL.FormattingEnabled = true;
            this.optionSetVL.Items.AddRange(new object[] {
            "OPTIONSET VALUES",
            "OPTIONSET LABELS"});
            this.optionSetVL.Location = new System.Drawing.Point(4, 258);
            this.optionSetVL.Margin = new System.Windows.Forms.Padding(4);
            this.optionSetVL.Name = "optionSetVL";
            this.optionSetVL.Size = new System.Drawing.Size(500, 33);
            this.optionSetVL.TabIndex = 3;
            this.optionSetVL.Visible = false;
            // 
            // crmAction
            // 
            this.crmAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.crmAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.crmAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crmAction.FormattingEnabled = true;
            this.crmAction.Items.AddRange(new object[] {
            "UPSERT",
            "CREATE",
            "UPDATE",
            "DELETE"});
            this.crmAction.Location = new System.Drawing.Point(4, 106);
            this.crmAction.Margin = new System.Windows.Forms.Padding(4);
            this.crmAction.Name = "crmAction";
            this.crmAction.Size = new System.Drawing.Size(500, 33);
            this.crmAction.TabIndex = 2;
            this.crmAction.DropDownClosed += new System.EventHandler(this.CrmAction_DropDownClosed);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(388, 286);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExcelColumn,
            this.isKey,
            this.CRMField,
            this.IsLookup,
            this.lkpTargetEntity,
            this.lkpTargetfield,
            this.Truevalue,
            this.Falsevalue,
            this.OperatorCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(728, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // ExcelColumn
            // 
            this.ExcelColumn.HeaderText = "Excel Column";
            this.ExcelColumn.Name = "ExcelColumn";
            this.ExcelColumn.ReadOnly = true;
            this.ExcelColumn.Width = 150;
            // 
            // isKey
            // 
            this.isKey.HeaderText = "is Key";
            this.isKey.Name = "isKey";
            this.isKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CRMField
            // 
            this.CRMField.HeaderText = "CRM Field";
            this.CRMField.Name = "CRMField";
            this.CRMField.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CRMField.Sorted = true;
            this.CRMField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CRMField.Width = 150;
            // 
            // IsLookup
            // 
            this.IsLookup.HeaderText = "Is Lookup";
            this.IsLookup.Name = "IsLookup";
            this.IsLookup.Visible = false;
            // 
            // lkpTargetEntity
            // 
            this.lkpTargetEntity.HeaderText = "[Lookup] Entity Name";
            this.lkpTargetEntity.Name = "lkpTargetEntity";
            this.lkpTargetEntity.ReadOnly = true;
            this.lkpTargetEntity.Sorted = true;
            this.lkpTargetEntity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lkpTargetEntity.Visible = false;
            this.lkpTargetEntity.Width = 150;
            // 
            // lkpTargetfield
            // 
            this.lkpTargetfield.HeaderText = "[Lookup] Field Name";
            this.lkpTargetfield.Name = "lkpTargetfield";
            this.lkpTargetfield.ReadOnly = true;
            this.lkpTargetfield.Sorted = true;
            this.lkpTargetfield.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lkpTargetfield.Visible = false;
            this.lkpTargetfield.Width = 150;
            // 
            // Truevalue
            // 
            this.Truevalue.HeaderText = "True Label";
            this.Truevalue.Name = "Truevalue";
            this.Truevalue.ReadOnly = true;
            this.Truevalue.Visible = false;
            this.Truevalue.Width = 50;
            // 
            // Falsevalue
            // 
            this.Falsevalue.HeaderText = "False Label";
            this.Falsevalue.Name = "Falsevalue";
            this.Falsevalue.ReadOnly = true;
            this.Falsevalue.Visible = false;
            this.Falsevalue.Width = 50;
            // 
            // OperatorCol
            // 
            this.OperatorCol.HeaderText = "Operator";
            this.OperatorCol.Items.AddRange(new object[] {
            "Equal",
            "NotEqual",
            "GreaterThan",
            "LessThan",
            "GreaterEqual",
            "LessEqual",
            "Like",
            "NotLike",
            "In",
            "NotIn",
            "Between",
            "NotBetween",
            "Null",
            "NotNull",
            "Yesterday",
            "Today",
            "Tomorrow",
            "Last7Days",
            "Next7Days",
            "LastWeek",
            "ThisWeek",
            "NextWeek",
            "LastMonth",
            "ThisMonth",
            "NextMonth",
            "On",
            "OnOrBefore",
            "OnOrAfter",
            "LastYear",
            "ThisYear",
            "NextYear",
            "LastXHours",
            "NextXHours",
            "LastXDays",
            "NextXDays",
            "LastXWeeks",
            "NextXWeeks",
            "LastXMonths",
            "NextXMonths",
            "LastXYears",
            "NextXYears",
            "EqualUserId",
            "NotEqualUserId",
            "EqualBusinessId",
            "NotEqualBusinessId",
            "ChildOf",
            "Mask",
            "NotMask",
            "MasksSelect",
            "Contains",
            "DoesNotContain",
            "EqualUserLanguage",
            "NotOn",
            "OlderThanXMonths",
            "BeginsWith",
            "DoesNotBeginWith",
            "EndsWith",
            "DoesNotEndWith",
            "ThisFiscalYear",
            "ThisFiscalPeriod",
            "NextFiscalYear",
            "NextFiscalPeriod",
            "LastFiscalYear",
            "LastFiscalPeriod",
            "LastXFiscalYears",
            "LastXFiscalPeriods",
            "NextXFiscalYears",
            "NextXFiscalPeriods",
            "InFiscalYear",
            "InFiscalPeriod",
            "InFiscalPeriodAndYear",
            "InOrBeforeFiscalPeriodAndYear",
            "InOrAfterFiscalPeriodAndYear",
            "EqualUserTeams",
            "EqualUserOrUserTeams",
            "Under",
            "NotUnder",
            "UnderOrEqual",
            "Above",
            "AboveOrEqual",
            "EqualUserOrUserHierarchy",
            "EqualUserOrUserHierarchyAndTeams",
            "OlderThanXYears",
            "OlderThanXWeeks",
            "OlderThanXDays",
            "OlderThanXHours",
            "OlderThanXMinutes",
            "ContainValues",
            "DoesNotContainValues"});
            this.OperatorCol.Name = "OperatorCol";
            this.OperatorCol.Visible = false;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1120, 579);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox crmAction;
        private System.Windows.Forms.ComboBox optionSetVL;
        private System.Windows.Forms.ComboBox pickedEntity;
        private System.Windows.Forms.ToolStripButton BrowseFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox textView;
        private System.Windows.Forms.Button copyText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RefreshLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox keyRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKey;
        private System.Windows.Forms.DataGridViewComboBoxColumn CRMField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLookup;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetEntity;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falsevalue;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCol;
    }
}
