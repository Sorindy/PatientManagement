using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;

namespace PatientManagement
{
    public partial class MedicalRecordWebViewer : Form
    {
        internal string Html;
        internal Patient Patient;
        internal Account Account;
        public string Refferrer;
        private string _path;
        private readonly DefaultSamplePrint  _defaultSample= new DefaultSamplePrint() ;
        internal int Defaultsampleprint;

        public MedicalRecordWebViewer()
        {
            InitializeComponent();
        }

        private void MedicalRecordWebViewer_Load(object sender, EventArgs e)
        {
            var start = '<';
            var startindex = Html.IndexOf(start);
            var end = "left;"+'"'+'>';
            var endindex = Html.IndexOf(end, StringComparison.Ordinal);
            var count = Html.Substring(startindex, endindex + start - startindex).Count();


            Html = Html.Substring(count-51);
            Html = Html.Remove(Html.Length - 16);
      
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"S:\";
            Defaultsampleprint = _defaultSample.SearchId(Account.WorkerId);
            CheckDefaultPrintSample(Defaultsampleprint);
        }

        public string DirectoryAndPath()
        {
            string path;
            if (Directory.Exists(@"S:\"))
            {
                path = @"D:\ABC soft\";
            }
            else
            {
                path = _path;
            }
            return path;
        }

        public void ShowSample_A_InWebViewer()
        {
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleA.html");
        }

        public void ShowSample_B_InWebViewer()
        {
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleB.html");
        }

        public void ShowSample_C_InWebViewer()
        {
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleC.html");
        }

        public void ShowSample_D_InWebViewer()
        {
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleD.html");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wvPrintSample.Print();
        }

        private void printDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wvPrintSample.ShowPrintDialog();
        }

        private void printPreviewDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wvPrintSample.ShowPrintPreviewDialog();
        }

        private void sampleAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSample_A_InWebViewer();
        }

        private void sampleBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSample_B_InWebViewer();
        }

        private void sampleCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSample_C_InWebViewer();
        }

        private void sampleDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSample_D_InWebViewer();
        }

        public void InputContentSampleA_B_C_D()
        {
            if (wvPrintSample.Document != null)
            {
                var daydate = wvPrintSample.Document.GetElementById("DayDate");
                if (daydate != null) daydate.InnerHtml = DateTime.Now.ToString("dddd, dd MMMM yyyy");

                var patientname = wvPrintSample.Document.GetElementById("PatientName");
                if (patientname != null) patientname.InnerHtml = Patient.FirstName.ToUpper() + " " + Patient.LastName.ToUpper() + "( " + Patient.KhmerName + " )";

                var patientId = wvPrintSample.Document.GetElementById("PatientId");
                if (patientId != null) patientId.InnerHtml = Patient.PatientIdentify.ToString();

                var gender = wvPrintSample.Document.GetElementById("Gender");
                if (gender != null) gender.InnerHtml = Patient.Gender;

                var age = wvPrintSample.Document.GetElementById("Age");
                if (age != null) age.InnerHtml = Patient.Age.ToString();

                var referrerName = wvPrintSample.Document.GetElementById("ReferrerName");
                if (referrerName != null) referrerName.InnerHtml = Refferrer;

                var dr = wvPrintSample.Document.GetElementById("Dr");
                if (dr != null) dr.InnerHtml = Account.Worker.FirstName.ToUpper() + " " + Account.Worker.LastName.ToUpper();

                var phonenumber = wvPrintSample.Document.GetElementById("PhoneNumber");
                if (phonenumber != null) phonenumber.InnerHtml = Patient.Phone1;

                var boxcontrol = wvPrintSample.Document.GetElementById("Box2");
                if (boxcontrol != null) boxcontrol.InnerHtml = Html;

                var body = wvPrintSample.Document.GetElementById("Body");
                if (body != null) body.Style =
                      "padding-left: " + _defaultSample.SetPadding(Account.WorkerId, Defaultsampleprint).PadddingLeft + "px; "
                    + "padding-top: " + _defaultSample.SetPadding(Account.WorkerId, Defaultsampleprint).PaddingTop + "px; "
                    + "padding-right: " + _defaultSample.SetPadding(Account.WorkerId, Defaultsampleprint).PaddingRight + "px; "
                    + "padding-down: " + _defaultSample.SetPadding(Account.WorkerId, Defaultsampleprint).PaddingDown + "px; ";
            }
        }

        private void wvPrintSample_Navigated(object sender,WebBrowserNavigatedEventArgs e)
        {
                InputContentSampleA_B_C_D();  
        }

        public void CheckDefaultPrintSample(int defualtsample)
        {
            if (defualtsample == 1)
            {
                sampleAToolStripMenuItem.PerformClick();
            }
            else if (defualtsample == 2)
            {
                sampleBToolStripMenuItem.PerformClick();
            }
            else if (defualtsample == 3)
            {
                sampleCToolStripMenuItem.PerformClick();
            }
            else if (defualtsample == 4)
            {
                sampleDToolStripMenuItem.PerformClick();
            }
            else
            {
                sampleAToolStripMenuItem.PerformClick();
            }
        }

        private void setAAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtATop.Text != @"top" || txtADown.Text != @"down" || txtAleft.Text != @"left" || txtARight.Text != @"right")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 1, Convert.ToInt16(txtATop.Text),
                    Convert.ToInt16(txtAleft.Text), Convert.ToInt16(txtARight.Text), Convert.ToInt16(txtADown.Text));
                
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                _defaultSample.SetUsing(Account.WorkerId, 3, false);
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Make Sure Your Magin is not Null");
            }
        }

        private void setBAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBTop.Text != @"top" || txtBDown.Text != @"down" || txtBLeft.Text != @"left" || txtBRight.Text != @"right")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 2, Convert.ToInt16(txtBTop.Text),
                    Convert.ToInt16(txtBLeft.Text), Convert.ToInt16(txtBRight.Text), Convert.ToInt16(txtBDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
               
                _defaultSample.SetUsing(Account.WorkerId, 3, false);
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Make Sure Your Magin is not Null");
            }
        }

        private void setCAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCTop.Text != @"top" || txtCDown.Text != @"down" || txtCLeft.Text != @"left" || txtCRight.Text != @"right")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 3, Convert.ToInt16(txtCTop.Text),
                    Convert.ToInt16(txtCLeft.Text), Convert.ToInt16(txtCRight.Text), Convert.ToInt16(txtCDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Make Sure Your Magin is not Null");
            }
        }

        private void setDAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDTop.Text != @"top" || txtDDown.Text != @"down" || txtDLeft.Text != @"left" || txtDRight.Text != @"right")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 4, Convert.ToInt16(txtDTop.Text),
                    Convert.ToInt16(txtDLeft.Text), Convert.ToInt16(txtDRight.Text), Convert.ToInt16(txtDDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                _defaultSample.SetUsing(Account.WorkerId, 3,false);
               
            }
            else
            {
                MessageBox.Show(@"Please Make Sure Your Magin is not Null");
            }
        }

    
    
    }
}
