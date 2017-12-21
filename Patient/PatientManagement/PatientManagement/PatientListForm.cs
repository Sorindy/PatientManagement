﻿using System;
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
            dgvListPatient.Columns.AddRange(btnView);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListPatient.DataSource = null;
            dgvListPatient.Columns.RemoveAt(0);
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
            dgvListPatient.Columns.AddRange(btnView);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void dgvListPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (dgvListPatient.CurrentRow != null)
                {
                    var id = dgvListPatient.CurrentRow.Cells[0].Value;
                    var patient = _patient.Select(Convert.ToInt32(id));
                    var form = new HistorysForm() {Account = Account,Pateint = patient};
                    form.ShowDialog();
                }
            }
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            var form = new NewPatient {PatientListForm = this};
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new NewPatient { PatientListForm = this };
            form.ShowDialog();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            var form = new NewPatient { PatientListForm = this };
            form.ShowDialog();
        }
    }
}