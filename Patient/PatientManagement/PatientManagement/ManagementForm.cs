using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private readonly Management _management = new Management();

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            dgvShow.DataSource = _management.Show_WorkerHasAccount();
            _management.ClearTemp();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvShow.DataSource = _management.Search_WorkerHasAccount(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            gboControlName.Controls.Clear();
            var btn = new Button { Name = "btnAddtoPreview", Text = @"Add to Preview",
                Size = new Size(155, 36), Location = new Point(381, 14) };
            btn.Click += btnAddtoPreview_Click;
            gboControlName.Controls.Add(_management.ChoosenFormPanel(cboControl.Text));
            gboControlName.Controls.Add(btn);
        }

        private void btnAddtoPreview_Click(object sender, EventArgs e)
        {
            var collection = gboControlName.Controls.OfType<FlowLayoutPanel>();
 
            foreach (var itemConFlowLayoutPanel in collection)
            {
                foreach (var itemGroupBox in itemConFlowLayoutPanel.Controls.OfType<GroupBox>())
                {
                    foreach (var itemFlowLayoutPanel in itemGroupBox.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (var itemBox in itemFlowLayoutPanel.Controls.OfType<CheckedListBox>())
                        {
                            for (var i = 0; i < itemBox.CheckedItems.Count; i++)
                            {
                                var getCheckedItem = itemBox.CheckedItems[i];
                                if (dgvShow.CurrentRow != null)
                                {
                                    _management.CheckedItems(dgvShow.CurrentRow.Cells[0].Value.ToString(),
                                        cboControl.Text, itemGroupBox.Text, getCheckedItem.ToString(), true);
                                }
                            }
                        }
                    }                    
                }
            }
            gboPreview.Controls.Clear();
            gboPreview.Controls.Add(_management.TabControlPreview());
        }

        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null)
                gboControlName.Text = dgvShow.CurrentRow.Cells[4].Value + @"'s Control";
            cboControl.DataSource = _management.Show_Control();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null) _management.SubmitManagement(dgvShow.CurrentRow.Cells[0].Value.ToString());
        }

    }
}
