using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WorkerListForm : Form
    {
        public WorkerListForm()
        {
            InitializeComponent();
        }

        internal Worker Worker=new Worker();
        internal CatelogForm CatelogForm;
        
        private void CheckOrderDgv()
        {
            for(var i=0;i<=dgvListWorker.RowCount-1;i++)
            {
                dgvListWorker.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }

        internal void WorkerListForm_Shown(object sender, EventArgs e)
        {
            dgvListWorker.DataSource = Worker.ShowAll();
            dgvListWorker.Columns[0].Visible = false;
            var btnView = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"View",
                HeaderText = @"View"
            };
            btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btnView.UseColumnTextForButtonValue = true;
            var btnDelete = new DataGridViewButtonColumn
            {
                Text = @"Delete",
                FlatStyle = FlatStyle.Flat,
                HeaderText = @"Delete"
            };
            btnDelete.CellTemplate.Style.BackColor=Color.DarkRed;
            btnDelete.UseColumnTextForButtonValue = true;
            dgvListWorker.Columns.AddRange(btnView,btnDelete);
            dgvListWorker.ClearSelection();
            CheckOrderDgv();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newWorker = new NewWorker { WorkerListForm = this, Dock = DockStyle.Fill, TopLevel = false };
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(newWorker);
            newWorker.Show();
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            var newWorker = new NewWorker { WorkerListForm = this ,Dock = DockStyle.Fill,TopLevel = false};
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(newWorker);
            newWorker.Show();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            var newWorker = new NewWorker { WorkerListForm = this, Dock = DockStyle.Fill, TopLevel = false };
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(newWorker);
            newWorker.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListWorker.DataSource = null;
            dgvListWorker.Columns.RemoveAt(1);
            dgvListWorker.Columns.RemoveAt(0);
            dgvListWorker.DataSource = Worker.Search(txtSearch.Text);

            dgvListWorker.Columns[0].Visible = false;
            var btnView = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"View",
                HeaderText = @"View"
            };
            btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btnView.UseColumnTextForButtonValue = true;
            var btnDelete = new DataGridViewButtonColumn
            {
                Text = @"Delete",
                FlatStyle = FlatStyle.Flat,
                HeaderText = @"Delete"
            };
            btnDelete.CellTemplate.Style.BackColor = Color.DarkRed;
            btnDelete.UseColumnTextForButtonValue = true;
            dgvListWorker.Columns.AddRange(btnView, btnDelete);
            //WorkerListForm_Shown(this, new EventArgs());
        }

        private void dgvListWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (dgvListWorker.CurrentRow != null)
                {
                    var id = dgvListWorker.CurrentRow.Cells[0].Value;
                    var worker = Worker.SelectedWorker(Convert.ToInt32(id));
                    var form = new WorkerForm { Worker =worker ,WorkerListForm = this,TopLevel = false,Dock = DockStyle.Fill};
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                }

            }
            if (e.ColumnIndex == 9)
            {
                if (dgvListWorker.CurrentRow != null)
                {
                    var id = dgvListWorker.CurrentRow.Cells[0].Value;
                    var showDeleteMsg = MessageBox.Show(@"Are you sure want to delete this?", @"Delete",
                        MessageBoxButtons.YesNo);

                    if (showDeleteMsg == DialogResult.Yes)
                    {
                        Worker.Delete(Convert.ToInt32(id));
                        dgvListWorker.Columns.RemoveAt(8);
                        dgvListWorker.Columns.RemoveAt(8);
                        WorkerListForm_Shown(this, new EventArgs());
                    }
                    if (showDeleteMsg == DialogResult.No)
                    {
                        dgvListWorker.Columns.RemoveAt(8);
                        dgvListWorker.Columns.RemoveAt(8);
                        WorkerListForm_Shown(this,new EventArgs());
                    }
                }
            }
        }
    }
}
