using System;
using System.Windows.Forms;
using ReportClass = PatientManagement.Class.ReportClass;

namespace PatientManagement
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private readonly ReportClass _report=new ReportClass();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvListWorker.DataSource = _report.ShowAll(dtpFrom.Value.Date, dtpTo.Value.Date);
        }

        private void Report_Shown(object sender, EventArgs e)
        {
            cboService.Enabled = false;
            chkService.Checked = false;
            cboCategory.Enabled = false;
            chkCategory.Checked = false;
            cboDoctor.Enabled = false;
            chkDoctor.Checked = false;
            cboNurse.Enabled = false;
            chkNurse.Checked = false;
            cboRefferrer.Enabled = false;
            chkRefferrer.Checked = false;
        }
    }
}
