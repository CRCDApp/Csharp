using System;
using System.Data;
using System.Windows.Forms;

namespace DoctorPrescription
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void LoadPatientData()
        {
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
        }
        private void View(MainView view)
        {
            PanelPatients.Visible = false;
            PanelPatients.Dock = System.Windows.Forms.DockStyle.None;
            panelDrug.Visible = false;
            panelDrug.Dock = System.Windows.Forms.DockStyle.None;
            panelPrescription.Visible = false;
            panelPrescription.Dock = System.Windows.Forms.DockStyle.None;
            panelReport.Dock = System.Windows.Forms.DockStyle.None;
            panelReport.Visible = false;
            switch (view)
            {
                case MainView.Drug:
                    panelDrug.Visible = true;
                    panelDrug.Dock = System.Windows.Forms.DockStyle.Fill;
                    break;
                case MainView.Patient:
                    PanelPatients.Visible = true;
                    PanelPatients.Dock = System.Windows.Forms.DockStyle.Fill;
                    break;
                case MainView.Prescription:
                    panelPrescription.Visible = true;
                    panelPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
                    break;
                case MainView.Report:
                    panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
                    panelReport.Visible = true;
                    break;
                default:
                    panelPrescription.Visible = true;
                    panelPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
                    break;
            }
        }

        private void LoadPrescriptionData()
        {
            if (Tools.userType == UserType.Doctor)
                this.prescriptionTableAdapter.FillByDoctorId(this.dataSet1.Prescription, Tools.UserName);
            else if (Tools.userType == UserType.Admin)
                this.prescriptionTableAdapter.Fill(this.dataSet1.Prescription);
            else if (Tools.userType == UserType.Patient)
                this.prescriptionTableAdapter.FillByPatientId(this.dataSet1.Prescription, Tools.UserName);
        }

        private void drugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View(MainView.Drug);
        }

        private void LoadDrugData()
        {
            this.drugTableAdapter.Fill(this.dataSet1.Drug);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPrescriptionData();
            if (Tools.userType != UserType.Patient)
            {
                LoadDrugData();
                LoadPatientData();
            }
            Tools.setBackgroundGridview(this);
            UserViewSetup();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            EditTables.frmPatientAE patient = new EditTables.frmPatientAE("");
            if (patient.ShowDialog() == DialogResult.OK)
                LoadPatientData();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (patientBindingSource.Current == null)
                return;
            EditTables.frmPatientAE patient = new EditTables.frmPatientAE((String)((DataRowView)patientBindingSource.Current)["UserName"]);
            if (patient.ShowDialog() == DialogResult.OK)
                LoadPatientData();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            EditTables.frmDrugAE drug = new EditTables.frmDrugAE(0);
            if (drug.ShowDialog() == DialogResult.OK)
                LoadDrugData();
        }

        private void btnEditDrug_Click(object sender, EventArgs e)
        {
            if (drugBindingSource.Current == null)
                return;
            EditTables.frmDrugAE drug = new EditTables.frmDrugAE((int)((DataRowView)drugBindingSource.Current)["ID"]);
            if (drug.ShowDialog() == DialogResult.OK)
                LoadDrugData();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View(MainView.Patient);
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View(MainView.Prescription);
        }

        private void prescriptionAddNewItem_Click(object sender, EventArgs e)
        {
            EditTables.frmPrescriptionAE prescription = new EditTables.frmPrescriptionAE(0);
            if (prescription.ShowDialog() == DialogResult.OK)
                LoadPrescriptionData();
        }

        private void UserViewSetup()
        {
            if (Tools.userType == UserType.Patient)
            {
                drugToolStripMenuItem.Visible = patientToolStripMenuItem.Visible = btnDrugsReport.Visible = false;
                btnPrescriptionAdd.Visible = btnPrescriptionEdit.Visible = false;
            }
            else if (Tools.userType == UserType.Doctor)
            {
                btnAddDrug.Visible = btnEditDrug.Visible = false;
            }
            View(MainView.Prescription);
        }

        private void prescriptionEditItem_Click(object sender, EventArgs e)
        {
            if (prescriptionBindingSource.Current == null)
                return;

            EditTables.frmPrescriptionAE prescription = new EditTables.frmPrescriptionAE((int)((DataRowView)prescriptionBindingSource.Current)["ID"]);
            if (prescription.ShowDialog() == DialogResult.OK)
                LoadPrescriptionData();
        }

        private void prescriptionDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataSet1TableAdapters.Prescription_DrugTableAdapter presc_drug = new DataSet1TableAdapters.Prescription_DrugTableAdapter();
            DataSet1.Prescription_DrugDataTable dt = presc_drug.GetDataByPrescriptionId((int)((DataRowView)prescriptionBindingSource.Current)["ID"]);
            String tmp = "DATE:\t" + Convert.ToString(((DataRowView)prescriptionBindingSource.Current)["DATE"]) + "\nDoctor:\t" + Convert.ToString(((DataRowView)prescriptionBindingSource.Current)["Doctor_ID"])
                + "\nPatient:\t" + Convert.ToString(((DataRowView)prescriptionBindingSource.Current)["Patient_ID"]) + "\n";

            foreach (DataRow row in dt)
                tmp += Convert.ToString((String)drugTableAdapter.GetDataByID(Convert.ToInt32(row["DrugID"])).Rows[0]["Name"])
                    + ":\t" + Convert.ToString(row["NumOfUnits"]) + "\n";

            MessageBox.Show(tmp);
        }

        private void txtSearchDrug_TextChanged(object sender, EventArgs e)
        {
            drugBindingSource.Filter = "Name LIKE '%" + txtSearchDrug.Text + "%'";
        }

        private void txtSearchPrescription_TextChanged(object sender, EventArgs e)
        {
            prescriptionBindingSource.Filter = "Doctor_ID LIKE '%" + txtSearchPrescription.Text + "%' OR Patient_ID LIKE '%" + txtSearchPrescription.Text + "%'";
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            patientBindingSource.Filter = "UserName LIKE '%" + txtSearchPatient.Text + "%' OR FirstName LIKE '%" + txtSearchPatient.Text + "%' OR LastName LIKE '%" + txtSearchPatient.Text + "%'";
        }

        private void btnPrescriptionReport_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.spPatientPrescriptionsTableAdapter pres = new DataSet1TableAdapters.spPatientPrescriptionsTableAdapter();
            pres.Fill(this.dataSet1.spPatientPrescriptions, Tools.UserName);
            PatientPrescriptionReports rpt = new PatientPrescriptionReports();
            rpt.SetDataSource(this.dataSet1);
            crystalReportViewer1.ReportSource = rpt;
            View(MainView.Report);
        }

        private void btnDrugsReport_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            rpt.SetDataSource(this.dataSet1);
            crystalReportViewer1.ReportSource = rpt;
            View(MainView.Report);
        }
    }
}
