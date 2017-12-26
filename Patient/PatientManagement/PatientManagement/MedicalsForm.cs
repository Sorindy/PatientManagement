using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using Account = Hospital_Entity_Framework.Account;
using ConsultationCategory = PatientManagement.Class.ConsultationCategory;
using Form = System.Windows.Forms.Form;
using LaboratoryCategory = PatientManagement.Class.LaboratoryCategory;
using Patient = Hospital_Entity_Framework.Patient;
using WaitingList = Hospital_Entity_Framework.WaitingList;
using Worker = Hospital_Entity_Framework.Worker;

namespace PatientManagement
{
    public partial class MedicalsForm : Form
    {
        public MedicalsForm()
        {
            InitializeComponent();
        }

        private string _path;
        internal Account Account;
        internal Patient Patient;
        internal Worker Worker;
        internal WaitingList WaitingList;
        private ICategory _category;
        private readonly MedicalRecord _medical=new MedicalRecord();
        private int _key;
        private readonly Dating _dating = new Dating();

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html;
            txtDescription.Save(out html, TXTextControl.StringStreamType.HTMLFormat);
            txtDescription.Load(html, TXTextControl.StringStreamType.HTMLFormat);


            var form=new SamplesDialogForm(){MedicalsForm = this,CategoryId = _key,ServiceText = cboService.Text,Str = html};
            form.ShowDialog();
        }



        private void MedicalsForm_Shown(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
            txtNameDoctor.Text = Account.Worker.Name;
            txtDescription.ForeColor = Color.Black;
        }

        private void picHideTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picHideTop")
            {
                picHideTop.Name = "picShowTop";
                picHideTop.ImageLocation = _path + @"Hide-down-icon.png";
                pnlTitle.Visible = false;
                picHideTop.Click += picShowTop_Click;
            }
        }

        private void picShowTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picShowTop")
            {
                picHideTop.Name = "picHideTop";
                picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
                pnlTitle.Visible = true;
                picHideTop.Click -= picShowTop_Click;
            }
        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
                pnlButton.Visible = true;
                picHideRight.Click -=picShowRight_Click;
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            var form=new SearchPatient(){MedicalsForm = this};
            form.ShowDialog();
            if (Patient != null)
            {
                txtNamePatient.Text = Patient.Name;
                txtGenderPatient.Text = Patient.Gender;
                if (btnPatient.Name == "btnPatient")
                {
                    btnPatient.Name = "btnInfoPatient";
                    btnPatient.Text = @"ពត៍មាន​ បន្ថែម";
                    btnPatient.Click += btnInfoPatient_Click;
                    btnPatient.Click -= btnPatient_Click;
                }
            }
        }

        private void btnInfoPatient_Click(object sender, EventArgs e)
        {
            if (btnPatient.Name == "btnInfoPatient")
            {
                var form=new PatientForm(){Patient = Patient,Account = Account};
                form.ShowDialog();
            }
        }

        private void btnDating_Click(object sender, EventArgs e)
        {
            var datinglistform = new DatingListForm
            {
                Worker = Account.Worker,
                Patient = Patient
            };
            datinglistform.ShowDialog();
        }

        private void btmWaitingList_Click(object sender, EventArgs e)
        {
          
            var waitinglistform = new WaitingListForm
            { 
                GetStaffCategory = cboCategory.ValueMember,
                Worker = Account.Worker,
                Medicalsform =this
            };
            waitinglistform.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _category = new ConsultationCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Laboratory")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Medical Imaging")
            {
                _category = new MedicalImagingCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Prescription")
            {
                _category = new PrescriptionCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Various Document")
            {
                _category = new VariousDocumentCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
        }

        private void chkBoxReferrer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxReferrer.Checked)
            {
                var dicReferrer = _medical.ShowReferrer();
                if (dicReferrer.Count != 0)
                {
                    cboReferrer.DataSource = new BindingSource(dicReferrer, null);
                    cboReferrer.DisplayMember = "Value";
                    cboReferrer.ValueMember = "Key";
                }
            }
            else
            {
                cboReferrer.DataSource = null;
            }
        }

        private void chkBoxNurse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxNurse.Checked)
            {
                var dicNurse = _medical.ShowNurse();
                if (dicNurse.Count != 0)
                {
                    cboNurse.DataSource = new BindingSource(dicNurse, null);
                    cboNurse.DisplayMember = "Value";
                    cboNurse.ValueMember = "Key";
                }
            }
            else
            {
                cboNurse.DataSource = null;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.DataSource == null) return;

            var selectedItem = cboCategory.SelectedIndex;
            _key = selectedItem;
        }

        private void picAddDate_Click(object sender, EventArgs e)
        {
            _dating.Insert(Patient.Id, Account.Worker.Id, dtpDate.Value);
            MessageBox.Show(@"Dating is Complect....");
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Images.Add();
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

    }
}
