using System;
using System.Drawing;
using PatientManagement.Class;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class RefferrerForm : Form
    {
        private readonly Refferrer _refferrer = new Refferrer();
        internal Hospital_Entity_Framework.Referrer Referrer;
        internal MedicalsForm MedicalForm;
        internal HistorysForm HistoryForm;
        private bool _mouseDown;
        private Point _lastLocation;

        public RefferrerForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtfName.Text = "";
            txtlName.Text = "";
            txtSpeciality.Text = "";
            txtWorkPlace.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefferrerForm_Load(object sender, EventArgs e)
        {
            if (Referrer == null)
            {
                Clear();

                btnEdit.Name = @"btnAdd";
                btnEdit.Text = @"បញ្ចូល";
                btnEdit.Click += btnAdd_Click;
            }
            else
            {
                Clear();
                txtfName.Text = Referrer.FirstName;
                txtlName.Text = Referrer.LastName;
                txtSpeciality.Text = Referrer.Specialty;
                txtWorkPlace.Text = Referrer.WorkPlace;
                txtPhone1.Text = Referrer.Phone1;
                txtPhone2.Text = Referrer.Phone2;
                txtEmail.Text = Referrer.Email;

                txtfName.Enabled = false;
                txtlName.Enabled = false;
                txtSpeciality.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone1.Enabled = false;
                txtPhone2.Enabled = false;
                txtWorkPlace.Enabled = false;
                btnEdit.Name = @"btnEdit";
                btnEdit.Text = @"កែប្រែ";
                btnEdit.Click +=btnEdit_Click;

                btnClear.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Name == @"btnAdd")
                {
                    try
                    {
                        var phone1 = Convert.ToInt32(txtPhone1.Text).ToString();
                        var phone2="";
                        if (txtPhone2.Text != "")
                        {
                             phone2 = Convert.ToInt32(txtPhone2.Text).ToString();
                        }
                        var getref= _refferrer.Insert(txtfName.Text, txtlName.Text, txtSpeciality.Text, txtWorkPlace.Text,phone1, phone2, txtEmail.Text);

                        if (MedicalForm!=null)
                        {
                            MedicalForm.Medical = null;
                            MedicalForm.Refferrer = null;
                            MedicalForm.Refferrer = new Refferrer();
                            MedicalForm.Medical = new MedicalRecord();
                            MedicalForm.chkBoxReferrer.Checked = true;
                            MedicalForm.cboReferrer.SelectedValue = getref.Id;
                        }

                        if (HistoryForm != null)
                        {
                            HistoryForm.Medical = null;
                            HistoryForm.Refferrer = null;
                            HistoryForm.Medical=new MedicalRecord();
                            HistoryForm.Refferrer=new Refferrer();
                            HistoryForm.chkBoxReferrer.Checked = true;
                            HistoryForm.cboReferrer.SelectedValue = getref.Id;
                        }

                        Close();
                    }
                    catch
                    {
                        MessageBox.Show(@"Please Input Phone number only digit number.", @"Error");
                    }
                }
                if (btnEdit.Name == @"btnUpdate")
                {
                    try
                    {
                        var phone1 = Convert.ToInt32(txtPhone1.Text).ToString();
                        var phone2 = "";
                        if (txtPhone2.Text != "")
                        {
                            phone2 = Convert.ToInt32(txtPhone2.Text).ToString();
                        }
                        var getref = _refferrer.Update(Referrer.Id, txtfName.Text, txtlName.Text, txtSpeciality.Text, txtWorkPlace.Text, phone1, phone2, txtEmail.Text);

                        if (MedicalForm != null)
                        {
                            MedicalForm.Medical = null;
                            MedicalForm.Refferrer = null;
                            MedicalForm.Refferrer = new Refferrer();
                            MedicalForm.Medical = new MedicalRecord();
                            MedicalForm.chkBoxReferrer.Checked = true;
                            MedicalForm.cboReferrer.SelectedValue = getref.Id;
                        }

                        if (HistoryForm != null)
                        {
                            HistoryForm.Medical = null;
                            HistoryForm.Refferrer = null;
                            HistoryForm.Medical = new MedicalRecord();
                            HistoryForm.Refferrer = new Refferrer();
                            HistoryForm.chkBoxReferrer.Checked = true;
                            HistoryForm.cboReferrer.SelectedValue = getref.Id;
                        }

                        Close();
                    }
                    catch
                    {
                        MessageBox.Show(@"Please Input Phone number only digit number.", @"Error");
                    }
                }
            }
            catch
            {
               Checking();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == @"btnEdit")
            {
                btnEdit.Name = @"btnUpdate";
                btnEdit.Text = @"បញ្ចូល";
                btnEdit.Click += btnUpdate_Click;

                btnClear.Enabled = true;

                txtfName.Enabled = true;
                txtlName.Enabled = true;
                txtSpeciality.Enabled = true;
                txtWorkPlace.Enabled = true;
                txtPhone1.Enabled = true;
                txtPhone2.Enabled = true;
                txtEmail.Enabled = true;
            }
        }

        private void Checking()
        {
            if (txtfName.Text == "")
            {
                MessageBox.Show(@"Please filling First Name.", @"Error");
                txtfName.Focus();
                return;
            }
            if (txtlName.Text == "")
            {
                MessageBox.Show(@"Please filling Last Name.", @"Error");
                txtlName.Focus();
                return;
            }
            if (txtSpeciality.Text == "")
            {
                MessageBox.Show(@"Please filling Speciality.", @"Error");
                txtSpeciality.Focus();
                return;
            }
            if (txtWorkPlace.Text == "")
            {
                MessageBox.Show(@"Please filling WorkPlace.", @"Error");
                txtWorkPlace.Focus();
                return;
            }
            if (txtPhone1.Text == "")
            {
                MessageBox.Show(@"Please filling Phone number at least 1.", @"Error");
                txtPhone1.Focus();
                return;
            }
            if (txtPhone2.Text == "")
            {
                txtPhone2.Text = @"NONE";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text=@"NONE";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Name == @"btnUpdate")
                {
                    try
                    {
                        var phone1 = Convert.ToInt32(txtPhone1.Text).ToString();
                        var phone2 = "";
                        if (txtPhone2.Text != "")
                        {
                            phone2 = Convert.ToInt32(txtPhone2.Text).ToString();
                        } 
                        _refferrer.Update(Referrer.Id, txtfName.Text, txtlName.Text, txtSpeciality.Text, txtWorkPlace.Text, phone1, phone2, txtEmail.Text);

                    txtfName.Enabled = false;
                    txtlName.Enabled = false;
                    txtSpeciality.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPhone1.Enabled = false;
                    txtPhone2.Enabled = false;
                    txtWorkPlace.Enabled = false;
                    btnEdit.Name = @"btnEdit";
                    btnEdit.Text = @"កែប្រែ";
                    btnEdit.Click += btnEdit_Click;

                    btnClear.Enabled = false;

                    if (MedicalForm.chkBoxReferrer.Checked)
                    {
                        MedicalForm.Medical = null;
                        MedicalForm.Refferrer = null;
                        MedicalForm.Refferrer = new Refferrer();
                        MedicalForm.Medical = new MedicalRecord();
                        MedicalForm.chkBoxReferrer_CheckedChanged(MedicalForm, new EventArgs());
                    }
                    }
                    catch
                    {
                        MessageBox.Show(@"Please Input Phone number only digit number.", @"Error");
                    }
                }
            }
            catch
            {
                Checking();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //if (MedicalForm.chkBoxReferrer.Checked)
            //{
            //    MedicalForm.Medical = null;
            //    MedicalForm.Refferrer = null;
            //    MedicalForm.Refferrer = new Refferrer();
            //    MedicalForm.Medical=new MedicalRecord();
            //    MedicalForm.chkBoxReferrer_CheckedChanged(MedicalForm, new EventArgs());
            //}
            if(btnEdit.Name!="btnAdd"||btnEdit.Name!="btnEdit")return;
            Clear();
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
        {

            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
