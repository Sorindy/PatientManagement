namespace PatientManagement
{
    partial class SamplesDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplesDialogForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tblShow = new System.Windows.Forms.TableLayoutPanel();
            this.tblPicking = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new TXTextControl.TextControl();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectForeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frameFillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.tblShow.SuspendLayout();
            this.tblPicking.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tblShow);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 155);
            this.pnlTop.TabIndex = 0;
            // 
            // tblShow
            // 
            this.tblShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tblShow.ColumnCount = 5;
            this.tblShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tblShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tblShow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblShow.Controls.Add(this.tblPicking, 1, 0);
            this.tblShow.Controls.Add(this.tblButton, 3, 0);
            this.tblShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblShow.Location = new System.Drawing.Point(0, 0);
            this.tblShow.Name = "tblShow";
            this.tblShow.RowCount = 1;
            this.tblShow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblShow.Size = new System.Drawing.Size(950, 155);
            this.tblShow.TabIndex = 0;
            this.tblShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblShow_MouseDown);
            this.tblShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblShow_MouseMove);
            this.tblShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblShow_MouseUp);
            // 
            // tblPicking
            // 
            this.tblPicking.ColumnCount = 1;
            this.tblPicking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPicking.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tblPicking.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tblPicking.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tblPicking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPicking.Location = new System.Drawing.Point(23, 3);
            this.tblPicking.Name = "tblPicking";
            this.tblPicking.RowCount = 4;
            this.tblPicking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tblPicking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblPicking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblPicking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPicking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPicking.Size = new System.Drawing.Size(462, 149);
            this.tblPicking.TabIndex = 0;
            this.tblPicking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblPicking_MouseDown);
            this.tblPicking.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblPicking_MouseMove);
            this.tblPicking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblPicking_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(456, 43);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboTitle, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 37);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // cboTitle
            // 
            this.cboTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTitle.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(130, 3);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(317, 31);
            this.cboTitle.TabIndex = 1;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged);
            this.cboTitle.TextChanged += new System.EventHandler(this.cboTitle_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboService, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(456, 35);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // cboService
            // 
            this.cboService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "Medical Imaging",
            "Prescription",
            "Various Document"});
            this.cboService.Location = new System.Drawing.Point(132, 3);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(321, 31);
            this.cboService.TabIndex = 1;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.cboCategory, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(456, 39);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // cboCategory
            // 
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "Medical Imaging",
            "Prescription",
            "Various Document"});
            this.cboCategory.Location = new System.Drawing.Point(132, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(321, 31);
            this.cboCategory.TabIndex = 2;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 5;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Controls.Add(this.btnAdd, 1, 1);
            this.tblButton.Controls.Add(this.btnClose, 3, 1);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(505, 3);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 3;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Size = new System.Drawing.Size(401, 149);
            this.tblButton.TabIndex = 1;
            this.tblButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tblButton_MouseDown);
            this.tblButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tblButton_MouseMove);
            this.tblButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tblButton_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Preah Vihear", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(13, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 69);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "បញ្ចូល";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Preah Vihear", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(213, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 69);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "ចាកចេញ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.groupBox3);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 155);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(950, 586);
            this.pnlFill.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.rulerBar1);
            this.groupBox3.Controls.Add(this.rulerBar2);
            this.groupBox3.Controls.Add(this.buttonBar1);
            this.groupBox3.Controls.Add(this.statusBar1);
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(950, 586);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.ButtonBar = this.buttonBar1;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescription.Location = new System.Drawing.Point(28, 93);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RulerBar = this.rulerBar2;
            this.txtDescription.Size = new System.Drawing.Size(919, 468);
            this.txtDescription.StatusBar = this.statusBar1;
            this.txtDescription.TabIndex = 2;
            this.txtDescription.VerticalRulerBar = this.rulerBar1;
            // 
            // buttonBar1
            // 
            this.buttonBar1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(3, 40);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(944, 28);
            this.buttonBar1.TabIndex = 10;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar2.Location = new System.Drawing.Point(3, 68);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(944, 25);
            this.rulerBar2.TabIndex = 9;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(3, 561);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(944, 22);
            this.statusBar1.TabIndex = 4;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar1.Location = new System.Drawing.Point(3, 93);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(25, 468);
            this.rulerBar1.TabIndex = 5;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.textColorToolStripMenuItem,
            this.foreColorToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.formatStyleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.textColorToolStripMenuItem.Text = "Text Color";
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectForeColorToolStripMenuItem,
            this.frameFillColorToolStripMenuItem});
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            // 
            // selectForeColorToolStripMenuItem
            // 
            this.selectForeColorToolStripMenuItem.Name = "selectForeColorToolStripMenuItem";
            this.selectForeColorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectForeColorToolStripMenuItem.Text = "Select Fore Color";
            // 
            // frameFillColorToolStripMenuItem
            // 
            this.frameFillColorToolStripMenuItem.Name = "frameFillColorToolStripMenuItem";
            this.frameFillColorToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.frameFillColorToolStripMenuItem.Text = "Frame Fill Color";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabToolStripMenuItem,
            this.pageColorToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tabToolStripMenuItem.Text = "Tab";
            // 
            // pageColorToolStripMenuItem
            // 
            this.pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            this.pageColorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pageColorToolStripMenuItem.Text = "Page Color";
            // 
            // formatStyleToolStripMenuItem
            // 
            this.formatStyleToolStripMenuItem.Name = "formatStyleToolStripMenuItem";
            this.formatStyleToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.formatStyleToolStripMenuItem.Text = "Format Style";
            // 
            // SamplesDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 741);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Name = "SamplesDialogForm";
            this.Shown += new System.EventHandler(this.SamplesDialogForm_Shown);
            this.pnlTop.ResumeLayout(false);
            this.tblShow.ResumeLayout(false);
            this.tblPicking.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.TableLayoutPanel tblShow;
        private System.Windows.Forms.GroupBox groupBox3;
        private TXTextControl.TextControl txtDescription;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectForeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frameFillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatStyleToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblPicking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTitle;
    }
}