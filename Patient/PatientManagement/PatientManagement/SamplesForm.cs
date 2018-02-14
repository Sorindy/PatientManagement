using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;

namespace PatientManagement
{
    public partial class SamplesForm : Form
    {
        private string _path;
        private ICategory _category;
        private ISample _sample;
        internal int GetCategoryId=0;

        public SamplesForm()
        {
            InitializeComponent();
        }

        private void picboxNew_Click(object sender, EventArgs e)
        {
            cboTitle.DataSource = null;
            cboTitle.DropDownStyle=ComboBoxStyle.DropDown;
            txtDescription.Text = "";
            if (btnSave.Name == "btnUpdate")
            {
                btnSave.Text = @"រក្សាទុក";
                btnSave.Name = @"btnSave";
                btnSave.Click -= btnUpdate_Click;
                btnSave.Click += btnSave_Click;
            }
        }

        private void picboxHide_Click(object sender, EventArgs e)
        {
            if (picboxHide.Name == "picboxHide")
            {
                picboxHide.Name = "picboxShow";
                picboxHide.ImageLocation =_path+@"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picboxHide.Click += picboxShow_Click;
            }
        }
        //E:\Work\PatientManagement\Patient\PatientManagement\PatientManagement\bin\Debug\
        private void picboxShow_Click(object sender, EventArgs e)
        {
            picboxHide.Name = "picboxHide";
            picboxHide.ImageLocation = _path+@"Hide-right-icon.png";
            pnlButton.Visible = true;
            picboxHide.Click -= picboxShow_Click;
        }

        private void SamplesForm_Shown(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            //_path = path.Remove(path.Length - 46);
            _path = path;
            //_path = @"C:\Users\Health\Desktop\Debug\";
            picboxHide.ImageLocation = _path+@"Hide-right-icon.png";
            cboService.SelectedItem = null;
            cboCategory.SelectedItem = null;
            cboTitle.DataSource=null;
            cboTitle.Text = "";
            cboTitle.DropDownStyle=ComboBoxStyle.DropDownList;
            txtDescription.Text = "";
            btnSave.Text = @"រក្សាទុក";
            btnSave.Name = @"btnSave";
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            if (cboService.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                var check = _category.ShowCategoryName();
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _category = new LaboratoryCategory();
                var check = _category.ShowCategoryName();
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                var check = _category.ShowCategoryName();
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _category = new PrescriptionCategory();
                var check = _category.ShowCategoryName();
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                var check = _category.ShowCategoryName();
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check,null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboTitle.DataSource != null)
            {
                if (btnSave.Name == "btnSave")
                {
                    btnSave.Text = @"កែប្រែ";
                    btnSave.Name = @"btnUpdate";
                    btnSave.Click += btnUpdate_Click;
                    btnSave.Click -= btnSave_Click;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cboTitle.Text==null)return;
            if (btnSave.Name == "btnUpdate")
            {
                btnSave.Text = @"Save";
                btnSave.Name = @"btnSave";
                btnSave.Click -= btnUpdate_Click;
                btnSave.Click += btnSave_Click;
            }

            if (cboCategory.SelectedItem == null) return;
            var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
            var keyCategory = selectedItem.Key;
            var selectedTitle = (KeyValuePair<int, string>) cboTitle.SelectedItem;
            var keyTitle = selectedTitle.Key;
            if (cboService.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\ConsultationSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(_path + @"RTF\ConsultationSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _sample = new LaboratorySample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\LaboratorySample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(_path + @"RTF\LaboratorySample\" + cboTitle.Text, StreamType.RichTextFormat);

            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\MedicalImagingSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(_path + @"RTF\MedicalImagingSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _sample = new PrescriptionSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\PrescriptionSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(_path + @"RTF\PrescriptionSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\VariousdocumentSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(_path + @"RTF\VariousdocumentSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            SamplesForm_Shown(this,new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTitle.Text == "") { MessageBox.Show(@"Something is going wrong please check again", @"Error"); }
            else
            {
                var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
                var key = selectedItem.Key;
                if (cboService.SelectedIndex.Equals(0))
                {
                    _sample = new ConsultationSample();
                    _sample.Insert(cboTitle.Text, _path + @"RTF\ConsultationSample\" + cboTitle.Text, key);
                    txtDescription.Save(_path + @"RTF\ConsultationSample\" + cboTitle.Text, StreamType.RichTextFormat);
                }
                if (cboService.SelectedIndex.Equals(1))
                {
                    _sample = new LaboratorySample();
                    _sample.Insert(cboTitle.Text, _path + @"RTF\LaboratorySample\" + cboTitle.Text, key);
                    txtDescription.Save(_path + @"RTF\LaboratorySample\" + cboTitle.Text, StreamType.RichTextFormat);

                }
                if (cboService.SelectedIndex.Equals(2))
                {
                    _sample = new MedicalImagingSample();
                    _sample.Insert(cboTitle.Text, _path + @"RTF\MedicalImagingSample\" + cboTitle.Text, key);
                    txtDescription.Save(_path + @"RTF\MedicalImagingSample\" + cboTitle.Text, StreamType.RichTextFormat);
                }
                if (cboService.SelectedIndex.Equals(3))
                {
                    _sample = new PrescriptionSample();
                    _sample.Insert(cboTitle.Text, _path + @"RTF\PrescriptionSample\" + cboTitle.Text, key);
                    txtDescription.Save(_path + @"RTF\PrescriptionSample\" + cboTitle.Text, StreamType.RichTextFormat);
                }
                if (cboService.SelectedIndex.Equals(4))
                {
                    _sample = new VariousDocumentSample();
                    _sample.Insert(cboTitle.Text, _path + @"RTF\VariousdocumentSample\" + cboTitle.Text, key);
                    txtDescription.Save(_path + @"RTF\VariousdocumentSample\" + cboTitle.Text, StreamType.RichTextFormat);
                }
                SamplesForm_Shown(this, new EventArgs());
                cboService.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cboTitle.Text==null)return;

            var showDeleteMsg = MessageBox.Show(@"Are you sure want to delete this?", @"Delete",
                MessageBoxButtons.YesNo);

            if (showDeleteMsg == DialogResult.Yes)
            {
                if (cboTitle.Text != "")
                {
                    var selectedTitle = (KeyValuePair<int, string>)cboTitle.SelectedItem;
                    var keyTitle = selectedTitle.Key;
                    if (cboService.SelectedIndex.Equals(0))
                    {
                        _sample = new ConsultationSample();
                        _sample.Delete(keyTitle);
                    }
                    if (cboService.SelectedIndex.Equals(1))
                    {
                        _sample = new LaboratorySample();
                        _sample.Delete(keyTitle);
                    }
                    if (cboService.SelectedIndex.Equals(2))
                    {
                        _sample = new MedicalImagingSample();
                        _sample.Delete(keyTitle);
                    }
                    if (cboService.SelectedIndex.Equals(3))
                    {
                        _sample = new PrescriptionSample();
                        _sample.Delete(keyTitle);
                    }
                    if (cboService.SelectedIndex.Equals(4))
                    {
                        _sample = new VariousDocumentSample();
                        _sample.Delete(keyTitle);
                    }
                    SamplesForm_Shown(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show(@"Something is going wrong please check again", @"Error");
                }
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SamplesForm_Shown(this,new EventArgs());
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCategory.SelectedItem==null)return;
            txtDescription.Text = "";
            var selectedItem =(KeyValuePair<int,string>)cboCategory.SelectedItem;
            var key = selectedItem.Key;
            cboTitle.DataSource = null;
            if (cboService.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                var dic = _sample.ShowDictionary(key);
                if(dic.Count==0)return;
                cboTitle.DataSource=new BindingSource(dic,null);
                cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _sample = new LaboratorySample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _sample = new PrescriptionSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                var dic = _sample.ShowDictionary(key);
                if (dic.Count == 0) return;
                cboTitle.DataSource = new BindingSource(dic, null); cboTitle.DisplayMember = "Value";
                cboTitle.ValueMember = "Key";
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FontDialog();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TextBackColorDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Tables.Add();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Images.Add();
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TabDialog();
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.PageColorDialog();
        }

        private void formatStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FormattingStylesDialog();
        }

        private void selectForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.ForeColorDialog();
        }

        private void frameFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FrameFillColorDialog();
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
    }
}
