using System;
using System.Linq;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
using CrystalDecisions.Shared;
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
            
            MedicalRecords1.SetParameterValue("pPatientName", Patient.FirstName+" "+Patient.LastName +"( " +Patient.KhmerName  +" )");
            MedicalRecords1.SetParameterValue("pGender",Patient.Gender);
            MedicalRecords1.SetParameterValue("pDatetime", DateTime.Now);
            MedicalRecords1.SetParameterValue("pDoctorName", Account.Worker.FirstName +" "+ Account.Worker.LastName);
            MedicalRecords1.SetParameterValue("pAge",Patient.Age);
            MedicalRecords1.SetParameterValue("pPdfPath", @"C:\Users\Hotso\Desktop\CV.pdf");
            crystalReportViewer1.ReportSource = MedicalRecords1 ;
        }
    }
}
