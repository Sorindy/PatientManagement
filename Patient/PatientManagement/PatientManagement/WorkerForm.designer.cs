namespace PatientManagement
{
    partial class WorkerForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dgvWorker = new System.Windows.Forms.DataGridView();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpSWD = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1164, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 80);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worker Registration";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(132, 245);
            this.dtpDOB.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(262, 30);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // dgvWorker
            // 
            this.dgvWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorker.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorker.Location = new System.Drawing.Point(12, 410);
            this.dgvWorker.MultiSelect = false;
            this.dgvWorker.Name = "dgvWorker";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorker.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorker.Size = new System.Drawing.Size(1338, 319);
            this.dgvWorker.TabIndex = 17;
            this.dgvWorker.SelectionChanged += new System.EventHandler(this.dgvWorker_SelectionChanged);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboGender.Location = new System.Drawing.Point(132, 193);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(262, 33);
            this.cboGender.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(132, 93);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(262, 30);
            this.txtID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 30);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(132, 310);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(262, 30);
            this.txtAge.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Month / Days / Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone 2";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(530, 140);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(242, 30);
            this.txtPhone2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phone 1";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.Location = new System.Drawing.Point(530, 90);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(242, 30);
            this.txtPhone1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(530, 240);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(242, 30);
            this.txtPosition.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(530, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Start Work Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(410, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(530, 290);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(242, 30);
            this.txtSalary.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(132, 353);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 30);
            this.txtAddress.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(551, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Month / Days / Year";
            // 
            // dtpSWD
            // 
            this.dtpSWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSWD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSWD.Location = new System.Drawing.Point(555, 338);
            this.dtpSWD.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpSWD.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpSWD.Name = "dtpSWD";
            this.dtpSWD.Size = new System.Drawing.Size(217, 30);
            this.dtpSWD.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(789, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 29);
            this.label16.TabIndex = 31;
            this.label16.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(909, 364);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 30);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1174, 318);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 80);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1164, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 80);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1164, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 80);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(991, 162);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(161, 80);
            this.btnCreateAcc.TabIndex = 14;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(820, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 80);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(820, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 80);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1174, 318);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 80);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(991, 162);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(161, 80);
            this.btnUpdateAcc.TabIndex = 33;
            this.btnUpdateAcc.Text = "Update Account";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(820, 109);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(161, 80);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpSWD);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.dgvWorker);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DataGridView dgvWorker;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpSWD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnNew;
    }
}