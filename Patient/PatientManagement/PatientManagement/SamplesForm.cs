﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Account = Hospital_Entity_Framework.Account;
using Image = TXTextControl.Image;

namespace PatientManagement
{
    public partial class SamplesForm : Form
    {
        private string _path;
        private ICategory _category;
        private ISample _sample;
        internal int GetCategoryId=0;
        private bool _edit;
        private bool _haveCategory;
        internal Account Account;
        private bool _haveTitle;

        public SamplesForm()
        {
            InitializeComponent();
        }

        //private void picboxNew_Click(object sender, EventArgs e)
        //{
        //    cboTitle.DataSource = null;
        //    cboTitle.DropDownStyle=ComboBoxStyle.DropDown;
        //    txtDescription.Text = "";
        //    if (btnSave.Name == "btnUpdate")
        //    {
        //        btnSave.Text = @"រក្សាទុក";
        //        btnSave.Name = @"btnSave";
        //        btnSave.Click -= btnUpdate_Click;
        //        btnSave.Click += btnSave_Click;
        //    }
        //}

        private void picboxHide_Click(object sender, EventArgs e)
        {
            if (picboxHide.Name == "picboxHide")
            {
                picboxHide.Name = "picboxShow";
                picboxHide.Image = Properties.Resources.Hide_left_icon;
                //picboxHide.ImageLocation =_path+@"Hide-Left-icon.png";
                pnlButton.Visible = false;
                picboxHide.Click += picboxShow_Click;
            }
        }
        //E:\Work\PatientManagement\Patient\PatientManagement\PatientManagement\bin\Debug\
        private void picboxShow_Click(object sender, EventArgs e)
        {
            picboxHide.Name = "picboxHide";
            picboxHide.Image = Properties.Resources.Hide_right_icon;
            //picboxHide.ImageLocation = _path+@"Hide-right-icon.png";
            pnlButton.Visible = true;
            picboxHide.Click -= picboxShow_Click;
        }

        private void SamplesForm_Shown(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            ////_path = path;
            //_path = @"S:\";
            picboxHide.Image = Properties.Resources.Hide_right_icon;
            //picboxHide.ImageLocation = _path+@"Hide-right-icon.png";
            cboService.SelectedItem = null;
            cboService.Enabled = false;
            cboCategory.SelectedItem = null;
            cboCategory.Enabled = false;
            cboTitle.DataSource=null;
            cboTitle.Enabled = false;
            cboTitle.Text = "";
            cboTitle.DropDownStyle=ComboBoxStyle.DropDownList;
            txtDescription.Text = "";
            btnSave.Text = @"រក្សាទុក";
            btnSave.Name = @"btnSave";
            txtDescription.EditMode=EditMode.ReadAndSelect;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
            btnNew.Enabled = true;
            txtDescription.ForeColor = Color.Black;
        }

        private void btnUpdate_Click()
        {
            if (cboTitle.Text.Trim() == "")
            {
                MessageBox.Show(@"Please fill Title.", @"Empty Title");
                return;
            }
            //if (btnSave.Name == "btnUpdate")
            //{
            //    btnSave.Text = @"Save";
            //    btnSave.Name = @"btnSave";
            //    btnSave.Click -= btnUpdate_Click;
            //    btnSave.Click += btnSave_Click;
            //}
            if (_haveTitle == false)
            {
                MessageBox.Show(@"Please select available title.", @"Empty Title");
                return;
            }
            if (cboCategory.SelectedItem == null) return;
            var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
            var keyCategory = selectedItem.Key;
            if(cboTitle.SelectedItem==null)return;
            var selectedTitle = (KeyValuePair<int, string>) cboTitle.SelectedItem;
            var keyTitle = selectedTitle.Key;
            string path;
            if (!Directory.Exists(@"S:\"))
            {
                path = @"D:\ABC soft\";
            }
            else
            {
                path = _path;
            }
            if (cboService.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\ConsultationSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(path + @"RTF\ConsultationSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _sample = new LaboratorySample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\LaboratorySample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(path + @"RTF\LaboratorySample\" + cboTitle.Text, StreamType.RichTextFormat);

            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\MedicalImagingSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(path + @"RTF\MedicalImagingSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _sample = new PrescriptionSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\PrescriptionSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(path + @"RTF\PrescriptionSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                _sample.Update(keyTitle,cboTitle.Text, _path + @"RTF\VariousdocumentSample\" + cboTitle.Text, keyCategory);
                txtDescription.Save(path + @"RTF\VariousdocumentSample\" + cboTitle.Text, StreamType.RichTextFormat);
            }
            SamplesForm_Shown(this,new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCategory.Text.Trim() == "")
            {
                MessageBox.Show(@"Please select available category.", @"Empty Category");
                return;
            }

            if (_edit)
            {
                btnUpdate_Click();
            }
            else
            {
                if (cboTitle.Text == "") { MessageBox.Show(@"Please fill Title.", @"Empty Title"); }
                else
                {

                    string path;
                    if (!Directory.Exists(@"S:\"))
                    {
                        path = @"D:\ABC soft\";
                    }
                    else
                    {
                        path = _path;
                    }
                    var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
                    var key = selectedItem.Key;
                    if (cboService.SelectedIndex.Equals(0))
                    {
                        _sample = new ConsultationSample();
                        _sample.Insert(cboTitle.Text, _path + @"RTF\ConsultationSample\" + cboTitle.Text, key);
                        txtDescription.Save(path + @"RTF\ConsultationSample\" + cboTitle.Text, StreamType.RichTextFormat);
                    }
                    if (cboService.SelectedIndex.Equals(1))
                    {
                        _sample = new LaboratorySample();
                        _sample.Insert(cboTitle.Text, _path + @"RTF\LaboratorySample\" + cboTitle.Text, key);
                        txtDescription.Save(path + @"RTF\LaboratorySample\" + cboTitle.Text, StreamType.RichTextFormat);

                    }
                    if (cboService.SelectedIndex.Equals(2))
                    {
                        _sample = new MedicalImagingSample();
                        _sample.Insert(cboTitle.Text, _path + @"RTF\MedicalImagingSample\" + cboTitle.Text, key);
                        txtDescription.Save(path + @"RTF\MedicalImagingSample\" + cboTitle.Text, StreamType.RichTextFormat);
                    }
                    if (cboService.SelectedIndex.Equals(3))
                    {
                        _sample = new PrescriptionSample();
                        _sample.Insert(cboTitle.Text, _path + @"RTF\PrescriptionSample\" + cboTitle.Text, key);
                        txtDescription.Save(path + @"RTF\PrescriptionSample\" + cboTitle.Text, StreamType.RichTextFormat);
                    }
                    if (cboService.SelectedIndex.Equals(4))
                    {
                        _sample = new VariousDocumentSample();
                        _sample.Insert(cboTitle.Text, _path + @"RTF\VariousdocumentSample\" + cboTitle.Text, key);
                        txtDescription.Save(path + @"RTF\VariousdocumentSample\" + cboTitle.Text, StreamType.RichTextFormat);
                    }
                    SamplesForm_Shown(this, new EventArgs());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboTitle.Text == null)
            {
                MessageBox.Show(@"Please select available title.", @"Empty title");
                return;
            }

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

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.SelectedIndex.Equals(0))
            {
                _category = new ConsultationCategory();
                var check = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                    cboCategory_SelectedIndexChanged(this,new EventArgs());
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
            }
            if (cboService.SelectedIndex.Equals(1))
            {
                _category = new LaboratoryCategory();
                var check = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
            }
            if (cboService.SelectedIndex.Equals(2))
            {
                _category = new MedicalImagingCategory();
                var check = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
            }
            if (cboService.SelectedIndex.Equals(3))
            {
                _category = new PrescriptionCategory();
                var check = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
            }
            if (cboService.SelectedIndex.Equals(4))
            {
                _category = new VariousDocumentCategory();
                var check = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (check.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(check, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                    cboCategory_SelectedIndexChanged(this, new EventArgs());
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                }
            }
            //if (cboTitle.DataSource != null)
            //{
            //    if (btnSave.Name == "btnSave")
            //    {
            //        btnSave.Text = @"កែប្រែ";
            //        btnSave.Name = @"btnUpdate";
            //        btnSave.Click += btnUpdate_Click;
            //        btnSave.Click -= btnSave_Click;
            //    }
            //}
            if (cboCategory.DataSource != null) cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCategory.DataSource==null)return;
            if(cboCategory.SelectedItem==null)return;
            if(_haveCategory==false)return;
            var selectedItem =(KeyValuePair<int,string>)cboCategory.SelectedItem;
            var key = selectedItem.Key;
            if (_edit&&_haveCategory)
            {
                cboTitle.DataSource = null;
                txtDescription.Text = "";
                if (cboService.SelectedIndex.Equals(0))
                {
                    _sample = new ConsultationSample();
                    var dic = _sample.ShowDictionary(key);
                    if (dic.Count == 0)
                    {
                        _haveTitle = false;
                        return;
                    }
                    _haveTitle = true;
                    cboTitle.DataSource = new BindingSource(dic, null);
                    cboTitle.DisplayMember = "Value";
                    cboTitle.ValueMember = "Key";
                }
                if (cboService.SelectedIndex.Equals(1))
                {
                    _sample = new LaboratorySample();
                    var dic = _sample.ShowDictionary(key);
                    if (dic.Count == 0)
                    {
                        _haveTitle = false;
                        return;
                    }
                    _haveTitle = true; cboTitle.DataSource = new BindingSource(dic, null); 
                    cboTitle.DisplayMember = "Value";
                    cboTitle.ValueMember = "Key";
                }
                if (cboService.SelectedIndex.Equals(2))
                {
                    _sample = new MedicalImagingSample();
                    var dic = _sample.ShowDictionary(key);
                    if (dic.Count == 0)
                    {
                        _haveTitle = false;
                        return;
                    }
                    _haveTitle = true; cboTitle.DataSource = new BindingSource(dic, null); 
                    cboTitle.DisplayMember = "Value";
                    cboTitle.ValueMember = "Key";
                }
                if (cboService.SelectedIndex.Equals(3))
                {
                    _sample = new PrescriptionSample();
                    var dic = _sample.ShowDictionary(key);
                    if (dic.Count == 0)
                    {
                        _haveTitle = false;
                        return;
                    }
                    _haveTitle = true; cboTitle.DataSource = new BindingSource(dic, null);
                    cboTitle.DisplayMember = "Value";
                    cboTitle.ValueMember = "Key";
                }
                if (cboService.SelectedIndex.Equals(4))
                {
                    _sample = new VariousDocumentSample();
                    var dic = _sample.ShowDictionary(key);
                    if (dic.Count == 0)
                    {
                        _haveTitle = false;
                        return;
                    }
                    _haveTitle = true; cboTitle.DataSource = new BindingSource(dic, null);
                    cboTitle.DisplayMember = "Value";
                    cboTitle.ValueMember = "Key";
                }
                if (cboTitle.DataSource != null) cboTitle.SelectedIndex = 0;
            }
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_haveTitle==false)return;
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
            var imagesobject1 = new Image {SaveMode = ImageSaveMode.SaveAsData};
            txtDescription.Images.Add(imagesobject1, -1);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboService.Enabled = true;
            cboCategory.Enabled = true;
            cboTitle.Enabled = true;
            txtDescription.EditMode=EditMode.Edit;
            _edit = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            cboTitle.DropDownStyle = ComboBoxStyle.DropDown;
            cboService.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboService.Enabled = true;
            cboCategory.Enabled = true;
            cboTitle.Enabled = true;
            txtDescription.EditMode = EditMode.Edit;
            _edit = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            cboService.SelectedIndex = 0;
            cboTitle.DropDownStyle=ComboBoxStyle.DropDown;
        }

        private void cboTitle_TextUpdate(object sender, EventArgs e)
        {
            if (_edit == false) return;
            var text = cboTitle.Text;
            cboTitle.DataSource = null;
            cboTitle.Items.Clear();
            if(cboCategory.SelectedItem==null||_haveCategory==false)return;
            var selectedItem = (KeyValuePair<int, string>)cboCategory.SelectedItem;
            var key = selectedItem.Key;
            if (cboService.SelectedIndex == 0)
            {
                _sample = new ConsultationSample();
                TitleTextUpdate(key,text);
            }
            if (cboService.SelectedIndex == 1)
            {
                _sample=new LaboratorySample();
                TitleTextUpdate(key, text);
            }
            if (cboService.SelectedIndex == 2)
            {
                _sample = new MedicalImagingSample();
                TitleTextUpdate(key, text);
            }
            if (cboService.SelectedIndex == 3)
            {
                _sample = new PrescriptionSample();
                TitleTextUpdate(key, text);
            }
            if (cboService.SelectedIndex == 4)
            {
                _sample = new VariousDocumentSample();
                TitleTextUpdate(key, text);
            }
            try
            {
                cboTitle.DroppedDown = false;
            }
            catch
            {
                //
            }
            if (cboTitle.DataSource == null) return;
            if (cboTitle.Focused) cboTitle.DroppedDown = true;
            cboTitle.SelectedIndex = -1;
            cboTitle.Text = text;
            cboTitle.Select(text.Length, 0);
            Cursor.Current = Cursors.Default;
        }

        private void TitleTextUpdate(int key,string text)
        {
            var dic = _sample.SearchTitle(key,text.ToLower());
            if (dic.Count == 0)
            {
                cboTitle.Text = text;
                cboTitle.Select(text.Length, 0);
                _haveTitle = false;
                return;
            }
            cboTitle.DataSource = new BindingSource(dic, null);
            cboTitle.DisplayMember = "Value";
            cboTitle.ValueMember = "Key";
            _haveTitle = true;
        }

        private void cboCategory_TextUpdate(object sender, EventArgs e)
        {
            var text = cboCategory.Text;
            //if (_edit == false) return;
            if (cboService.SelectedIndex == 0)
            {
                _category = new ConsultationCategory();
                var dic = _category.SearchCategory(Account.WorkerId, text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
            }
            if (cboService.SelectedIndex == 1)
            {
                _category = new LaboratoryCategory();
                var dic = _category.SearchCategory(Account.WorkerId, text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
            }
            if (cboService.SelectedIndex == 2)
            {
                _category = new MedicalImagingCategory();
                var dic = _category.SearchCategory(Account.WorkerId, text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
            }
            if (cboService.SelectedIndex == 3)
            {
                _category = new PrescriptionCategory();
                var dic = _category.SearchCategory(Account.WorkerId, text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
            }
            if (cboService.SelectedIndex == 4)
            {
                _category = new VariousDocumentCategory();
                var dic = _category.SearchCategory(Account.WorkerId, text.ToLower());
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                    _haveCategory = true;
                }
                else
                {
                    _haveCategory = false;
                    cboCategory.DataSource = null;
                    cboCategory.Items.Clear();
                    cboCategory.Text = text;
                    cboCategory.Select(text.Length, 0);
                }
            }
            try
            {
                cboCategory.DroppedDown = false;
            }
            catch
            {
               //
            }
            if(_haveCategory==false)return;
            if (cboCategory.Focused) cboCategory.DroppedDown = true;
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = text;
            cboCategory.Select(text.Length, 0);
            Cursor.Current = Cursors.Default;
        }
    }
}
