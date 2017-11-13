using System;
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

        private void Category_Shown(object sender, EventArgs e)
        {
            cboService.Text = "";
            txtName.Enabled = false;
            txtName.Text = "";
            dgvListCategory.ReadOnly = true;
            dgvListCategory.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            dgvListCategory.Enabled = false;
            txtName.Focus();

            if (btnNew.Name == "btnNew")
            {
                btnNew.Text = @"Add";
                btnEdit.Enabled = false;
                btnNew.Name = @"btnAdd";
                btnNew.Click += btnAdd_Click;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnNew.Name == "btnAdd")
            {
                btnNew.Text = @"New";
                btnEdit.Enabled = true;
                btnNew.Name = @"btnNew";
                btnNew.Click -=btnAdd_Click;
            }

            if (cboService.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                if (dgvListCategory.CurrentRow != null)
                    _category.Insert(txtName.Text);
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _category = new LaboratoryCategory();
                if (dgvListCategory.CurrentRow != null)
                    _category.Insert(txtName.Text);
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                if (dgvListCategory.CurrentRow != null)
                    _category.Insert(txtName.Text);
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _category = new PrescriptionCategory();
                if (dgvListCategory.CurrentRow != null)
                    _category.Insert(txtName.Text);
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                if (dgvListCategory.CurrentRow != null)
                    _category.Insert(txtName.Text);
            }

            Category_Shown(this,new EventArgs());
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnEdit")
            {
                btnEdit.Text = @"Update";
                btnEdit.Name = @"btnUpdate";
                cboService.Enabled = false;
                btnNew.Enabled = false;
                btnEdit.Click += btnUpdate_Click;

                if (dgvListCategory.CurrentRow != null)
                {
                    txtName.Text = dgvListCategory.CurrentRow.Cells[1].Value.ToString();
                    dgvListCategory.Enabled = false;
                    txtName.Enabled = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnUpdate")
            {
                btnEdit.Text = @"Edit";
                btnEdit.Name = @"btnEdit";
                cboService.Enabled = true;
                btnNew.Enabled = true;
                btnEdit.Click -= btnUpdate_Click;
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

            Category_Shown(this,new EventArgs());
        }
    }
}
