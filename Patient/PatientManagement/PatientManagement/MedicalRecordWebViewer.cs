using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
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
           
            wvMedicalRecord.DocumentText = html;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wvMedicalRecord.ShowPrintPreviewDialog();
        }
    }
}
