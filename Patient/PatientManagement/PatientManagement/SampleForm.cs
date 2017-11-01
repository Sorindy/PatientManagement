using System;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;

namespace PatientManagement
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private ISample _sample;
        private ICategory _category;

        private void SampleForm_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            cmbType.Text = cmbType.GetItemText("Consultation");
            dtgInformation.Visible = false;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
           
            btnNew.Visible = false;
            btnInsert.Visible = true;
            txtDescription.Enabled  = true;
            dtgInformation.Visible = false;
            Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Insert( txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationSample/"+txtTitle.Text ,Convert.ToInt32( txtCategoryId.Text ));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationSample/"+txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Insert(txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Insert(txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Insert(txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratorySample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratorySample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Insert(txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousdocumentSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousdocumentSample/" + txtTitle.Text, StreamType.RichTextFormat);
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
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratorySample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratorySample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Update(Convert.ToInt32(txtId.Text), txtTitle.Text, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousDocumentSample/" + txtTitle.Text, Convert.ToInt32(txtCategoryId.Text));
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousDocumentSample/" + txtTitle.Text, StreamType.RichTextFormat);
            }
            btnShow.PerformClick();
            Clear_Control();
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
                
                
            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                _sample.Delete(Convert.ToInt32(txtId.Text));
            }
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
            if (cmbType.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                dtgInformation.DataSource = _sample.Show();
            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                dtgInformation.DataSource = _sample.Show();
            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                dtgInformation.DataSource = _sample.Show();
            }
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
                cmbCategory.Text = dtgInformation.CurrentRow.Cells[2].Value.ToString();
                txtDescription.Load(dtgInformation.CurrentRow.Cells[3].Value.ToString(),StreamType.RichTextFormat);
            }
            dtgInformation.Visible = false;
            txtDescription.Visible = true;
            Refresh();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtDescription.Enabled = true;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FontDialog();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TextBackColorDialog();
        }

        private void selectForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.ForeColorDialog();
        }

        private void frameFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FrameFillColorDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Tables.Add();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Images.Add();
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TabDialog();
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.PageColorDialog();
        }

        private void formatStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FormattingStylesDialog();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                txtCategoryId.Text = _category.Search_Id(cmbCategory.Text).ToString();

            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();

            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();

            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();

            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();

            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                cmbCategory.DataSource = _category.Show_Category_Name();

            }
            if (cmbType.SelectedIndex.Equals(1))
            {
                _category = new PrescriptionCategory();

            }
            if (cmbType.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();

            }
            if (cmbType.SelectedIndex.Equals(3))
            {
                _category = new LaboratoryCategory();

            }
            if (cmbType.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();

            }
        }

    }
}
  