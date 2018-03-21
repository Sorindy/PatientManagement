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
            _path = path;
            //_path = @"S:\";
            btnPrintPreview.Visible = false;
            ShowSample_A_InWebViewer();
            ShowSample_B_InWebViewer();
            ShowSample_C_InWebViewer();
            ShowSample_D_InWebViewer();
            wvSampleA.Visible = false;
            wvSampleB.Visible = false;
            wvSampleC.Visible = false;
            wvSampleD.Visible = false;
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
                wvSampleA.Visible = true;
                wvSampleB.Visible = false;
                wvSampleC.Visible = false;
                wvSampleD.Visible = false;
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                if (wvSampleB.Document != null)
                {
                    var boxcontrol = wvSampleB.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                wvSampleB.Visible = true;
                wvSampleA.Visible = false;
                wvSampleC.Visible = false;
                wvSampleD.Visible = false;
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                if (wvSampleC.Document != null)
                {
                    var boxcontrol = wvSampleC.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                wvSampleC.Visible = true;
                wvSampleB.Visible = false;
                wvSampleA.Visible = false;
                wvSampleD.Visible = false;
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                if (wvSampleD.Document != null)
                {
                    var boxcontrol = wvSampleD.Document.GetElementById("Box2");
                    if (boxcontrol != null) boxcontrol.InnerHtml = Html;
                }
                wvSampleD.Visible = true;
                wvSampleB.Visible = false;
                wvSampleC.Visible = false;
                wvSampleA.Visible = false;
            }
           
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

        public void DeleteImageFolder()
        {
            string path;
            //if (!Directory.Exists(@"S:\"))
            //{
            //    path = @"D:\ABC soft\";
            //}
            //else
            //{
                path = _path;
            //}
            var directory = new DirectoryInfo(path+@"RTF\images");
            directory.Attributes = directory.Attributes & ~FileAttributes.ReadOnly;
            directory.Delete(true);
        }

        public void ShowSample_A_InWebViewer()
        {
            string path;
            //if (!Directory.Exists(@"S:\"))
            //{
            //    path = @"D:\ABC soft\";
            //}
            //else
            //{
            path = _path;
            //}
            btnPrintPreview.Visible = true;
            MedicalReportSampleA1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleA1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleA1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalReportSampleA1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalReportSampleA1.SetParameterValue("pAge", Patient.Age);
            MedicalReportSampleA1.ExportToDisk(ExportFormatType.HTML40, path + @"RTF\SampleA");
            wvSampleA.Navigate(path + @"RTF\SampleA.htm");
        }

        public void ShowSample_B_InWebViewer()
        {
            string path;
            //if (!Directory.Exists(@"S:\"))
            //{
            //    path = @"D:\ABC soft\";
            //}
            //else
            //{
            path = _path;
            //}
            btnPrintPreview.Visible = true;
            MedicalReportSampleB1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalReportSampleB1.SetParameterValue("pGender", Patient.Gender);
            MedicalReportSampleB1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalReportSampleB1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalReportSampleB1.SetParameterValue("pAge", Patient.Age);
            MedicalReportSampleB1.ExportToDisk(ExportFormatType.HTML40, path + @"RTF\SampleB");
            wvSampleB.Navigate(path + @"RTF\SampleB.htm");
        }

        public void ShowSample_C_InWebViewer()
        {
            string path;
            //if (!Directory.Exists(@"S:\"))
            //{
            //    path = @"D:\ABC soft\";
            //}
            //else
            //{
            path = _path;
            //}
            btnPrintPreview.Visible = true;
            MedicalRecortSampleC1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleC1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleC1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalRecortSampleC1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalRecortSampleC1.SetParameterValue("pAge", Patient.Age);
            MedicalRecortSampleC1.ExportToDisk(ExportFormatType.HTML40, path + @"RTF\SampleC");
            wvSampleC.Navigate(path + @"RTF\SampleC.htm");
        }

        public void ShowSample_D_InWebViewer()
        {
            string path;
            //if (!Directory.Exists(@"S:\"))
            //{
            //    path = @"D:\ABC soft\";
            //}
            //else
            //{
            path = _path;
            //}
            btnPrintPreview.Visible = true;
            MedicalRecortSampleD1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalRecortSampleD1.SetParameterValue("pGender", Patient.Gender);
            MedicalRecortSampleD1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalRecortSampleD1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalRecortSampleD1.SetParameterValue("pAge", Patient.Age);
            MedicalRecortSampleD1.ExportToDisk(ExportFormatType.HTML40, path + @"RTF\SampleD");
            wvSampleD.Navigate(path + @"RTF\SampleD.htm"); 
        }
    }
}
