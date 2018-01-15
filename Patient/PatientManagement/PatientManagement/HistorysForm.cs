using System;
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
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;
        private readonly MedicalHistory _medicalHistory=new MedicalHistory();
        private IHistory _history;
        private int _keyCategory;
        private string _keyService;
        private string _path;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckOrderDgv()
        {
            dgvHistory.Columns[0].Visible = false;
            for (int i = 0; i <= dgvHistory.RowCount - 1; i++)
            {
                dgvHistory.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }
        private void HistorysForm_Shown(object sender, EventArgs e)
        {
            lbpName.Text =Patient.FirstName+@"   "+ Patient.LastName;
            lbpGender.Text = Patient.Gender;
            lbdName.Text =Account.Worker.FirstName+@"    "+ Account.Worker.LastName;
            AddNodesToTree();
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"C:\Users\Health\Desktop\Debug\";
            picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
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
        //        _category=new LaboratoryCategory();
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
            var form = new PatientForm {Patient = Patient};
            form.ShowDialog();
            Close();
        }

        //private void cboSelection_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboSelection.Text == @"Consultation")
        //    {
        //        _history=new ConsultationHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboSelection.Text == @"Laboratory")
        //    {
        //        _history = new LaboratoryHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboSelection.Text == @"MedicalImaging")
        //    {
        //        _history = new MedicalImagingHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboSelection.Text == @"Prescription")
        //    {
        //        _history = new PrescriptionHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboSelection.Text == @"VariousDocument")
        //    {
        //        _history = new VariousDocumentHistory();
        //        dgvHistory.DataSource = _history.Show(Patient.Id);
        //    }
        //    if (cboSelection.Text == @"Patient's History")
        //    {
        //        dgvHistory.DataSource = null;
        //        var getPath = _medicalHistory.Show_medicalhistory(Patient.Id);
        //        if(getPath!=null)txtDescription.Load(getPath.Description, StreamType.RichTextFormat);
        //    }
        //    if (dgvHistory.DataSource != null) { dgvHistory.Columns[0].Visible = false; CheckOrderDgv();}
        //}
        private void AddNodesToTree()
        {
            {
                _category = new ConsultationCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[1].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
            {
                _category = new LaboratoryCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[2].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
            {
                _category = new MedicalImagingCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[3].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
            {
                _category = new PrescriptionCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[4].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
            {
                _category = new VariousDocumentCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[5].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
        }

        private void treeSelection_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtDescription.Text = "";
            _keyService = "";
            if (e.Node.Name != "Consultation" && e.Node.Name != "Laboratory" && e.Node.Name != "MedicalImaging" &&
                e.Node.Name != "Prescription" && e.Node.Name != "VariousDocument" && e.Node.Name != "History")
            {
                if (e.Node.Parent.Name == "Consultation")
                {
                    _keyService = "Consultation";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                    lbService.Text = _keyService;
                    lbCategory.Text = e.Node.Text;
                    _history = new ConsultationHistory();
                    dgvHistory.DataSource = _history.Show(Patient.Id,_keyCategory);
                }
                if (e.Node.Parent.Name == "Laboratory")
                {
                    _keyService = "Laboratory";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                    lbService.Text = _keyService;
                    lbCategory.Text = e.Node.Text;
                    _history = new LaboratoryHistory();
                    dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
                }
                if (e.Node.Parent.Name == "MedicalImaging")
                {
                    _keyService = "MedicalImaging";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                    lbService.Text = _keyService;
                    lbCategory.Text = e.Node.Text;
                    _history = new MedicalImagingHistory();
                    dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
                }
                if (e.Node.Parent.Name == "Prescription")
                {
                    _keyService = "Prescription";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                    lbService.Text = _keyService;
                    lbCategory.Text = e.Node.Text;
                    _history = new PrescriptionHistory();
                    dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
                }
                if (e.Node.Parent.Name == "VariousDocument")
                {
                    _keyService = "VariousDocument";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                    lbService.Text = _keyService;
                    lbCategory.Text = e.Node.Text;
                    _history = new VariousDocumentHistory();
                    dgvHistory.DataSource = _history.Show(Patient.Id, _keyCategory);
                }
            }
            if (e.Node.Name == "History")
            {
                
            }
            if(dgvHistory.DataSource!=null)CheckOrderDgv();
        }

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
            if (dgvHistory.DataSource == null) return;
            if (lbService.Text == @"Consultation")
            {
                if (dgvHistory.CurrentRow != null)
                {
                    _history=new ConsultationHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvHistory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Laboratory")
            {
                if (dgvHistory.CurrentRow != null)
                {
                    _history=new LaboratoryHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvHistory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Medical Imaging")
            {
                if (dgvHistory.CurrentRow != null)
                {
                    _history=new MedicalImagingHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvHistory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Prescription")
            {
                if (dgvHistory.CurrentRow != null)
                {
                    _history=new PrescriptionHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvHistory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
            if (lbService.Text == @"Various Document")
            {
                if (dgvHistory.CurrentRow != null)
                {
                    _history=new VariousDocumentHistory();
                    txtDescription.Text = "";
                    txtDescription.Load(_history.GetPath(Convert.ToInt32(dgvHistory.CurrentRow.Cells[0].Value)),
                        StreamType.RichTextFormat);
                }
            }
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
    }
}
