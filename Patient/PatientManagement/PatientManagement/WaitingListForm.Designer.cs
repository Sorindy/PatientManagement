﻿namespace PatientManagement
{
    partial class WaitingListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingListForm));
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.tblypnMidle = new System.Windows.Forms.TableLayoutPanel();
            this.gbWaitingCategory = new System.Windows.Forms.GroupBox();
            this.dgvWaitingCategory = new System.Windows.Forms.DataGridView();
            this.gbAllWaiting = new System.Windows.Forms.GroupBox();
            this.dgvAllWatingList = new System.Windows.Forms.DataGridView();
            this.tblypnMidleMidle = new System.Windows.Forms.TableLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnBoss.SuspendLayout();
            this.pnMidle.SuspendLayout();
            this.tblypnMidle.SuspendLayout();
            this.gbWaitingCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingCategory)).BeginInit();
            this.gbAllWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).BeginInit();
            this.tblypnMidleMidle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblypnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMidle);
            this.pnBoss.Controls.Add(this.panel1);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1130, 756);
            this.pnBoss.TabIndex = 4;
            // 
            // pnMidle
            // 
            this.pnMidle.Controls.Add(this.tblypnMidle);
            this.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidle.Location = new System.Drawing.Point(0, 65);
            this.pnMidle.Name = "pnMidle";
            this.pnMidle.Size = new System.Drawing.Size(1130, 691);
            this.pnMidle.TabIndex = 9;
            // 
            // tblypnMidle
            // 
            this.tblypnMidle.ColumnCount = 1;
            this.tblypnMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidle.Controls.Add(this.gbWaitingCategory, 0, 0);
            this.tblypnMidle.Controls.Add(this.gbAllWaiting, 0, 2);
            this.tblypnMidle.Controls.Add(this.tblypnMidleMidle, 0, 1);
            this.tblypnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnMidle.Location = new System.Drawing.Point(0, 0);
            this.tblypnMidle.Name = "tblypnMidle";
            this.tblypnMidle.RowCount = 3;
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.98734F));
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.088608F));
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.79747F));
            this.tblypnMidle.Size = new System.Drawing.Size(1130, 691);
            this.tblypnMidle.TabIndex = 5;
            // 
            // gbWaitingCategory
            // 
            this.gbWaitingCategory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbWaitingCategory.Controls.Add(this.dgvWaitingCategory);
            this.gbWaitingCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWaitingCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWaitingCategory.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWaitingCategory.ForeColor = System.Drawing.Color.Black;
            this.gbWaitingCategory.Location = new System.Drawing.Point(3, 3);
            this.gbWaitingCategory.Name = "gbWaitingCategory";
            this.gbWaitingCategory.Size = new System.Drawing.Size(1124, 332);
            this.gbWaitingCategory.TabIndex = 0;
            this.gbWaitingCategory.TabStop = false;
            this.gbWaitingCategory.Text = "តារាងរបស់អ្នក";
            // 
            // dgvWaitingCategory
            // 
            this.dgvWaitingCategory.AllowUserToAddRows = false;
            this.dgvWaitingCategory.AllowUserToDeleteRows = false;
            this.dgvWaitingCategory.AllowUserToResizeColumns = false;
            this.dgvWaitingCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWaitingCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaitingCategory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvWaitingCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvWaitingCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWaitingCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWaitingCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWaitingCategory.EnableHeadersVisualStyles = false;
            this.dgvWaitingCategory.Location = new System.Drawing.Point(3, 32);
            this.dgvWaitingCategory.Name = "dgvWaitingCategory";
            this.dgvWaitingCategory.ReadOnly = true;
            this.dgvWaitingCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWaitingCategory.RowHeadersVisible = false;
            this.dgvWaitingCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvWaitingCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.RowTemplate.Height = 45;
            this.dgvWaitingCategory.RowTemplate.ReadOnly = true;
            this.dgvWaitingCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitingCategory.Size = new System.Drawing.Size(1118, 297);
            this.dgvWaitingCategory.TabIndex = 7;
            this.dgvWaitingCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaitingCategory_CellContentClick);
            // 
            // gbAllWaiting
            // 
            this.gbAllWaiting.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbAllWaiting.Controls.Add(this.dgvAllWatingList);
            this.gbAllWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAllWaiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAllWaiting.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllWaiting.ForeColor = System.Drawing.Color.Black;
            this.gbAllWaiting.Location = new System.Drawing.Point(3, 390);
            this.gbAllWaiting.Name = "gbAllWaiting";
            this.gbAllWaiting.Size = new System.Drawing.Size(1124, 298);
            this.gbAllWaiting.TabIndex = 1;
            this.gbAllWaiting.TabStop = false;
            this.gbAllWaiting.Text = "តារាង";
            // 
            // dgvAllWatingList
            // 
            this.dgvAllWatingList.AllowUserToAddRows = false;
            this.dgvAllWatingList.AllowUserToDeleteRows = false;
            this.dgvAllWatingList.AllowUserToResizeColumns = false;
            this.dgvAllWatingList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllWatingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllWatingList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAllWatingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAllWatingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllWatingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllWatingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllWatingList.EnableHeadersVisualStyles = false;
            this.dgvAllWatingList.Location = new System.Drawing.Point(3, 32);
            this.dgvAllWatingList.Name = "dgvAllWatingList";
            this.dgvAllWatingList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAllWatingList.RowHeadersVisible = false;
            this.dgvAllWatingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.Height = 45;
            this.dgvAllWatingList.RowTemplate.ReadOnly = true;
            this.dgvAllWatingList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllWatingList.Size = new System.Drawing.Size(1118, 263);
            this.dgvAllWatingList.TabIndex = 7;
            // 
            // tblypnMidleMidle
            // 
            this.tblypnMidleMidle.ColumnCount = 4;
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.56584F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.3879F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.786477F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.17082F));
            this.tblypnMidleMidle.Controls.Add(this.cboCategory, 3, 0);
            this.tblypnMidleMidle.Controls.Add(this.cboService, 1, 0);
            this.tblypnMidleMidle.Controls.Add(this.label2, 0, 0);
            this.tblypnMidleMidle.Controls.Add(this.label3, 2, 0);
            this.tblypnMidleMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnMidleMidle.Location = new System.Drawing.Point(3, 341);
            this.tblypnMidleMidle.Name = "tblypnMidleMidle";
            this.tblypnMidleMidle.RowCount = 1;
            this.tblypnMidleMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidleMidle.Size = new System.Drawing.Size(1124, 43);
            this.tblypnMidleMidle.TabIndex = 2;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(652, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(469, 42);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboService
            // 
            this.cboService.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboService.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "Medical Imaging",
            "Prescription",
            "Various Document"});
            this.cboService.Location = new System.Drawing.Point(133, 3);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(403, 42);
            this.cboService.TabIndex = 2;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "សេវាកម្ម :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(542, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "ប្រភេទ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblypnTop);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 65);
            this.panel1.TabIndex = 8;
            // 
            // tblypnTop
            // 
            this.tblypnTop.ColumnCount = 3;
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.71274F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75834F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52892F));
            this.tblypnTop.Controls.Add(this.btnClose, 2, 0);
            this.tblypnTop.Controls.Add(this.label1, 0, 0);
            this.tblypnTop.Controls.Add(this.btnSubmit, 1, 0);
            this.tblypnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnTop.Location = new System.Drawing.Point(0, 0);
            this.tblypnTop.Name = "tblypnTop";
            this.tblypnTop.RowCount = 1;
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnTop.Size = new System.Drawing.Size(1130, 65);
            this.tblypnTop.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(945, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 59);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "បិត";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "               ​​​​​                  តារាង ​បង្ហាញបញ្ចីររងចាំ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(756, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 59);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "ចុចយក";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1032, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // WaitingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 756);
            this.ControlBox = false;
            this.Controls.Add(this.pnBoss);
            this.Name = "WaitingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WaitingListForm_Load);
            this.pnBoss.ResumeLayout(false);
            this.pnMidle.ResumeLayout(false);
            this.tblypnMidle.ResumeLayout(false);
            this.gbWaitingCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingCategory)).EndInit();
            this.gbAllWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).EndInit();
            this.tblypnMidleMidle.ResumeLayout(false);
            this.tblypnMidleMidle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tblypnTop.ResumeLayout(false);
            this.tblypnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tblypnMidle;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvAllWatingList;
        internal System.Windows.Forms.DataGridView dgvWaitingCategory;
        private System.Windows.Forms.Panel pnMidle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblypnTop;
        private System.Windows.Forms.GroupBox gbWaitingCategory;
        private System.Windows.Forms.GroupBox gbAllWaiting;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tblypnMidleMidle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.ComboBox cboCategory;
    }
}