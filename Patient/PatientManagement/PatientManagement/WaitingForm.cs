using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;
using WaitingList = PatientManagement.Class.WaitingList;

namespace PatientManagement
{
    public partial class WaitingForm : Form
    {
        public WaitingForm()
        {
            InitializeComponent();
        }

        internal Account Account;
        internal CatelogForm CatelogForm;
        private readonly WaitingList _waitingList=new WaitingList();
        private ICategory _category;
        private int _keyCategory;
        private string _keyService;
        private Hospital_Entity_Framework.WaitingList _waiting=new Hospital_Entity_Framework.WaitingList();

        private void WaitingForm_Shown(object sender, EventArgs e)
        {
            dgvAllWatingList.DataSource = null;
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _keyService = @"Consultation";
                _category=new ConsultationCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource=new BindingSource(dic,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Laboratory")
            {
                _keyService = @"Laboratory";
                _category = new LaboratoryCategory();
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
                _keyService = @"MedicalImaging";
                _category = new MedicalImagingCategory();
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
                _keyService = @"Prescription";
                _category = new PrescriptionCategory();
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
                _keyService = @"VariousDocument";
                _category = new VariousDocumentCategory();
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
            dgvAllWatingList.DataSource = null;
            dgvAllWatingList.Columns.Clear();
            var btnView = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"បង្ហាញប្រវត្តិ",
                HeaderText = @"History"
            };
            btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            btnView.UseColumnTextForButtonValue = true;
            var btnNew = new DataGridViewButtonColumn
            {
                FlatStyle = FlatStyle.Flat,
                Text = @"ពិនិត្យថ្មី",
                HeaderText = @"New"
            };
            btnNew.CellTemplate.Style.BackColor = Color.LimeGreen;
            btnNew.UseColumnTextForButtonValue = true;
            var getKey = (KeyValuePair<int,string>) cboCategory.SelectedItem;
            _keyCategory = getKey.Key;
            if (cboService.Text == @"Consultation")
            {
                dgvAllWatingList.DataSource = _waitingList.ShowWaiting(_keyService, _keyCategory);
            }
            if (cboService.Text == @"Laboratory")
            {
                dgvAllWatingList.DataSource = _waitingList.ShowWaiting(_keyService, _keyCategory);
            }
            if (cboService.Text == @"Medical Imaging")
            {
                dgvAllWatingList.DataSource = _waitingList.ShowWaiting(_keyService, _keyCategory);
            }
            if (cboService.Text == @"Prescription")
            {
                dgvAllWatingList.DataSource = _waitingList.ShowWaiting(_keyService, _keyCategory);
            }
            if (cboService.Text == @"Various Document")
            {
                dgvAllWatingList.DataSource = _waitingList.ShowWaiting(_keyService, _keyCategory);
            }
            if (dgvAllWatingList.DataSource != null)
            {
                CheckOrderDgv();
                dgvAllWatingList.Columns.AddRange(btnNew,btnView);
                dgvAllWatingList.Columns[0].Visible = false;
                dgvAllWatingList.Columns[1].Visible = false;
            }
        }
        private void CheckOrderDgv()
        {
            for (var i = 0; i <= dgvAllWatingList.RowCount - 1; i++)
            {
                dgvAllWatingList.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }

        private void dgvAllWatingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllWatingList.CurrentRow != null)
            {
                var id = Convert.ToInt32(dgvAllWatingList.CurrentRow.Cells[0].Value);
                var getWaitinglist = _waitingList.GetWaitingListObject(id);

                if (e.ColumnIndex == 7)
                {
                    var form = new MedicalsForm
                    {
                        Account = Account,
                        CatelogForm = CatelogForm,
                        KeyCategory = _keyCategory,
                        KeyService = _keyService,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        WaitingList = getWaitinglist,
                        cboService = {Enabled = false},
                        cboCategory = {Enabled = false},
                    };
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
                if (e.ColumnIndex == 8)
                {
                    var form = new HistorysForm
                    {
                        Account = Account,
                        CatelogForm = CatelogForm,
                        Patient = getWaitinglist.Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill
                    };
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
        }
    }
}
