﻿using System;
using CrystalDecisions.Shared;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class MedicalRecordWebViewer : Form
    {

        internal string html;
        internal Patient Patient;
        internal Account Account;
        
        public MedicalRecordWebViewer()
        {
            InitializeComponent();
        }

        private void MedicalRecordWebViewer_Load(object sender, EventArgs e)
        {
            html = html.Substring(229);
            html = html.Remove(html.Length - 16);
            btnPrint.Visible = false;
            btnPrintPreview.Visible = false;
            btnModel.Visible = false;
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (wv.Document != null)
            {
                var boxcontrol = wv.Document.GetElementById("Box2");
                if (boxcontrol != null) boxcontrol.InnerHtml = html;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           wv.ShowPrintDialog();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedIndex == 0)
            {
                btnPrint.Visible = true;
                btnPrintPreview.Visible = false;
                btnModel.Visible = true;
                MedicalReportSampleA1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalReportSampleA1.SetParameterValue("pGender", Patient.Gender);
                MedicalReportSampleA1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalReportSampleA1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalReportSampleA1.SetParameterValue("pAge", Patient.Age);
                MedicalReportSampleA1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleA");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleA.htm");
            }
            else if (cmbModel.SelectedIndex == 1)
            {
                btnPrint.Visible = true;
                btnPrintPreview.Visible = false;
                btnModel.Visible = true;
                MedicalReportSampleB1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalReportSampleB1.SetParameterValue("pGender", Patient.Gender);
                MedicalReportSampleB1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalReportSampleB1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalReportSampleB1.SetParameterValue("pAge", Patient.Age);
                MedicalReportSampleB1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleB");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleB.htm");
            }
            else if (cmbModel.SelectedIndex == 2)
            {
                btnPrint.Visible = false;
                btnPrintPreview.Visible = true ;
                btnModel.Visible = true;
                MedicalRecortSampleC1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalRecortSampleC1.SetParameterValue("pGender", Patient.Gender);
                MedicalRecortSampleC1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalRecortSampleC1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalRecortSampleC1.SetParameterValue("pAge", Patient.Age);
                MedicalRecortSampleC1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleC");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleC.htm");
            }
            else if (cmbModel.SelectedIndex == 3)
            {
                btnPrint.Visible = false;
                btnPrintPreview.Visible = true;
                btnModel.Visible = true;
                MedicalRecortSampleD1.SetParameterValue("pPatientName", Patient.FirstName + " " + Patient.LastName + " ( " + Patient.KhmerName + " )");
                MedicalRecortSampleD1.SetParameterValue("pGender", Patient.Gender);
                MedicalRecortSampleD1.SetParameterValue("pDatetime", DateTime.Now);
                MedicalRecortSampleD1.SetParameterValue("pDoctorName", Account.Worker.FirstName + " " + Account.Worker.LastName);
                MedicalRecortSampleD1.SetParameterValue("pAge", Patient.Age);
                MedicalRecortSampleD1.ExportToDisk(ExportFormatType.HTML40, @"D:\PatientManagement\Patient\RTF\SampleD");
                wv.Navigate(@"D:\PatientManagement\Patient\RTF\SampleD.htm");
            }
           
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            wv.ShowPrintPreviewDialog();
        }

    }
}