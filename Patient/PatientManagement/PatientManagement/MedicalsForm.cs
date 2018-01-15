using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Account = Hospital_Entity_Framework.Account;
using ConsultationCategory = PatientManagement.Class.ConsultationCategory;
using Form = System.Windows.Forms.Form;
using LaboratoryCategory = PatientManagement.Class.LaboratoryCategory;
using Patient = Hospital_Entity_Framework.Patient;
using WaitingList = Hospital_Entity_Framework.WaitingList;
using Worker = Hospital_Entity_Framework.Worker;

namespace PatientManagement
{
    public partial class MedicalsForm : Form
    {
        public MedicalsForm()
        {
            InitializeComponent();
        }

        private string _path;
        internal Account Account;
        internal Patient Patient;
        internal Worker Worker;
        private readonly Class.WaitingList _waitingList = new Class.WaitingList();
        internal WaitingList WaitingList;
        private ICategory _category;
        internal MedicalRecord Medical = new MedicalRecord();
        private int _indexCategory;
        private int _keyCategory;
        private string _keyService;
        private int? _keyNurse;

        private int? _keyReferrer;

        //private bool? _status;
        private readonly Dating _dating = new Dating();

        internal Refferrer Refferrer = new Refferrer();
        private IEstimate _estimate;

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html;
            txtDescription.Save(out html, StringStreamType.HTMLFormat);
            txtDescription.Load(html, StringStreamType.HTMLFormat);


            var form = new SamplesDialogForm()
            {
                MedicalsForm = this,
                CategoryId = _indexCategory,
                ServiceText = cboService.Text,
                Str = html
            };
            form.ShowDialog();
        }

        //C:\Users\Health\Desktop\Debug

        private void MedicalsForm_Shown(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            _path = path.Remove(path.Length - 46);
            //_path = path;
            //_path = @"C:\Users\Health\Desktop\Debug\";
            picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
            picHideTop.ImageLocation = _path + @"Hide-Up-icon.png";
            picHideLeft.ImageLocation = _path + @"Hide-left-icon.png";
            txtNameDoctor.Text = Account.Worker.LastName;
            txtDescription.ForeColor = Color.Black;
            AddNodesToTree();
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
                pnlButton.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
                pnlButton.Visible = true;
                picHideRight.Click -= picShowRight_Click;
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            var form = new SearchPatient() {MedicalsForm = this};
            form.ShowDialog();
            if (Patient != null)
            {
                txtNamePatient.Text = Patient.LastName;
                txtGenderPatient.Text = Patient.Gender;
                if (btnPatient.Name == "btnPatient")
                {
                    btnPatient.Name = "btnInfoPatient";
                    btnPatient.Text = @"ប្រវត្តិ អ្នកជម្ងឺ";
                    btnPatient.Click += btnInfoPatient_Click;
                    btnPatient.Click -= btnPatient_Click;
                }
            }
        }

        private void btnInfoPatient_Click(object sender, EventArgs e)
        {
            if (btnPatient.Name == "btnInfoPatient")
            {
                var form = new HistorysForm() {Account = Account, Patient = Patient};
                form.ShowDialog();
            }
        }

        private void btnDating_Click(object sender, EventArgs e)
        {
            var datinglistform = new DatingListForm
            {
                Worker = Account.Worker,
                Patient = Patient
            };
            datinglistform.ShowDialog();
        }

        private void btmWaitingList_Click(object sender, EventArgs e)
        {
            //if (cboCategory.SelectedItem == null) return;
            //var selectedItem = (KeyValuePair<int, string>) cboCategory.SelectedItem;
            //var keyService = selectedItem.Key;

            var waitinglistform = new WaitingListForm
            {
                Service = _keyService,
                GetStaffCategoryid = _keyCategory,
                Worker = Account.Worker,
                Account = Account,
                Medicalsform = this
            };
            waitinglistform.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = WaitingList.PatientId + DateTime.Today.Day +
                        DateTime.Today.Month + DateTime.Today.Year + DateTime.Now.Hour.ToString() +
                        DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
            if (_keyService == @"Consultation")
            {
                _estimate = new ConsultationEstimate();
                _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                    Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                    _path + @"RTF\ConsultationEstimate\" +title);
                txtDescription.Save(
                    _path + @"RTF\ConsultationEstimate\" + title,
                    StreamType.RichTextFormat);
                _waitingList.DeleteConsultationWaitingList(WaitingList.Id, _keyCategory);
            }
            if (_keyService == @"Laboratory")
            {
                _estimate = new LaboratoryEstimate();
                _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                    Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                    _path + @"RTF\LaboratoryEstimate\" + title);
                txtDescription.Save(
                    _path + @"RTF\LaboratoryEstimate\" + title,
                    StreamType.RichTextFormat);
                _waitingList.DeleteLaboratoryWaitingList(WaitingList.Id, _keyCategory);
            }
            if (_keyService == @"Medical Imaging")
            {
                _estimate = new MedicalImagingEstimate();
                _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                    Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                    _path + @"RTF\MedicalImagingEstimate\" + title);
                txtDescription.Save(
                    _path + @"RTF\MedicalImagingEstimate\" +title,
                    StreamType.RichTextFormat);
                _waitingList.DeleteMedicalImagingWatingList(WaitingList.Id, _keyCategory);
            }
            if (_keyService == @"Prescription")
            {
                _estimate = new PrescriptionEstimate();
                _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                    Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                    _path + @"RTF\PrescriptionEstimate\" +title);
                txtDescription.Save(
                    _path + @"RTF\PrescriptionEstimate\" + title,
                    StreamType.RichTextFormat);
                _waitingList.DeletePrescriptionWatingList(WaitingList.Id, _keyCategory);
            }
            if (_keyService == @"Various Document")
            {
                _estimate = new VariousDocumentEstimate();
                _estimate.Insert(WaitingList.VisitId, WaitingList.VisitCount, WaitingList.PatientId, _keyCategory,
                    Account.WorkerId, _keyNurse, _keyReferrer, DateTime.Today,
                    _path + @"RTF\VariousdocumentEstimate\" + title);
                txtDescription.Save(
                    _path + @"RTF\VariousdocumentEstimate\" +title,
                    StreamType.RichTextFormat);
                _waitingList.DeleteVariousDocumentWatingList(WaitingList.Id, _keyCategory);
            }
            CheckWaitingListDeleteOrUpdate();
            Clear();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _category = new ConsultationCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Laboratory")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = null;
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
                _category = new MedicalImagingCategory();
                cboCategory.DataSource = null;
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
                _category = new PrescriptionCategory();
                cboCategory.DataSource = null;
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
                _category = new VariousDocumentCategory();
                cboCategory.DataSource = null;
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
        }

        internal void chkBoxReferrer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxReferrer.Checked)
            {
                var dicReferrer = Medical.ShowReferrer();
                if (dicReferrer.Count != 0)
                {
                    cboReferrer.DataSource = new BindingSource(dicReferrer, null);
                    cboReferrer.DisplayMember = "Value";
                    cboReferrer.ValueMember = "Key";
                }
            }
            else
            {
                cboReferrer.DataSource = null;
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
                }
            }
            else
            {
                cboNurse.DataSource = null;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.DataSource == null) return;

            var selectedItem = cboCategory.SelectedIndex;
            _indexCategory = selectedItem;
            var selectkey = (KeyValuePair<int, string>) cboCategory.SelectedItem;
            _keyCategory = selectkey.Key;
        }

        private void picAddDate_Click(object sender, EventArgs e)
        {
            if (Patient != null)
            {
                _dating.Insert(Patient.Id, Account.Worker.Id, dtpDate.Value);
                MessageBox.Show(@"Dating is Complect....");
            }
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

        private void btnInfoReferrer_Click(object sender, EventArgs e)
        {
            if (cboReferrer.SelectedItem == null) return;
            var selectedItem = (KeyValuePair<int, string>) cboReferrer.SelectedItem;
            var keyCategory = selectedItem.Key;
            var form = new RefferrerForm()
            {
                MedicalForm = this,
                Referrer = Refferrer.GetRefferrer(keyCategory)
            };
            form.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new RefferrerForm() {MedicalForm = this};
            form.ShowDialog();
        }

        private void CheckWaitingListDeleteOrUpdate()
        {
            if (_waitingList.CheckWaitingList(WaitingList.PatientId, WaitingList.Id))
            {
                _waitingList.DeleteWaitingList(WaitingList.Id);
            }
            else
            {
                _waitingList.UpdatePatientStatus(WaitingList.Id, true);
            }
        }

        private void Clear()
        {
            WaitingList = null;
            Patient = null;

            txtNamePatient.Text = "";
            txtGenderPatient.Text = "";
            if (btnPatient.Name == "btnInfoPatient")
            {
                btnPatient.Name = "btnPatient";
                btnPatient.Text = @"ជ្រើស អ្នកជម្ងឺថ្មី";
                btnPatient.Click -= btnInfoPatient_Click;
                btnPatient.Click += btnPatient_Click;
            }
            chkBoxNurse.Checked = false;
            chkBoxReferrer.Checked = false;
            txtDescription.Text = "";
        }

        private void cboNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNurse.DataSource == null)
            {
                _keyNurse = null;
                return;
            }

            var selectedItem = cboNurse.SelectedIndex;
            _keyNurse = selectedItem;
        }

        private void cboReferrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReferrer.DataSource == null)
            {
                _keyReferrer = null;
                return;
            }

            var selectedItem = cboReferrer.SelectedIndex;
            _keyReferrer = selectedItem;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void picHideLeft_Click(object sender, EventArgs e)
        {
            if (picHideLeft.Name == "picHideLeft")
            {
                picHideLeft.Name = "picShowLeft";
                picHideLeft.ImageLocation = _path + @"Hide-right-icon.png";
                pnlHideLeft.Visible = false;
                picHideLeft.Click += picShowLeft_Click;
            }
        }

        private void picShowLeft_Click(object sender, EventArgs e)
        {
            if (picHideLeft.Name == "picShowLeft")
            {
                picHideLeft.Name = "picHideLeft";
                picHideLeft.ImageLocation = _path + @"Hide-left-icon.png";
                pnlHideLeft.Visible = true;
                picHideLeft.Click -= picShowLeft_Click;
            }
        }

        private void treeSelection_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _keyService = "";
            if (e.Node.Name != "Consultation" && e.Node.Name != "Laboratory" && e.Node.Name != "MedicalImaging" &&
                e.Node.Name != "Prescription" && e.Node.Name != "VariousDocument")
            {
                if (e.Node.Parent.Name == "Consultation")
                {
                    _keyService = "Consultation";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                }
                if (e.Node.Parent.Name == "Laboratory")
                {
                    _keyService = "Laboratory";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                }
                if (e.Node.Parent.Name == "MedicalImaging")
                {
                    _keyService = "MedicalImaging";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                }
                if (e.Node.Parent.Name == "Prescription")
                {
                    _keyService = "Prescription";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                }
                if (e.Node.Parent.Name == "VariousDocument")
                {
                    _keyService = "VariousDocuemtn";
                    _keyCategory = Convert.ToInt32(e.Node.TreeView.SelectedNode.Name);
                }
            }

        }

        private void AddNodesToTree()
        {
            {
                _category = new ConsultationCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    foreach (var item in dic)
                    {
                        treeSelection.Nodes[0].Nodes.Add(item.Key.ToString(),item.Value);
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
                        treeSelection.Nodes[1].Nodes.Add(item.Key.ToString(), item.Value);
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
                        treeSelection.Nodes[2].Nodes.Add(item.Key.ToString(), item.Value);
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
                        treeSelection.Nodes[3].Nodes.Add(item.Key.ToString(), item.Value);
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
                        treeSelection.Nodes[4].Nodes.Add(item.Key.ToString(), item.Value);
                    }
                }
            }
        }

    }
}
