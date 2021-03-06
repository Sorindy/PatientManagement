﻿namespace PatientManagement
{
    partial class WaitingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.tblypnMidle = new System.Windows.Forms.TableLayoutPanel();
            this.gbAllWaiting = new System.Windows.Forms.GroupBox();
            this.dgvAllWatingList = new System.Windows.Forms.DataGridView();
            this.tblypnMidleMidle = new System.Windows.Forms.TableLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlFill.SuspendLayout();
            this.pnMidle.SuspendLayout();
            this.tblypnMidle.SuspendLayout();
            this.gbAllWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).BeginInit();
            this.tblypnMidleMidle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnMidle);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1064, 729);
            this.pnlFill.TabIndex = 10;
            // 
            // pnMidle
            // 
            this.pnMidle.Controls.Add(this.tblypnMidle);
            this.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidle.Location = new System.Drawing.Point(0, 0);
            this.pnMidle.Name = "pnMidle";
            this.pnMidle.Size = new System.Drawing.Size(1064, 729);
            this.pnMidle.TabIndex = 10;
            // 
            // tblypnMidle
            // 
            this.tblypnMidle.ColumnCount = 1;
            this.tblypnMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidle.Controls.Add(this.gbAllWaiting, 0, 1);
            this.tblypnMidle.Controls.Add(this.tblypnMidleMidle, 0, 0);
            this.tblypnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnMidle.Location = new System.Drawing.Point(0, 0);
            this.tblypnMidle.Name = "tblypnMidle";
            this.tblypnMidle.RowCount = 2;
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidle.Size = new System.Drawing.Size(1064, 729);
            this.tblypnMidle.TabIndex = 5;
            // 
            // gbAllWaiting
            // 
            this.gbAllWaiting.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbAllWaiting.Controls.Add(this.dgvAllWatingList);
            this.gbAllWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAllWaiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAllWaiting.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllWaiting.ForeColor = System.Drawing.Color.Black;
            this.gbAllWaiting.Location = new System.Drawing.Point(3, 63);
            this.gbAllWaiting.Name = "gbAllWaiting";
            this.gbAllWaiting.Size = new System.Drawing.Size(1058, 663);
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
            this.dgvAllWatingList.MultiSelect = false;
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
            this.dgvAllWatingList.Size = new System.Drawing.Size(1052, 628);
            this.dgvAllWatingList.TabIndex = 7;
            this.dgvAllWatingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllWatingList_CellClick);
            // 
            // tblypnMidleMidle
            // 
            this.tblypnMidleMidle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tblypnMidleMidle.ColumnCount = 4;
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblypnMidleMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnMidleMidle.Controls.Add(this.cboCategory, 3, 0);
            this.tblypnMidleMidle.Controls.Add(this.label2, 0, 0);
            this.tblypnMidleMidle.Controls.Add(this.label3, 2, 0);
            this.tblypnMidleMidle.Controls.Add(this.panel1, 1, 0);
            this.tblypnMidleMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnMidleMidle.Location = new System.Drawing.Point(3, 3);
            this.tblypnMidleMidle.Name = "tblypnMidleMidle";
            this.tblypnMidleMidle.RowCount = 1;
            this.tblypnMidleMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidleMidle.Size = new System.Drawing.Size(1058, 54);
            this.tblypnMidleMidle.TabIndex = 2;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(676, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(379, 44);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            this.cboCategory.TextUpdate += new System.EventHandler(this.cboCategory_TextUpdate);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "សេវាកម្ម :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(558, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "ប្រភេទ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(166, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 48);
            this.panel1.TabIndex = 4;
            // 
            // cboService
            // 
            this.cboService.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboService.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "Medical Imaging",
            "Prescription",
            "Various Document"});
            this.cboService.Location = new System.Drawing.Point(0, 0);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(379, 44);
            this.cboService.TabIndex = 3;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.pnlFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingForm";
            this.Text = "WaitingForm";
            this.Shown += new System.EventHandler(this.WaitingForm_Shown);
            this.pnlFill.ResumeLayout(false);
            this.pnMidle.ResumeLayout(false);
            this.tblypnMidle.ResumeLayout(false);
            this.gbAllWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).EndInit();
            this.tblypnMidleMidle.ResumeLayout(false);
            this.tblypnMidleMidle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnMidle;
        private System.Windows.Forms.TableLayoutPanel tblypnMidle;
        private System.Windows.Forms.GroupBox gbAllWaiting;
        internal System.Windows.Forms.DataGridView dgvAllWatingList;
        private System.Windows.Forms.TableLayoutPanel tblypnMidleMidle;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboService;
    }
}