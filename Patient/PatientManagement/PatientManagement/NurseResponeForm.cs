using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class NurseResponeForm : Form
    {
       
        private NurseRespone _nurseRespone = new NurseRespone() ;
        private WaitingList _waitingList= new WaitingList() ;

        public NurseResponeForm()
        {
            InitializeComponent();
        }

        private void NurseResponeForm_Load(object sender, EventArgs e)
        {
            timer.Interval = (5 * 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
            AddButtonTodtgDataGridView("Delete",dtgWaitingList);
            AddButtonTodtgDataGridView("Avialable", dtgInformation);
            AddButtonTodtgDataGridView("UnAvialable", dtgInformation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //_nurseRespone = new NurseRespone();
            //_waitingList = new WaitingList();
            dtgInformation.DataSource = _nurseRespone.SelectTempWaiting();
            dtgWaitingList.DataSource = _waitingList.SeleteAllWaiting();
        }

        public void AddButtonTodtgDataGridView(string buttonname,DataGridView dtg)
        {
            var btn = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = buttonname,
                HeaderText = buttonname
            };
            btn.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btn.UseColumnTextForButtonValue = true;
            dtg.Columns.AddRange(btn);
        }

        public void MessageForButtonDataGridview(string message,string title,DataGridView dtGridView)
        {
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dtGridView.CurrentRow != null)
                {

                }
            }
        }

        private void dtgWaitingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dtgWaitingList.CurrentRow != null)
                {
                    var message = "Do You Want to Delete this Waiting...?";
                    var title = "Delete Waiting List";
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (dtgInformation.CurrentRow != null)
                        {

                        }
                    }
                }
            }
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dtgInformation.CurrentRow != null)
                {
                    var message = "Does this Patient is Avialable Now...";
                    var title = "Selete Patient For Doctor";
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (dtgInformation.CurrentRow != null)
                        {
                            //_waitingList = new WaitingList();
                            //_nurseRespone = new NurseRespone();
                            _waitingList.UpdatePatientStatus(Convert.ToInt16(dtgInformation.CurrentRow.Cells[3].Value), true);
                            _nurseRespone.DeleteTempWaitingList(Convert.ToInt16(dtgInformation.CurrentRow.Cells[2].Value));
                        }
                    }
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (dtgInformation.CurrentRow != null)
                {
                    var message = "Does this Patient is Not Avialbale ?";
                    var title = "Selete Patient For Doctor";
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (dtgInformation.CurrentRow != null)
                        {
                            //_waitingList = new WaitingList();
                            //_nurseRespone = new NurseRespone();
                            _waitingList.UpdatePatientStatus(Convert.ToInt16(dtgInformation.CurrentRow.Cells[3].Value), false);
                            _nurseRespone.DeleteTempWaitingList(Convert.ToInt16(dtgInformation.CurrentRow.Cells[2].Value));
                        }
                    }
                }
            }
        }


    }
}
