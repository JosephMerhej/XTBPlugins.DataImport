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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowseFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LogToggle = new System.Windows.Forms.Button();
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExcelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CRMField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsLookup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lkpTargetEntity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lkpTargetfield = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Truevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falsevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1245, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(73, 28);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BrowseFile
            // 
            this.BrowseFile.Image = ((System.Drawing.Image)(resources.GetObject("BrowseFile.Image")));
            this.BrowseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(123, 28);
            this.BrowseFile.Text = "Browse Excel";
            this.BrowseFile.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(126, 28);
            this.toolStripButton2.Text = "Process fields";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 28);
            this.toolStripButton1.Text = "Import data";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 28);
            this.toolStripButton3.Text = "Reset";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 640);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LogToggle);
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
            this.splitContainer2.Size = new System.Drawing.Size(350, 640);
            this.splitContainer2.SplitterDistance = 241;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 3;
            // 
            // LogToggle
            // 
            this.LogToggle.Location = new System.Drawing.Point(234, 213);
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
            this.label6.Location = new System.Drawing.Point(2, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
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
            this.keyRecords.Location = new System.Drawing.Point(2, 94);
            this.keyRecords.Margin = new System.Windows.Forms.Padding(2);
            this.keyRecords.Name = "keyRecords";
            this.keyRecords.Size = new System.Drawing.Size(345, 21);
            this.keyRecords.TabIndex = 13;
            // 
            // RefreshLogs
            // 
            this.RefreshLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RefreshLogs.Location = new System.Drawing.Point(180, 213);
            this.RefreshLogs.Name = "RefreshLogs";
            this.RefreshLogs.Size = new System.Drawing.Size(49, 23);
            this.RefreshLogs.TabIndex = 12;
            this.RefreshLogs.Text = "↻";
            this.RefreshLogs.UseVisualStyleBackColor = true;
            this.RefreshLogs.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter logs";
            // 
            // copyText
            // 
            this.copyText.Location = new System.Drawing.Point(127, 213);
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
            this.textView.Location = new System.Drawing.Point(2, 214);
            this.textView.Margin = new System.Windows.Forms.Padding(2);
            this.textView.Name = "textView";
            this.textView.Size = new System.Drawing.Size(121, 21);
            this.textView.TabIndex = 4;
            this.textView.DropDownClosed += new System.EventHandler(this.TextView_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
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
            this.comboBox1.Location = new System.Drawing.Point(2, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 157);
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
            this.label3.Location = new System.Drawing.Point(2, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. Choose CRM Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
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
            this.pickedEntity.Location = new System.Drawing.Point(2, 16);
            this.pickedEntity.Margin = new System.Windows.Forms.Padding(2);
            this.pickedEntity.Name = "pickedEntity";
            this.pickedEntity.Size = new System.Drawing.Size(345, 21);
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
            this.optionSetVL.Location = new System.Drawing.Point(2, 134);
            this.optionSetVL.Margin = new System.Windows.Forms.Padding(2);
            this.optionSetVL.Name = "optionSetVL";
            this.optionSetVL.Size = new System.Drawing.Size(345, 21);
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
            this.crmAction.Location = new System.Drawing.Point(2, 55);
            this.crmAction.Margin = new System.Windows.Forms.Padding(2);
            this.crmAction.Name = "crmAction";
            this.crmAction.Size = new System.Drawing.Size(345, 21);
            this.crmAction.TabIndex = 2;
            this.crmAction.DropDownClosed += new System.EventHandler(this.CrmAction_DropDownClosed);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(350, 397);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Thistle;
            this.splitContainer3.Panel2.Controls.Add(this.label12);
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.textDeleted);
            this.splitContainer3.Panel2.Controls.Add(this.textUpdated);
            this.splitContainer3.Panel2.Controls.Add(this.textCreated);
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Panel2.Controls.Add(this.textRowCount);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxError);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxSuccess);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Size = new System.Drawing.Size(893, 640);
            this.splitContainer3.SplitterDistance = 611;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer4.Panel1MinSize = 300;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridViewLogs);
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.Panel2MinSize = 200;
            this.splitContainer4.Size = new System.Drawing.Size(893, 611);
            this.splitContainer4.SplitterDistance = 300;
            this.splitContainer4.TabIndex = 6;
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
            this.DefaultValue,
            this.OperatorCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(893, 611);
            this.dataGridView1.TabIndex = 1;
            // 
            // ExcelColumn
            // 
            this.ExcelColumn.HeaderText = "Excel Column";
            this.ExcelColumn.MinimumWidth = 9;
            this.ExcelColumn.Name = "ExcelColumn";
            this.ExcelColumn.ReadOnly = true;
            this.ExcelColumn.Width = 150;
            // 
            // isKey
            // 
            this.isKey.HeaderText = "is Key";
            this.isKey.MinimumWidth = 9;
            this.isKey.Name = "isKey";
            this.isKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isKey.Width = 175;
            // 
            // CRMField
            // 
            this.CRMField.HeaderText = "CRM Field";
            this.CRMField.MinimumWidth = 9;
            this.CRMField.Name = "CRMField";
            this.CRMField.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CRMField.Sorted = true;
            this.CRMField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CRMField.Width = 150;
            // 
            // IsLookup
            // 
            this.IsLookup.HeaderText = "Is Lookup";
            this.IsLookup.MinimumWidth = 9;
            this.IsLookup.Name = "IsLookup";
            this.IsLookup.Visible = false;
            this.IsLookup.Width = 175;
            // 
            // lkpTargetEntity
            // 
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
            this.Truevalue.HeaderText = "True Label";
            this.Truevalue.MinimumWidth = 9;
            this.Truevalue.Name = "Truevalue";
            this.Truevalue.ReadOnly = true;
            this.Truevalue.Visible = false;
            this.Truevalue.Width = 50;
            // 
            // Falsevalue
            // 
            this.Falsevalue.HeaderText = "False Label";
            this.Falsevalue.MinimumWidth = 9;
            this.Falsevalue.Name = "Falsevalue";
            this.Falsevalue.ReadOnly = true;
            this.Falsevalue.Visible = false;
            this.Falsevalue.Width = 50;
            // 
            // DefaultValue
            // 
            this.DefaultValue.HeaderText = "Default Value";
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.ReadOnly = true;
            this.DefaultValue.Visible = false;
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
            this.OperatorCol.MinimumWidth = 9;
            this.OperatorCol.Name = "OperatorCol";
            this.OperatorCol.Visible = false;
            this.OperatorCol.Width = 175;
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
            this.dataGridViewLogs.Size = new System.Drawing.Size(893, 307);
            this.dataGridViewLogs.TabIndex = 4;
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
            this.textBoxError.Size = new System.Drawing.Size(91, 23);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Import
            // 
            this.Import.HeaderText = "Import";
            this.Import.Name = "Import";
            this.Import.ReadOnly = true;
            this.Import.Width = 50;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Width = 50;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 150;
            // 
            // GUID
            // 
            this.GUID.HeaderText = "GUID";
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.Width = 250;
            // 
            // Logs
            // 
            this.Logs.HeaderText = "Logs";
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.Width = 300;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1245, 671);
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcelColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isKey;
        private System.Windows.Forms.DataGridViewComboBoxColumn CRMField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLookup;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetEntity;
        private System.Windows.Forms.DataGridViewComboBoxColumn lkpTargetfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn Truevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Falsevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logs;
    }
}
