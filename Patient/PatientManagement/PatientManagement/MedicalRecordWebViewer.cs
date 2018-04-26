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
            if (txtATop.Text != "" && txtADown.Text != "" && txtAleft.Text != "" && txtARight.Text != "")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 1, Convert.ToInt16(txtATop.Text),
                    Convert.ToInt16(txtAleft.Text), Convert.ToInt16(txtARight.Text), Convert.ToInt16(txtADown.Text));
                
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                _defaultSample.SetUsing(Account.WorkerId, 3, false);
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Input Number Or Make Sure Your Magin is Not NULL");
            }
        }

        private void setBAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBTop.Text != "" && txtBDown.Text != "" && txtBLeft.Text != "" && txtBRight.Text != "")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 2, Convert.ToInt16(txtBTop.Text),
                    Convert.ToInt16(txtBLeft.Text), Convert.ToInt16(txtBRight.Text), Convert.ToInt16(txtBDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
               
                _defaultSample.SetUsing(Account.WorkerId, 3, false);
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Input Number Or Make Sure Your Magin is Not NULL");
            }
        }

        private void setCAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCTop.Text != "" && txtCDown.Text != "" && txtCLeft.Text != "" && txtCRight.Text != "")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 3, Convert.ToInt16(txtCTop.Text),
                    Convert.ToInt16(txtCLeft.Text), Convert.ToInt16(txtCRight.Text), Convert.ToInt16(txtCDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                
                _defaultSample.SetUsing(Account.WorkerId, 4, false);
            }
            else
            {
                MessageBox.Show(@"Please Input Number Or Make Sure Your Magin is Not NULL");
            }
        }

        private void setDAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDTop.Text != "" && txtDDown.Text != "" && txtDLeft.Text != "" && txtDRight.Text != "")
            {
                _defaultSample.InsertOrUpdate(Account.WorkerId, 4, Convert.ToInt16(txtDTop.Text),
                    Convert.ToInt16(txtDLeft.Text), Convert.ToInt16(txtDRight.Text), Convert.ToInt16(txtDDown.Text));
                _defaultSample.SetUsing(Account.WorkerId, 1, false);
                _defaultSample.SetUsing(Account.WorkerId, 2, false);
                _defaultSample.SetUsing(Account.WorkerId, 3,false);
               
            }
            else
            {
                MessageBox.Show(@"Please Input Number Or Make Sure Your Magin is Not NULL");
            }
        }

        public void ShowPaddingInToolScriptTextboxA()
        {
            if (_defaultSample.CheckSampleNumber(Account.WorkerId, 1))
            {
                txtATop.Text = @"Top = " + _defaultSample.ShowPadding(Account.WorkerId, 1).PaddingTop +@"px";
                txtAleft.Text = @"Left = " + _defaultSample.ShowPadding(Account.WorkerId, 1).PadddingLeft+@"px";
                txtARight.Text = @"Right = " + _defaultSample.ShowPadding(Account.WorkerId, 1).PaddingRight+@"px";
                txtADown.Text = @"Down = " + _defaultSample.ShowPadding(Account.WorkerId, 1).PaddingDown + @"px";
            }
            else
            {
                txtATop.Text = @"Top = 0px" ;
                txtAleft.Text = @"Left = 0px";
                txtARight.Text = @"Right = 0px";
                txtADown.Text = @"Down = 0px";

            }
        }

        public void ShowPaddingInToolScriptTextboxB()
        {
            if (_defaultSample.CheckSampleNumber(Account.WorkerId, 2))
            {
                txtBTop.Text = @"Top = " + _defaultSample.ShowPadding(Account.WorkerId, 2).PaddingTop+@"px";
                txtBLeft.Text = @"Left = " + _defaultSample.ShowPadding(Account.WorkerId, 2).PadddingLeft + @"px";
                txtBRight.Text = @"Right = " + _defaultSample.ShowPadding(Account.WorkerId, 2).PaddingRight + @"px";
                txtBDown.Text = @"Down = " + _defaultSample.ShowPadding(Account.WorkerId, 2).PaddingDown + @"px"; 
            }
            else
            {
                txtBTop.Text = @"Top = 0px";
                txtBLeft.Text = @"Left = 0px";
                txtBRight.Text = @"Right = 0px";
                txtBDown.Text = @"Down = 0px";

            }
        }

        public void ShowPaddingInToolScriptTextboxC()
        {
            if (_defaultSample.CheckSampleNumber(Account.WorkerId, 3))
            {
                txtCTop.Text = @"Top = " + _defaultSample.ShowPadding(Account.WorkerId, 3).PaddingTop + @"px";
                txtCLeft.Text = @"Left = " + _defaultSample.ShowPadding(Account.WorkerId, 3).PadddingLeft + @"px";
                txtCRight.Text = @"Right = " + _defaultSample.ShowPadding(Account.WorkerId, 3).PaddingRight + @"px";
                txtCDown.Text = @"Down = " + _defaultSample.ShowPadding(Account.WorkerId, 3).PaddingDown + @"px";
            }
            else
            {
                txtCTop.Text = @"Top = 0px";
                txtCLeft.Text = @"Left = 0px";
                txtCRight.Text = @"Right = 0px";
                txtCDown.Text = @"Down = 0px";

            }
        }

        public void ShowPaddingInToolScriptTextboxD()
        {
            if (_defaultSample.CheckSampleNumber(Account.WorkerId, 4))
            {
                txtDTop.Text = @"Top = " + _defaultSample.ShowPadding(Account.WorkerId, 4).PaddingTop + @"px";
                txtDLeft.Text = @"Left = " + _defaultSample.ShowPadding(Account.WorkerId, 4).PadddingLeft + @"px";
                txtDRight.Text = @"Right = " + _defaultSample.ShowPadding(Account.WorkerId, 4).PaddingRight + @"px";
                txtDDown.Text = @"Down = " + _defaultSample.ShowPadding(Account.WorkerId, 4).PaddingDown + @"px";
            }
            else
            {
                txtDTop.Text = @"Top = 0px";
                txtDLeft.Text = @"Left = 0px";
                txtDRight.Text = @"Right = 0px";
                txtDDown.Text = @"Down = 0px";

            }
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            ShowPaddingInToolScriptTextboxA();
        }

        private void toolStripMenuItem2_MouseEnter(object sender, EventArgs e)
        {
            ShowPaddingInToolScriptTextboxB();
        }

        private void toolStripMenuItem3_MouseEnter(object sender, EventArgs e)
        {
            ShowPaddingInToolScriptTextboxC();
        }

        private void toolStripMenuItem4_MouseEnter(object sender, EventArgs e)
        {
            ShowPaddingInToolScriptTextboxD();
        }

        private void txtATop_Click(object sender, EventArgs e)
        {
            txtATop.Text = "";
        }

        private void txtAleft_Click(object sender, EventArgs e)
        {
            txtAleft.Text = "";
        }

        private void txtARight_Click(object sender, EventArgs e)
        {
            txtARight.Text = "";
        }

        private void txtADown_Click(object sender, EventArgs e)
        {
            txtADown.Text = "";
        }

        private void txtBTop_MouseEnter(object sender, EventArgs e)
        {
            txtBTop.Text = "";
        }

        private void txtBLeft_MouseEnter(object sender, EventArgs e)
        {
            txtBLeft.Text = "";
        }

        private void txtBRight_MouseEnter(object sender, EventArgs e)
        {
            txtBRight.Text = "";
        }

        private void txtBDown_MouseEnter(object sender, EventArgs e)
        {
            txtBDown.Text = "";
        }

        private void txtCTop_MouseEnter(object sender, EventArgs e)
        {
            txtCTop.Text = "";
        }

        private void txtCLeft_MouseEnter(object sender, EventArgs e)
        {
            txtCLeft.Text = "";
        }

        private void txtCRight_MouseEnter(object sender, EventArgs e)
        {
            txtCRight.Text = "";
        }

        private void txtCDown_MouseEnter(object sender, EventArgs e)
        {
            txtCDown.Text = "";
        }

        private void txtDTop_MouseEnter(object sender, EventArgs e)
        {
            txtDTop.Text = "";
        }

        private void txtDLeft_MouseEnter(object sender, EventArgs e)
        {
            txtDLeft.Text = "";
        }

        private void txtDRight_MouseEnter(object sender, EventArgs e)
        {
            txtDRight.Text = "";
        }

        private void txtDDown_MouseEnter(object sender, EventArgs e)
        {
            txtDDown.Text = "";
        }



    }
}
