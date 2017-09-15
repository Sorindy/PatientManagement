﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Microsoft.VisualBasic.PowerPacks;


namespace PatientManagement.Class
{
    public class Management
    {
        private readonly HospitalDbContext _db=new HospitalDbContext();
        private IStatus _status;

        public void Insert(string id, string accId)
        {
            var insert=new Hospital_Entity_Framework.Management(){Id = id,AccountId = accId};

            _db.Managements.Add(insert);
            _db.SaveChanges();
        }

        public void Delete(Hospital_Entity_Framework.Management management)
        {
            var delete = _db.Managements.Single(v => v.Id == management.Id);

            _db.Managements.Remove(delete);
            _db.SaveChanges();
        }

        public object Show_Control()
        {
            BindingSource bs=new BindingSource();
            var forms = new[] {"Worker's Form","Patient's Form","CheckIn's Form","Management's Form","Admin's Form","Medical's Form",
                    "Category's Form"};

                bs.DataSource = forms.ToList();
            return bs;
        }

        public object Show_WorkerHasAccount()
        {
            var bs = new BindingSource();

                var show = _db.Accounts;

                bs.DataSource = show.Select(s => new { s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName }).ToList();

            return bs;
        }

        public object Search_WorkerHasAccount(string search)
        {
            BindingSource bs2 = new BindingSource();

            var searchs = _db.Accounts.Where(v => v.Worker.Id.Contains(search) || v.Worker.Name.Contains(search) ||
                                                  v.Worker.Position.Contains(search));

            bs2.DataSource = searchs
                .Select(s => new {s.Worker.Id, s.Worker.Name, s.Worker.Gender, s.Worker.Position, s.UserName}).ToList();

            return bs2;
        }

        public string AutoId()
        {
            var management=new Hospital_Entity_Framework.Management();
            try
            {
                var getLastId = _db.Managements.OrderByDescending(m => m.Id).First();
                var getvalue = getLastId.Id;
                var num = Convert.ToInt32(getvalue.Substring(10));
                num += 1;
                management.Id = string.Concat("Management", num);
            }
            catch
            {
                management.Id = "Management1";
            }
            return management.Id;
        }

        //public Panel ShowControlForm(string str)
        //{
        //    var panelControl = new Panel();
        //    panelControl.Controls.Clear();
        //    panelControl.Name = "panelControl";
        //    panelControl.AutoScroll = true;
        //    panelControl.Location = new Point(6, 29);
        //    panelControl.Size = new Size(526, 394);

        //    //ComboBox comboBox = new ComboBox();
        //    //comboBox.Controls.Clear();
        //    //comboBox.Name = "cboChoosen";
        //    //comboBox.Font = new Font("Oswald", 16);
        //    //comboBox.Location = new Point(15, 19);
        //    //comboBox.Size = new Size(285, 39);
        //    //comboBox.DataSource = bs;

        //    var textBox = new TextBox();
        //    textBox.Controls.Clear();
        //    textBox.Name = "txtChoosen";
        //    textBox.Location = new Point(6, 29);
        //    textBox.Size = new Size(285, 39);
        //    textBox.Text = str;
        //    textBox.ReadOnly = true;




        //    var treeView = new TreeView();
        //    treeView.Controls.Clear();
        //    treeView.Name = "treeViewList";
        //    treeView.Location = new Point(51, 64);
        //    treeView.Size = new Size(461, 330);
        //    treeView.CheckBoxes = true;

        //    var line = new LineShape
        //    {
        //        X1 = 298,
        //        X2 = 525,
        //        Y1 = 39,
        //        Y2 = 39
        //    };

        //    var sc = new ShapeContainer();
        //    line.Parent = sc;

        //    treeView.Nodes.Add(ChoosenForm(str));
            
        //    panelControl.Controls.Add(treeView);
        //    panelControl.Controls.Add(sc);
        //    panelControl.Controls.Add(textBox);

        //    return panelControl;
        //}

        //public Panel PreviewManagements(TreeNode node)
        //{
        //    var panel = new Panel
        //    {
        //        Name = "panelControl",
        //        AutoScroll = true,
        //        Location = new Point(6, 29),
        //        Size = new Size(526, 189)
        //    };

        //    var comboBox = new ComboBox();
        //    comboBox.Controls.Clear();
        //    comboBox.Name = "cboChoosen";
        //    comboBox.Font = new Font("Oswald", 16);
        //    comboBox.Location = new Point(15, 19);
        //    comboBox.Size = new Size(285, 39);
        //    comboBox.DataSource = Show_Control();

        //    var line = new LineShape
        //    {
        //        X1 = 298,
        //        X2 = 525,
        //        Y1 = 39,
        //        Y2 = 39
        //    };

        //    var sc = new ShapeContainer();
        //    line.Parent = sc;

        //    var flpnPreview=new FlowLayoutPanel();
        //    flpnPreview.Controls.Clear();
        //    flpnPreview.Location = new Point(40, 89);
        //    flpnPreview.Size = new Size(429,136);
        //    flpnPreview.Name = "flpnPreview";
        //    flpnPreview.AutoScroll = true;

        //    var checkBox=new CheckBox();
        //    checkBox.Font = new Font("Pristina", 16);
        //    checkBox.AutoSize = true;
        //    checkBox.Enabled = false;
        //    checkBox.Checked = true;
        //    checkBox.Text = node.Text;

        //    flpnPreview.Controls.Add(checkBox);

        //    panel.Controls.Add(comboBox);
        //    panel.Controls.Add(sc);
        //    panel.Controls.Add(flpnPreview);
            
        //    return panel;
        //}
        
        public List<TreeNode> GetCheckedNodes(TreeNode node)
        {
            var nodes = new List<TreeNode>();

            foreach (TreeNode childNode in node.Nodes)
            {
                nodes.AddRange(GetCheckedNodes(childNode));
            }

            if (node.Checked)
            {
                nodes.Add(node);
            }

            return nodes;
        }

        private object SaveTemp(string form,string service,string category,bool status)
        {
            var temp=new Tuple<string,string,string,bool>(form,service,category,status);
            return temp;
        }

        public FlowLayoutPanel FlowLayoutPanel()
        {
            var flpn=new FlowLayoutPanel();

            
            
            return flpn;
        }

        private void CheckedNodes(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode aNode in treeNodeCollection)
            {
                if (aNode.Checked)
                {
                    
                }
                if (aNode.Nodes.Count != 0)
                {
                    CheckedNodes(aNode.Nodes);
                }
            }
            
        }

        public TreeNode ChoosenForm(string str)
        {
            TreeNode treeNode = new TreeNode();

            if (str == "Worker's Form")
            {
                treeNode = WorkerNode();
            }
            if (str == "Patient's Form")
            {
                treeNode = PatientNode();
            }
            if (str == "CheckIn's Form")
            {
                treeNode = CheckInNode();
            }
            if (str == "Management's Form")
            {
                treeNode = WorkerNode();
            }
            if (str == "Admin's Form")
            {
                treeNode = WorkerNode();
            }
            if (str == "Medical's Form")
            {
                treeNode = MedicalManagement();
            }
            if (str == "Category's Form")
            {
                treeNode = WorkerNode();
            }

            return treeNode;
        }

        private TreeNode MedicalManagement()
        {
            var treeNode = new TreeNode();

            _status=new ConsultationStatus();
            var showConsultation= _status.ShowCategory();
            _status=new LaboratoryStatus();
            var showLaboratory = _status.ShowCategory();
            _status=new MedicalImagingStatus();
            var showMedicalImaging = _status.ShowCategory();
            _status=new PrescriptionStatus();
            var showPrescription = _status.ShowCategory();
            _status=new VariousDocumentStatus();
            var showVariousDoc = _status.ShowCategory();
     
            treeNode.Text = @"MedicalManagement";
            treeNode.Nodes.AddRange(new []{showConsultation,showLaboratory,showMedicalImaging,showPrescription,showVariousDoc});

            return treeNode;
        }

        private TreeNode WorkerNode()
        {

            var treeNode = new TreeNode {Text = @"Worker's Form"};

            return treeNode;
        }

        private TreeNode PatientNode()
        {
            var treeNode = new TreeNode {Text = @"Patient's Form"};

            return treeNode;
        }

        private TreeNode CheckInNode()
        {
            var treeNode = new TreeNode {Text = @"CheckIn's Form"};
            return treeNode;
        }

    }

}
