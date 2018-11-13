using System;
using System.Data;
using System.Windows.Forms;

namespace DoctorPrescription.EditTables
{
    public partial class frmPrescriptionAE : Form
    {
        private int Id;
        public frmPrescriptionAE(int ID)
        {
            InitializeComponent();
            this.Id = ID;
        }
        private void LoadDrugData() => drugTableAdapter.Fill(dataSet1.Drug);
        private void LoadPrescriptionData() => prescriptionTableAdapter.FillByID(dataSet1.Prescription, Id);
        private void LoadPatientData() => patientTableAdapter.Fill(dataSet1.Patient);
        private void LoadPrescription_DrugData() => prescription_DrugTableAdapter.FillByPrescriptionId(dataSet1.Prescription_Drug, Id);
        private void setup(bool enabled)
        {
            bindingNavigatorAddNewItem.Enabled = bindingNavigatorDeleteItem.Enabled = enabled;
            btnAddPrescription.Enabled = !enabled;
        }
        private void frmPrescriptionAE_Load(object sender, EventArgs e)
        {

            LoadDrugData();

            patient_IDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadPatientData();

            if (Id == 0)
            {
                prescriptionBindingSource.AddNew();
                doctor_IDTextBox.Text = Tools.UserName;
                setup(false);
            }
            else
            {
                LoadPrescriptionData();
                LoadPrescription_DrugData();
                setup(true);
            }

            Tools.setBackgroundGridview(this);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (doctor_IDTextBox.Text.Trim() == "" || patient_IDComboBox.Text.Trim() == "")
            {
                MessageBox.Show("doctor & patient Error");
                errorProvider1.SetError(patient_IDComboBox, "Enter Patient UserName!");
                return;
            }

            this.Validate();
            this.prescriptionBindingSource.EndEdit();
            this.prescriptionTableAdapter.Update(this.dataSet1.Prescription);
            this.prescription_DrugBindingSource.EndEdit();
            this.prescription_DrugTableAdapter.Update(this.dataSet1.Prescription_Drug);

            DialogResult = DialogResult.OK;


        }

        private void prescription_DrugDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(prescription_DrugDataGridView_KeyPress);
            if (prescription_DrugDataGridView.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(prescription_DrugDataGridView_KeyPress);
                }
            }
        }


        private void prescription_DrugDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            EditTables.frmPrescriptionItemsAE prescriptionItems = new EditTables.frmPrescriptionItemsAE(Id, 0);
            if (prescriptionItems.ShowDialog() == DialogResult.OK)
                this.prescription_DrugTableAdapter.FillByPrescriptionId(this.dataSet1.Prescription_Drug, Id);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (prescription_DrugBindingSource.Current == null)
                return;
            DataSet1.DrugDataTable dt = drugTableAdapter.GetDataByID((int)((DataRowView)prescription_DrugBindingSource.Current)["DrugID"]);

            if (MessageBox.Show("Are you Sure " + (String)dt.Rows[0]["Name"], "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.prescription_DrugTableAdapter.DeleteQuery((int)((DataRowView)prescription_DrugBindingSource.Current)["PrescriptionID"], (int)((DataRowView)prescription_DrugBindingSource.Current)["DrugID"]);
                this.prescription_DrugTableAdapter.FillByPrescriptionId(this.dataSet1.Prescription_Drug,Id);
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (doctor_IDTextBox.Text.Trim() == "" || patient_IDComboBox.Text.Trim() == "")
            {
                MessageBox.Show("doctor & patient Error");
                errorProvider1.SetError(patient_IDComboBox, "Enter Patient UserName!");
                return;
            }

            this.Validate();
            this.prescriptionBindingSource.EndEdit();
            this.prescriptionTableAdapter.Update(this.dataSet1.Prescription);

            Id = (int)((DataRowView)prescriptionBindingSource.Current)["ID"];

            setup(true);
        }
    }
}
