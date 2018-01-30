using System;
using CrystalDecisions.Shared;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class MedicalRecordWebViewer : Form
    {

        internal string html;
        internal Patient Patient;
        internal Account Account;
        
        public MedicalRecordWebViewer()
        {
            InitializeComponent();
        }

        private void MedicalRecordWebViewer_Load(object sender, EventArgs e)
        {
            html = html.Substring(229);
            html = html.Remove(html.Length - 16);     
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (wv.Document != null)
            {
                var boxcontrol = wv.Document.GetElementById("Box2");
                boxcontrol.InnerHtml = html;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wv.ShowPrintPreviewDialog();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                MedicalReportSampleA1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalReportSampleA1.SetParameterValue("pGender", Patient.Gender);
                MedicalReportSampleA1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalReportSampleA1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalReportSampleA1.SetParameterValue("pAge", Patient.Age);
                MedicalReportSampleA1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleA");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleA.htm");
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                MedicalReportSampleB1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalReportSampleB1.SetParameterValue("pGender", Patient.Gender);
                MedicalReportSampleB1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalReportSampleB1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalReportSampleB1.SetParameterValue("pAge", Patient.Age);
                MedicalReportSampleB1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleB");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleB.htm");
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                MedicalRecortSampleC1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalRecortSampleC1.SetParameterValue("pGender", Patient.Gender);
                MedicalRecortSampleC1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalRecortSampleC1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalRecortSampleC1.SetParameterValue("pAge", Patient.Age);
                MedicalRecortSampleC1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleC");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleC.htm");
            }
        }

    }
}
