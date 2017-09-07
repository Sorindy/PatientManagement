using System;
using System.Windows.Forms;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        //public Consultation_sCategory Cc = new Consultation_sCategory();
        //public Prescription_sCategory Pc = new Prescription_sCategory();
        //public VariousDocument_sCategory Vc = new VariousDocument_sCategory();
        //public MedicalImaging_sCategory Mc = new MedicalImaging_sCategory();
        //public Laboratory_sCategory Lc = new Laboratory_sCategory();

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    Refresh();
        //    Close();
        //}

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    Clear_Control();
        //    Refresh();
        //}

        //public void Clear_Control()
        //{
        //    cmbType.Text = cmbType.GetItemText("Consultation");
        //    txtId.Text = "";
        //    txtName.Text = "";
        //    btnNew.Visible = true;
        //    dtgInformation.DataSource = null;
        //    Refresh();
        //}

        //private void CategoryForm_Load(object sender, EventArgs e)
        //{
        //    cmbType.Text = cmbType.GetItemText("Consultation");
        //}

        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    // if (cmbType.Text == "Consultation")
        //    if (cmbType.SelectedIndex.Equals(0))
        //    {
        //        Cc.Insert_Consultation_Category(txtId.Text, txtName.Text);
        //    }
        //    //  if (cmbType.Text == "Prescription")
        //    if (cmbType.SelectedIndex.Equals(1))
        //    {
        //        Pc.Insert_Prescription_Category(txtId.Text, txtName.Text);
        //    }
        //    //if (cmbType.Text == "MedicalImaging")
        //    if (cmbType.SelectedIndex.Equals(2))
        //    {
        //        Mc.Insert_MedicalImaging_Category(txtId.Text, txtName.Text);
        //    }
        //    // if (cmbType.Text == "Laboratory")
        //    if (cmbType.SelectedIndex.Equals(3))
        //    {
        //        Lc.Insert_Laboratory_Category(txtId.Text, txtName.Text);
        //    }
        //    //   if (cmbType.Text == "VariousDocument")
        //    if (cmbType.SelectedIndex.Equals(4))
        //    {
        //        Vc.Insert_VariousDocument_Category(txtId.Text, txtName.Text);
        //    }
        //    Clear_Control();
        //    btnInsert.Visible = false;
        //    btnNew.Visible = true;
        //    Refresh();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //if (cmbType.Text == "Consultation")
        //    if (cmbType.SelectedIndex.Equals(0))
        //    {
        //        Cc.Update_Consultation_Category(txtId.Text, txtName.Text);
        //    }
        //    //if (cmbType.Text == "Prescription")
        //    if (cmbType.SelectedIndex.Equals(1))
        //    {
        //        Pc.Update_Prescription_Category(txtId.Text, txtName.Text);
        //    }
        //    //if (cmbType.Text == "MedicalImaging")
        //    if (cmbType.SelectedIndex.Equals(2))
        //    {
        //        Mc.Update_MedicalImaging_Category(txtId.Text, txtName.Text);
        //    }
        //    //if (cmbType.Text == "Laboratory")
        //    if (cmbType.SelectedIndex.Equals(3))
        //    {
        //        Lc.Update_Laboratory_Category(txtId.Text, txtName.Text);
        //    }
        //    //if (cmbType.Text == "VariousDocument")
        //    if (cmbType.SelectedIndex.Equals(4))
        //    {
        //        Vc.Update_VariousDocument_Category(txtId.Text, txtName.Text);
        //    }
        //    Refresh();
        //}

        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    //if (cmbType.Text == "Consultation")
        //    if (cmbType.SelectedIndex.Equals(0))
        //    {
        //        dtgInformation.DataSource = Cc.Show_Consultation_Category();
        //    }
        //    //if (cmbType.Text == "Prescription")
        //    if (cmbType.SelectedIndex.Equals(1))
        //    {
        //        dtgInformation.DataSource = Pc.Show_Prescription_Category();
        //    }
        //    //if (cmbType.Text == "MedicalImaging")
        //    if (cmbType.SelectedIndex.Equals(2))
        //    {
        //        dtgInformation.DataSource = Mc.Show_MedicalImaging_Category();
        //    }
        //    //if (cmbType.Text == "Laboratory")
        //    if (cmbType.SelectedIndex.Equals(3))
        //    {
        //        dtgInformation.DataSource = Lc.Show_Laboratory_Category();
        //    }
        //    //if (cmbType.Text == "VariousDocument")
        //    if (cmbType.SelectedIndex.Equals(4))
        //    {
        //        dtgInformation.DataSource = Vc.Show_VariousDocument_Category();
        //    }
        //    Refresh();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    //if (cmbType.Text == "Consultation")
        //    if (cmbType.SelectedIndex.Equals(0))
        //    {
        //        Cc.Delete_Consultation_Category(txtId.Text);
        //    }
        //    //if (cmbType.Text == "Prescription")
        //    if (cmbType.SelectedIndex.Equals(1))
        //    {
        //        Pc.Delete_Prescription_Category(txtId.Text);
        //    }
        //    //if (cmbType.Text == "MedicalImaging")
        //    if (cmbType.SelectedIndex.Equals(2))
        //    {
        //        Mc.Delete_MedicalImaging_Category(txtId.Text);
        //    }
        //    //if (cmbType.Text == "Laboratory")
        //    if (cmbType.SelectedIndex.Equals(3))
        //    {
        //        Lc.Delete_Laboratory_Category(txtId.Text);
        //    }
        //    //if (cmbType.Text == "VariousDocument")
        //    if (cmbType.SelectedIndex.Equals(4))
        //    {
        //        Vc.Delete_VariousDocument_Category(txtId.Text);
        //    }
        //    Refresh();
        //}

        //private void btnNew_Click(object sender, EventArgs e)
        //{
        //    //if (cmbType.Text == "Consultation")
        //    if (cmbType.SelectedIndex.Equals(0))
        //    {
        //        txtId.Text = Cc.AutoId_Consultation_Category();
        //    }
        //    //if (cmbType.Text == "Prescription")
        //    if (cmbType.SelectedIndex.Equals(1))
        //    {
        //        txtId.Text = Pc.AutoId_Prescription_Category();
        //    }
        //    //if (cmbType.Text == "MedicalImaging")
        //    if (cmbType.SelectedIndex.Equals(2))
        //    {
        //        txtId.Text = Mc.AutoId_MedicalImaging_Category();
        //    }
        //    //if (cmbType.Text == "Laboratory")
        //    if (cmbType.SelectedIndex.Equals(3))
        //    {
        //        txtId.Text = Lc.AutoId_Laboratory_Category();
        //    }
        //    //if (cmbType.Text == "VariousDocument")
        //    if (cmbType.SelectedIndex.Equals(4))
        //    {
        //        txtId.Text = Vc.AutoId_VariousDocument_Category();
        //    }
        //    btnInsert.Visible = true;
        //    btnNew.Visible = false;
        //    Refresh();
        //}

        //private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

       


    }
}
