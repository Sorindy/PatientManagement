using System;
using System.Windows.Forms;
using PatientManagement.Class;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;
using WaitingList = Hospital_Entity_Framework.WaitingList;

namespace PatientManagement
{
    public partial class CheckInsForm : Form
    {
        public CheckInsForm()
        {
            InitializeComponent();
        }
        private readonly CheckIn _chkIn = new CheckIn();
        internal WaitingList WaitingList;
        internal Patient Patient;
        private string _path = "";

        private void CheckInsForm_Shown(object sender, EventArgs e)
        {
            pnlShowService.Controls.Clear();
            pnlSelection.Controls.Clear();
            pnlShowService.Controls.Add(_chkIn.ShowService());
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
            _chkIn.ClearTemp();
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            picboxHide.ImageLocation = _path + @"Hide-right-icon.png";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Patient == null)
            {
                MessageBox.Show(@"Something is going wrong please check again.", @"Error");
            }
            else
            {
                _chkIn.SubmitService(Patient.Id, DateTime.Now.TimeOfDay);
                ClearControl();
            }
        }

        private void tblSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlSelection.Enabled = true;
            pnlSelection.Controls.Clear();
            pnlShowService.Enabled = true;
        }

        private void picboxSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient{CheckInsForm = this};
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlSelection.Enabled = true;
            pnlSelection.Controls.Clear();
            pnlShowService.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlShowService.Enabled = true;
            pnlSelection.Controls.Clear();
            pnlSelection.Enabled = true;
        }

        internal void ClearControl()
        {
            txtName.Text = "";
            txtGender.Text = "";
            pnlSelection.Controls.Clear();
            pnlShowService.Controls.Clear();
            pnlShowService.Controls.Add(_chkIn.ShowService());
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void picboxHide_Click(object sender, EventArgs e)
        {
            if (picboxHide.Name == "picboxHide")
            {
                picboxHide.Name = "picboxShow";
                picboxHide.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picboxHide.Click += picboxShow_Click;
            }
        }
        private void picboxShow_Click(object sender, EventArgs e)
        {
            picboxHide.Name = "picboxHide";
            picboxHide.ImageLocation = _path + @"Hide-right-icon.png";
            pnlButton.Visible = true;
            picboxHide.Click -= picboxShow_Click;
        }
    }
}
