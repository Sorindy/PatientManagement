namespace PatientManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnBoss = new System.Windows.Forms.Panel();
            this.pnMidle = new System.Windows.Forms.Panel();
            this.tblypnMidle = new System.Windows.Forms.TableLayoutPanel();
            this.gbWaitingCategory = new System.Windows.Forms.GroupBox();
            this.dgvWaitingCategory = new System.Windows.Forms.DataGridView();
            this.gbAllWaiting = new System.Windows.Forms.GroupBox();
            this.dgvAllWatingList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblypnTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnBoss.SuspendLayout();
            this.pnMidle.SuspendLayout();
            this.tblypnMidle.SuspendLayout();
            this.gbWaitingCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingCategory)).BeginInit();
            this.gbAllWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWatingList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tblypnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(945, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnBoss
            // 
            this.pnBoss.Controls.Add(this.pnMidle);
            this.pnBoss.Controls.Add(this.panel1);
            this.pnBoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBoss.Location = new System.Drawing.Point(0, 0);
            this.pnBoss.Name = "pnBoss";
            this.pnBoss.Size = new System.Drawing.Size(1130, 814);
            this.pnBoss.TabIndex = 4;
            // 
            // pnMidle
            // 
            this.pnMidle.Controls.Add(this.tblypnMidle);
            this.pnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMidle.Location = new System.Drawing.Point(0, 49);
            this.pnMidle.Name = "pnMidle";
            this.pnMidle.Size = new System.Drawing.Size(1130, 765);
            this.pnMidle.TabIndex = 9;
            // 
            // tblypnMidle
            // 
            this.tblypnMidle.ColumnCount = 1;
            this.tblypnMidle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnMidle.Controls.Add(this.gbWaitingCategory, 0, 0);
            this.tblypnMidle.Controls.Add(this.gbAllWaiting, 0, 1);
            this.tblypnMidle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypnMidle.Location = new System.Drawing.Point(0, 0);
            this.tblypnMidle.Name = "tblypnMidle";
            this.tblypnMidle.RowCount = 2;
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tblypnMidle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tblypnMidle.Size = new System.Drawing.Size(1130, 765);
            this.tblypnMidle.TabIndex = 5;
            // 
            // gbWaitingCategory
            // 
            this.gbWaitingCategory.Controls.Add(this.dgvWaitingCategory);
            this.gbWaitingCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWaitingCategory.Location = new System.Drawing.Point(3, 3);
            this.gbWaitingCategory.Name = "gbWaitingCategory";
            this.gbWaitingCategory.Size = new System.Drawing.Size(1124, 340);
            this.gbWaitingCategory.TabIndex = 0;
            this.gbWaitingCategory.TabStop = false;
            this.gbWaitingCategory.Text = "Your Waiting List";
            // 
            // dgvWaitingCategory
            // 
            this.dgvWaitingCategory.AllowUserToAddRows = false;
            this.dgvWaitingCategory.AllowUserToDeleteRows = false;
            this.dgvWaitingCategory.AllowUserToResizeColumns = false;
            this.dgvWaitingCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvWaitingCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaitingCategory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvWaitingCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvWaitingCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvWaitingCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingCategory.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvWaitingCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWaitingCategory.EnableHeadersVisualStyles = false;
            this.dgvWaitingCategory.Location = new System.Drawing.Point(3, 16);
            this.dgvWaitingCategory.Name = "dgvWaitingCategory";
            this.dgvWaitingCategory.ReadOnly = true;
            this.dgvWaitingCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvWaitingCategory.RowHeadersVisible = false;
            this.dgvWaitingCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvWaitingCategory.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvWaitingCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWaitingCategory.RowTemplate.Height = 45;
            this.dgvWaitingCategory.RowTemplate.ReadOnly = true;
            this.dgvWaitingCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitingCategory.Size = new System.Drawing.Size(1118, 321);
            this.dgvWaitingCategory.TabIndex = 7;
            this.dgvWaitingCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaitingCategory_CellContentClick);
            // 
            // gbAllWaiting
            // 
            this.gbAllWaiting.Controls.Add(this.dgvAllWatingList);
            this.gbAllWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAllWaiting.Location = new System.Drawing.Point(3, 349);
            this.gbAllWaiting.Name = "gbAllWaiting";
            this.gbAllWaiting.Size = new System.Drawing.Size(1124, 413);
            this.gbAllWaiting.TabIndex = 1;
            this.gbAllWaiting.TabStop = false;
            this.gbAllWaiting.Text = "All Waiting List";
            // 
            // dgvAllWatingList
            // 
            this.dgvAllWatingList.AllowUserToAddRows = false;
            this.dgvAllWatingList.AllowUserToDeleteRows = false;
            this.dgvAllWatingList.AllowUserToResizeColumns = false;
            this.dgvAllWatingList.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAllWatingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllWatingList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAllWatingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAllWatingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAllWatingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAllWatingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllWatingList.EnableHeadersVisualStyles = false;
            this.dgvAllWatingList.Location = new System.Drawing.Point(3, 16);
            this.dgvAllWatingList.Name = "dgvAllWatingList";
            this.dgvAllWatingList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWatingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvAllWatingList.RowHeadersVisible = false;
            this.dgvAllWatingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.dgvAllWatingList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllWatingList.RowTemplate.Height = 45;
            this.dgvAllWatingList.RowTemplate.ReadOnly = true;
            this.dgvAllWatingList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWatingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllWatingList.Size = new System.Drawing.Size(1118, 394);
            this.dgvAllWatingList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblypnTop);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 49);
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
            this.tblypnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblypnTop.Location = new System.Drawing.Point(0, 0);
            this.tblypnTop.Name = "tblypnTop";
            this.tblypnTop.RowCount = 1;
            this.tblypnTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypnTop.Size = new System.Drawing.Size(1130, 49);
            this.tblypnTop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "                     Waiting List Form";
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
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(756, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 43);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // WaitingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 814);
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
    }
}