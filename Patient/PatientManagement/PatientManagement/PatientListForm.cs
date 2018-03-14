using System;
using System.Drawing;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PatientListForm : Form
    {
        public PatientListForm()
        {
            InitializeComponent();
        }

        private readonly Class.Patient _patient = new Class.Patient();
        internal Account Account;
        internal CatelogForm CatelogForm;
        
        private void CheckOrderDgv()
        {
            for (int i = 0; i <= dgvListPatient.RowCount - 1; i++)
            {
                dgvListPatient.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }
        internal void PatientListForm_Shown(object sender, EventArgs e)
        {
            dgvListPatient.DataSource = _patient.ShowAll();
            dgvListPatient.Columns[0].Visible = false;
            var btnView = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"View",
                HeaderText = @"View"
            };
            btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btnView.UseColumnTextForButtonValue = true;
            var btnCheckIn = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"CheckIn",
                HeaderText = @"CheckIn"
            };
            btnCheckIn.CellTemplate.Style.BackColor = Color.Aqua;
            btnCheckIn.UseColumnTextForButtonValue = true;
            dgvListPatient.Columns.AddRange(btnCheckIn,btnView);
            dgvListPatient.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvListPatient.ColumnHeadersDefaultCellStyle.Font = new Font(@"Arial", 14);
            CheckOrderDgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListPatient.DataSource = null;
            dgvListPatient.Columns.Clear();
            dgvListPatient.DataSource = _patient.Search(txtSearch.Text);

            dgvListPatient.Columns[0].Visible = false;
            var btnView = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"View",
                HeaderText = @"View"
            };
            btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btnView.UseColumnTextForButtonValue = true;
            var btnCheckIn = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"CheckIn",
                HeaderText = @"CheckIn"
            };
            btnCheckIn.CellTemplate.Style.BackColor = Color.Aqua;
            btnCheckIn.UseColumnTextForButtonValue = true;
            dgvListPatient.Columns.AddRange(btnCheckIn, btnView);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void dgvListPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (dgvListPatient.CurrentRow != null)
                {
                    var id = dgvListPatient.CurrentRow.Cells[0].Value;
                    var patient = _patient.Select(Convert.ToInt32(id));
                    var form = new HistorysForm() {Account = Account,Patient = patient,CatelogForm = CatelogForm,TopLevel = false,Dock = DockStyle.Fill};
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                }
            }
            if (e.ColumnIndex == 9)
            {
                if (dgvListPatient.CurrentRow != null)
                {
                    var id = dgvListPatient.CurrentRow.Cells[0].Value;
                    var patient = _patient.Select(Convert.ToInt32(id));
                    var form = new CheckInsForm {Patient = patient,TopLevel = false,Dock = DockStyle.Fill};
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                }
            }
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            var form = new NewPatient {PatientListForm = this,TopLevel = false,Dock = DockStyle.Fill};
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(form);
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new NewPatient { PatientListForm = this, TopLevel = false ,Dock = DockStyle.Fill};
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(form);
            form.Show();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            var form = new NewPatient { PatientListForm = this, TopLevel = false,Dock = DockStyle.Fill};
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(form);
            form.Show();
        }
    }
}
