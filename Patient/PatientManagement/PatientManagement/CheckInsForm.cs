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

        private void CheckInsForm_Shown(object sender, EventArgs e)
        {
            pnlShowService.Controls.Clear();
            pnlSelection.Controls.Clear();
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
            picboxHide.Image = Properties.Resources.Hide_right_icon;
            //picboxHide.ImageLocation = _path + @"Hide-right-icon.png";
            if (Patient == null) return;
            txtName.Text = Patient.FirstName + @"    " + Patient.LastName;
            txtGender.Text = Patient.Gender;
            pnlShowService.Controls.Add(_chkIn.ShowService(this));
            pnlShowService.Enabled = true;
            pnlSelection.Enabled = true;
            txtGender.Enabled = false;
            txtName.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Patient == null)
            {
                MessageBox.Show(@"Something is going wrong please check again.", @"Error");
            }
            else
            {
                if (_chkIn.CheckWaitinglist(Patient.Id))
                {
                    _chkIn.SubmitService(this, DateTime.Now.TimeOfDay);
                    var print = new PrintWaitingForm();
                    if (WaitingList != null) print.WaitingList = WaitingList;
                    print.Show();
                    ClearControl();
                }
                else
                {
                  MessageBox.Show(
                        @"You didn't select any category yet . Please select at least one category to checkin.",
                        @"Empty Selection");
                }
            }
        }

        private void tblSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.FirstName+@"    "+ Patient.LastName;
            txtGender.Text = Patient.Gender;
            pnlShowService.Controls.Add(_chkIn.ShowService(this));
            pnlSelection.Enabled = true;
            pnlShowService.Enabled = true;
        }

        private void picboxSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient{CheckInsForm = this};
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.FirstName + @"   " + Patient.LastName;
            txtGender.Text = Patient.Gender;
            pnlShowService.Controls.Add(_chkIn.ShowService(this));
            pnlSelection.Enabled = true;
            pnlShowService.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchPatient { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.FirstName + @"    " + Patient.LastName;
            txtGender.Text = Patient.Gender;
            pnlShowService.Controls.Add(_chkIn.ShowService(this));
            pnlShowService.Enabled = true;
            pnlSelection.Enabled = true;
        }

        internal void ClearControl()
        {
            txtName.Text = "";
            txtGender.Text = "";
            pnlSelection.Controls.Clear();
            pnlShowService.Controls.Clear();
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
            Patient = null;
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
                picboxHide.Image = Properties.Resources.Hide_left_icon;
                //picboxHide.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picboxHide.Click += picboxShow_Click;
            }
        }
        private void picboxShow_Click(object sender, EventArgs e)
        {
            picboxHide.Name = "picboxHide";
            picboxHide.Image = Properties.Resources.Hide_right_icon;
            //picboxHide.ImageLocation = _path + @"Hide-right-icon.png";
            pnlButton.Visible = true;
            picboxHide.Click -= picboxShow_Click;
        }
    }
}
