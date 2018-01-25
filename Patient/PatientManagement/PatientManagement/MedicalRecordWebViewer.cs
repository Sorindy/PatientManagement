using System;
using System.Windows.Forms;
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
            MedicalReports1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
            MedicalReports1.SetParameterValue("pGender", Patient.Gender);
            MedicalReports1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalReports1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
            MedicalReports1.SetParameterValue("pAge", Patient.Age);
            MedicalReports1.ExportToDisk(ExportFormatType.HTML40,@"D:\PatientManagement\Patient\RTF\Sample");

          // wvMedicalRecord.DocumentText = html;
            wvMedicalRecord.Navigate(@"D:\PatientManagement\Patient\RTF\Sample.htm");
            html = html.Substring(229);
            html = html.Remove(html.Length - 16);
            if (wvMedicalRecord.Document.GetElementById("Box2") != null)
            {
                var boxcontrol = wvMedicalRecord.Document.GetElementById("Box2");
                boxcontrol.InnerHtml = html;
            }
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wvMedicalRecord.Print();
        }
    }
}
