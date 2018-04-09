using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using ReportClass = PatientManagement.Class.ReportClass;

namespace PatientManagement
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private readonly ReportClass _report=new ReportClass();
        private ICategory _category;
        private bool _chkService;
        private bool _chkCategory;
        private bool _chkDoctor;
        private bool _chkNurse;
        private bool _chkRefferrer;
        private bool _chkPatient;


        private void CheckOrderDgv()
        {
            for (var i = 0; i <= dgvListWorker.RowCount - 1; i++)
            {
                dgvListWorker.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkService.Checked || chkDoctor.Checked || chkNurse.Checked || chkRefferrer.Checked ||
                chkPatient.Checked)
            {
                dgvListWorker.DataSource = _report.Searching(dtpFrom.Value.Date, dtpTo.Value.Date, cboService.Text,
                    cboCategory.Text, cboDoctor.Text,
                    cboNurse.Text, cboRefferrer.Text, cboPatient.Text);
            }
            else
            {
                dgvListWorker.DataSource = _report.ShowAll(dtpFrom.Value.Date, dtpTo.Value.Date);
            }

            if (dgvListWorker.DataSource != null)
            {
                dgvListWorker.Columns[0].DefaultCellStyle.Format = @"dd/MM/yyyy";
                dgvListWorker.ClearSelection();
                dgvListWorker.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                CheckOrderDgv();
                dgvListWorker.ColumnHeadersDefaultCellStyle.Font = new Font(@"Arial", 18, FontStyle.Bold);
                dgvListWorker.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Report_Shown(object sender, EventArgs e)
        {
            cboService.Enabled = false;
            chkService.Checked = false;
            cboCategory.Enabled = false;
            chkCategory.Checked = false;
            chkCategory.Enabled = false;
            cboDoctor.Enabled = false;
            chkDoctor.Checked = false;
            cboNurse.Enabled = false;
            chkNurse.Checked = false;
            cboRefferrer.Enabled = false;
            chkRefferrer.Checked = false;
            cboPatient.Enabled = false;
            chkPatient.Checked = false;

            dtpFrom.CustomFormat = @"dd/MM/yyyy";
            dtpTo.CustomFormat = @"dd/MM/yyyy";

            picHideRight.Image = Properties.Resources.Hide_right_icon;

        }

        private void picHideRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picHideRight")
            {
                picHideRight.Name = "picShowRight";
                picHideRight.Image = Properties.Resources.Hide_left_icon;
                //picHideRight.ImageLocation = _path + @"Hide-Left-icon.png";
                pnlOperate.Visible = false;
                picHideRight.Click += picShowRight_Click;
            }
        }

        private void picShowRight_Click(object sender, EventArgs e)
        {
            if (picHideRight.Name == "picShowRight")
            {
                picHideRight.Name = "picHideRight";
                picHideRight.Image = Properties.Resources.Hide_right_icon;
                //picHideRight.ImageLocation = _path + @"Hide-right-icon.png";
                pnlOperate.Visible = true;
                picHideRight.Click -= picShowRight_Click;
            }
        }

        private void chkService_CheckedChanged(object sender, EventArgs e)
        {
            if (chkService.Checked)
            {
                cboService.Enabled = true;
                cboService.SelectedIndex = 0;
                chkCategory.Enabled = true;
                _chkService = true;
            }
            else
            {
                _chkService = false;
                _chkCategory = false;
                cboService.Enabled = false;
                chkCategory.Checked = false;
                chkCategory.Enabled = false;
                cboCategory.Text = "";
                cboCategory.Enabled = false;
                cboService.SelectedItem = null;
            }
        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategory.Checked)
            {
                cboCategory.DataSource = null;
                cboCategory.Items.Clear();
                if (cboService.SelectedIndex == 0)
                {
                    _category = new ConsultationCategory();
                    var dic = _category.ShowCategoryName();
                    if (dic.Count != 0)
                    {
                        cboCategory.DataSource = new BindingSource(dic, null);
                        cboCategory.DisplayMember = "Value";
                        cboCategory.ValueMember = "Key";
                        cboCategory.SelectedIndex = 0;
                        _chkCategory = true;
                    }
                }
                if (cboService.SelectedIndex == 1)
                {
                    _category = new LaboratoryCategory();
                    var dic = _category.ShowCategoryName();
                    if (dic.Count != 0)
                    {
                        cboCategory.DataSource = new BindingSource(dic, null);
                        cboCategory.DisplayMember = "Value";
                        cboCategory.ValueMember = "Key";
                        cboCategory.SelectedIndex = 0;
                        _chkCategory = true;
                    }
                }
                if (cboService.SelectedIndex == 2)
                {
                    _category = new MedicalImagingCategory();
                    var dic = _category.ShowCategoryName();
                    if (dic.Count != 0)
                    {
                        cboCategory.DataSource = new BindingSource(dic, null);
                        cboCategory.DisplayMember = "Value";
                        cboCategory.ValueMember = "Key";
                        cboCategory.SelectedIndex = 0;
                        _chkCategory = true;
                    }
                }
                if (cboService.SelectedIndex == 3)
                {
                    _category = new PrescriptionCategory();
                    var dic = _category.ShowCategoryName();
                    if (dic.Count != 0)
                    {
                        cboCategory.DataSource = new BindingSource(dic, null);
                        cboCategory.DisplayMember = "Value";
                        cboCategory.ValueMember = "Key";
                        cboCategory.SelectedIndex = 0;
                        _chkCategory = true;
                    }
                }
                if (cboService.SelectedIndex == 4)
                {
                    _category = new VariousDocumentCategory();
                    var dic = _category.ShowCategoryName();
                    if (dic.Count != 0)
                    {
                        cboCategory.DataSource = new BindingSource(dic, null);
                        cboCategory.DisplayMember = "Value";
                        cboCategory.ValueMember = "Key";
                        cboCategory.SelectedIndex = 0;
                        _chkCategory = true;                    }
                }
                cboCategory.Enabled = true;
            }
            else
            {
                _chkCategory = false;
                cboCategory.Enabled = false;
                cboCategory.DataSource = null;
                cboCategory.Items.Clear();
            }
        }

        private void chkDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoctor.Checked)
            {
                cboDoctor.Enabled = true;
                cboDoctor.DataSource = null;
                cboDoctor.Items.Clear();
                var dic = _report.ListsDoctor();
                if (dic.Count != 0)
                {
                    cboDoctor.DataSource = new BindingSource(dic, null);
                    cboDoctor.DisplayMember = "Value";
                    cboDoctor.ValueMember = "Key";
                    cboDoctor.SelectedIndex = 0;
                    _chkDoctor = true;
                }
            }
            else
            {
                _chkDoctor = false;
                cboDoctor.Enabled = false;
                cboDoctor.DataSource = null;
                cboDoctor.Items.Clear();
            }
        }

        private void chkNurse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNurse.Checked)
            {
                cboNurse.Enabled = true;
                cboNurse.DataSource = null;
                cboNurse.Items.Clear();
                var dic = _report.ListNurse();
                if (dic.Count != 0)
                {
                    cboNurse.DataSource = new BindingSource(dic, null);
                    cboNurse.DisplayMember = "Value";
                    cboNurse.ValueMember = "Key";
                    cboNurse.SelectedIndex = 0;
                    _chkNurse = true;
                }
            }
            else
            {
                _chkNurse = false;
                cboNurse.Enabled = false;
                cboNurse.DataSource = null;
                cboNurse.Items.Clear();
            }
        }

        private void chkRefferrer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRefferrer.Checked)
            {
                cboRefferrer.Enabled = true;
                cboRefferrer.DataSource = null;
                cboRefferrer.Items.Clear();
                var dic = _report.ListRefferrer();
                if (dic.Count != 0)
                {
                    cboRefferrer.DataSource = new BindingSource(dic, null);
                    cboRefferrer.DisplayMember = "Value";
                    cboRefferrer.ValueMember = "Key";
                    cboRefferrer.SelectedIndex = 0;
                    _chkRefferrer = true;
                }
            }
            else
            {
                _chkRefferrer = false;
                cboRefferrer.Enabled = false;
                cboRefferrer.DataSource = null;
                cboRefferrer.Items.Clear();
            }
        }

        private void chkPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPatient.Checked)
            {
                cboPatient.Enabled = true;
                cboPatient.DataSource = null;
                cboPatient.Items.Clear();
                var dic = _report.ListPatient();
                if (dic.Count != 0)
                {
                    cboPatient.DataSource = new BindingSource(dic, null);
                    cboPatient.DisplayMember = "Value";
                    cboPatient.ValueMember = "Key";
                    cboPatient.SelectedIndex = 0;
                    _chkPatient = true;
                }
            }
            else
            {
                _chkPatient = false;
                cboPatient.Enabled = false;
                cboPatient.DataSource = null;
                cboPatient.Items.Clear();
            }
        }

        private void cboNurse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkNurse) return;
            var index = cboNurse.FindString(cboNurse.Text);
            cboNurse.SelectedIndex = index;
        }

        private void cboService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkService) return;
            var index = cboService.FindString(cboService.Text);
            cboService.SelectedIndex = index;
        }

        private void cboCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkCategory) return;
            var index = cboCategory.FindString(cboCategory.Text);
            cboCategory.SelectedIndex = index;
        }

        private void cboDoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkDoctor) return;
            var index = cboDoctor.FindString(cboDoctor.Text);
            cboDoctor.SelectedIndex = index;
        }

        private void cboPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkPatient) return;
            var index = cboPatient.FindString(cboPatient.Text);
            cboPatient.SelectedIndex = index;
        }

        private void cboRefferrer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!_chkRefferrer) return;
            var index = cboRefferrer.FindString(cboRefferrer.Text);
            cboRefferrer.SelectedIndex = index;
        }
    }
}
