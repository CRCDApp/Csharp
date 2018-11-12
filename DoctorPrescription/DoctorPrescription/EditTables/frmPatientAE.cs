using System;
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
            if (userNameTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Username & password Error");
                return;
            }

            DataSet1TableAdapters.PatientTableAdapter patient = new DataSet1TableAdapters.PatientTableAdapter();
            DataSet1.PatientDataTable dt = patient.GetDataByUserName(userNameTextBox.Text);

            if (dt.Rows.Count > 0 && UserName.Trim() == "")
            {
                MessageBox.Show("Username Error");
                return;
            }
            else
            {
                this.Validate();
                this.patientBindingSource.EndEdit();
                this.patientTableAdapter.Update(this.dataSet1.Patient);
                DialogResult = DialogResult.OK;
            }
        }
    }
}