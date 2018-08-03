using System;
using System.Collections.Generic;
using System.Drawing;
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
        private bool _mouseDown;
        private Point _lastLocation;
        internal string Ref;
        internal string Nur;

        private void ServiceAndCategegorySelection_Load(object sender, EventArgs e)
        {
            if (Service == "Consultation") cboService.SelectedIndex = 0;
            if (Service == "Laboratory") cboService.SelectedIndex = 1;
            if (Service == "MedicalImaging") cboService.SelectedIndex = 2;
            if (Service == "Prescription") cboService.SelectedIndex = 3;
            if (Service == "VariousDocument") cboService.SelectedIndex = 4;
            lbRef.Text = Ref;
            lbNur.Text = Nur;
            if(Category==0)return;
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
                    _have = true;
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
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
                    _have = true;
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
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
                    _have = true;
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
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
                    _have = true;
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
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
                    _have = true;
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
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
            if (!_have || cboCategory.Text == ""||cboCategory.SelectedItem==null) return;
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
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
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
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
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
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
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
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
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
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
                _keyService = @"VariousDocument";
            }
            try
            {
                cboCategory.DroppedDown = false;
                cboCategory.Text = text;
                cboCategory.Select(text.Length, 0);
            }
            catch
            {
                //
            }
            if (cboCategory.DataSource == null)
            {
                return;
            }
            if (cboCategory.Focused) cboCategory.DroppedDown = true;
            Cursor.Current = Cursors.Default;
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
            if (cboCategory.DataSource == null||cboCategory.Text==""||_have)
            {
                MessageBox.Show(@"Please select available category.", @"Empty category selection");
                return;
            }
            HistoryForm.KeyService = _keyService;
            HistoryForm.KeyCategory = _keyCategory;
            Close();
        }

        private void ServiceAndCategegorySelection_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void ServiceAndCategegorySelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void ServiceAndCategegorySelection_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
