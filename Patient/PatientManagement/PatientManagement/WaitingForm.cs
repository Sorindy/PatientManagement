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

        private void WaitingForm_Shown(object sender, EventArgs e)
        {
            dgvAllWatingList.DataSource = null;
            dgvAllWatingList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Refreshing()
        {
            timer1.Interval =(1*10000);
            timer1.Tick += cboCategory_SelectedIndexChanged;
            timer1.Start();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
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
            Refreshing();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAllWatingList.DataSource = null;
            dgvAllWatingList.Columns.Clear();
            if(cboCategory.DataSource==null)return;
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
            dgvAllWatingList.ClearSelection();
            DtgHeaderText();
        }
        private void CheckOrderDgv()
        {
            for (var i = 0; i <= dgvAllWatingList.RowCount - 1; i++)
            {
                dgvAllWatingList.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
            dgvAllWatingList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAllWatingList.ColumnHeadersDefaultCellStyle.Font = new Font(@"Arial", 14, FontStyle.Bold);
        }

        private void dgvAllWatingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllWatingList.CurrentRow != null)
            {
                var id = Convert.ToInt32(dgvAllWatingList.CurrentRow.Cells[0].Value);
                var getWaitinglist = _waitingList.GetWaitingListObject(id);

                if (e.ColumnIndex == 7)
                {
                    if (dgvAllWatingList.CurrentRow.Cells[5].Value==null)
                    {
                        var form = new MedicalsForm
                        {
                            Account = Account,
                            CatelogForm = CatelogForm,
                            KeyCategory = _keyCategory,
                            KeyService = _keyService,
                            TopLevel = false,
                            Dock = DockStyle.Fill,
                            WaitingList =getWaitinglist,
                            cboService = { Enabled = false },
                            cboCategory = { Enabled = false },
                        };
                        CatelogForm.pnlFill.Controls.Clear();
                        CatelogForm.pnlFill.Controls.Add(form);
                        form.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Please select another patient.", @"Patient is busy");
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    var form = new HistorysForm
                    {
                        Account = Account,
                        CatelogForm = CatelogForm,
                        Patient = getWaitinglist.Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyService = _keyService,
                        KeyCategory = _keyCategory
                    };
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
        }

        public void DtgHeaderText()
        {
            try
            {
                dgvAllWatingList.Columns[2].HeaderText = @"ត្រកូល";
                dgvAllWatingList.Columns[3].HeaderText = @"ឈ្នោះ";
                dgvAllWatingList.Columns[4].HeaderText = @"ពេលវេលា";
                dgvAllWatingList.Columns[5].HeaderText = @"ទំនេរ";
                dgvAllWatingList.Columns[6].HeaderText = @"លេខរងចាំ";
                dgvAllWatingList.Columns[7].HeaderText = @"ពិគ្រោះ";
                dgvAllWatingList.Columns[8].HeaderText = @"ប្រវត្តិរូប";
            }
            catch
            {
            }

        }

    }
}
