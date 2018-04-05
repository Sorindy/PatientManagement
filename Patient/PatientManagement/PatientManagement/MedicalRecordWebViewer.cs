using System;
using System.IO;
using System.Linq;
using CrystalDecisions.Shared;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class MedicalRecordWebViewer : Form
    {
        internal string Html;
        internal Patient Patient;
        internal Account Account;
        private string _path;
        
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
            ShowSample_A_InWebViewer();
            ShowSample_B_InWebViewer();
            ShowSample_C_InWebViewer();
            ShowSample_D_InWebViewer();
            WebviewerVisible(false, false, false, false);
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                if (wvSampleA.Document != null)
                {
                    var boxcontrol = wvSampleA.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                WebviewerVisible(true, false, false, false);
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                if (wvSampleB.Document != null)
                {
                    var boxcontrol = wvSampleB.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                WebviewerVisible(false, true , false, false);
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                if (wvSampleC.Document != null)
                {
                    var boxcontrol = wvSampleC.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                WebviewerVisible(false, false, true , false);
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                if (wvSampleD.Document != null)
                {
                    var boxcontrol = wvSampleD.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                WebviewerVisible(false, false, false, true );
            }

        }

        public void WebviewerVisible(bool sampleA, bool sampleB, bool sampleC, bool sampleD)
        {
            wvSampleA.Visible = sampleA ;
            wvSampleB.Visible = sampleB ;
            wvSampleC.Visible = sampleC ;
            wvSampleD.Visible = sampleD ;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                wvSampleA.ShowPrintPreviewDialog();
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                wvSampleB.ShowPrintPreviewDialog();
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                wvSampleC.ShowPrintPreviewDialog();
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                wvSampleD.ShowPrintPreviewDialog();
            }
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
            MedicalReportSampleA1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleA1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleA1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalReportSampleA1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalReportSampleA1.SetParameterValue("pAge", Patient.Age);
            MedicalReportSampleA1.SetParameterValue("pPatientId", Patient.Id );
            MedicalReportSampleA1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleA");
            wvSampleA.Navigate(DirectoryAndPath() + @"RTF\SampleA.htm");
        }

        public void ShowSample_B_InWebViewer()
        {
            MedicalReportSampleB1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleB1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleB1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalReportSampleB1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalReportSampleB1.SetParameterValue("pAge", Patient.Age);
            MedicalReportSampleB1.SetParameterValue("pPatientId", Patient.Id );
            MedicalReportSampleB1.SetParameterValue("pPhoneNumber", Patient.Phone1 );
            MedicalReportSampleB1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleB");
            wvSampleB.Navigate(DirectoryAndPath() + @"RTF\SampleB.htm");
        }

        public void ShowSample_C_InWebViewer()
        {
            MedicalRecortSampleC1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleC1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleC1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalRecortSampleC1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalRecortSampleC1.SetParameterValue("pAge", Patient.Age);
            MedicalRecortSampleC1.SetParameterValue("pPatientId", Patient.Id);
            MedicalRecortSampleC1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleC");
            wvSampleC.Navigate(DirectoryAndPath() + @"RTF\SampleC.htm");
        }

        public void ShowSample_D_InWebViewer()
        {
            MedicalRecortSampleD1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleD1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleD1.SetParameterValue("pDatetime", DateTime.Now.ToLongDateString());
            MedicalRecortSampleD1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalRecortSampleD1.SetParameterValue("pAge", Patient.Age);
            MedicalRecortSampleD1.SetParameterValue("pPatientId", Patient.Id);
            MedicalRecortSampleD1.SetParameterValue("pPhoneNumber", Patient.Phone1);
            MedicalRecortSampleD1.ExportToDisk(ExportFormatType.HTML40, DirectoryAndPath() + @"RTF\SampleD");
            wvSampleD.Navigate(DirectoryAndPath() + @"RTF\SampleD.htm"); 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                wvSampleA.Print();
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                wvSampleB.Print();
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                wvSampleC.Print();
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                wvSampleD.Print();
            }
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                wvSampleA.ShowPageSetupDialog();
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                wvSampleB.ShowPrintDialog();
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                wvSampleC.ShowPrintDialog();
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                wvSampleD.ShowPrintDialog();
            }
        }

     
    }
}
