using System.Linq;
using System;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PrintWaitingForm : Form
    {
        public WaitingList WaitingList;
        public PrintWaitingForm()
        {
            InitializeComponent();
        }

        private void PrintWaitingForm_Load(object sender, EventArgs e)
        {
            var db=new HospitalDbContext();
            var name = db.Patients.Single(v => v.Id == WaitingList.PatientId).Name;
            waiting1.SetParameterValue("pName", name);
            waiting1.SetParameterValue("pTime", WaitingList.Time.ToString());
            var getvalue = WaitingList.Id;
            var num = Convert.ToInt32(getvalue.Substring(4));
            waiting1.SetParameterValue("pNumber", num.ToString());
            crystalReportViewer2.ReportSource = waiting1;
            crystalReportViewer2.PrintReport();
            Close();
        }

        
    }
}
