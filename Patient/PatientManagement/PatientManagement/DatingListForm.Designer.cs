namespace PatientManagement
{
    partial class DatingListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDating = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatingId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtgInformation = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tblypnDoctorInformation = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.tblypnRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.tblypnPatientInformation = new System.Windows.Forms.TableLayoutPanel();
            this.tblypnActivity = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tblypnDoctorInformation.SuspendLayout();
            this.pnBoss.SuspendLayout();
            this.pnMidle.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.tblypnRight.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.tblypnTop.SuspendLayout();
            this.tblypnPatientInformation.SuspendLayout();
            this.tblypnActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dating-List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblypnPatientInformation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(676, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient-Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(61, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(238, 28);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatientName.Location = new System.Drawing.Point(391, 3);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(268, 27);
            this.txtPatientName.TabIndex = 4;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatientId.Location = new System.Drawing.Point(61, 3);
            this.txtPatientId.Multiline = true;
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(238, 27);
            this.txtPatientId.TabIndex = 3;
            this.txtPatientId.TextChanged += new System.EventHandler(this.txtPatientId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(305, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient-Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient-Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblypnActivity);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity";
            // 
            // dtpDating
            // 
            this.dtpDating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDating.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDating.Location = new System.Drawing.Point(3, 50);
            this.dtpDating.Name = "dtpDating";
            this.dtpDating.Size = new System.Drawing.Size(182, 20);
            this.dtpDating.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "dating-Id";
            // 
            // txtDatingId
            // 
            this.txtDatingId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatingId.Location = new System.Drawing.Point(3, 21);
            this.txtDatingId.Multiline = true;
            this.txtDatingId.Name = "txtDatingId";
            this.txtDatingId.ReadOnly = true;
            this.txtDatingId.Size = new System.Drawing.Size(182, 23);
            this.txtDatingId.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 76);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.Location = new System.Drawing.Point(3, 194);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(194, 73);
            this.btnShow.TabIndex = 46;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 61);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(3, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(194, 81);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(3, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 58);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(3, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 64);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtgInformation
            // 
            this.dtgInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgInformation.Location = new System.Drawing.Point(0, 0);
            this.dtgInformation.Name = "dtgInformation";
            this.dtgInformation.Size = new System.Drawing.Size(1147, 558);
            this.dtgInformation.TabIndex = 3;
            this.dtgInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInformation_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tblypnDoctorInformation);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 86);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doctor Information";
            // 
            // tblypnDoctorInformation
            // 
            this.tblypnDoctorInformation.ColumnCount = 4;
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tblypnDoctorInformation.Controls.Add(this.label5, 0, 0);
            this.tblypnDoctorInformation.Controls.Add(this.txtStaffName, 3, 0);
            this.tblypnDoctorInformation.Controls.Add(this.txtStaffID, 1, 0);
            this.tblypnDoctorInformation.Controls.Add(this.label4, 2, 0);
            this.tblypnDoctorInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnDoctorInformation.Location = new System.Drawing.Point(3, 16);
            this.tblypnDoctorInformation.Name = "tblypnDoctorInformation";
            this.tblypnDoctorInformation.RowCount = 1;
            this.tblypnDoctorInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnDoctorInformation.Size = new System.Drawing.Size(661, 67);
            this.tblypnDoctorInformation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 67);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor-Id";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffName.Location = new System.Drawing.Point(471, 3);
            this.txtStaffName.Multiline = true;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(187, 61);
            this.txtStaffName.TabIndex = 7;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffID.Location = new System.Drawing.Point(177, 3);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(168, 61);
            this.txtStaffID.TabIndex = 6;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(351, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 67);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor-Name";
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMidle);
            this.pnBoss.Controls.Add(this.pnRight);
            this.pnBoss.Controls.Add(this.pnTop);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1347, 697);
            this.pnBoss.TabIndex = 5;
            // 
            // pnMidle
            // 
            this.pnMidle.Controls.Add(this.dtgInformation);
            this.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidle.Location = new System.Drawing.Point(0, 139);
            this.pnMidle.Name = "pnMidle";
            this.pnMidle.Size = new System.Drawing.Size(1147, 558);
            this.pnMidle.TabIndex = 6;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.tblypnRight);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(1147, 139);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(200, 558);
            this.pnRight.TabIndex = 8;
            // 
            // tblypnRight
            // 
            this.tblypnRight.ColumnCount = 1;
            this.tblypnRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnRight.Controls.Add(this.btnAdd, 0, 1);
            this.tblypnRight.Controls.Add(this.btnShow, 0, 2);
            this.tblypnRight.Controls.Add(this.btnUpdate, 0, 3);
            this.tblypnRight.Controls.Add(this.btnClose, 0, 6);
            this.tblypnRight.Controls.Add(this.btnDelete, 0, 4);
            this.tblypnRight.Controls.Add(this.btnClear, 0, 5);
            this.tblypnRight.Controls.Add(this.groupBox2, 0, 0);
            this.tblypnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnRight.Location = new System.Drawing.Point(0, 0);
            this.tblypnRight.Name = "tblypnRight";
            this.tblypnRight.RowCount = 7;
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblypnRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tblypnRight.Size = new System.Drawing.Size(200, 558);
            this.tblypnRight.TabIndex = 7;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.tblypnTop);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1347, 139);
            this.pnTop.TabIndex = 0;
            // 
            // tblypnTop
            // 
            this.tblypnTop.ColumnCount = 2;
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnTop.Controls.Add(this.groupBox3, 0, 1);
            this.tblypnTop.Controls.Add(this.groupBox1, 1, 1);
            this.tblypnTop.Controls.Add(this.label1, 0, 0);
            this.tblypnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnTop.Location = new System.Drawing.Point(0, 0);
            this.tblypnTop.Name = "tblypnTop";
            this.tblypnTop.RowCount = 2;
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81295F));
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.18705F));
            this.tblypnTop.Size = new System.Drawing.Size(1347, 139);
            this.tblypnTop.TabIndex = 6;
            // 
            // tblypnPatientInformation
            // 
            this.tblypnPatientInformation.ColumnCount = 4;
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.2053F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.7947F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tblypnPatientInformation.Controls.Add(this.label2, 0, 0);
            this.tblypnPatientInformation.Controls.Add(this.btnSearch, 1, 1);
            this.tblypnPatientInformation.Controls.Add(this.txtPatientId, 1, 0);
            this.tblypnPatientInformation.Controls.Add(this.txtPatientName, 3, 0);
            this.tblypnPatientInformation.Controls.Add(this.label3, 2, 0);
            this.tblypnPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnPatientInformation.Location = new System.Drawing.Point(3, 16);
            this.tblypnPatientInformation.Name = "tblypnPatientInformation";
            this.tblypnPatientInformation.RowCount = 2;
            this.tblypnPatientInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnPatientInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnPatientInformation.Size = new System.Drawing.Size(662, 67);
            this.tblypnPatientInformation.TabIndex = 44;
            // 
            // tblypnActivity
            // 
            this.tblypnActivity.ColumnCount = 1;
            this.tblypnActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnActivity.Controls.Add(this.label6, 0, 0);
            this.tblypnActivity.Controls.Add(this.dtpDating, 0, 2);
            this.tblypnActivity.Controls.Add(this.txtDatingId, 0, 1);
            this.tblypnActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnActivity.Location = new System.Drawing.Point(3, 16);
            this.tblypnActivity.Name = "tblypnActivity";
            this.tblypnActivity.RowCount = 3;
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.29787F));
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.70213F));
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblypnActivity.Size = new System.Drawing.Size(188, 84);
            this.tblypnActivity.TabIndex = 51;
            // 
            // DatingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 697);
            this.Controls.Add(this.pnBoss);
            this.Name = "DatingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatingListForm";
            this.Load += new System.EventHandler(this.DatingListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tblypnDoctorInformation.ResumeLayout(false);
            this.tblypnDoctorInformation.PerformLayout();
            this.pnBoss.ResumeLayout(false);
            this.pnMidle.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.tblypnRight.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.tblypnTop.ResumeLayout(false);
            this.tblypnTop.PerformLayout();
            this.tblypnPatientInformation.ResumeLayout(false);
            this.tblypnPatientInformation.PerformLayout();
            this.tblypnActivity.ResumeLayout(false);
            this.tblypnActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgInformation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDatingId;
        private System.Windows.Forms.DateTimePicker dtpDating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnBoss;
        private System.Windows.Forms.Panel pnMidle;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TableLayoutPanel tblypnRight;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.TableLayoutPanel tblypnTop;
        private System.Windows.Forms.TableLayoutPanel tblypnDoctorInformation;
        private System.Windows.Forms.TableLayoutPanel tblypnPatientInformation;
        private System.Windows.Forms.TableLayoutPanel tblypnActivity;
    }
}