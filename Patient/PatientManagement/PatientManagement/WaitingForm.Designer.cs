namespace PatientManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.tblypnMidle = new System.Windows.Forms.TableLayoutPanel();
            this.gbAllWaiting = new System.Windows.Forms.GroupBox();
            this.dgvAllWatingList = new System.Windows.Forms.DataGridView();
            this.tblypnMidleMidle = new System.Windows.Forms.TableLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tblypnTop.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnMidle.SuspendLayout();
            this.tblypnMidle.SuspendLayout();
            this.gbAllWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).BeginInit();
            this.tblypnMidleMidle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tblypnTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1064, 65);
            this.pnlTop.TabIndex = 9;
            // 
            // tblypnTop
            // 
            this.tblypnTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tblypnTop.ColumnCount = 1;
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblypnTop.Controls.Add(this.label1, 0, 0);
            this.tblypnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnTop.Location = new System.Drawing.Point(0, 0);
            this.tblypnTop.Name = "tblypnTop";
            this.tblypnTop.RowCount = 1;
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnTop.Size = new System.Drawing.Size(1064, 65);
            this.tblypnTop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(400, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "តារាង ​បង្ហាញបញ្ចីររងចាំ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnMidle);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 65);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1064, 664);
            this.pnlFill.TabIndex = 10;
            // 
            // pnMidle
            // 
            this.pnMidle.Controls.Add(this.tblypnMidle);
            this.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidle.Location = new System.Drawing.Point(0, 0);
            this.pnMidle.Name = "pnMidle";
            this.pnMidle.Size = new System.Drawing.Size(1064, 664);
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
            this.tblypnMidle.Size = new System.Drawing.Size(1064, 664);
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
            this.gbAllWaiting.Size = new System.Drawing.Size(1058, 598);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllWatingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllWatingList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAllWatingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAllWatingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllWatingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllWatingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllWatingList.EnableHeadersVisualStyles = false;
            this.dgvAllWatingList.Location = new System.Drawing.Point(3, 32);
            this.dgvAllWatingList.Name = "dgvAllWatingList";
            this.dgvAllWatingList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllWatingList.RowHeadersVisible = false;
            this.dgvAllWatingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.Height = 45;
            this.dgvAllWatingList.RowTemplate.ReadOnly = true;
            this.dgvAllWatingList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllWatingList.Size = new System.Drawing.Size(1052, 563);
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
            this.tblypnMidleMidle.Controls.Add(this.cboService, 1, 0);
            this.tblypnMidleMidle.Controls.Add(this.label2, 0, 0);
            this.tblypnMidleMidle.Controls.Add(this.label3, 2, 0);
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
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(676, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(379, 44);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
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
            this.cboService.Location = new System.Drawing.Point(166, 3);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(379, 44);
            this.cboService.TabIndex = 2;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
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
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingForm";
            this.Text = "WaitingForm";
            this.Shown += new System.EventHandler(this.WaitingForm_Shown);
            this.pnlTop.ResumeLayout(false);
            this.tblypnTop.ResumeLayout(false);
            this.tblypnTop.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnMidle.ResumeLayout(false);
            this.tblypnMidle.ResumeLayout(false);
            this.gbAllWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).EndInit();
            this.tblypnMidleMidle.ResumeLayout(false);
            this.tblypnMidleMidle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tblypnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnMidle;
        private System.Windows.Forms.TableLayoutPanel tblypnMidle;
        private System.Windows.Forms.GroupBox gbAllWaiting;
        internal System.Windows.Forms.DataGridView dgvAllWatingList;
        private System.Windows.Forms.TableLayoutPanel tblypnMidleMidle;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}