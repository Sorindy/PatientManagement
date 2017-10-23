using System;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;

namespace PatientManagement
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private ICategory _category;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Control();
            Refresh();
        }

        public void Clear_Control()
        {
            cmbType.Text = cmbType.GetItemText("Consultation");
            txtId.Text = "";
            txtName.Text = "";
            txtName.Enabled = false;
            btnNew.Visible = true;
            dtgInformation.DataSource = null;
            Refresh();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            cmbType.Text = cmbType.GetItemText("Consultation");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {     
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                _category.Insert(txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();
                _category.Insert(txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                _category.Insert(txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();
                _category.Insert(txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                _category.Insert(txtName.Text);
            }
            btnShow.PerformClick();
            btnInsert.Visible = false;
            btnNew.Visible = true;
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                _category.Update(Convert.ToInt32(txtId.Text), txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();
                _category.Update(Convert.ToInt32(txtId.Text), txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                _category.Update(Convert.ToInt32(txtId.Text), txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();
                _category.Update(Convert.ToInt32(txtId.Text), txtName.Text);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                _category.Update(Convert.ToInt32(txtId.Text), txtName.Text);
            }
            btnShow.PerformClick();
            Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                dtgInformation.DataSource = _category.Show();
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();
                dtgInformation.DataSource = _category.Show();
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                dtgInformation.DataSource = _category.Show();
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();
                dtgInformation.DataSource = _category.Show();
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                dtgInformation.DataSource = _category.Show();
            }
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                _category.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();
                _category.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                _category.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();
                _category.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                _category.Delete(Convert.ToInt32(txtId.Text));
            }
            btnShow.PerformClick();
            Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            btnInsert.Visible = true;
            btnNew.Visible = false;
            Refresh();
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dtgInformation.CurrentRow != null )
           {
               txtId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
               txtName.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
           } 
            Refresh();
        }
    }
}
