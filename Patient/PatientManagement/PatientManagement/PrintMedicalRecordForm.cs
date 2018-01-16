using System;
using System.Linq;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PrintMedicalRecordForm : Form
    {
        internal Account Account;
        internal Patient Patient;
        internal string Path;

        public PrintMedicalRecordForm()
        {
            InitializeComponent();
        }

        private void PrintMedicalRecordForm_Load(object sender, EventArgs e)
        {
            
            MedicalRecord1.SetParameterValue("pPatientName", Patient.FirstName+" "+Patient.LastName +"( " +Patient.KhmerName  +" )");
            MedicalRecord1.SetParameterValue("pGender",Patient.Gender);
            MedicalRecord1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalRecord1.SetParameterValue("pDoctorName", Account.Worker.FirstName +" "+ Account.Worker.LastName);
            MedicalRecord1.SetParameterValue("pAge",Patient.Age);
            MedicalRecord1.SetParameterValue("pPdfPath", @"D:\PatientManagement\Patient\RTF\ConsultationEstimate\Work.docx");
            crystalReportViewer1.ReportSource = MedicalRecord1 ;
        }
    }
}
