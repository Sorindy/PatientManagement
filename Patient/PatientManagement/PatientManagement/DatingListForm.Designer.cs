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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.tblypnPatientInformation = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.tblypnActivity = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDating = new System.Windows.Forms.DateTimePicker();
            this.txtDatingId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbDoctorInformation = new System.Windows.Forms.GroupBox();
            this.tblypnDoctorInformation = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.dtgInformation = new System.Windows.Forms.DataGridView();
            this.pnRight = new System.Windows.Forms.Panel();
            this.tblypnRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.gbPatientInformation.SuspendLayout();
            this.tblypnPatientInformation.SuspendLayout();
            this.gbActivity.SuspendLayout();
            this.tblypnActivity.SuspendLayout();
            this.gbDoctorInformation.SuspendLayout();
            this.tblypnDoctorInformation.SuspendLayout();
            this.pnBoss.SuspendLayout();
            this.pnMidle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).BeginInit();
            this.pnRight.SuspendLayout();
            this.tblypnRight.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.tblypnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                           Dating List";
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.tblypnPatientInformation);
            this.gbPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPatientInformation.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.Location = new System.Drawing.Point(676, 50);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(668, 86);
            this.gbPatientInformation.TabIndex = 1;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient-Information";
            // 
            // tblypnPatientInformation
            // 
            this.tblypnPatientInformation.ColumnCount = 4;
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.87708F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.12292F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tblypnPatientInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tblypnPatientInformation.Controls.Add(this.label2, 0, 0);
            this.tblypnPatientInformation.Controls.Add(this.btnSearch, 1, 1);
            this.tblypnPatientInformation.Controls.Add(this.txtPatientId, 1, 0);
            this.tblypnPatientInformation.Controls.Add(this.txtPatientName, 3, 0);
            this.tblypnPatientInformation.Controls.Add(this.label3, 2, 0);
            this.tblypnPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnPatientInformation.Location = new System.Drawing.Point(3, 15);
            this.tblypnPatientInformation.Name = "tblypnPatientInformation";
            this.tblypnPatientInformation.RowCount = 2;
            this.tblypnPatientInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnPatientInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnPatientInformation.Size = new System.Drawing.Size(662, 68);
            this.tblypnPatientInformation.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Id";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(113, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 28);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientId
            // 
            this.txtPatientId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatientId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(113, 3);
            this.txtPatientId.Multiline = true;
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.ReadOnly = true;
            this.txtPatientId.Size = new System.Drawing.Size(183, 28);
            this.txtPatientId.TabIndex = 3;
            this.txtPatientId.TextChanged += new System.EventHandler(this.txtPatientId_TextChanged);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatientName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(440, 3);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(219, 28);
            this.txtPatientName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name";
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.tblypnActivity);
            this.gbActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActivity.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActivity.Location = new System.Drawing.Point(3, 3);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(194, 103);
            this.gbActivity.TabIndex = 2;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activity";
            // 
            // tblypnActivity
            // 
            this.tblypnActivity.ColumnCount = 1;
            this.tblypnActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnActivity.Controls.Add(this.label6, 0, 0);
            this.tblypnActivity.Controls.Add(this.dtpDating, 0, 2);
            this.tblypnActivity.Controls.Add(this.txtDatingId, 0, 1);
            this.tblypnActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnActivity.Location = new System.Drawing.Point(3, 15);
            this.tblypnActivity.Name = "tblypnActivity";
            this.tblypnActivity.RowCount = 3;
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.3741F));
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35971F));
            this.tblypnActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.26619F));
            this.tblypnActivity.Size = new System.Drawing.Size(188, 85);
            this.tblypnActivity.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 49;
            this.label6.Text = "dating-Id";
            // 
            // dtpDating
            // 
            this.dtpDating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDating.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDating.Location = new System.Drawing.Point(3, 51);
            this.dtpDating.Name = "dtpDating";
            this.dtpDating.Size = new System.Drawing.Size(182, 19);
            this.dtpDating.TabIndex = 50;
            // 
            // txtDatingId
            // 
            this.txtDatingId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatingId.Location = new System.Drawing.Point(3, 30);
            this.txtDatingId.Multiline = true;
            this.txtDatingId.Name = "txtDatingId";
            this.txtDatingId.ReadOnly = true;
            this.txtDatingId.Size = new System.Drawing.Size(182, 15);
            this.txtDatingId.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnShow.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClose.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 64);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbDoctorInformation
            // 
            this.gbDoctorInformation.Controls.Add(this.tblypnDoctorInformation);
            this.gbDoctorInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDoctorInformation.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoctorInformation.Location = new System.Drawing.Point(3, 50);
            this.gbDoctorInformation.Name = "gbDoctorInformation";
            this.gbDoctorInformation.Size = new System.Drawing.Size(667, 86);
            this.gbDoctorInformation.TabIndex = 4;
            this.gbDoctorInformation.TabStop = false;
            this.gbDoctorInformation.Text = "Doctor Information";
            // 
            // tblypnDoctorInformation
            // 
            this.tblypnDoctorInformation.ColumnCount = 4;
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71758F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.28242F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tblypnDoctorInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tblypnDoctorInformation.Controls.Add(this.label5, 0, 0);
            this.tblypnDoctorInformation.Controls.Add(this.txtStaffName, 3, 0);
            this.tblypnDoctorInformation.Controls.Add(this.txtStaffID, 1, 0);
            this.tblypnDoctorInformation.Controls.Add(this.label4, 2, 0);
            this.tblypnDoctorInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnDoctorInformation.Location = new System.Drawing.Point(3, 15);
            this.tblypnDoctorInformation.Name = "tblypnDoctorInformation";
            this.tblypnDoctorInformation.RowCount = 1;
            this.tblypnDoctorInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblypnDoctorInformation.Size = new System.Drawing.Size(661, 68);
            this.tblypnDoctorInformation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 68);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor Id";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(468, 3);
            this.txtStaffName.Multiline = true;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(190, 62);
            this.txtStaffName.TabIndex = 7;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(109, 3);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(204, 62);
            this.txtStaffID.TabIndex = 6;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 68);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor Name";
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
            // dtgInformation
            // 
            this.dtgInformation.AllowUserToAddRows = false;
            this.dtgInformation.AllowUserToDeleteRows = false;
            this.dtgInformation.AllowUserToResizeColumns = false;
            this.dtgInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInformation.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dtgInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInformation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgInformation.EnableHeadersVisualStyles = false;
            this.dtgInformation.Location = new System.Drawing.Point(0, 0);
            this.dtgInformation.Name = "dtgInformation";
            this.dtgInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgInformation.RowHeadersVisible = false;
            this.dtgInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dtgInformation.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgInformation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgInformation.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgInformation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtgInformation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dtgInformation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgInformation.RowTemplate.Height = 45;
            this.dtgInformation.RowTemplate.ReadOnly = true;
            this.dtgInformation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInformation.Size = new System.Drawing.Size(1147, 558);
            this.dtgInformation.TabIndex = 8;
            this.dtgInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInformation_CellContentClick_1);
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
            this.tblypnRight.Controls.Add(this.gbActivity, 0, 0);
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
            this.tblypnTop.Controls.Add(this.gbDoctorInformation, 0, 1);
            this.tblypnTop.Controls.Add(this.gbPatientInformation, 1, 1);
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
            // DatingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 697);
            this.ControlBox = false;
            this.Controls.Add(this.pnBoss);
            this.Name = "DatingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DatingListForm_Load);
            this.gbPatientInformation.ResumeLayout(false);
            this.tblypnPatientInformation.ResumeLayout(false);
            this.tblypnPatientInformation.PerformLayout();
            this.gbActivity.ResumeLayout(false);
            this.tblypnActivity.ResumeLayout(false);
            this.tblypnActivity.PerformLayout();
            this.gbDoctorInformation.ResumeLayout(false);
            this.tblypnDoctorInformation.ResumeLayout(false);
            this.tblypnDoctorInformation.PerformLayout();
            this.pnBoss.ResumeLayout(false);
            this.pnMidle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInformation)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.tblypnRight.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.tblypnTop.ResumeLayout(false);
            this.tblypnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbDoctorInformation;
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
        internal System.Windows.Forms.DataGridView dtgInformation;
    }
}