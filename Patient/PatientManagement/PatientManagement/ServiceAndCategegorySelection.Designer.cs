namespace PatientManagement
{
    partial class ServiceAndCategegorySelection
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRef = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOK.Image = global::PatientManagement.Properties.Resources._46830___save__2_;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(259, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(181, 56);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.Image = global::PatientManagement.Properties.Resources._46795___clear_delete_remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(446, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 56);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Preah Vihear", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "សេវាកម្ម  ";
            // 
            // cboService
            // 
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "MedicalImaging",
            "Prescription",
            "Various Document"});
            this.cboService.Location = new System.Drawing.Point(169, 87);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(458, 41);
            this.cboService.TabIndex = 6;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(169, 162);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(458, 41);
            this.cboCategory.TabIndex = 8;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            this.cboCategory.TextUpdate += new System.EventHandler(this.cboCategory_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Preah Vihear", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "ប្រភេទ     ";
            // 
            // lbRef
            // 
            this.lbRef.AutoSize = true;
            this.lbRef.Font = new System.Drawing.Font("Preah Vihear", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRef.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbRef.Location = new System.Drawing.Point(149, 24);
            this.lbRef.Name = "lbRef";
            this.lbRef.Size = new System.Drawing.Size(71, 29);
            this.lbRef.TabIndex = 9;
            this.lbRef.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Preah Vihear", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nurse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Preah Vihear", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Refferrer :";
            // 
            // lbNur
            // 
            this.lbNur.AutoSize = true;
            this.lbNur.Font = new System.Drawing.Font("Preah Vihear", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNur.Location = new System.Drawing.Point(410, 24);
            this.lbNur.Name = "lbNur";
            this.lbNur.Size = new System.Drawing.Size(71, 29);
            this.lbNur.TabIndex = 12;
            this.lbNur.Text = "NULL";
            // 
            // ServiceAndCategegorySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 311);
            this.Controls.Add(this.lbNur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRef);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceAndCategegorySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ServiceAndCategegorySelection_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServiceAndCategegorySelection_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ServiceAndCategegorySelection_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ServiceAndCategegorySelection_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNur;
    }
}