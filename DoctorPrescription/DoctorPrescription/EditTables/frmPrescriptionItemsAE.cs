using System;
using System.Data;
using System.Windows.Forms;

namespace DoctorPrescription.EditTables
{
    public partial class frmPrescriptionItemsAE : Form
    {
        private int PrescriptionID, DrugId;
        public frmPrescriptionItemsAE(int prescriptionId, int drugId)
        {
            InitializeComponent();
            PrescriptionID = prescriptionId;
            DrugId = drugId;
        }



        private void frmPrescriptionItemsAE_Load(object sender, EventArgs e)
        {
            this.drugTableAdapter.Fill(this.dataSet1.Drug);

            if (DrugId == 0)
            {
                prescription_DrugBindingSource.AddNew();
                ((DataRowView)prescription_DrugBindingSource.Current)["PrescriptionID"] = PrescriptionID;
            }
            else
            {
                prescription_DrugTableAdapter.FillByPDID(this.dataSet1.Prescription_Drug, PrescriptionID, DrugId);
            }

            drugIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void btnOk_Click(object sender, EventArgs e)
        {

            if (drugIDComboBox.Text.Trim() == "" || numOfUnitsMaskedTextBox.Text.Trim() == "")
            {
                MessageBox.Show("doctor & patient Error");
                return;
            }

            DataSet1TableAdapters.Prescription_DrugTableAdapter pd = new DataSet1TableAdapters.Prescription_DrugTableAdapter();
            DataSet1.Prescription_DrugDataTable dt = pd.GetDataByPDID(PrescriptionID, (int)drugIDComboBox.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Drug Error");
                return;
            }

            this.Validate();
            this.prescription_DrugBindingSource.EndEdit();
            ((DataRowView)prescription_DrugBindingSource.Current)["DrugID"] = (int)drugIDComboBox.SelectedValue;
            this.prescription_DrugTableAdapter.Update(this.dataSet1.Prescription_Drug);
            DialogResult = DialogResult.OK;

        }
    }
}
