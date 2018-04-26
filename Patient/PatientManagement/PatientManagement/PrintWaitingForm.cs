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
            wvPrint.Navigate(@"D:\PatientManagement\Patient\RTF\waiting.html");
            //crystalReportViewer2.PrintReport();
            //Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wvPrint.Print();
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            wvPrint.ShowPrintDialog();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            wvPrint.ShowPrintPreviewDialog();
        }

        private void wvPrint_Navigated(object sender, System.Windows.Forms.WebBrowserNavigatedEventArgs e)
        {
            var db = new HospitalDbContext();
            var name = db.Patients.Single(v => v.Id == WaitingList.PatientId).FirstName + @"  " + db.Patients.Single(v => v.Id == WaitingList.PatientId).LastName;
            if (wvPrint.Document != null)
            {
                var patientname = wvPrint.Document.GetElementById("PatientName");
                if (patientname != null) patientname.InnerHtml = name;

                var time = wvPrint.Document.GetElementById("Time");
                if (time!= null) time.InnerHtml = WaitingList.Time.Hours+" : "+WaitingList.Time.Minutes ;

                var getvalue = WaitingList.Number;
                var num = getvalue;
                var number = wvPrint.Document.GetElementById("Number");
                if (number != null) number.InnerHtml = num.ToString();
            } 

        }

        
    }
}
