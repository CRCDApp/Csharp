using System;
using System.Windows.Forms;

namespace DoctorPrescription.EditTables
{
    public partial class frmDrugAE : Form
    {
        private int Id;
        public frmDrugAE(int ID)
        {
            InitializeComponent();
            this.Id = ID;
        }

        private void frmDrugAE_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                drugBindingSource.AddNew();
            }
            else
            {
                drugTableAdapter.FillByID(this.dataSet1.Drug, Id);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || dose_unitsMaskedTextBox.Text == "")
            {
                MessageBox.Show("Name & Dose Error");
                return;
            }
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.drugTableAdapter.Update(this.dataSet1.Drug);
            DialogResult = DialogResult.OK;
        }
    }
}
