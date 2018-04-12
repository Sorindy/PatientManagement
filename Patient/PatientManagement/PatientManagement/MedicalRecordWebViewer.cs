using System;
using System.IO;
using System.Linq;
using CrystalDecisions.Shared;
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
        private   DefaultSamplePrint  defaultSample= new DefaultSamplePrint() ;
        
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
           // Html = Html.Insert(0, @"<section>");
           // Html = Html.Insert(Html.Length, @"</section>");
            //Html = Html.Insert(0, @"<span class=" + "ad281d4f79-0002-451a-a51d-f2ce0baa9e4d-2" + "style=z-index:10;top:247px;left:161px;width:629px;height:837px;" + ">");
            //Html = Html.Insert(Html.Length, @"</span>");
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"S:\";   
            CheckDefaultPrintSample(defaultSample.SearchId(Account.WorkerId));
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
            MedicalReportSampleA1.SetParameterValue("pPatientName", Patient.FirstName.ToUpper( ) + " " + Patient.LastName.ToUpper( ) + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleA1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleA1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString()  );
            MedicalReportSampleA1.SetParameterValue("pDoctorName", Account.Worker.FirstName.ToUpper( ) + " " + Account.Worker.LastName.ToUpper( ));
            MedicalReportSampleA1.SetParameterValue("pAge", Patient.Age);
            //MedicalReportSampleA1.SetParameterValue("pRefferrer", Refferrer);
            MedicalReportSampleA1.SetParameterValue("pPatientId", Patient.PatientIdentify);
            MedicalReportSampleA1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleA");
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleA.htm");
           // wvPrintSample.DocumentText.Insert(13, @"@page { size: A4; margin: 0;}@media print {html, body { width: 210mm;height: 297mm;}}");

        }

        public void ShowSample_B_InWebViewer()
        {
            MedicalReportSampleB1.SetParameterValue("pPatientName", Patient.FirstName.ToUpper() + " " + Patient.LastName.ToUpper() + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleB1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleB1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalReportSampleB1.SetParameterValue("pDoctorName", Account.Worker.FirstName.ToUpper() + " " + Account.Worker.LastName.ToUpper());
            MedicalReportSampleB1.SetParameterValue("pAge", Patient.Age);
            MedicalReportSampleB1.SetParameterValue("pPatientId", Patient.PatientIdentify  );
            //MedicalReportSampleB1.SetParameterValue("pRefferrer", Refferrer.ToUpper());
            MedicalReportSampleB1.SetParameterValue("pPhoneNumber", Patient.Phone1 );
            MedicalReportSampleB1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleB");
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleB.htm");
        }

        public void ShowSample_C_InWebViewer()
        {
            MedicalRecortSampleC1.SetParameterValue("pPatientName", Patient.FirstName.ToUpper() + " " + Patient.LastName.ToUpper() + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleC1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleC1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalRecortSampleC1.SetParameterValue("pDoctorName", Account.Worker.FirstName.ToUpper() + " " + Account.Worker.LastName.ToUpper());
            MedicalRecortSampleC1.SetParameterValue("pAge", Patient.Age);
            //MedicalRecortSampleC1.SetParameterValue("pRefferrer", Refferrer.ToUpper());
            MedicalRecortSampleC1.SetParameterValue("pPatientId", Patient.PatientIdentify);
            MedicalRecortSampleC1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleC");
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleC.htm");
        }

        public void ShowSample_D_InWebViewer()
        {
            MedicalRecortSampleD1.SetParameterValue("pPatientName", Patient.FirstName.ToUpper() + " " + Patient.LastName.ToUpper() + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleD1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleD1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalRecortSampleD1.SetParameterValue("pDoctorName", Account.Worker.FirstName.ToUpper() + " " + Account.Worker.LastName.ToUpper());
            MedicalRecortSampleD1.SetParameterValue("pAge", Patient.Age);
            MedicalRecortSampleD1.SetParameterValue("pPatientId", Patient.PatientIdentify);
            MedicalRecortSampleD1.SetParameterValue("pPhoneNumber", Patient.Phone1);
            //MedicalRecortSampleD1.SetParameterValue("pRefferrer", Refferrer.ToUpper());
            MedicalRecortSampleD1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleD");
            wvPrintSample.Navigate(DirectoryAndPath() + @"RTF\SampleD.htm");
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

        public void InputContent()
        {
            if (wvPrintSample.Document != null)
            {
                var boxcontrol = wvPrintSample.Document.GetElementById("Box2");
                if (boxcontrol != null) boxcontrol.InnerHtml = Html;
            }
        }

        private void wvPrintSample_Navigated(object sender, System.Windows.Forms.WebBrowserNavigatedEventArgs e)
        {
            InputContent();
            
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

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultSample.SearchWorkerId(Account.WorkerId))
            {
                defaultSample.Update(Account.WorkerId, 1);
            }
            else
            {
                defaultSample.Insert(Account.WorkerId, 1);
            }    
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultSample.SearchWorkerId(Account.WorkerId))
            {
                defaultSample.Update( Account.WorkerId, 2);
            }
            else
            {
                defaultSample.Insert(Account.WorkerId, 2);
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultSample.SearchWorkerId(Account.WorkerId))
            {
                defaultSample.Update( Account.WorkerId, 3);
            }
            else
            {
                defaultSample.Insert(Account.WorkerId, 3);
            }
            
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (defaultSample.SearchWorkerId(Account.WorkerId))
            {
                defaultSample.Update( Account.WorkerId, 4);
            }
            else
            {
                defaultSample.Insert(Account.WorkerId, 4);
            }
        }
     
    
    
    }
}
