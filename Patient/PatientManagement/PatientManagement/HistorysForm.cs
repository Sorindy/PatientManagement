﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;
using WaitingList = Hospital_Entity_Framework.WaitingList;
using Worker = Hospital_Entity_Framework.Worker;

namespace PatientManagement
{
    public partial class HistorysForm : Form
    {
        public HistorysForm()
        {
            InitializeComponent();
        }

        internal Patient Patient;
        internal Account Account;
        internal Worker Worker;
        internal CatelogForm CatelogForm;
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;
        private IEstimate _estimate;
        private ISample _sample;
        internal MedicalRecord Medical=new MedicalRecord();
        //private readonly MedicalHistory _medicalHistory=new MedicalHistory();
        private readonly Class.WaitingList _waitingList = new Class.WaitingList();
        internal WaitingList WaitingList;
        private IHistory _history;
        private int _keyCategory;
        internal int KeyCategory;
        internal string KeyService;
        private string _path;
        internal Refferrer Refferrer=new Refferrer();
        internal string Title = "";
        internal bool NewMedical;
        private int? _keyNurse;
        private int? _keyReferrer;
        internal bool Editing;
        private string _refName;

        private static void CheckOrderDgv(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            for (var i = 0; i <= dgv.RowCount - 1; i++)
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(@"Arial", 14, FontStyle.Bold);
        }
        private void HistorysForm_Shown(object sender, EventArgs e)
        {
            lbpName.Text =Patient.FirstName+@"   "+ Patient.LastName;
            lbpGender.Text = Patient.Gender;
            lbdName.Text =Account.Worker.FirstName+@"    "+ Account.Worker.LastName;
            AddAllCategoryToEachService();
            lbCategory.Text = "";
            if (KeyService != null)
            {
                lbService.Text = KeyService;
                if (KeyService == "Consultation")
                {
                    tabSelection.SelectedTab = tabConsultation;
                    cboConCategory.SelectedValue = KeyCategory;
                    lbCategory.Text = cboConCategory.Text;
                }
                if (KeyService == "Laboratory")
                {
                    tabSelection.SelectedTab = tabLaboratory;
                    cboLabCategory.SelectedValue = KeyCategory;
                    lbCategory.Text = cboLabCategory.Text;
                }
                if (KeyService == "MedicalImaging")
                {
                    tabSelection.SelectedTab = tabMedicalImaging;
                    cboMedCategory.SelectedValue = KeyCategory;
                    lbCategory.Text = cboMedCategory.Text;
                }
                if (KeyService == "Prescription")
                {
                    tabSelection.SelectedTab = tabPrescription;
                    cboPreCategory.SelectedValue = KeyCategory;
                    lbCategory.Text = cboPreCategory.Text;
                }
                if (KeyService == "VariousDocument")
                {
                    tabSelection.SelectedTab = tabVariousDocument;
                    cboVarCategory.SelectedValue = KeyCategory;
                    lbCategory.Text = cboVarCategory.Text;
                }
            }
            else
            {
                lbService.Text = @"Consultation";
                cboConCategory.SelectedIndex=0;
                lbCategory.Text = cboConCategory.Text;
                KeyService = @"Consultation";
            }
            //AddNodesToTree();
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"S:\";
            //dgvConsultation.Columns.Clear();
            //dgvLaboratory.Columns.Clear();
            //dgvMedicalImaging.Columns.Clear();
            //dgvPrescription.Columns.Clear();
            //dgvVariousDocument.Columns.Clear();
            picHideRight.Image = Properties.Resources.Hide_right_icon;
            //picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.Image = Properties.Resources.Hide_Up_icon;
            //picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
            txtDescription.EditMode = EditMode.ReadAndSelect;
            dgvConsultation.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvLaboratory.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvMedicalImaging.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvPrescription.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvVariousDocument.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            tabSelection.ItemSize = new Size(Convert.ToInt32(pnlShowHistory.Width / 5.3), 35);
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            cboNurse.Enabled = false;
            cboReferrer.Enabled = false;
            gboRefferAndNurse.Enabled = false;
            txtDescription.ForeColor=Color.Black;
            CatelogForm.Skip = false;
            tabSelection.SelectedTab = tabLaboratory;
            tabSelection.SelectedTab = tabMedicalImaging;
            tabSelection.SelectedTab = tabPrescription;
            tabSelection.SelectedTab = tabVariousDocument;
            tabSelection.SelectedTab = tabConsultation;
        }

        //private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboService.Text == @"Consultation")
        //    {
        //        _category = new ConsultationCategory();
        //        var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
        //        if (dic.Count != 0)
        //        {
        //            cboCategory.DataSource = new BindingSource(dic, null);
        //            cboCategory.DisplayMember = "Value";
        //            cboCategory.ValueMember = "Key";
        //        }
        //    }
        //    if (cboService.Text == @"Laboratory")
        //    {
        //        _category = new LaboratoryCategory();
        //        var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
        //        if (dic.Count != 0)
        //        {
        //            cboCategory.DataSource = new BindingSource(dic, null);
        //            cboCategory.DisplayMember = "Value";
        //            cboCategory.ValueMember = "Key";
        //        }
        //    }
        //    if (cboService.Text == @"Medical Imaging")
        //    {
        //        _category = new LaboratoryCategory();
        //        var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
        //        if (dic.Count != 0)
        //        {
        //            cboCategory.DataSource = new BindingSource(dic, null);
        //            cboCategory.DisplayMember = "Value";
        //            cboCategory.ValueMember = "Key";
        //        }
        //    }
        //    if (cboService.Text == @"Prescription")
        //    {
        //        _category = new LaboratoryCategory();
        //        var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
        //        if (dic.Count != 0)
        //        {
        //            cboCategory.DataSource = new BindingSource(dic, null);
        //            cboCategory.DisplayMember = "Value";
        //            cboCategory.ValueMember = "Key";
        //        }
        //    }
        //    if (cboService.Text == @"Various Document")
        //    {
        //        _category = new LaboratoryCategory();
        //        var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
        //        if (dic.Count != 0)
        //        {
        //            cboCategory.DataSource = new BindingSource(dic, null);
        //            cboCategory.DisplayMember = "Value";
        //            cboCategory.ValueMember = "Key";
        //        }
        //    }
        //}

        private void HistorysForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void HistorysForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void HistorysForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel1_MouseUp(object sender,MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            var form = new PatientForm {Patient = Patient,HistorysForm = this};
            form.ShowDialog();
        }

        //private void cboSelection_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboService.Text == @"Consultation")
        //    {
        //        _history = new ConsultationHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboService.Text == @"Laboratory")
        //    {
        //        _history = new LaboratoryHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboService.Text == @"MedicalImaging")
        //    {
        //        _history = new MedicalImagingHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboService.Text == @"Prescription")
        //    {
        //        _history = new PrescriptionHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboService.Text == @"VariousDocument")
        //    {
        //        _history = new VariousDocumentHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboService.Text == @"Patient's History")
        //    {
        //        dgvHistory.DataSource = null;
        //        var getPath = _medicalHistory.Show_medicalhistory(Patient.Id);
        //        if (getPath != null) txtDescription.Load(getPath.Description, StreamType.RichTextFormat);
        //    }
        //    if (dgvHistory.DataSource != null) { dgvHistory.Columns[0].Visible = false; CheckOrderDgv(); }
        //}

        //Use for tree in History

        //private void AddNodesToTree()
        //{
        //    {
        //        _category = new ConsultationCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            foreach (var item in dic)
        //            {
        //                treeSelection.Nodes[1].Nodes.Add(item.Key.ToString(), item.Value);
        //            }
        //        }
        //    }
        //    {
        //        _category = new LaboratoryCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            foreach (var item in dic)
        //            {
        //                treeSelection.Nodes[2].Nodes.Add(item.Key.ToString(), item.Value);
        //            }
        //        }
        //    }
        //    {
        //        _category = new MedicalImagingCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            foreach (var item in dic)
        //            {
        //                treeSelection.Nodes[3].Nodes.Add(item.Key.ToString(), item.Value);
        //            }
        //        }
        //    }
        //    {
        //        _category = new PrescriptionCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            foreach (var item in dic)
        //            {
        //                treeSelection.Nodes[4].Nodes.Add(item.Key.ToString(), item.Value);
        //            }
        //        }
        //    }
        //    {
        //        _category = new VariousDocumentCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            foreach (var item in dic)
        //            {
        //                treeSelection.Nodes[5].Nodes.Add(item.Key.ToString(), item.Value);
        //            }
        //        }
        //    }
        //}

        //private void treeSelection_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    txtDescription.Text = "";
        //    _keyService = "";
        //    dgvHistory.DataSource = null;
        //    dgvHistory.Columns.Clear();
        //    if (e.Node.Name != "Consultation" && e.Node.Name != "Laboratory" && e.Node.Name != "MedicalImaging" &&
        //        e.Node.Name != "Prescription" && e.Node.Name != "VariousDocument" && e.Node.Name != "History")
        //    {
        //        if (e.Node.Parent.Name == "Consultation")
        //        {
        //            _keyService = "Consultation";
        //            _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
        //            lbService.Text = _keyService;
        //            lbCategory.Text = e.Node.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }
                   
        //            else
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //        if (e.Node.Parent.Name == "Laboratory")
        //        {
        //            _keyService = "Laboratory";
        //            _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
        //            lbService.Text = _keyService;
        //            lbCategory.Text = e.Node.Text;
        //            _history = new LaboratoryHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //        if (e.Node.Parent.Name == "MedicalImaging")
        //        {
        //            _keyService = "MedicalImaging";
        //            _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
        //            lbService.Text = _keyService;
        //            lbCategory.Text = e.Node.Text;
        //            _history = new MedicalImagingHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //        if (e.Node.Parent.Name == "Prescription")
        //        {
        //            _keyService = "Prescription";
        //            _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
        //            lbService.Text = _keyService;
        //            lbCategory.Text = e.Node.Text;
        //            _history = new PrescriptionHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //        if (e.Node.Parent.Name == "VariousDocument")
        //        {
        //            _keyService = "VariousDocument";
        //            _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
        //            lbService.Text = _keyService;
        //            lbCategory.Text = e.Node.Text;
        //            _history = new VariousDocumentHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //    }
        //    if (e.Node.Name == "History")
        //    {
                
        //    }
        //    if(dgvHistory.DataSource!=null)CheckOrderDgv();
        //}

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imagesobject1 = new TXTextControl.Image {SaveMode = ImageSaveMode.SaveAsData};
            txtDescription.Images.Add(imagesobject1, -1);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FontDialog();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TextBackColorDialog();
        }

        private void selectForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.ForeColorDialog();
        }

        private void frameFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FrameFillColorDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Tables.Add();
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

        //private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtDescription.EditMode = EditMode.ReadAndSelect;
        //    if (dgvConsultation.DataSource == null) return;
        //    if (lbService.Text == @"Consultation")
        //    {
        //        if (dgvConsultation.CurrentRow != null)
        //        {
        //            _history=new ConsultationHistory();
        //            txtDescription.Text = "";
        //            txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
        //                StreamType.RichTextFormat);
        //        }
        //    }
        //    if (lbService.Text == @"Laboratory")
        //    {
        //        if (dgvConsultation.CurrentRow != null)
        //        {
        //            _history=new LaboratoryHistory();
        //            txtDescription.Text = "";
        //            txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
        //                StreamType.RichTextFormat);
        //        }
        //    }
        //    if (lbService.Text == @"Medical Imaging")
        //    {
        //        if (dgvConsultation.CurrentRow != null)
        //        {
        //            _history=new MedicalImagingHistory();
        //            txtDescription.Text = "";
        //            txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
        //                StreamType.RichTextFormat);
        //        }
        //    }
        //    if (lbService.Text == @"Prescription")
        //    {
        //        if (dgvConsultation.CurrentRow != null)
        //        {
        //            _history=new PrescriptionHistory();
        //            txtDescription.Text = "";
        //            txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
        //                StreamType.RichTextFormat);
        //        }
        //    }
        //    if (lbService.Text == @"Various Document")
        //    {
        //        if (dgvConsultation.CurrentRow != null)
        //        {
        //            _history=new VariousDocumentHistory();
        //            txtDescription.Text = "";
        //            txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
        //                StreamType.RichTextFormat);
        //        }
        //    }
        //}

        private static void InsertButtonEditAndNewForDoctor(DataGridView dgv)
        {
            //var btnView = new DataGridViewButtonColumn
            //{
            //    FlatStyle = FlatStyle.Flat,
            //    Text = @"ថ្មី",
            //    HeaderText = @"New"
            //};
            //btnView.CellTemplate.Style.BackColor = Color.LightSeaGreen;
            //btnView.UseColumnTextForButtonValue = true;
            var btnDelete = new DataGridViewButtonColumn
            {
                Text = @"កែប្រែ",
                FlatStyle = FlatStyle.Flat,
                HeaderText = @"Edit"
            };
            btnDelete.CellTemplate.Style.BackColor = Color.DeepSkyBlue;
            btnDelete.UseColumnTextForButtonValue = true;
            dgv.Columns.AddRange(btnDelete);
            dgv.ClearSelection();
        }

        private void picHideTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picHideTop")
            {
                picHideTop.Name = "picShowTop";
                picHideTop.Image = Properties.Resources.Hide_down_icon;
                //picHideTop.ImageLocation = _path + @"Hide-down-icon.png";
                pnlTitle.Visible = false;
                picHideTop.Click += picShowTop_Click;
            }
        }

        private void picShowTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picShowTop")
            {
                picHideTop.Name = "picHideTop";
                picHideTop.Image = Properties.Resources.Hide_Up_icon;
                //picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
                pnlTitle.Visible = true;
                picHideTop.Click -= picShowTop_Click;
            }
        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.Image = Properties.Resources.Hide_left_icon;
                //picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlShowHistory.Visible = false;
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
                pnlShowHistory.Visible = true;
                picHideRight.Click -= picShowRight_Click;
            }
        }

        //private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (_keyService == @"Consultation")
        //    {
        //        var get =(KeyValuePair<int,string>) cboConCategory.SelectedItem;
        //        var key = get.Key;
        //        if (key != 0)
        //        {
        //            dgvConsultation.Columns.Clear();
        //            _keyCategory = Convert.ToInt32(key);
        //            lbCategory.Text = cboConCategory.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
                
        //    }
        //    if (_keyService == @"Laboratory")
        //    {
        //        var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
        //        var key = get.Key;
        //        if (key != 0)
        //        {
        //            dgvConsultation.Columns.Clear();
        //            _keyCategory = Convert.ToInt32(key);
        //            lbCategory.Text = cboConCategory.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //    }
        //    if (_keyService == @"MedicalImaging")
        //    {
        //        var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
        //        var key = get.Key;
        //        if (key != 0)
        //        {
        //            dgvConsultation.Columns.Clear();
        //            _keyCategory = Convert.ToInt32(key);
        //            lbCategory.Text = cboConCategory.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }   
        //    }
        //    if (_keyService == @"Prescription")
        //    {
        //        var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
        //        var key = get.Key;
        //        if (key != 0)
        //        {
        //            dgvConsultation.Columns.Clear();
        //            _keyCategory = Convert.ToInt32(key);
        //            lbCategory.Text = cboConCategory.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //    }
        //    if (_keyService == @"VariousDocument")
        //    {
        //        var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
        //        var key = get.Key;
        //        if (key != 0)
        //        {
        //            dgvConsultation.Columns.Clear();
        //            _keyCategory = Convert.ToInt32(key);
        //            lbCategory.Text = cboConCategory.Text;
        //            _history = new ConsultationHistory();
        //            if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //                InsertButtonEditAndNewForDoctor();
        //            }

        //            else
        //            {
        //                dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
        //            }
        //        }
        //    }
        //   // if(dgvConsultation.DataSource!=null)CheckOrderDgv();
        //}

        //private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboService.Text == @"Consultation")
        //    {
        //        _category=new ConsultationCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            cboConCategory.DataSource = new BindingSource(dic, null);
        //            cboConCategory.DisplayMember = "Value";
        //            cboConCategory.ValueMember = "Key";
        //            _keyService = @"Consultation";
        //        }
        //    }
        //    if (cboService.Text == @"Laboratory")
        //    {
        //        _category=new LaboratoryCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            cboConCategory.DataSource = new BindingSource(dic, null);
        //            cboConCategory.DisplayMember = "Value";
        //            cboConCategory.ValueMember = "Key";
        //            _keyService = @"Laboratory";
        //        }
        //    }
        //    if (cboService.Text == @"MedicalImaging")
        //    {
        //        _category=new MedicalImagingCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            cboConCategory.DataSource = new BindingSource(dic, null);
        //            cboConCategory.DisplayMember = "Value";
        //            cboConCategory.ValueMember = "Key";
        //            _keyService = @"MedicalImaging";
        //        }
        //    }
        //    if (cboService.Text == @"Prescription")
        //    {
        //        _category=new PrescriptionCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            cboConCategory.DataSource = new BindingSource(dic, null);
        //            cboConCategory.DisplayMember = "Value";
        //            cboConCategory.ValueMember = "Key";
        //            _keyService = @"Prescription";
        //        }
        //    }
        //    if (cboService.Text == @"VariousDocument")
        //    {
        //        _category=new VariousDocumentCategory();
        //        var dic = _category.ShowAllCategoryForHistory();
        //        if (dic.Count != 0)
        //        {
        //            cboConCategory.DataSource = new BindingSource(dic, null);
        //            cboConCategory.DisplayMember = "Value";
        //            cboConCategory.ValueMember = "Key";
        //            _keyService = @"VariousDocument";
        //        }
        //    }
        //    lbService.Text = _keyService;
        //}

        private void AddAllCategoryToEachService()
        {
            {
                _category=new ConsultationCategory();
                var dic = _category.ShowAllCategoryForHistory();
                if (dic.Count != 0)
                {
                    cboConCategory.DataSource=new BindingSource(dic,null);
                    cboConCategory.DisplayMember = "Value";
                    cboConCategory.ValueMember = "Key";
                    cboConCategory.SelectedIndex=0;
                }
            }
            {
                _category = new LaboratoryCategory();
                var dic = _category.ShowAllCategoryForHistory();
                if (dic.Count != 0)
                {
                    cboLabCategory.DataSource = new BindingSource(dic, null);
                    cboLabCategory.DisplayMember = "Value";
                    cboLabCategory.ValueMember = "Key";
                    cboLabCategory.SelectedIndex = 0;
                }
            }
            {
                _category = new MedicalImagingCategory();
                var dic = _category.ShowAllCategoryForHistory();
                if (dic.Count != 0)
                {
                    cboMedCategory.DataSource = new BindingSource(dic, null);
                    cboMedCategory.DisplayMember = "Value";
                    cboMedCategory.ValueMember = "Key";
                    cboMedCategory.SelectedIndex = 0;
                }
            }
            {
                _category = new PrescriptionCategory();
                var dic = _category.ShowAllCategoryForHistory();
                if (dic.Count != 0)
                {
                    cboPreCategory.DataSource = new BindingSource(dic, null);
                    cboPreCategory.DisplayMember = "Value";
                    cboPreCategory.ValueMember = "Key";
                    cboPreCategory.SelectedIndex = 0;
                }
            }
            {
                _category = new VariousDocumentCategory();
                var dic = _category.ShowAllCategoryForHistory();
                if (dic.Count != 0)
                {
                    cboVarCategory.DataSource = new BindingSource(dic, null);
                    cboVarCategory.DisplayMember = "Value";
                    cboVarCategory.ValueMember = "Key";
                    cboVarCategory.SelectedIndex = 0;
                }
            }
        }

        private void cboConCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
            var key = get.Key;
            if (key != 0)
            {
                dgvConsultation.Columns.Clear();
                if (!Editing || !NewMedical) _keyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboConCategory.Text;
                _history = new ConsultationHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
                {
                    dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
                    InsertButtonEditAndNewForDoctor(dgvConsultation);
                }

                else
                {
                    dgvConsultation.DataSource = _history.Show(Patient.Id, _keyCategory);
                }
            } if (dgvConsultation.DataSource != null) CheckOrderDgv(dgvConsultation);
        }

        private void cboLabCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var get = (KeyValuePair<int, string>)cboLabCategory.SelectedItem;
            var key = get.Key;
            if (key != 0)
            {
                dgvLaboratory.Columns.Clear();
                if (!Editing || !NewMedical) _keyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboLabCategory.Text;
                _history = new LaboratoryHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
                {
                    dgvLaboratory.DataSource = _history.Show(Patient.Id, _keyCategory);
                    InsertButtonEditAndNewForDoctor(dgvLaboratory);
                }

                else
                {
                    dgvLaboratory.DataSource = _history.Show(Patient.Id, _keyCategory);
                    btnNewLaboratory.Enabled = false;
                }
            } if (dgvLaboratory.DataSource != null) CheckOrderDgv(dgvLaboratory);
        }

        private void cboMedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var get = (KeyValuePair<int, string>)cboMedCategory.SelectedItem;
            var key = get.Key;
            if (key != 0)
            {
                dgvMedicalImaging.Columns.Clear();
                if (!Editing || !NewMedical) _keyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboMedCategory.Text;
                _history = new MedicalImagingHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
                {
                    dgvMedicalImaging.DataSource = _history.Show(Patient.Id, _keyCategory);
                    InsertButtonEditAndNewForDoctor(dgvMedicalImaging);
                    btnNewMedicalImaging.Enabled = true;
                }

                else
                {
                    dgvMedicalImaging.DataSource = _history.Show(Patient.Id, _keyCategory);
                    btnNewMedicalImaging.Enabled = false;
                }
            } if (dgvMedicalImaging.DataSource != null) CheckOrderDgv(dgvMedicalImaging);
        }

        private void cboPreCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var get = (KeyValuePair<int, string>)cboPreCategory.SelectedItem;
            var key = get.Key;
            if (key != 0)
            {
                dgvPrescription.Columns.Clear();
                if (!Editing || !NewMedical) _keyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboPreCategory.Text;
                _history = new PrescriptionHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
                {
                    dgvPrescription.DataSource = _history.Show(Patient.Id, _keyCategory);
                    InsertButtonEditAndNewForDoctor(dgvPrescription);
                    btnNewPresciption.Enabled = true;
                }

                else
                {
                    dgvPrescription.DataSource = _history.Show(Patient.Id, _keyCategory);
                    btnNewPresciption.Enabled = false;
                }
            } if (dgvPrescription.DataSource != null) CheckOrderDgv(dgvPrescription);
        }

        private void cboVarCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var get = (KeyValuePair<int, string>)cboVarCategory.SelectedItem;
            var key = get.Key;
            if (key != 0)
            {
                dgvVariousDocument.Columns.Clear();
                if (!Editing || !NewMedical) _keyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboVarCategory.Text;
                _history = new VariousDocumentHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, _keyCategory))
                {
                    dgvVariousDocument.DataSource = _history.Show(Patient.Id, _keyCategory);
                    InsertButtonEditAndNewForDoctor(dgvVariousDocument);
                    btnNewVarious.Enabled = true;
                }

                else
                {
                    dgvVariousDocument.DataSource = _history.Show(Patient.Id, _keyCategory);
                    btnNewVarious.Enabled = false;
                }
            } if (dgvVariousDocument.DataSource != null) CheckOrderDgv(dgvVariousDocument);
        }

        private void dgvVariousDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"VariousDocument";
            //if (e.ColumnIndex.Equals(7))
            //{
            //    if (dgvVariousDocument.DataSource != null)
            //    {
            //        var form = new MedicalsForm
            //        {
            //            Worker = Account.Worker,
            //            Account = Account,
            //            Patient = Patient,
            //            TopLevel = false,
            //            Dock = DockStyle.Fill,
            //            KeyCategory = _keyCategory,
            //            KeyService = KeyService
            //        };
            //        dgvVariousDocument.SelectionChanged -= dgvVariousDocument_SelectionChanged;
            //        CatelogForm.pnlFill.Controls.Clear();
            //        CatelogForm.pnlFill.Controls.Add(form);
            //        form.Show();
            //        Close();
            //    }
            //}
            if (!e.ColumnIndex.Equals(7)) return;
            txtDescription.EditMode = EditMode.Edit;
            saveToolStripMenuItem.Enabled = true;
            gboRefferAndNurse.Enabled = true;
            Editing = true;
            CatelogForm.Skip = true;
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
            _estimate = new VariousDocumentEstimate();
            if (dgvVariousDocument.CurrentRow == null) return;
            var id = Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[0].Value);
            if (_estimate.GetRefferrerId(id) != "")
            {
                int? refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                chkBoxReferrer.Checked = true;
                if (cboReferrer.DataSource != null)
                {
                    cboReferrer.SelectedValue = refId;
                }
            }
            if (_estimate.GetNurseId(id) == "") return;
            int? nurId = Convert.ToInt32(_estimate.GetNurseId(id));
            chkBoxNurse.Checked = true;
            if (cboNurse.DataSource != null)
            {
                cboNurse.SelectedValue = nurId;
            }
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
        }

        private void dgvPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Prescription";
            //if (e.ColumnIndex.Equals(7))
            //{
            //    if (dgvPrescription.DataSource != null)
            //    {
            //        var form = new MedicalsForm
            //        {
            //            Worker = Account.Worker,
            //            Account = Account,
            //            Patient = Patient,
            //            TopLevel = false,
            //            Dock = DockStyle.Fill,
            //            KeyCategory = _keyCategory,
            //            KeyService = KeyService
            //        };
            //        dgvPrescription.SelectionChanged -= dgvPrescription_SelectionChanged;
            //        CatelogForm.pnlFill.Controls.Clear();
            //        CatelogForm.pnlFill.Controls.Add(form);
            //        form.Show();
            //        Close();
            //    }
            //}
            if (!e.ColumnIndex.Equals(7)) return;
            txtDescription.EditMode = EditMode.Edit;
            saveToolStripMenuItem.Enabled = true;
            gboRefferAndNurse.Enabled = true;
            Editing = true;
            CatelogForm.Skip = true;
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
            _estimate = new PrescriptionEstimate();
            if (dgvPrescription.CurrentRow == null) return;
            var id = Convert.ToInt32(dgvPrescription.CurrentRow.Cells[0].Value);
            if (_estimate.GetRefferrerId(id) != "")
            {
                int? refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                chkBoxReferrer.Checked = true;
                if (cboReferrer.DataSource != null)
                {
                    cboReferrer.SelectedValue = refId;
                }
            }
            if (_estimate.GetNurseId(id) == "") return;
            int? nurId = Convert.ToInt32(_estimate.GetNurseId(id));
            chkBoxNurse.Checked = true;
            if (cboNurse.DataSource != null)
            {
                cboNurse.SelectedValue = nurId;
            }
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
        }

        private void dgvVariousDocument_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvVariousDocument.Focused) return;
            if (CatelogForm.Skip) return;
            var status = true;
            if (NewMedical||Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            txtDescription.EditMode = EditMode.ReadAndSelect;
            gboRefferAndNurse.Enabled = false;
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            WaitingList = null;
            NewMedical = false;
            Editing = false;
            CatelogForm.Skip = false;
            if (dgvVariousDocument.DataSource == null) return;
            if (lbService.Text != @"VariousDocument") return;
            if (dgvVariousDocument.CurrentRow == null) return;
            _history = new VariousDocumentHistory();
            txtDescription.Text = "";
            _refName = dgvVariousDocument.CurrentRow.Cells[4].Value.ToString();
            try
            {
                txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[0].Value)),
                    StreamType.RichTextFormat);
                saveToolStripMenuItem.Enabled = false;
            }
            catch
            {
                try
                {
                    var path = _history.GetPath(Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[0].Value));
                    var subpath = path.Substring(3, path.Length);
                    txtDescription.Load(@"D:\ABC soft\" + subpath,
                        StreamType.RichTextFormat);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    try
                    {
                        txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[1].Value)),
                            StreamType.RichTextFormat);
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                       //Ignore
                    }
                }
            }
        }

        private void tabSelection_Selected(object sender, TabControlEventArgs e)
        {
            lbCategory.Text = "";
            if (tabSelection.SelectedTab.Text == @"Consultation")
            {
                lbService.Text = @"Consultation";
                if (cboConCategory.DataSource != null)
                {
                    try
                    {
                        cboConCategory.SelectedIndex = 1;
                    }
                    catch
                    {
                        //
                    }
                    cboConCategory.SelectedIndex = 0;
                    lbCategory.Text = cboConCategory.Text;
                    dgvConsultation.ClearSelection();
                    if(Editing||NewMedical)return;
                    KeyService = @"Consultation";
                }
            }
            if (tabSelection.SelectedTab.Text == @"Laboratory")
            {
                lbService.Text = @"Laboratory";
                if (cboLabCategory.DataSource != null)
                {
                    try
                    {
                        cboLabCategory.SelectedIndex = 1;
                    }
                    catch
                    {
                        //
                    }
                    cboLabCategory.SelectedIndex = 0;
                    lbCategory.Text = cboLabCategory.Text;
                    dgvLaboratory.ClearSelection();
                    if (Editing || NewMedical) return;
                    KeyService = @"Laboratory";
                }
            }
            if (tabSelection.SelectedTab.Text == @"MedicalImaging")
            {
                lbService.Text = @"MedicalImaging";
                if (cboMedCategory.DataSource != null)
                {
                    try
                    {
                        cboMedCategory.SelectedIndex = 1;
                    }
                    catch
                    {
                        //
                    }
                    cboMedCategory.SelectedIndex = 0;
                    lbCategory.Text = cboMedCategory.Text;
                    dgvMedicalImaging.ClearSelection();
                    if (Editing || NewMedical) return;
                    KeyService = @"MedicalImaging";
                }
            }
            if (tabSelection.SelectedTab.Text == @"Prescription")
            {
                lbService.Text = @"Prescription";
                if (cboPreCategory.DataSource != null)
                {
                    try
                    {
                        cboPreCategory.SelectedIndex = 1;
                    }
                    catch
                    {
                        //
                    }
                    cboPreCategory.SelectedIndex = 0;
                    lbCategory.Text = cboPreCategory.Text;
                    dgvPrescription.ClearSelection();
                    if (Editing || NewMedical) return;
                    KeyService = @"Prescription";
                }
            }
            if (tabSelection.SelectedTab.Text == @"VariousDocument")
            {
                lbService.Text = @"VariousDocument";
                if (cboVarCategory.DataSource != null)
                {
                    try
                    {
                        cboVarCategory.SelectedIndex = 1;
                    }
                    catch
                    {
                        //
                    }
                    cboVarCategory.SelectedIndex = 0;
                    lbCategory.Text = cboVarCategory.Text;
                    dgvVariousDocument.ClearSelection();
                    if (Editing || NewMedical) return;
                    KeyService = @"VariousDocument";
                }
            }
        }

        private void dgvPrescription_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvPrescription.Focused) return;
            if (CatelogForm.Skip) return;
            var status = true;
            if (NewMedical||Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            txtDescription.EditMode = EditMode.ReadAndSelect;
            gboRefferAndNurse.Enabled = false;
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            WaitingList = null;
            NewMedical = false;
            Editing = false;
            CatelogForm.Skip = false;
            if (dgvPrescription.DataSource == null) return;
            if (lbService.Text != @"Prescription") return;
            if (dgvPrescription.CurrentRow == null) return;
            _history = new PrescriptionHistory();
            txtDescription.Text = "";
            _refName = dgvPrescription.CurrentRow.Cells[4].Value.ToString();
            try
            {
                txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvPrescription.CurrentRow.Cells[0].Value)),
                    StreamType.RichTextFormat );
                saveToolStripMenuItem.Enabled = false;
            }
            catch
            {
                try
                {
                    var path = _history.GetPath(Convert.ToInt32(dgvPrescription.CurrentRow.Cells[0].Value));
                    var subpath = path.Substring(3, path.Length);
                    txtDescription.Load(@"D:\ABC soft\" + subpath,
                        StreamType.RichTextFormat);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    try
                    {
                        txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvPrescription.CurrentRow.Cells[1].Value)),
                            StreamType.RichTextFormat);
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                       //Ignore
                    }
                }
            }
        }

        private void dgvMedicalImaging_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"MedicalImaging";
            if (e.ColumnIndex.Equals(7))
            {
            //    if (dgvMedicalImaging.DataSource != null)
            //    {
            //        var form = new MedicalsForm
            //        {
            //            Worker = Account.Worker,
            //            Account = Account,
            //            Patient = Patient,
            //            TopLevel = false,
            //            Dock = DockStyle.Fill,
            //            KeyCategory = _keyCategory,
            //            KeyService = KeyService
            //        };
            //        dgvMedicalImaging.SelectionChanged -= dgvMedicalImaging_SelectionChanged;
            //        CatelogForm.pnlFill.Controls.Clear();
            //        CatelogForm.pnlFill.Controls.Add(form);
            //        form.Show();
            //        Close();
            //    }
            //}
            //if (e.ColumnIndex.Equals(8))
            //{
                txtDescription.EditMode = EditMode.Edit;
                saveToolStripMenuItem.Enabled = true;
                Editing = true;
                CatelogForm.Skip = true;
                _estimate = new MedicalImagingEstimate();
                if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
                gboRefferAndNurse.Enabled = true;
                if (dgvMedicalImaging.CurrentRow == null) return;
                var id = Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[0].Value);
                if (_estimate.GetRefferrerId(id) != "")
                {
                    int? refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                    chkBoxReferrer.Checked = true;
                    if (cboReferrer.DataSource != null)
                    {
                        cboReferrer.SelectedValue = refId;
                    }
                }
                if (_estimate.GetNurseId(id) == "") return;
                int? nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                chkBoxNurse.Checked = true;
                if (cboNurse.DataSource != null)
                {
                    cboNurse.SelectedValue = nurId;
                }
            }
        }

        private void dgvMedicalImaging_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvMedicalImaging.Focused) return;
            if (CatelogForm.Skip) return;
            var status = true;
            if (NewMedical||Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            txtDescription.EditMode = EditMode.ReadAndSelect;
            gboRefferAndNurse.Enabled = false;
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            WaitingList = null;
            NewMedical = false;
            Editing = false;
            CatelogForm.Skip = false;
            if (dgvMedicalImaging.DataSource == null) return;
            if (lbService.Text != @"MedicalImaging") return;
            if (dgvMedicalImaging.CurrentRow == null) return;
            _history = new MedicalImagingHistory();
            txtDescription.Text = "";
            _refName = dgvMedicalImaging.CurrentRow.Cells[4].Value.ToString();
            try
            {
                txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[0].Value)),
                    StreamType.RichTextFormat );
                saveToolStripMenuItem.Enabled = false;
            }
            catch
            {
                try
                {
                    var path = _history.GetPath(Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[0].Value));
                    var subpath = path.Substring(3, path.Length);
                    txtDescription.Load(@"D:\ABC soft\" + subpath,
                        StreamType.RichTextFormat);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    try
                    {
                        txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[1].Value)),
                            StreamType.RichTextFormat);
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                        //Ignore
                    }
                }
            }
        }

        private void dgvLaboratory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Laboratory";
            if (e.ColumnIndex.Equals(7))
            {
            //    if (dgvLaboratory.DataSource != null)
            //    {
            //        var form = new MedicalsForm
            //        {
            //            Worker = Account.Worker,
            //            Account = Account,
            //            Patient = Patient,
            //            TopLevel = false,
            //            Dock = DockStyle.Fill,
            //            KeyCategory = _keyCategory,
            //            KeyService = KeyService
            //        };
            //        dgvLaboratory.SelectionChanged -= dgvLaboratory_SelectionChanged;
            //        CatelogForm.pnlFill.Controls.Clear();
            //        CatelogForm.pnlFill.Controls.Add(form);
            //        form.Show();
            //        Close();
            //    }
            //}
            //if (e.ColumnIndex.Equals(8))
            //{
                txtDescription.EditMode = EditMode.Edit;
                saveToolStripMenuItem.Enabled = true;
                gboRefferAndNurse.Enabled = true;
                Editing = true;
                CatelogForm.Skip = true;
                _estimate = new LaboratoryEstimate();
                if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
                if (dgvLaboratory.CurrentRow == null) return;
                var id = Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[0].Value);
                if (_estimate.GetRefferrerId(id) != "")
                {
                    int? refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                    chkBoxReferrer.Checked = true;
                    if (cboReferrer.DataSource != null)
                    {
                        cboReferrer.SelectedValue = refId;
                    }
                }
                if (_estimate.GetNurseId(id) == "") return;
                int? nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                chkBoxNurse.Checked = true;
                if (cboNurse.DataSource != null)
                {
                    cboNurse.SelectedValue = nurId;
                }
            }
        }

        private void dgvLaboratory_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvLaboratory.Focused) return;
            if (CatelogForm.Skip) return;
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            txtDescription.EditMode = EditMode.ReadAndSelect;
            gboRefferAndNurse.Enabled = false;
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            WaitingList = null;
            NewMedical = false;
            Editing = false;
            CatelogForm.Skip = false;
            if (dgvLaboratory.DataSource == null) return;
            if (lbService.Text != @"Laboratory") return;
            if (dgvLaboratory.CurrentRow == null) return;
            _history = new LaboratoryHistory();
            txtDescription.Text = "";
            _refName = dgvLaboratory.CurrentRow.Cells[4].Value.ToString();
            try
            {
                txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[0].Value)),
                    StreamType.RichTextFormat);
                saveToolStripMenuItem.Enabled = false;
            }
            catch
            {
                try
                {
                    var path = _history.GetPath(Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[0].Value));
                    var subpath = path.Substring(3, path.Length);
                    txtDescription.Load(@"D:\ABC soft\" + subpath,
                        StreamType.RichTextFormat);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    try
                    {
                        txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[1].Value)),
                            StreamType.RichTextFormat);
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                       //Ignore
                    }
                }
            }
        }

        private void dgvConsultation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Consultation";
            if (e.ColumnIndex.Equals(7))
            {
                //if (dgvConsultation.DataSource != null)
                //{
            //        var form = new MedicalsForm
            //        {
            //            Worker = Account.Worker,
            //            Account = Account,
            //            Patient = Patient,
            //            TopLevel = false,
            //            Dock = DockStyle.Fill,
            //            KeyCategory = _keyCategory,
            //            KeyService = KeyService
            //        };
            //        dgvConsultation.SelectionChanged -= dgvConsultation_SelectionChanged;
            //        CatelogForm.pnlFill.Controls.Clear();
            //        CatelogForm.pnlFill.Controls.Add(form);
            //        form.Show();
            //        Close();
            //    }
            //}
            //if (e.ColumnIndex.Equals(8))
            //{
                txtDescription.EditMode = EditMode.Edit;
                Editing = true;
                //CatelogForm.Skip = true;
                saveToolStripMenuItem.Enabled = true;
                gboRefferAndNurse.Enabled = true;
                _estimate=new ConsultationEstimate();
                if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
                if (dgvConsultation.CurrentRow == null) return;
                var id = Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value);
                if (_estimate.GetRefferrerId(id) != "")
                {
                    int? refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                    chkBoxReferrer.Checked=true;
                    if (cboReferrer.DataSource != null)
                    {
                        cboReferrer.SelectedValue = refId;
                    }
                }
                if (_estimate.GetNurseId(id) == "") return;
                int? nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                chkBoxNurse.Checked = true;
                if (cboNurse.DataSource != null)
                {
                    cboNurse.SelectedValue = nurId;
                }
            }
        }

        private void dgvConsultation_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvConsultation.Focused) return;
            if (CatelogForm.Skip) return;
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            txtDescription.EditMode = EditMode.ReadAndSelect;
            gboRefferAndNurse.Enabled = false;
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            WaitingList = null;
            NewMedical = false;
            Editing = false;
            CatelogForm.Skip = false;
            if (dgvConsultation.DataSource == null) return;
            if (lbService.Text != @"Consultation") return;
            if (dgvConsultation.CurrentRow == null) return;
            _history = new ConsultationHistory();
            txtDescription.Text = "";
            _refName = dgvConsultation.CurrentRow.Cells[4].Value.ToString();
            try
            {
                txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                    StreamType.RichTextFormat);
                saveToolStripMenuItem.Enabled = false;
            }
            catch
            {
                try
                {
                    var path = _history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value));
                    var subpath = path.Substring(3, path.Length);
                    txtDescription.Load(@"D:\ABC soft\" + subpath,
                        StreamType.RichTextFormat);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch
                {
                    try
                    {
                        txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                            StreamType.RichTextFormat);
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch
                    {
                       //Ignore
                    }
                }
            }
        }

        private void CheckService()
        {
            if (lbService.Text == @"Consultation")
            {
                KeyService = @"Consultation";
                var get = (KeyValuePair<int, string>)cboConCategory.SelectedItem;
                var key = get.Key;
                if (key != 0) _keyCategory = key;
            }
            if (lbService.Text == @"Laboratory")
            {
                KeyService = @"Laboratory";
                var get = (KeyValuePair<int, string>)cboLabCategory.SelectedItem;
                var key = get.Key;
                if (key != 0) _keyCategory = key;
            }
            if (lbService.Text == @"MedicalImaging")
            {
                KeyService = @"MedicalImaging";
                var get = (KeyValuePair<int, string>)cboMedCategory.SelectedItem;
                var key = get.Key;
                if (key != 0) _keyCategory = key;
            }
            if (lbService.Text == @"Prescription")
            {
                KeyService = @"Prescription";
                var get = (KeyValuePair<int, string>)cboPreCategory.SelectedItem;
                var key = get.Key;
                if (key != 0) _keyCategory = key;
            }
            if (lbService.Text == @"VariousDocument"){
                KeyService = @"VariousDocument";
                var get = (KeyValuePair<int, string>)cboVarCategory.SelectedItem;
                var key = get.Key;
                if (key != 0) _keyCategory = key;
            }
        }

        private void btnNewConsultation_Click(object sender, EventArgs e)
        {
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            //_category=new ConsultationCategory();
            gboRefferAndNurse.Enabled = true;
            txtDescription.Text = "";
            txtDescription.EditMode = EditMode.Edit;
            txtDescription.Focus();
            NewMedical = true;
            saveToolStripMenuItem.Enabled = true;
            CheckService();
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
            //if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory),
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //    WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
            //}
            //else
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //}
        }

        private void btnNewLaboratory_Click(object sender, EventArgs e)
        {
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            //_category = new LaboratoryCategory();
            gboRefferAndNurse.Enabled = true;
            txtDescription.Text = "";
            txtDescription.EditMode = EditMode.Edit;
            txtDescription.Focus();
            NewMedical = true; 
            saveToolStripMenuItem.Enabled = true;
            CheckService();
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
            //if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory),
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //    WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
            //}
            //else
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //}
        }

        private void btnNewMedicalImaging_Click(object sender, EventArgs e)
        {
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            //_category = new MedicalImagingCategory();
            gboRefferAndNurse.Enabled = true;
            txtDescription.Text = "";
            txtDescription.EditMode = EditMode.Edit;
            txtDescription.Focus();
            NewMedical = true;
            saveToolStripMenuItem.Enabled = true;
            CheckService();
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());
            //if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory),
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //    WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
            //}
            //else
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //}
        }

        private void btnNewPresciption_Click(object sender, EventArgs e)
        {
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            //_category = new PrescriptionCategory();
            gboRefferAndNurse.Enabled = true;
            txtDescription.Text = "";
            txtDescription.EditMode = EditMode.Edit;
            txtDescription.Focus();
            NewMedical = true;
            saveToolStripMenuItem.Enabled = true;
            CheckService();
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this, new EventArgs());

            //if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory),
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //    WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
            //}
            //else
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //}
        }

        private void btnNewVarious_Click(object sender, EventArgs e)
        {
            var status = true;
            if (NewMedical || Editing)
            {
                var msg = MessageBox.Show(@"Are you sure want to leave this document? All text will be deleted.", @"Delete",
                    MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    status = false;
                }
            }
            if (!status) return;
            //_category = new VariousDocumentCategory();
            gboRefferAndNurse.Enabled = true;
            txtDescription.Text = "";
            txtDescription.EditMode = EditMode.Edit;
            txtDescription.Focus();
            NewMedical = true;
            saveToolStripMenuItem.Enabled = true;
            CheckService();
            if (picHideRight.Name == "picHideRight") picHideRight_Click(this,new EventArgs());

            //if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory),
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //    WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
            //}
            //else
            //{
            //    var form = new MedicalsForm
            //    {
            //        Account = Account,
            //        Patient = Patient,
            //        KeyCategory = _keyCategory,
            //        KeyService = KeyService,
            //        CatelogForm = CatelogForm,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    CatelogForm.pnlFill.Controls.Clear();
            //    CatelogForm.pnlFill.Controls.Add(form);
            //    form.Show();
            //}
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Patient == null)
            {
                MessageBox.Show(@"Patient is null.", @"Error");
            }
            if (Account == null)
            {
                MessageBox.Show(@"Doctor is null.", @"Error");
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show(@"Document is empty.", @"Empty Document");
            }
            if (cboReferrer.Text != "" && cboReferrer.SelectedItem != null&&chkBoxReferrer.Checked) _refName = cboReferrer.Text;
            else
            {
                string html;
                txtDescription.Save(out html, StringStreamType.HTMLFormat);
                txtDescription.Load(html, StringStreamType.HTMLFormat);
                //MessageBox.Show(html);
                var wv = new MedicalRecordWebViewer
                {
                    Html = html,
                    Patient = Patient,
                    Account = Account,
                    Refferrer = _refName
                };
                wv.ShowDialog();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || KeyService == null || _keyCategory == 0) return;
            string path;
            if (Directory.Exists(@"S:\"))
            {
                path = @"D:\ABC soft\";
            }
            else
            {
                path = _path;
            }
            var title = Patient.Id + DateTime.Today.Day +
                        DateTime.Today.Month + DateTime.Today.Year + DateTime.Now.Hour.ToString() +
                        DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
            if (NewMedical)
            {
                var form = new ServiceAndCategegorySelection
                {
                    HistoryForm = this,
                    Account = Account,
                    Service = KeyService,
                    Category = _keyCategory,
                    Ref = cboReferrer.Text,
                    Nur = cboNurse.Text
                };
                form.ShowDialog();
                if (KeyCategory == 0) return;
                _keyCategory = KeyCategory;
            }
            if (KeyService == @"Consultation")
            {
                _estimate = new ConsultationEstimate();
                if (NewMedical)
                {
                    _category=new ConsultationCategory();
                    if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
                    {
                        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
                    }
                    if (WaitingList != null)
                    {
                        _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                            Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\ConsultationEstimate\" + title);
                        _waitingList.DeleteConsultationWaitingList(WaitingList.Id, KeyCategory);
                    }
                    else
                    {
                        _estimate.Insert(null, null, Patient.Id, _keyCategory, Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\ConsultationEstimate\" + title);
                    }
                    txtDescription.Save(path + @"RTF\ConsultationEstimate\" + title,
                        StreamType.RichTextFormat);
                }
                else
                {
                    if (dgvConsultation.CurrentRow != null)
                    {
                        var id = Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value);
                        //int? refId = null;
                        //if (_estimate.GetRefferrerId(id)!="")
                        //{
                        //    refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                        //}
                        //int? nurId = null;
                        //if (_estimate.GetNurseId(id) != "")
                        //{
                        //    nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                        //}
                        var hisPath = _estimate.GetPath(id);
                        _estimate.Update(id, _keyCategory, Account.WorkerId, _keyReferrer, _keyReferrer, DateTime.Today, hisPath);

                        txtDescription.Save(hisPath, StreamType.RichTextFormat);
                    }   
                }                    
            }
            if (KeyService == @"Laboratory")
            {
                _estimate = new LaboratoryEstimate();
                if (NewMedical)
                {
                    _category = new LaboratoryCategory();
                    if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
                    {
                        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
                    }
                    if (WaitingList != null)
                    {
                        _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                            Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\LaboratoryEstimate\" + title);
                        _waitingList.DeleteLaboratoryWaitingList(WaitingList.Id, KeyCategory);
                    }
                    else
                    {
                        _estimate.Insert(null, null, Patient.Id, _keyCategory, Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\LaboratoryEstimate\" + title);
                    }
                    txtDescription.Save(
                        path + @"RTF\LaboratoryEstimate\" + title,
                        StreamType.RichTextFormat);
                }
                else
                {
                    if (dgvLaboratory.CurrentRow != null)
                    {
                        var id = Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[0].Value);
                        //int? refId = null;
                        //if (_estimate.GetRefferrerId(id) != "")
                        //{
                        //    refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                        //}
                        //int? nurId = null;
                        //if (_estimate.GetNurseId(id) != "")
                        //{
                        //    nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                        //}
                        var hisPath = _estimate.GetPath(id);
                        _estimate.Update(id, _keyCategory, Account.WorkerId, _keyReferrer, _keyReferrer, DateTime.Today, hisPath);

                        txtDescription.Save(hisPath, StreamType.RichTextFormat);
                    }
                }
            }
            if (KeyService == @"MedicalImaging")
            {
                _estimate = new MedicalImagingEstimate();
                if (NewMedical)
                {
                    _category = new MedicalImagingCategory();
                    if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
                    {
                        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
                    }
                    if (WaitingList != null)
                    {
                        _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                            Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\MedicalImagingEstimate\" + title);
                        _waitingList.DeleteMedicalImagingWatingList(WaitingList.Id, KeyCategory);
                    }
                    else
                    {
                        _estimate.Insert(null, null, Patient.Id, _keyCategory, Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\MedicalImagingEstimate\" + title);
                    }
                    txtDescription.Save(
                        path + @"RTF\MedicalImagingEstimate\" + title,
                        StreamType.RichTextFormat);
                }
                else
                {
                    if (dgvMedicalImaging.CurrentRow != null)
                    {
                        var id = Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[0].Value);
                        //int? refId = null;
                        //if (_estimate.GetRefferrerId(id) != "")
                        //{
                        //    refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                        //}
                        //int? nurId = null;
                        //if (_estimate.GetNurseId(id) != "")
                        //{
                        //    nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                        //}
                        var hisPath = _estimate.GetPath(id);
                        _estimate.Update(id, _keyCategory, Account.WorkerId, _keyReferrer, _keyReferrer, DateTime.Today, hisPath);

                        txtDescription.Save(hisPath, StreamType.RichTextFormat);
                    }
    
                }                    
            }
            if (KeyService == @"Prescription")
            {
                _estimate = new PrescriptionEstimate();
                if (NewMedical)
                {
                    _category = new PrescriptionCategory();
                    if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
                    {
                        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
                    }
                    if (WaitingList != null)
                    {
                        _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                            Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\PrescriptionEstimate\" + title);
                        _waitingList.DeletePrescriptionWatingList(WaitingList.Id, KeyCategory);
                    }
                    else
                    {
                        _estimate.Insert(null, null, Patient.Id, _keyCategory, Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\PrescriptionEstimate\" + title);
                    }
                    txtDescription.Save(
                        path + @"RTF\PrescriptionEstimate\" + title,
                        StreamType.RichTextFormat);
                }
                else
                {
                    if (dgvPrescription.CurrentRow != null)
                    {
                        var id = Convert.ToInt32(dgvPrescription.CurrentRow.Cells[0].Value);
                        //int? refId = null;
                        //if (_estimate.GetRefferrerId(id) != "")
                        //{
                        //    refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                        //}
                        //int? nurId = null;
                        //if (_estimate.GetNurseId(id) != "")
                        //{
                        //    nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                        //}
                        var hisPath = _estimate.GetPath(id);
                        _estimate.Update(id, _keyCategory, Account.WorkerId, _keyReferrer, _keyReferrer, DateTime.Today, hisPath);

                        txtDescription.Save(hisPath, StreamType.RichTextFormat);
                    }    
                }
            }
            if (KeyService == @"VariousDocument")
            {
                _estimate = new VariousDocumentEstimate();
                if (NewMedical)
                {
                    _category = new VariousDocumentCategory();
                    if (_category.CheckWaitingList(Patient.Id, _keyCategory) != null)
                    {
                        WaitingList = _category.CheckWaitingList(Patient.Id, _keyCategory);
                    }
                    if (WaitingList != null)
                    {
                        _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                            Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\VariousdocumentEstimate\" + title);
                        _waitingList.DeleteVariousDocumentWatingList(WaitingList.Id, KeyCategory);
                    }
                    else
                    {
                        _estimate.Insert(null, null, Patient.Id, _keyCategory, Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                            _path + @"RTF\VariousdocumentEstimate\" + title);
                    }
                    txtDescription.Save(
                        path + @"RTF\VariousdocumentEstimate\" + title,
                        StreamType.RichTextFormat);
                }
                else
                {
                    if (dgvVariousDocument.CurrentRow != null)
                    {
                        var id = Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[0].Value);
                        //int? refId = null;
                        //if (_estimate.GetRefferrerId(id) != "")
                        //{
                        //    refId = Convert.ToInt32(_estimate.GetRefferrerId(id));
                        //}
                        //int? nurId = null;
                        //if (_estimate.GetNurseId(id) != "")
                        //{
                        //    nurId = Convert.ToInt32(_estimate.GetNurseId(id));
                        //}
                        var hisPath = _estimate.GetPath(id);
                        _estimate.Update(id, _keyCategory, Account.WorkerId, _keyReferrer, _keyReferrer, DateTime.Today, hisPath);
                        txtDescription.Save(hisPath, StreamType.RichTextFormat);
                    }
                }
            }
            NewMedical = false;
            Editing = false;
            var messageDocument = "Do You Want to Print This Document or not...?";
            var titlesDocument = "Print Document";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(messageDocument, titlesDocument, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                printToolStripMenuItem_Click(this, new EventArgs());
            }
            if (WaitingList == null) return;
            CheckWaitingListDeleteOrUpdate();
            WaitingList = null;
        }
        private void CheckWaitingListDeleteOrUpdate()
        {
            if (_waitingList.CheckWaitingList(WaitingList.PatientId, WaitingList.Id))
            {
                //_waitingList.DeleteWaitingList(WaitingList.Id);
            }
            else
            {
                _waitingList.UpdatePatientStatus(WaitingList.Id, true);
            }
        }

        private void saveAsSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && KeyCategory != 0 && KeyService != "")
            {
                string path;
                if (Directory.Exists(@"S:\"))
                {
                    path = @"D:\ABC soft\";
                }
                else
                {
                    path = _path;
                }
                var form = new TitleInput() { HistoryForm = this };
                form.ShowDialog();
                if (Title != "")
                {
                    if (KeyService == @"Consultation")
                    {
                        _sample = new ConsultationSample();
                        _sample.Insert(Title, _path + @"RTF\ConsultationSample\" + Title, KeyCategory);
                        txtDescription.Save(path + @"RTF\ConsultationSample\" + Title, StreamType.RichTextFormat);
                    }
                    if (KeyService == @"Laboratory")
                    {
                        _sample = new LaboratorySample();
                        _sample.Insert(Title, _path + @"RTF\LaboratorySample\" + Title, KeyCategory);
                        txtDescription.Save(path + @"RTF\LaboratorySample\" + Title, StreamType.RichTextFormat);
                    }
                    if (KeyService == @"MedicalImaging")
                    {
                        _sample = new MedicalImagingSample();
                        _sample.Insert(Title, _path + @"RTF\MedicalImagingSample\" + Title, KeyCategory);
                        txtDescription.Save(path + @"RTF\MedicalImagingSample\" + Title, StreamType.RichTextFormat);
                    }
                    if (KeyService == @"Prescription")
                    {
                        _sample = new ConsultationSample();
                        _sample.Insert(Title, _path + @"RTF\PrescriptionSample\" + Title, KeyCategory);
                        txtDescription.Save(path + @"RTF\PrescriptionSample\" + Title, StreamType.RichTextFormat);
                    }
                    if (KeyService == @"VariousDocument")
                    {
                        _sample = new ConsultationSample();
                        _sample.Insert(Title, _path + @"RTF\VariousdocumentSample\" + Title, KeyCategory);
                        txtDescription.Save(path + @"RTF\VariousdocumentSample\" + Title, StreamType.RichTextFormat);
                    }
                    MessageBox.Show(@"Saved !!!", @"Save");
                }
                //else
                //{
                //    MessageBox.Show(@"Sample's Title is empty.", @"Empty Title");
                //}
            }
            else
            {
                MessageBox.Show(@"Document is empty.", @"Empty Document");
            }
        }

        private void samplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html;
            txtDescription.Save(out html, StringStreamType.HTMLFormat);
            txtDescription.Load(html, StringStreamType.HTMLFormat);
            var form = new SamplesDialogForm()
            {
                HistorysForm = this,
                CategoryId = KeyCategory,
                ServiceText = KeyService,
                Str = html,
                Dock = DockStyle.Fill,
                CatelogForm = CatelogForm,
                TopLevel = false
            };
            CatelogForm.pnlFill.Controls.Clear();
            CatelogForm.pnlFill.Controls.Add(form);
            form.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new RefferrerForm() {HistoryForm = this};
            form.ShowDialog();
        }

        private void btnInfoReferrer_Click(object sender, EventArgs e)
        {
            if (cboReferrer.SelectedItem == null) return;
            var selectedItem = (KeyValuePair<int, string>)cboReferrer.SelectedItem;
            var key = selectedItem.Key;
            var form = new RefferrerForm()
            {
                HistoryForm = this,
                Referrer = Refferrer.GetRefferrer(key)
            };
            form.ShowDialog();
        }

        private void chkBoxReferrer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxReferrer.Checked)
            {
                var dicReferrer = Medical.DicAllRefferer();
                if (dicReferrer.Count != 0)
                {
                    cboReferrer.DataSource = new BindingSource(dicReferrer, null);
                    cboReferrer.DisplayMember = "Value";
                    cboReferrer.ValueMember = "Key";
                    cboReferrer.SelectedIndex = 0;
                    cboReferrer.Enabled = true;
                }
            }
            else
            {
                cboReferrer.DataSource = null;
                cboReferrer.Items.Clear();
                cboReferrer.Enabled = false;
            }
        }

        private void chkBoxNurse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxNurse.Checked)
            {
                var dicNurse = Medical.ShowNurse();
                if (dicNurse.Count != 0)
                {
                    cboNurse.DataSource = new BindingSource(dicNurse, null);
                    cboNurse.DisplayMember = "Value";
                    cboNurse.ValueMember = "Key";
                    cboNurse.SelectedIndex = 0;
                    cboNurse.Enabled = true;
                }
            }
            else
            {
                cboNurse.DataSource = null;
                cboNurse.Items.Clear();
                cboNurse.Enabled = false;
            }
        }

        private void cboReferrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReferrer.DataSource == null||cboReferrer.SelectedItem == null)
            {
                _keyReferrer = null;
                return;
            }
            var get = (KeyValuePair<int, string>)cboReferrer.SelectedItem;
            _keyReferrer = get.Key;
        }

        private void cboNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNurse.DataSource == null||cboNurse.SelectedItem == null)
            {
                _keyReferrer = null;
                return;
            }
            var get = (KeyValuePair<int, string>)cboNurse.SelectedItem;
            _keyNurse = get.Key;
        }

        private void cboReferrer_TextUpdate(object sender, EventArgs e)
        {
            if (chkBoxReferrer.Checked)
            {
                var dicReferrer = Medical.SearchRefferer(cboReferrer.Text);
                var text = cboReferrer.Text;
                if (dicReferrer.Count == 0)
                {
                    cboReferrer.Text = text;
                    cboReferrer.Select(text.Length, 0);
                    _keyReferrer = null;
                    return;
                }
                cboReferrer.DataSource = new BindingSource(dicReferrer, null);
                cboReferrer.DisplayMember = "Value";
                cboReferrer.ValueMember = "Key";
                cboReferrer.Enabled = true;
                cboReferrer.SelectedIndex = -1;
                cboReferrer.Text = text;
                cboReferrer.Select(text.Length,0);
                if (cboReferrer.Focused) cboReferrer.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                cboReferrer.DataSource = null;
                cboReferrer.Items.Clear();
                cboReferrer.Enabled = false;
            }
        }

        private void cboNurse_TextUpdate(object sender, EventArgs e)
        {
            if (chkBoxNurse.Checked)
            {
                var dicNurse = Medical.SearchNurse(cboNurse.Text);
                var text = cboNurse.Text;
                if (dicNurse.Count == 0)
                {
                    cboNurse.Text = text;
                    cboNurse.Select(text.Length, 0);
                    _keyNurse = null;
                    return;
                }
                cboNurse.DataSource = new BindingSource(dicNurse, null);
                cboNurse.DisplayMember = "Value";
                cboNurse.ValueMember = "Key";
                cboNurse.Enabled = true;
                cboNurse.SelectedIndex = -1;
                cboNurse.Text = text;
                cboNurse.Select(text.Length,0);
                if (cboNurse.Focused) cboNurse.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                cboNurse.DataSource = null;
                cboNurse.Items.Clear();
                cboNurse.Enabled = false;
            }
        }

    }
}
