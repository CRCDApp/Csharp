using System;
using System.Data;
using System.Windows.Forms;

namespace DoctorPrescription
{
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();

        private bool IsDoctor()
        {
            DataSet1TableAdapters.DoctorTableAdapter doctor = new DataSet1TableAdapters.DoctorTableAdapter();
            DataSet1.DoctorDataTable dt = doctor.GetDataByUP(txtUserName.Text, txtPassword.Text);

            if (dt.Rows.Count == 0)
                return false;

            DataRow dr = dt.Rows[0];

            if (Convert.ToBoolean(dr["IsAdmin"]))
                Tools.userType = UserType.Admin;
            else
                Tools.userType = UserType.Doctor;

            Tools.UserName = Convert.ToString(dr["UserName"]);

            return true;
        }
        private bool IsPatient()
        {
            DataSet1TableAdapters.PatientTableAdapter patient = new DataSet1TableAdapters.PatientTableAdapter();
            DataSet1.PatientDataTable dt = patient.GetDataByUP(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count == 0)
                return false;

            Tools.userType = UserType.Patient;
            DataRow dr = dt.Rows[0];
            Tools.UserName = Convert.ToString(dr["UserName"]);
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username or Password Empty");
                Tools.clearForm(this);
                txtUserName.Focus();
            }
            else if (IsDoctor() || IsPatient())
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Username or Password Error");
                Tools.clearForm(this);
                txtUserName.Focus();
            }

        }
    }
}
