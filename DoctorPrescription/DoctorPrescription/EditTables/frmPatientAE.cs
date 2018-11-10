﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorPrescription.EditTables
{
    public partial class frmPatientAE : Form
    {
        private String UserName;
        public frmPatientAE(String UserName)
        {

            InitializeComponent();
            this.UserName = UserName;
            
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmPatientAE_Load(object sender, EventArgs e)
        {
            if (UserName == "")
            {
                patientBindingSource.AddNew();
                sexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                patientTableAdapter.FillByUserName(this.dataSet1.Patient, UserName);
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username & password Error");
                return;
            }
            DataSet1TableAdapters.PatientTableAdapter patient = new DataSet1TableAdapters.PatientTableAdapter();
            DataSet1.PatientDataTable dt = patient.GetDataByUserName(userNameTextBox.Text);
            //DataSet1TableAdapters.DoctorTableAdapter doctor = new DataSet1TableAdapters.DoctorTableAdapter();
            //DataSet1.DoctorDataTable dt = doctor.GetDataByUP(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count > 0 && UserName=="")
            {
                MessageBox.Show("Username Error");
                return;
            }
            else { 
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.patientTableAdapter.Update(this.dataSet1.Patient);
            DialogResult = DialogResult.OK;
        }
        }
    }
}
