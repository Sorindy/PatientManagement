namespace PatientManagement
{
    partial class ManagementForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cboControl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboControlName = new System.Windows.Forms.GroupBox();
            this.gboPreview = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(823, 525);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 82);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(575, 242);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(430, 248);
            this.dgvShow.TabIndex = 1;
            this.dgvShow.SelectionChanged += new System.EventHandler(this.dgvShow_SelectionChanged);
            // 
            // cboControl
            // 
            this.cboControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboControl.FormattingEnabled = true;
            this.cboControl.Location = new System.Drawing.Point(671, 103);
            this.cboControl.Name = "cboControl";
            this.cboControl.Size = new System.Drawing.Size(334, 39);
            this.cboControl.TabIndex = 2;
            this.cboControl.SelectedIndexChanged += new System.EventHandler(this.cboControl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Management Form";
            // 
            // gboControlName
            // 
            this.gboControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboControlName.Location = new System.Drawing.Point(12, 58);
            this.gboControlName.Name = "gboControlName";
            this.gboControlName.Size = new System.Drawing.Size(538, 432);
            this.gboControlName.TabIndex = 4;
            this.gboControlName.TabStop = false;
            this.gboControlName.Text = "Control\'s Name";
            // 
            // gboPreview
            // 
            this.gboPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPreview.Location = new System.Drawing.Point(12, 496);
            this.gboPreview.Name = "gboPreview";
            this.gboPreview.Size = new System.Drawing.Size(538, 233);
            this.gboPreview.TabIndex = 5;
            this.gboPreview.TabStop = false;
            this.gboPreview.Text = "Preview Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(671, 177);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 38);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(575, 525);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(182, 82);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(707, 637);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 77);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 733);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gboPreview);
            this.Controls.Add(this.gboControlName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboControl);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSubmit);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ComboBox cboControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboControlName;
        private System.Windows.Forms.GroupBox gboPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClose;
    }
}