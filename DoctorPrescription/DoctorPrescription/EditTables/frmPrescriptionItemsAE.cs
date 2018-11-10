using System;
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
            // TODO: This line of code loads data into the 'dataSet1.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.dataSet1.Drug);
            // TODO: This line of code loads data into the 'dataSet1.Prescription_Drug' table. You can move, or remove it, as needed.

            if (DrugId == 0)
            {
                prescription_DrugBindingSource.AddNew();
                // doctor_IDTextBox.Text = Tools.UserName;
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

            if (drugIDComboBox.Text == "" || numOfUnitsTextBox.Text == "")
            {
                MessageBox.Show("doctor & patient Error");
                return;
            }

            DataSet1TableAdapters.Prescription_DrugTableAdapter pd = new DataSet1TableAdapters.Prescription_DrugTableAdapter();
            DataSet1.Prescription_DrugDataTable dt = pd.GetDataByPDID(PrescriptionID, (int)drugIDComboBox.SelectedValue);
            if (dt.Rows.Count > 0 )
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
