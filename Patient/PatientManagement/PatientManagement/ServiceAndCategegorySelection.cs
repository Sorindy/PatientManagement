using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;

namespace PatientManagement
{
    public partial class ServiceAndCategegorySelection : Form
    {
        public ServiceAndCategegorySelection()
        {
            InitializeComponent();
        }

        internal HistorysForm HistoryForm;
        internal Hospital_Entity_Framework.Account Account;
        internal string Service;
        internal int Category;
        private string _keyService;
        private int _keyCategory;
        private ICategory _iCategory;
        private bool _have;


        private void ServiceAndCategegorySelection_Load(object sender, EventArgs e)
        {
            if (Service == "Consultation") cboService.SelectedIndex = 0;
            if (Service == "Laboratory") cboService.SelectedIndex = 1;
            if (Service == "MedicalImaging") cboService.SelectedIndex = 2;
            if (Service == "Prescription") cboService.SelectedIndex = 3;
            if (Service == "VariousDocument") cboService.SelectedIndex = 4;
            cboCategory.SelectedValue = Category;
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _iCategory = new ConsultationCategory();
                var dic = _iCategory.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Consultation";
            }
            if (cboService.Text == @"Laboratory")
            {
                _iCategory = new LaboratoryCategory();
                var dic = _iCategory.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Laboratory";
            }
            if (cboService.Text == @"MedicalImaging")
            {
                _iCategory = new MedicalImagingCategory();
                var dic = _iCategory.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"MedicalImaging";
            }
            if (cboService.Text == @"Prescription")
            {
                _iCategory = new PrescriptionCategory();
                var dic = _iCategory.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Prescription";
            }
            if (cboService.Text == @"Various Document" || cboService.Text == @"VariousDocument")
            {
                _iCategory = new VariousDocumentCategory();
                var dic = _iCategory.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"VariousDocument";
            }
            if (cboCategory.DataSource != null) cboCategory.SelectedIndex= 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_have || cboCategory.Text == "") return;
            var get = (KeyValuePair<int, string>) cboCategory.SelectedItem;
            _keyCategory = get.Key;
        }

        private void cboCategory_TextUpdate(object sender, EventArgs e)
        {
            if (cboCategory.Focused) cboCategory.DroppedDown = true;
            var text = cboCategory.Text;
            if (cboService.Text == @"Consultation")
            {
                _iCategory = new ConsultationCategory();
                var dic = _iCategory.SearchCategory(Account.WorkerId,cboCategory.Text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Consultation";
            }
            if (cboService.Text == @"Laboratory")
            {
                _iCategory = new LaboratoryCategory();
                var dic = _iCategory.SearchCategory(Account.WorkerId, cboCategory.Text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Laboratory";
            }
            if (cboService.Text == @"MedicalImaging")
            {
                _iCategory = new MedicalImagingCategory();
                var dic = _iCategory.SearchCategory(Account.WorkerId, cboCategory.Text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"MedicalImaging";
            }
            if (cboService.Text == @"Prescription")
            {
                _iCategory = new PrescriptionCategory();
                var dic = _iCategory.SearchCategory(Account.WorkerId, cboCategory.Text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"Prescription";
            }
            if (cboService.Text == @"Various Document" || cboService.Text == @"VariousDocument")
            {
                _iCategory = new VariousDocumentCategory();
                var dic = _iCategory.SearchCategory(Account.WorkerId, cboCategory.Text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _have = true;
                }
                else
                {
                    _have = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
                _keyService = @"VariousDocument";
            }
            if (cboCategory.DataSource == null) return;
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = text;
            cboCategory.Select(text.Length, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HistoryForm.KeyCategory = 0;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboCategory.DataSource == null||cboCategory.Text=="")
            {
                MessageBox.Show(@"Please select available category.", @"Empty category selection");
                return;
            }
            HistoryForm.KeyService = _keyService;
            HistoryForm.KeyCategory = _keyCategory;
            Close();
        }
    }
}
