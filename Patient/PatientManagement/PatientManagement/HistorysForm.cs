using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;

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
        internal CatelogForm CatelogForm;
        internal PatientListForm PatientListForm;
        internal MedicalsForm MedicalsForm;
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;
        //private readonly MedicalHistory _medicalHistory=new MedicalHistory();
        private IHistory _history;
        internal int KeyCategory;
        internal string KeyService;
        private string _path;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MedicalsForm != null)
            {
                MedicalsForm.Refresh();
                CatelogForm.pnlFill.Controls.Clear();
                CatelogForm.pnlFill.Controls.Add(MedicalsForm);
                MedicalsForm.Show();
            }
            if (PatientListForm != null)
            {
                PatientListForm.Refresh();
                CatelogForm.pnlFill.Controls.Clear();
                CatelogForm.pnlFill.Controls.Add(PatientListForm);
                PatientListForm.Show();
            }

            Close();
        }

        private static void CheckOrderDgv(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            for (var i = 0; i <= dgv.RowCount - 1; i++)
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
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
                }
                if (KeyService == "Laboratory")
                {
                    tabSelection.SelectedTab = tabLaboratory;
                    cboLabCategory.SelectedValue= KeyCategory;
                }
                if (KeyService == "MedicalImaging")
                {
                    tabSelection.SelectedTab = tabMedicalImaging;
                    cboMedCategory.SelectedValue = KeyCategory;
                }
                if (KeyService == "Prescription")
                {
                    tabSelection.SelectedTab = tabPrescription;
                    cboPreCategory.SelectedValue = KeyCategory;
                }
                if (KeyService == "VariousDocument")
                {
                    tabSelection.SelectedTab = tabVariousDocument;
                    cboVarCategory.SelectedValue = KeyCategory;
                }
            }
            //AddNodesToTree();
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"C:\Users\Health\Desktop\Debug\";
            //dgvConsultation.Columns.Clear();
            //dgvLaboratory.Columns.Clear();
            //dgvMedicalImaging.Columns.Clear();
            //dgvPrescription.Columns.Clear();
            //dgvVariousDocument.Columns.Clear();
            picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
            txtDescription.EditMode = EditMode.ReadAndSelect;
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
            txtDescription.Images.Add();
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

        private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvConsultation.DataSource == null) return;
            if (lbService.Text == @"Consultation")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history=new ConsultationHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Laboratory")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history=new LaboratoryHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Medical Imaging")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history=new MedicalImagingHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Prescription")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history=new PrescriptionHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Various Document")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history=new VariousDocumentHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

        private void InsertButtonEditAndNewForDoctor(DataGridView dgv)
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
                picHideTop.ImageLocation = _path + @"Hide-down-icon.png";
                pnlTitle.Visible = false;
                picHideTop.Click += picShowTop_Click;
            }
        }

        private void picShowTop_Click(object sender, EventArgs e)
        {
            if (picHideTop.Name == "picShowTop")
            {
                picHideTop.Name = "picHideTop";
                picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
                pnlTitle.Visible = true;
                picHideTop.Click -= picShowTop_Click;
            }
        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlShowHistory.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.ImageLocation = _path + @"Hide-Right-icon.png";
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
                KeyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboConCategory.Text;
                _history = new ConsultationHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, KeyCategory))
                {
                    dgvConsultation.DataSource = _history.Show(Patient.Id, KeyCategory);
                    InsertButtonEditAndNewForDoctor(dgvConsultation);
                }

                else
                {
                    dgvConsultation.DataSource = _history.Show(Patient.Id, KeyCategory);
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
                KeyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboConCategory.Text;
                _history = new LaboratoryHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, KeyCategory))
                {
                    dgvLaboratory.DataSource = _history.Show(Patient.Id, KeyCategory);
                    InsertButtonEditAndNewForDoctor(dgvLaboratory);
                }

                else
                {
                    dgvLaboratory.DataSource = _history.Show(Patient.Id, KeyCategory);
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
                KeyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboMedCategory.Text;
                _history = new MedicalImagingHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, KeyCategory))
                {
                    dgvMedicalImaging.DataSource = _history.Show(Patient.Id, KeyCategory);
                    InsertButtonEditAndNewForDoctor(dgvMedicalImaging);
                }

                else
                {
                    dgvMedicalImaging.DataSource = _history.Show(Patient.Id, KeyCategory);
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
                KeyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboPreCategory.Text;
                _history = new PrescriptionHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, KeyCategory))
                {
                    dgvPrescription.DataSource = _history.Show(Patient.Id, KeyCategory);
                    InsertButtonEditAndNewForDoctor(dgvPrescription);
                }

                else
                {
                    dgvPrescription.DataSource = _history.Show(Patient.Id, KeyCategory);
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
                KeyCategory = Convert.ToInt32(key);
                lbCategory.Text = cboVarCategory.Text;
                _history = new VariousDocumentHistory();
                if (_history.CheckDoctorCategory(Account.WorkerId, KeyCategory))
                {
                    dgvVariousDocument.DataSource = _history.Show(Patient.Id, KeyCategory);
                    InsertButtonEditAndNewForDoctor(dgvVariousDocument);
                }

                else
                {
                    dgvVariousDocument.DataSource = _history.Show(Patient.Id, KeyCategory);
                }
            } if (dgvVariousDocument.DataSource != null) CheckOrderDgv(dgvVariousDocument);
        }

        private void dgvVariousDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"VariousDocument";
            if (e.ColumnIndex.Equals(7))
            {
                if (dgvVariousDocument.DataSource != null)
                {
                    var form = new MedicalsForm
                    {
                        Worker = Account.Worker,
                        Account = Account,
                        Patient = Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyCategory = KeyCategory,
                        KeyService = KeyService
                    };
                    dgvVariousDocument.SelectionChanged -= dgvVariousDocument_SelectionChanged;
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
            if (e.ColumnIndex.Equals(8))
            {
                txtDescription.EditMode = txtDescription.EditMode == EditMode.Edit ? EditMode.ReadAndSelect : EditMode.Edit;
            }
        }

        private void dgvPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Prescription";
            if (e.ColumnIndex.Equals(7))
            {
                if (dgvPrescription.DataSource != null)
                {
                    var form = new MedicalsForm
                    {
                        Worker = Account.Worker,
                        Account = Account,
                        Patient = Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyCategory = KeyCategory,
                        KeyService = KeyService
                    };
                    dgvPrescription.SelectionChanged -= dgvPrescription_SelectionChanged;
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
            if (e.ColumnIndex.Equals(8))
            {
                txtDescription.EditMode = txtDescription.EditMode == EditMode.Edit ? EditMode.ReadAndSelect : EditMode.Edit;
            }
        }

        private void dgvVariousDocument_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvVariousDocument.DataSource == null) return;
            if (lbService.Text == @"VariousDocument")
            {
                if (dgvVariousDocument.CurrentRow != null)
                {
                    _history = new VariousDocumentHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvVariousDocument.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

        private void tabSelection_Selected(object sender, TabControlEventArgs e)
        {
            if (tabSelection.SelectedTab.Text == @"Consultation")
            {
                lbService.Text = @"Consultation";
            }
            if (tabSelection.SelectedTab.Text == @"Laboratory")
            {
                lbService.Text = @"Laboratory";
            }
            if (tabSelection.SelectedTab.Text == @"MedicalImaging")
            {
                lbService.Text = @"MedicalImaging";
            }
            if (tabSelection.SelectedTab.Text == @"Prescription")
            {
                lbService.Text = @"Prescription";
            }
            if (tabSelection.SelectedTab.Text == @"VariousDocument")
            {
                lbService.Text = @"VariousDocument";
            }
        }

        private void dgvPrescription_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvPrescription.DataSource == null) return;
            if (lbService.Text == @"Prescription")
            {
                if (dgvPrescription.CurrentRow != null)
                {
                    _history = new PrescriptionHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvPrescription.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

        private void dgvMedicalImaging_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"MedicalImaging";
            if (e.ColumnIndex.Equals(7))
            {
                if (dgvMedicalImaging.DataSource != null)
                {
                    var form = new MedicalsForm
                    {
                        Worker = Account.Worker,
                        Account = Account,
                        Patient = Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyCategory = KeyCategory,
                        KeyService = KeyService
                    };
                    dgvMedicalImaging.SelectionChanged -= dgvMedicalImaging_SelectionChanged;
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
            if (e.ColumnIndex.Equals(8))
            {
                txtDescription.EditMode = txtDescription.EditMode == EditMode.Edit ? EditMode.ReadAndSelect : EditMode.Edit;
            }
        }

        private void dgvMedicalImaging_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvMedicalImaging.DataSource == null) return;
            if (lbService.Text == @"MedicalImaging")
            {
                if (dgvMedicalImaging.CurrentRow != null)
                {
                    _history = new MedicalImagingHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvMedicalImaging.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

        private void dgvLaboratory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Laboratory";
            if (e.ColumnIndex.Equals(7))
            {
                if (dgvLaboratory.DataSource != null)
                {
                    var form = new MedicalsForm
                    {
                        Worker = Account.Worker,
                        Account = Account,
                        Patient = Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyCategory = KeyCategory,
                        KeyService = KeyService
                    };
                    dgvLaboratory.SelectionChanged -= dgvLaboratory_SelectionChanged;
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
            if (e.ColumnIndex.Equals(8))
            {
                txtDescription.EditMode = txtDescription.EditMode == EditMode.Edit ? EditMode.ReadAndSelect : EditMode.Edit;
            }
        }

        private void dgvLaboratory_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvLaboratory.DataSource == null) return;
            if (lbService.Text == @"Laboratory")
            {
                if (dgvLaboratory.CurrentRow != null)
                {
                    _history = new LaboratoryHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

        private void dgvConsultation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KeyService = @"Consultation";
            if (e.ColumnIndex.Equals(7))
            {
                if (dgvConsultation.DataSource != null)
                {
                    var form = new MedicalsForm
                    {
                        Worker = Account.Worker,
                        Account = Account,
                        Patient = Patient,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        KeyCategory = KeyCategory,
                        KeyService = KeyService
                    };
                    dgvConsultation.SelectionChanged -= dgvConsultation_SelectionChanged;
                    CatelogForm.pnlFill.Controls.Clear();
                    CatelogForm.pnlFill.Controls.Add(form);
                    form.Show();
                    Close();
                }
            }
            if (e.ColumnIndex.Equals(8))
            {
                txtDescription.EditMode = txtDescription.EditMode == EditMode.Edit ? EditMode.ReadAndSelect : EditMode.Edit;
            }
        }

        private void dgvConsultation_SelectionChanged(object sender, EventArgs e)
        {
            txtDescription.EditMode = EditMode.ReadAndSelect;
            if (dgvConsultation.DataSource == null) return;
            if (lbService.Text == @"Consultation")
            {
                if (dgvConsultation.CurrentRow != null)
                {
                    _history = new ConsultationHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvConsultation.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
        }

    }
}
