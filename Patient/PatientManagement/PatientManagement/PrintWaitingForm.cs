using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            waiting1.SetParameterValue("pPatientName",name);
            waiting1.SetParameterValue("pTime", WaitingList.Time.ToString());
            var getvalue = WaitingList.Id;
            var num = Convert.ToInt32(getvalue.Substring(4));
            waiting1.SetParameterValue("pNumber", num.ToString());
            crystalReportViewer1.ReportSource = waiting1;
        }
    }
}
