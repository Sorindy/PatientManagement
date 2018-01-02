using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        internal Hospital_Entity_Framework.Worker Worker;
        private readonly  WaitingList _waitingList = new WaitingList() ;
        private NurseRespone _nurseRespone;
        internal MedicalsForm Medicalsform;
        private bool? _num ;

        public Hospital_Entity_Framework.WaitingList WaitingList;
       
       
        public int GetStaffCategoryid;
        public string Service;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            
            timer.Interval = (5* 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
            //var btnReset = new DataGridViewButtonColumn
            //{
            //    FlatStyle = FlatStyle.Flat,
            //    Text = @"Reset",
            //    HeaderText = @"Reset"
            //};
            //btnReset.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            //btnReset.UseColumnTextForButtonValue = true;
            //dgvWaitingCategory.Columns.AddRange(btnReset);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvWaitingCategory.DataSource = _waitingList.ShowWaiting(Service,GetStaffCategoryid);
            dgvAllWatingList.DataSource = _waitingList.SeleteAllWaiting();
        }

        private void dgvWaitingCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    if (dgvWaitingCategory.CurrentRow != null)
            //    {
            //        _waitingList.UpdatePatientStatus(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[1].Value),_num);
            //    }
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvWaitingCategory.CurrentRow != null)
            {
                if (dgvWaitingCategory.CurrentRow.Cells[4].Value == null )
                {
                    Medicalsform.WaitingList = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value));
                    Medicalsform.Patient = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value)).Patient;
                    Medicalsform.txtNamePatient.Text = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value)).Patient.LastName;
                    Medicalsform.txtGenderPatient.Text = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value)).Patient.Gender;
                    Close();
                    _nurseRespone = new NurseRespone();
                    _nurseRespone.Insert(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value.ToString()), Worker.Id);
                    _waitingList.UpdatePatientStatus(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value), false);    
                }
                else if (dgvWaitingCategory.CurrentRow.Cells[4].Value.Equals(false))
                {
                    MessageBox.Show(@"This Patient is already Proccess by another Doctor...!!!");
                }
                //var loadingform = new LoadingForm
                //{
                //    WaitingList = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[1].Value)),
                //    MedicalsForm = Medicalsform,
                //    Waitinglistform = this
                //};
                //loadingform.ShowDialog();
            }
        }

    }
}
