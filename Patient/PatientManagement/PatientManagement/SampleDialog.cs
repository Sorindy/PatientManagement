using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;

namespace PatientManagement
{
    public partial class SampleDialog : Form
    {
        public SampleDialog()
        {
            InitializeComponent();
        }

        private ISample _sample;
        private string _keyService="";
        private int _keyCategory;
        private int _keyTitle;
        private bool _have;
        private bool _selected;
        private bool _mouseClick;

        private void SampleDialog_Load(object sender, EventArgs e)
        {
            AddNodesToTree();
            cboTitle.Enabled = false;
            picHideRight.Image = Properties.Resources.Hide_right_icon;
            _mouseClick = false;
        }
        private void AddNodesToTree()
        {
            {
                _sample = new ConsultationSample();
                var dic = _sample.AddNodeToService();
                if (dic != null)
                {
                    treeViewSelection.Nodes.Add(dic);
                }
            }
            {
                _sample = new LaboratorySample();
                var dic = _sample.AddNodeToService();
                if (dic != null)
                {
                    treeViewSelection.Nodes.Add(dic);
                }
            }
            {
                _sample = new MedicalImagingSample();
                var dic = _sample.AddNodeToService();
                if (dic != null)
                {
                    treeViewSelection.Nodes.Add(dic);
                }
            }
            {
                _sample = new PrescriptionSample();
                var dic = _sample.AddNodeToService();
                if (dic != null)
                {
                    treeViewSelection.Nodes.Add(dic);
                }
            }
            {
                _sample = new VariousDocumentSample();
                var dic = _sample.AddNodeToService();
                if (dic != null)
                {
                    treeViewSelection.Nodes.Add(dic);
                }
            }
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTitle.Focused == false || _selected == false)
            {
                _selected = true;
                return;
            }
            if (cboTitle.DataSource == null || cboTitle.SelectedItem == null || _have == false) return;
            var get = (KeyValuePair<Dictionary<Dictionary<string, int>, int>, string>)cboTitle.SelectedItem;
            var key = get.Key;
            var keys = key.Keys.First();
            _keyService = keys.Keys.First();
            _keyCategory = keys.Values.First();
            _keyTitle = key.Values.First();
            treeViewSelection.SelectedNode = treeViewSelection.Nodes[_keyService].Nodes[Name = _keyCategory.ToString()]
                .Nodes[Name = _keyTitle.ToString()];
            treeViewSelection.Select();
        }

        private void cboTitle_TextUpdate(object sender, EventArgs e)
        {
            _selected = false;
            if(cboTitle.Focused==false)return;
            var text = cboTitle.Text;
            var dic = new Dictionary<Dictionary<Dictionary<string, int>, int>, string>();
            _sample=new ConsultationSample();
            var getCon = _sample.SearchTitle(text);
            if (getCon.Count != 0)
            {
                foreach (var item in getCon)
                {
                    dic.Add(item.Key,item.Value);
                }
            }
            _sample = new LaboratorySample();
            var getLab = _sample.SearchTitle(text);
            if (getLab.Count != 0)
            {
                foreach (var item in getLab)
                {
                    dic.Add(item.Key, item.Value);
                }
            }
            _sample = new MedicalImagingSample();
            var getMed = _sample.SearchTitle(text);
            if (getMed.Count != 0)
            {
                foreach (var item in getMed)
                {
                    dic.Add(item.Key, item.Value);
                }
            }
            _sample = new PrescriptionSample();
            var getPre = _sample.SearchTitle(text);
            if (getPre.Count != 0)
            {
                foreach (var item in getPre)
                {
                    dic.Add(item.Key, item.Value);
                }
            }
            _sample = new VariousDocumentSample();
            var getVar = _sample.SearchTitle(text);
            if (getVar.Count != 0)
            {
                foreach (var item in getVar)
                {
                    dic.Add(item.Key, item.Value);
                }
            }
            try
            {
                cboTitle.DroppedDown = false;
            }
            catch
            {
                //
            }
            if (dic.Count == 0)
            {
                cboTitle.Text = text;
                cboTitle.Select(text.Length, 0);
                _have = false;
                return;
            }
            _have = true;
            if (cboTitle.Focused) cboTitle.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            _selected = false;
            cboTitle.DataSource = new BindingSource(dic, null);
            _selected = false;
            cboTitle.DisplayMember = "Value";
            _selected = false;
            cboTitle.ValueMember = "Key";
            _selected = false;
            cboTitle.SelectedIndex = -1;
            _selected = false;
            cboTitle.Text = text;
            _selected = false;
            cboTitle.Select(text.Length, 0);
            _selected = true;
        }

        private void treeViewSelection_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name != "Consultation" && e.Node.Name != "Laboratory" && e.Node.Name != "MedicalImaging" &&
                e.Node.Name != "Prescription" && e.Node.Name != "VariousDocument")
            {
                try
                {
                    if (e.Node.Parent.Parent.Name == "Consultation")
                    {
                        _keyCategory = Convert.ToInt32(e.Node.Parent.Name);
                        try
                        {
                            if (e.Node.Parent.Name == _keyCategory.ToString())
                            {
                                _sample = new ConsultationSample();
                                _keyTitle = Convert.ToInt32(e.Node.Name);
                                txtDescription.Text = "";
                                txtDescription.Load(_sample.Path(_keyTitle), StreamType.RichTextFormat);
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                    if (e.Node.Parent.Parent.Name == "Laboratory")
                    {
                        _keyCategory = Convert.ToInt32(e.Node.Parent.Name);
                        try
                        {
                            if (e.Node.Parent.Name == _keyCategory.ToString())
                            {
                                _sample = new ConsultationSample();
                                _keyTitle = Convert.ToInt32(e.Node.Name);
                                txtDescription.Text = "";
                                txtDescription.Load(_sample.Path(_keyTitle), StreamType.RichTextFormat);
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                    if (e.Node.Parent.Parent.Name == "MedicalImaging")
                    {
                        _keyCategory = Convert.ToInt32(e.Node.Parent.Name);
                        try
                        {
                            if (e.Node.Parent.Name == _keyCategory.ToString())
                            {
                                _sample = new ConsultationSample();
                                _keyTitle = Convert.ToInt32(e.Node.Name);
                                txtDescription.Text = "";
                                txtDescription.Load(_sample.Path(_keyTitle), StreamType.RichTextFormat);
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                    if (e.Node.Parent.Parent.Name == "Prescription")
                    {
                        _keyCategory = Convert.ToInt32(e.Node.Parent.Name);
                        try
                        {
                            if (e.Node.Parent.Name == _keyCategory.ToString())
                            {
                                _sample = new ConsultationSample();
                                _keyTitle = Convert.ToInt32(e.Node.Name);
                                txtDescription.Text = "";
                                txtDescription.Load(_sample.Path(_keyTitle), StreamType.RichTextFormat);
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                    if (e.Node.Parent.Parent.Name == "VariousDocument")
                    {
                        _keyCategory = Convert.ToInt32(e.Node.Parent.Name);
                        try
                        {
                            if (e.Node.Parent.Name == _keyCategory.ToString())
                            {
                                _sample = new ConsultationSample();
                                _keyTitle = Convert.ToInt32(e.Node.Name);
                                txtDescription.Text = "";
                                txtDescription.Load(_sample.Path(_keyTitle), StreamType.RichTextFormat);
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                }
                catch
                {
                 //
                }
            }
        }

        private void chkTitle_CheckedChanged(object sender, EventArgs e)
        {
            cboTitle.Enabled = chkTitle.Checked;
            _keyCategory = 0;
            _keyTitle = 0;
            _keyService = "";
            cboTitle.Text = "";
            if (chkTitle.Checked) cboTitle.Focus();
        }

        private void cboTitle_Leave(object sender, EventArgs e)
        {
            treeViewSelection.Select();
        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.Image = Properties.Resources.Hide_left_icon;
                //picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlLeft.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.Image = Properties.Resources.Hide_right_icon;
                //picHideRight.ImageLocation = _path + @"Hide-Right-icon.png";
                pnlLeft.Visible = true;
                picHideRight.Click -= picShowRight_Click;
            }
        }

        private void tableLayoutPanel3_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeWE;
        }

        private void tableLayoutPanel3_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeWE;
        }

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseClick = true;
        }

        private void tableLayoutPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseClick)
            {
                pnlLeft.Width = pnlLeft.Right + e.X;
                Cursor.Current = Cursors.SizeWE;
            }
        }

        private void tableLayoutPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClick = false;
        }
    }
}
