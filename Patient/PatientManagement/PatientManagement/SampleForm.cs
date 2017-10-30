using System;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;

namespace PatientManagement
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private ISample _sample;

        private void SampleForm_Load(object sender, EventArgs e)
        {
            cmbType.Text = cmbType.GetItemText("Consultation");
            dtgInformation.Visible = false;
        }

        private void btnFort_Click(object sender, EventArgs e)
        {
            _fd = new FontDialog
            {
                ShowColor = true,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = true
            };
            if (_fd.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty( txtDescription.Text))
            {
               
               txtDescription.SelectionFont = _fd.Font;
               txtDescription.SelectionColor = _fd.Color;
            }
         
        }

        private void _fd_Apply(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
            btnNew.Visible = false;
            btnInsert.Visible = true;
            txtDescription.Visible = true;
            dtgInformation.Visible = false;
            Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Insert( txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Insert( txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Insert( txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Insert( txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Insert( txtTitle.Text, txtDescription.Text);
            }
            btnShow.PerformClick();
            Clear_Control();
            btnInsert.Visible = false;
            btnNew.Visible = true;
            Refresh();
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
            txtTitle.Text = "";
            txtDescription.Text = "";
            btnNew.Visible = true;
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, txtDescription.Text);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, txtDescription.Text);
            }
            btnShow.PerformClick();
            Clear_Control();
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (cmbType.Text == "Consultation")
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            //if (cmbType.Text == "Prescription")
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            //if (cmbType.Text == "MedicalImaging")
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            //if (cmbType.Text == "Laboratory")
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            //if (cmbType.Text == "VariousDocument")
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            btnShow.PerformClick();
            Clear_Control();
            Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                dtgInformation.DataSource = _sample.Show();
            }
            //if (cmbType.Text == "Prescription")
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                dtgInformation.DataSource = _sample.Show();
            }
            //if (cmbType.Text == "MedicalImaging")
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                dtgInformation.DataSource = _sample.Show();
            }
            //if (cmbType.Text == "Laboratory")
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                dtgInformation.DataSource = _sample.Show();
            }
            //if (cmbType.Text == "VariousDocument")
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                dtgInformation.DataSource = _sample.Show();
            }
            dtgInformation.Visible = true;
            txtDescription.Visible = false;
            Refresh();
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                txtId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dtgInformation.CurrentRow.Cells[2].Value.ToString();
            }
            dtgInformation.Visible = false;
            txtDescription.Visible = true;
            Refresh();
        }

    }
}
    
