namespace FileSearcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.fileNameTextBox = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.searchDirTextBox = new System.Windows.Forms.TextBox();
        	this.selectSearchDirButton = new System.Windows.Forms.Button();
        	this.includeSubDirsCheckBox = new System.Windows.Forms.CheckBox();
        	this.newerThanCheckBox = new System.Windows.Forms.CheckBox();
        	this.newerThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
        	this.olderThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
        	this.olderThanCheckBox = new System.Windows.Forms.CheckBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.openContainingFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.startButton = new System.Windows.Forms.Button();
        	this.stopButton = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.configDirTextBox = new System.Windows.Forms.TextBox();
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.tabPage3 = new System.Windows.Forms.TabPage();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.splitContainer2 = new System.Windows.Forms.SplitContainer();
        	this.resultsList = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.txtReal = new System.Windows.Forms.RichTextBox();
        	this.txtProposal = new System.Windows.Forms.RichTextBox();
        	this.treeView1 = new System.Windows.Forms.TreeView();
        	this.delimeterTextBox = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.writeResultsButton = new System.Windows.Forms.Button();
        	this.txtConsole1 = new System.Windows.Forms.TextBox();
        	this.groupBox1.SuspendLayout();
        	this.contextMenuStrip.SuspendLayout();
        	this.tabControl1.SuspendLayout();
        	this.tabPage1.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
        	this.splitContainer2.Panel1.SuspendLayout();
        	this.splitContainer2.Panel2.SuspendLayout();
        	this.splitContainer2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// fileNameTextBox
        	// 
        	this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.fileNameTextBox.Location = new System.Drawing.Point(273, 107);
        	this.fileNameTextBox.Name = "fileNameTextBox";
        	this.fileNameTextBox.Size = new System.Drawing.Size(527, 20);
        	this.fileNameTextBox.TabIndex = 5;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 110);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(255, 13);
        	this.label1.TabIndex = 4;
        	this.label1.Text = "Filename (may include wildcards, not case sensitive):";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 61);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(87, 13);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Search directory:";
        	// 
        	// searchDirTextBox
        	// 
        	this.searchDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.searchDirTextBox.Location = new System.Drawing.Point(117, 58);
        	this.searchDirTextBox.Name = "searchDirTextBox";
        	this.searchDirTextBox.Size = new System.Drawing.Size(659, 20);
        	this.searchDirTextBox.TabIndex = 1;
        	// 
        	// selectSearchDirButton
        	// 
        	this.selectSearchDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.selectSearchDirButton.Location = new System.Drawing.Point(782, 57);
        	this.selectSearchDirButton.Name = "selectSearchDirButton";
        	this.selectSearchDirButton.Size = new System.Drawing.Size(24, 21);
        	this.selectSearchDirButton.TabIndex = 2;
        	this.selectSearchDirButton.Text = "...";
        	this.selectSearchDirButton.UseVisualStyleBackColor = true;
        	this.selectSearchDirButton.Click += new System.EventHandler(this.selectSearchDirButton_Click);
        	// 
        	// includeSubDirsCheckBox
        	// 
        	this.includeSubDirsCheckBox.AutoSize = true;
        	this.includeSubDirsCheckBox.Location = new System.Drawing.Point(117, 84);
        	this.includeSubDirsCheckBox.Name = "includeSubDirsCheckBox";
        	this.includeSubDirsCheckBox.Size = new System.Drawing.Size(129, 17);
        	this.includeSubDirsCheckBox.TabIndex = 3;
        	this.includeSubDirsCheckBox.Text = "Include subdirectories";
        	this.includeSubDirsCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// newerThanCheckBox
        	// 
        	this.newerThanCheckBox.AutoSize = true;
        	this.newerThanCheckBox.Location = new System.Drawing.Point(6, 22);
        	this.newerThanCheckBox.Name = "newerThanCheckBox";
        	this.newerThanCheckBox.Size = new System.Drawing.Size(106, 17);
        	this.newerThanCheckBox.TabIndex = 0;
        	this.newerThanCheckBox.Text = "Files newer than:";
        	this.newerThanCheckBox.UseVisualStyleBackColor = true;
        	this.newerThanCheckBox.CheckedChanged += new System.EventHandler(this.newerThanCheckBox_CheckedChanged);
        	// 
        	// newerThanDateTimePicker
        	// 
        	this.newerThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
        	this.newerThanDateTimePicker.Enabled = false;
        	this.newerThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.newerThanDateTimePicker.Location = new System.Drawing.Point(118, 19);
        	this.newerThanDateTimePicker.Name = "newerThanDateTimePicker";
        	this.newerThanDateTimePicker.Size = new System.Drawing.Size(123, 20);
        	this.newerThanDateTimePicker.TabIndex = 1;
        	// 
        	// olderThanDateTimePicker
        	// 
        	this.olderThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
        	this.olderThanDateTimePicker.Enabled = false;
        	this.olderThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.olderThanDateTimePicker.Location = new System.Drawing.Point(360, 19);
        	this.olderThanDateTimePicker.Name = "olderThanDateTimePicker";
        	this.olderThanDateTimePicker.Size = new System.Drawing.Size(123, 20);
        	this.olderThanDateTimePicker.TabIndex = 3;
        	// 
        	// olderThanCheckBox
        	// 
        	this.olderThanCheckBox.AutoSize = true;
        	this.olderThanCheckBox.Location = new System.Drawing.Point(254, 22);
        	this.olderThanCheckBox.Name = "olderThanCheckBox";
        	this.olderThanCheckBox.Size = new System.Drawing.Size(100, 17);
        	this.olderThanCheckBox.TabIndex = 2;
        	this.olderThanCheckBox.Text = "Files older than:";
        	this.olderThanCheckBox.UseVisualStyleBackColor = true;
        	this.olderThanCheckBox.CheckedChanged += new System.EventHandler(this.olderThanCheckBox_CheckedChanged);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox1.Controls.Add(this.olderThanDateTimePicker);
        	this.groupBox1.Controls.Add(this.newerThanCheckBox);
        	this.groupBox1.Controls.Add(this.olderThanCheckBox);
        	this.groupBox1.Controls.Add(this.newerThanDateTimePicker);
        	this.groupBox1.Location = new System.Drawing.Point(12, 135);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(794, 51);
        	this.groupBox1.TabIndex = 6;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Restrictions";
        	// 
        	// contextMenuStrip
        	// 
        	this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.openContainingFolderContextMenuItem});
        	this.contextMenuStrip.Name = "contextMenuStrip";
        	this.contextMenuStrip.Size = new System.Drawing.Size(195, 26);
        	this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
        	// 
        	// openContainingFolderContextMenuItem
        	// 
        	this.openContainingFolderContextMenuItem.Name = "openContainingFolderContextMenuItem";
        	this.openContainingFolderContextMenuItem.Size = new System.Drawing.Size(194, 22);
        	this.openContainingFolderContextMenuItem.Text = "Open containing folder";
        	this.openContainingFolderContextMenuItem.Click += new System.EventHandler(this.openContainingFolderContextMenuItem_Click);
        	// 
        	// startButton
        	// 
        	this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.startButton.Location = new System.Drawing.Point(731, 192);
        	this.startButton.Name = "startButton";
        	this.startButton.Size = new System.Drawing.Size(75, 23);
        	this.startButton.TabIndex = 8;
        	this.startButton.Text = "Start";
        	this.startButton.UseVisualStyleBackColor = true;
        	this.startButton.Click += new System.EventHandler(this.startButton_Click);
        	// 
        	// stopButton
        	// 
        	this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.stopButton.Enabled = false;
        	this.stopButton.Location = new System.Drawing.Point(650, 192);
        	this.stopButton.Name = "stopButton";
        	this.stopButton.Size = new System.Drawing.Size(75, 23);
        	this.stopButton.TabIndex = 7;
        	this.stopButton.Text = "Stop";
        	this.stopButton.UseVisualStyleBackColor = true;
        	this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
        	// 
        	// button1
        	// 
        	this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.button1.Location = new System.Drawing.Point(782, 4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(24, 21);
        	this.button1.TabIndex = 12;
        	this.button1.Text = "...";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(12, 7);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(83, 13);
        	this.label4.TabIndex = 10;
        	this.label4.Text = "Config directory:";
        	// 
        	// configDirTextBox
        	// 
        	this.configDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.configDirTextBox.Location = new System.Drawing.Point(117, 4);
        	this.configDirTextBox.Name = "configDirTextBox";
        	this.configDirTextBox.Size = new System.Drawing.Size(659, 20);
        	this.configDirTextBox.TabIndex = 11;
        	this.configDirTextBox.Text = "D:\\JSP TLSB\\json";
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tabControl1.Controls.Add(this.tabPage1);
        	this.tabControl1.Controls.Add(this.tabPage2);
        	this.tabControl1.Controls.Add(this.tabPage3);
        	this.tabControl1.Location = new System.Drawing.Point(18, 201);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(782, 383);
        	this.tabControl1.TabIndex = 13;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.groupBox2);
        	this.tabPage1.Location = new System.Drawing.Point(4, 22);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(774, 357);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "Results";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.txtConsole1);
        	this.tabPage2.Location = new System.Drawing.Point(4, 22);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(774, 357);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "Console 1";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// tabPage3
        	// 
        	this.tabPage3.Location = new System.Drawing.Point(4, 22);
        	this.tabPage3.Name = "tabPage3";
        	this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage3.Size = new System.Drawing.Size(774, 357);
        	this.tabPage3.TabIndex = 2;
        	this.tabPage3.Text = "Console 2";
        	this.tabPage3.UseVisualStyleBackColor = true;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox2.Controls.Add(this.splitContainer2);
        	this.groupBox2.Controls.Add(this.treeView1);
        	this.groupBox2.Controls.Add(this.delimeterTextBox);
        	this.groupBox2.Controls.Add(this.label3);
        	this.groupBox2.Controls.Add(this.writeResultsButton);
        	this.groupBox2.Location = new System.Drawing.Point(6, 9);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(762, 345);
        	this.groupBox2.TabIndex = 12;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Results";
        	// 
        	// splitContainer2
        	// 
        	this.splitContainer2.AllowDrop = true;
        	this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.splitContainer2.Location = new System.Drawing.Point(176, 10);
        	this.splitContainer2.Name = "splitContainer2";
        	this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer2.Panel1
        	// 
        	this.splitContainer2.Panel1.Controls.Add(this.resultsList);
        	// 
        	// splitContainer2.Panel2
        	// 
        	this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
        	this.splitContainer2.Size = new System.Drawing.Size(580, 300);
        	this.splitContainer2.SplitterDistance = 148;
        	this.splitContainer2.TabIndex = 10;
        	// 
        	// resultsList
        	// 
        	this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2,
        	        	        	this.columnHeader3,
        	        	        	this.columnHeader4});
        	this.resultsList.ContextMenuStrip = this.contextMenuStrip;
        	this.resultsList.FullRowSelect = true;
        	this.resultsList.Location = new System.Drawing.Point(9, 8);
        	this.resultsList.MultiSelect = false;
        	this.resultsList.Name = "resultsList";
        	this.resultsList.ShowItemToolTips = true;
        	this.resultsList.Size = new System.Drawing.Size(553, 133);
        	this.resultsList.TabIndex = 1;
        	this.resultsList.UseCompatibleStateImageBehavior = false;
        	this.resultsList.View = System.Windows.Forms.View.Details;
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "Path";
        	this.columnHeader1.Width = 120;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Search";
        	this.columnHeader2.Width = 90;
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Size";
        	this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	this.columnHeader3.Width = 90;
        	// 
        	// columnHeader4
        	// 
        	this.columnHeader4.Text = "Last modified";
        	this.columnHeader4.Width = 50;
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer1.Location = new System.Drawing.Point(9, 3);
        	this.splitContainer1.Name = "splitContainer1";
        	this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.txtReal);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.txtProposal);
        	this.splitContainer1.Size = new System.Drawing.Size(553, 138);
        	this.splitContainer1.SplitterDistance = 62;
        	this.splitContainer1.TabIndex = 10;
        	// 
        	// txtReal
        	// 
        	this.txtReal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.txtReal.Location = new System.Drawing.Point(11, 7);
        	this.txtReal.Name = "txtReal";
        	this.txtReal.Size = new System.Drawing.Size(532, 52);
        	this.txtReal.TabIndex = 8;
        	this.txtReal.Text = "";
        	// 
        	// txtProposal
        	// 
        	this.txtProposal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.txtProposal.Location = new System.Drawing.Point(11, 3);
        	this.txtProposal.Name = "txtProposal";
        	this.txtProposal.Size = new System.Drawing.Size(532, 62);
        	this.txtProposal.TabIndex = 9;
        	this.txtProposal.Text = "";
        	// 
        	// treeView1
        	// 
        	this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left)));
        	this.treeView1.Location = new System.Drawing.Point(7, 20);
        	this.treeView1.Name = "treeView1";
        	this.treeView1.Size = new System.Drawing.Size(163, 290);
        	this.treeView1.TabIndex = 4;
        	// 
        	// delimeterTextBox
        	// 
        	this.delimeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.delimeterTextBox.Location = new System.Drawing.Point(254, 318);
        	this.delimeterTextBox.MaxLength = 4;
        	this.delimeterTextBox.Name = "delimeterTextBox";
        	this.delimeterTextBox.Size = new System.Drawing.Size(38, 20);
        	this.delimeterTextBox.TabIndex = 2;
        	// 
        	// label3
        	// 
        	this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(3, 321);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(249, 13);
        	this.label3.TabIndex = 1;
        	this.label3.Text = "Delimeter for text file (may include escapes \\r,\\n,\\t):";
        	// 
        	// writeResultsButton
        	// 
        	this.writeResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.writeResultsButton.Location = new System.Drawing.Point(606, 316);
        	this.writeResultsButton.Name = "writeResultsButton";
        	this.writeResultsButton.Size = new System.Drawing.Size(150, 23);
        	this.writeResultsButton.TabIndex = 3;
        	this.writeResultsButton.Text = "Write results to text file...";
        	this.writeResultsButton.UseVisualStyleBackColor = true;
        	// 
        	// txtConsole1
        	// 
        	this.txtConsole1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.txtConsole1.Location = new System.Drawing.Point(7, 7);
        	this.txtConsole1.Multiline = true;
        	this.txtConsole1.Name = "txtConsole1";
        	this.txtConsole1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.txtConsole1.Size = new System.Drawing.Size(761, 344);
        	this.txtConsole1.TabIndex = 0;
        	// 
        	// MainWindow
        	// 
        	this.AcceptButton = this.startButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.stopButton;
        	this.ClientSize = new System.Drawing.Size(817, 596);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.configDirTextBox);
        	this.Controls.Add(this.stopButton);
        	this.Controls.Add(this.startButton);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.includeSubDirsCheckBox);
        	this.Controls.Add(this.selectSearchDirButton);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.searchDirTextBox);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.fileNameTextBox);
        	this.Controls.Add(this.tabControl1);
        	this.MinimumSize = new System.Drawing.Size(485, 490);
        	this.Name = "MainWindow";
        	this.Text = "File Searcher";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
        	this.Load += new System.EventHandler(this.MainWindow_Load);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.contextMenuStrip.ResumeLayout(false);
        	this.tabControl1.ResumeLayout(false);
        	this.tabPage1.ResumeLayout(false);
        	this.tabPage2.ResumeLayout(false);
        	this.tabPage2.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.splitContainer2.Panel1.ResumeLayout(false);
        	this.splitContainer2.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
        	this.splitContainer2.ResumeLayout(false);
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtConsole1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtProposal;
        private System.Windows.Forms.RichTextBox txtReal;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox configDirTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Button selectSearchDirButton;
        private System.Windows.Forms.CheckBox includeSubDirsCheckBox;
        private System.Windows.Forms.CheckBox newerThanCheckBox;
        private System.Windows.Forms.DateTimePicker newerThanDateTimePicker;
        private System.Windows.Forms.DateTimePicker olderThanDateTimePicker;
        private System.Windows.Forms.CheckBox olderThanCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderContextMenuItem;
        private System.Windows.Forms.TextBox delimeterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeResultsButton;
    }
}

