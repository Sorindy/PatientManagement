using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        internal Hospital_Entity_Framework.Worker Worker;
        private readonly WaitingList _waitingList = new WaitingList();
        //  private NurseRespone _nurseRespone;
        internal MedicalsForm Medicalsform;
        internal Hospital_Entity_Framework.Account Account;
        private ICategory _category;
        private int _keyCategory;
        //    private bool? _num ;

        public int GetStaffCategoryid;
        public string Service;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void CheckOrderDgv()
        {
            for (var i = 0; i <= dgvAllWatingList.RowCount - 1; i++)
            {
                dgvAllWatingList.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
            for (var i = 0; i <= dgvWaitingCategory.RowCount - 1; i++)
            {
                dgvWaitingCategory.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {

            timer.Interval = (1 * 10000);
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
            dgvWaitingCategory.DataSource = _waitingList.ShowWaiting(Service, GetStaffCategoryid);
            CheckOrderDgv();
            DgvWatingListCategoryHeaderText();
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
                if (dgvWaitingCategory.CurrentRow.Cells[5].Value == null || dgvWaitingCategory.CurrentRow.Cells[5].Value.Equals(true))
                {
                    var obj = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0]
                        .Value));
                    Medicalsform.WaitingList = new Hospital_Entity_Framework.WaitingList();
                    Medicalsform.WaitingList =obj;
                    Medicalsform.Patient = obj.Patient;
                    Medicalsform.lblPName.Text =obj.Patient.FirstName+@"    "+ obj.Patient.LastName;
                    Medicalsform.lblPGender.Text = obj.Patient.Gender;
                    Medicalsform.lblPAddress.Text = obj.Patient.Address;
                    Medicalsform.lblPPhone.Text = obj.Patient.Phone1;
                    Close();
                    //_nurseRespone = new NurseRespone();
                    //_nurseRespone.Insert(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value.ToString()), Worker.Id);
                    _waitingList.UpdatePatientStatus(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value),false);
                }
                else if (dgvWaitingCategory.CurrentRow.Cells[5].Value.Equals(false))
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

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _category = new ConsultationCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Laboratory")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Medical Imaging")
            {
                _category = new MedicalImagingCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Prescription")
            {
                _category = new PrescriptionCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Various Document")
            {
                _category = new VariousDocumentCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.DataSource == null) return;
            var selectkey = (KeyValuePair<int, string>)cboCategory.SelectedItem;
            _keyCategory = selectkey.Key;
            dgvAllWatingList.DataSource = _waitingList.ShowWaiting(cboService.Text, _keyCategory);
            DgvAllWatingListHeaderText();
        }

        public void DgvAllWatingListHeaderText()
        {
            try
            {
                dgvAllWatingList.Columns[0].Visible = false;
                dgvAllWatingList.Columns[1].Visible = false;
                dgvAllWatingList.Columns[2].HeaderText = @"ត្រកូល";
                dgvAllWatingList.Columns[3].HeaderText = @"ឈ្មោះ";
                dgvAllWatingList.Columns[4].HeaderText = @"ពេលវាលា";
                dgvAllWatingList.Columns[5].HeaderText = @"ទំនេរ";
                dgvAllWatingList.Columns[6].HeaderText = @"លេខរងចាំ";
            }
            catch
            {
            }    
        }

        public void DgvWatingListCategoryHeaderText()
        {
            try
            {
                dgvWaitingCategory.Columns[0].Visible = false;
                dgvWaitingCategory.Columns[1].Visible = false;
                dgvWaitingCategory.Columns[2].HeaderText = @"ត្រកូល";
                dgvWaitingCategory.Columns[3].HeaderText = @"ឈ្មោះ";
                dgvWaitingCategory.Columns[4].HeaderText = @"ពេលវាលា";
                dgvWaitingCategory.Columns[5].HeaderText = @"ទំនេរ";
                dgvWaitingCategory.Columns[6].HeaderText = @"លេខរងចាំ";
            }
            catch
            {
            }
        }

    }
    }
