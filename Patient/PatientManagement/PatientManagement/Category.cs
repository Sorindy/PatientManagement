using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;

namespace PatientManagement
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private ICategory _category;

        private void CheckOrderDgv()
        {
            for (int i = 0; i <= dgvListCategory.RowCount - 1; i++)
            {
                dgvListCategory.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }
        private void Category_Shown(object sender, EventArgs e)
        {
            cboService.Text = null;
            cboService.Enabled = true;
            txtName.Enabled = false;
            txtName.Text = "";
            dgvListCategory.ReadOnly = true;
            dgvListCategory.Enabled = true;
            dgvListCategory.DataSource = null;
            btnDelete.Enabled = false;
            CheckOrderDgv();
            dgvListCategory.ColumnHeadersDefaultCellStyle.Font=new Font(@"Arial",20);
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (cboService.Text != "")
            {
                txtName.Enabled = true;
                dgvListCategory.Enabled = false;
                cboService.Enabled = false;
                txtName.Focus();

                if (btnNew.Name == "btnNew")
                {
                    btnNew.Text = @"បញ្ចូល";
                    btnNew.Name = @"btnAdd";
                    btnNew.Click += btnAdd_Click;
                    btnEdit.Text = @"Cancel";
                    btnEdit.Name = @"btnCancel";
                    btnEdit.Click += btnCancel_Click;
                }
            }
            else
            {
                MessageBox.Show(@"Please select service first.", @"Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnCancel")
            {
                btnEdit.Text = @"កែប្រែ";
                btnEdit.Name = @"btnEdit";
                btnEdit.Click -= btnCancel_Click;
                btnNew.Text = @"បង្កើតថ្មី";
                btnNew.Name = @"btnNew";
                btnNew.Click -= btnAdd_Click;
                cboService_TextChanged(this,new EventArgs());
            }
            if (btnNew.Name == "btnCancel")
            {
                btnEdit.Text = @"កែប្រែ";
                btnEdit.Name = @"btnEdit";
                btnEdit.Click -= btnUpdate_Click;
                btnNew.Text = @"បង្កើតថ្មី";
                btnNew.Name = @"btnNew";
                btnNew.Click -= btnCancel_Click;
                cboService_TextChanged(this,new EventArgs());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (btnNew.Name == "btnAdd")
                {
                    btnNew.Text = @"បង្កើតថ្មី";
                    btnNew.Name = @"btnNew";
                    btnNew.Click -= btnAdd_Click;
                    btnEdit.Text = @"កែប្រែ";
                    btnEdit.Name = @"btnEdit";
                    btnEdit.Click -= btnCancel_Click;
                }

                if (cboService.SelectedIndex.Equals(0))
                {
                    _category = new ConsultationCategory();
                    _category.Insert(txtName.Text);
                }
                if (cboService.SelectedIndex.Equals(1))
                {
                    _category = new LaboratoryCategory();
                    _category.Insert(txtName.Text);
                }
                if (cboService.SelectedIndex.Equals(2))
                {
                    _category = new MedicalImagingCategory();
                    _category.Insert(txtName.Text);
                }
                if (cboService.SelectedIndex.Equals(3))
                {
                    _category = new PrescriptionCategory();
                    _category.Insert(txtName.Text);
                }
                if (cboService.SelectedIndex.Equals(4))
                {
                    _category = new VariousDocumentCategory();
                    _category.Insert(txtName.Text);
                }

                dgvListCategory.Enabled = true;
                txtName.Text = "";
                cboService_TextChanged(this, new EventArgs());
               
            }
            else
            {
                MessageBox.Show(@"Please input text to name.", @"Error");
                txtName.Focus();
            }
        }

        private void cboService_TextChanged(object sender, EventArgs e)
        {
            if (cboService.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                dgvListCategory.DataSource = _category.Show();
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _category = new LaboratoryCategory();
                dgvListCategory.DataSource = _category.Show();
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                dgvListCategory.DataSource = _category.Show();
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _category = new PrescriptionCategory();
                dgvListCategory.DataSource = _category.Show();
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                dgvListCategory.DataSource = _category.Show();
            }
            btnDelete.Enabled = false;
            dgvListCategory.Enabled = true;
            CheckOrderDgv();
            cboService.Enabled = true;
            txtName.Enabled = false;
            txtName.Text = "";
            dgvListCategory.Columns[0].Visible = false;
            DtgHeaderText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboService.Text != "")
            {
                if (btnEdit.Name == "btnEdit")
                {
                    btnEdit.Text = @"បញ្ចូល";
                    btnEdit.Name = @"btnUpdate";
                    cboService.Enabled = false;
                    btnNew.Text = @"Canel";
                    btnNew.Name = @"btnCancel";
                    btnNew.Click += btnCancel_Click;
                    btnEdit.Click += btnUpdate_Click;

                    if (dgvListCategory.CurrentRow != null)
                    {
                        txtName.Text = dgvListCategory.CurrentRow.Cells[2].Value.ToString();
                        dgvListCategory.Enabled = false;
                        txtName.Enabled = true;
                    }
                }
                btnDelete.Enabled = false;
                txtName.Focus();
            }
            else
            {
                MessageBox.Show(@"Please select service first.", @"Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboService.Text != "")
            {
                if (txtName.Text != "")
                {
                    if (btnEdit.Name == "btnUpdate")
                    {
                        btnEdit.Text = @"កែប្រែ";
                        btnEdit.Name = @"btnEdit";
                        cboService.Enabled = true;
                        btnNew.Text = @"បង្កើតថ្មី";
                        btnNew.Name = @"btnNew";
                        btnNew.Enabled = true;
                        btnEdit.Click -= btnUpdate_Click;
                        btnNew.Click -= btnCancel_Click;
                    }

                    if (cboService.SelectedIndex.Equals(0))
                    {
                        _category = new ConsultationCategory();
                        if (dgvListCategory.CurrentRow != null)
                            _category.Update(Convert.ToInt32(dgvListCategory.CurrentRow.Cells[0].Value), txtName.Text);
                    }
                    if (cboService.SelectedIndex.Equals(1))
                    {
                        _category = new LaboratoryCategory();
                        if (dgvListCategory.CurrentRow != null)
                            _category.Update(Convert.ToInt32(dgvListCategory.CurrentRow.Cells[0].Value), txtName.Text);
                    }
                    if (cboService.SelectedIndex.Equals(2))
                    {
                        _category = new MedicalImagingCategory();
                        if (dgvListCategory.CurrentRow != null)
                            _category.Update(Convert.ToInt32(dgvListCategory.CurrentRow.Cells[0].Value), txtName.Text);
                    }
                    if (cboService.SelectedIndex.Equals(3))
                    {
                        _category = new PrescriptionCategory();
                        if (dgvListCategory.CurrentRow != null)
                            _category.Update(Convert.ToInt32(dgvListCategory.CurrentRow.Cells[0].Value), txtName.Text);
                    }
                    if (cboService.SelectedIndex.Equals(4))
                    {
                        _category = new VariousDocumentCategory();
                        if (dgvListCategory.CurrentRow != null)
                            _category.Update(Convert.ToInt32(dgvListCategory.CurrentRow.Cells[0].Value), txtName.Text);
                    }
                    dgvListCategory.Enabled = true;
                    cboService_TextChanged(this, new EventArgs());
                    
                }
                else
                {
                    MessageBox.Show(@"Please input name.", @"Error");
 
                }                
            }
            else
            {
                MessageBox.Show(@"Please select service first.", @"Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msgbox= MessageBox.Show(@"Do you really want to delete this category?", @"Permenant deletation",MessageBoxButtons.YesNo);
            if (msgbox == DialogResult.Yes)
            {
                MessageBox.Show(@"Sorry you can't delete this category because it had some data contain in it.",
                    @"Permenant deletation");
            }
        }

        private void dgvListCategory_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnNew.Name == "btnAdd")
                {
                    btnAdd_Click(this, new EventArgs());
                }
                else
                {
                    btnUpdate_Click(this,new EventArgs());
                }
            }
        }

        public void DtgHeaderText()
        {
            dgvListCategory.Columns[0].HeaderText = @"ID";
            dgvListCategory.Columns[1].HeaderText = @"លេខរៀង";
            dgvListCategory.Columns[2].HeaderText = @"ឈ្មោះ";
        }
    }
}
