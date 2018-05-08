using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class TitleInput : Form
    {
        public TitleInput()
        {
            InitializeComponent();
        }

        internal MedicalsForm MedicalForm;
        internal HistorysForm HistoryForm;
        private bool _mouseDown;
        private Point _lastLocation;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                if(MedicalForm!=null) MedicalForm.Title = txtTitle.Text;
                if (HistoryForm != null) HistoryForm.Title = txtTitle.Text;
                Close();
            }
            else
            {
                MessageBox.Show(@"Please input Title.", @"Empty Title");
                txtTitle.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MedicalForm != null) MedicalForm.Title = "";
            if (HistoryForm != null) HistoryForm.Title = "";
            Close();
        }

        private void TitleInput_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void TitleInput_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void TitleInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

    }
}
