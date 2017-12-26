using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class SamplesDialogForm : Form
    {
        public SamplesDialogForm()
        {
            InitializeComponent();
        }

        internal MedicalsForm MedicalsForm;
        internal string ServiceText;
        internal int CategoryId=0;
        private ISample _sample;
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;

        private void SamplesDialogForm_Shown(object sender, EventArgs e)
        {
            cboService.Text = ServiceText;
            cboService_SelectedIndexChanged(this,new EventArgs());
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            if (cboService.Text==@"Consultation")
            {
                _category = new ConsultationCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryName(), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
                if (ServiceText == @"Consultation")
                {
                    cboCategory.SelectedIndex = CategoryId;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
            }
            if (cboService.Text==@"Laboratory")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryName(), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
                if (ServiceText == @"Laboratory")
                {
                    cboCategory.SelectedIndex = CategoryId;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
            }
            if (cboService.Text==@"Medical Imaging")
            {
                _category = new MedicalImagingCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryName(), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
                if (ServiceText == @"Medical Imaging")
                {
                    cboCategory.SelectedIndex = CategoryId;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
            }
            if (cboService.Text==@"Prescription")
            {
                _category = new PrescriptionCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryName(), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
                if (ServiceText == @"Prescription")
                {
                    cboCategory.SelectedIndex = CategoryId;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
            }
            if (cboService.Text==@"Various Document")
            {
                _category = new VariousDocumentCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryName(), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
                if (ServiceText == @"Various Document")
                {
                    cboCategory.SelectedIndex = CategoryId;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem == null) return;
            txtDescription.Text = "";
            var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
            var key = selectedItem.Key;
            cboTitle.DataSource = null;
            if (cboService.Text==@"Consultation")
            {
                _sample = new ConsultationSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null);
                cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.Text==@"Laboratory")
            {
                _sample = new LaboratorySample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.Text==@"Medical Imaging")
            {
                _sample = new MedicalImagingSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.Text==@"Prescription")
            {
                _sample = new PrescriptionSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.Text==@"Various Document")
            {
                _sample = new VariousDocumentSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTitle.SelectedItem == null) return;
            var selectedItem = (KeyValuePair<int, string>)cboTitle.SelectedItem;
            var key = selectedItem.Key;
            if (cboService.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                txtDescription.Text = "";
                txtDescription.Load(_sample.Path(key), StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _sample = new LaboratorySample();
                txtDescription.Text = "";
                txtDescription.Load(_sample.Path(key), StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                txtDescription.Text = "";
                txtDescription.Load(_sample.Path(key), StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _sample = new PrescriptionSample();
                txtDescription.Text = "";
                txtDescription.Load(_sample.Path(key), StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                txtDescription.Text = "";
                txtDescription.Load(_sample.Path(key), StreamType.RichTextFormat);
            }
        }

        private void cboTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblShow_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tblShow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tblShow_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void tblButton_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tblButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tblButton_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void tblPicking_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tblPicking_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tblPicking_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
