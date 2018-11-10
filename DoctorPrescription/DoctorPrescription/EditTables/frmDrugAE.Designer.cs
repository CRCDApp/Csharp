namespace DoctorPrescription.EditTables
{
    partial class frmDrugAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label maximum_DoseLabel;
            System.Windows.Forms.Label dose_unitsLabel;
            this.dataSet1 = new DoctorPrescription.DataSet1();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new DoctorPrescription.DataSet1TableAdapters.DrugTableAdapter();
            this.tableAdapterManager = new DoctorPrescription.DataSet1TableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.maximum_DoseTextBox = new System.Windows.Forms.TextBox();
            this.dose_unitsTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            maximum_DoseLabel = new System.Windows.Forms.Label();
            dose_unitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(25, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(25, 51);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 5;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // maximum_DoseLabel
            // 
            maximum_DoseLabel.AutoSize = true;
            maximum_DoseLabel.Location = new System.Drawing.Point(25, 77);
            maximum_DoseLabel.Name = "maximum_DoseLabel";
            maximum_DoseLabel.Size = new System.Drawing.Size(82, 13);
            maximum_DoseLabel.TabIndex = 7;
            maximum_DoseLabel.Text = "Maximum Dose:";
            // 
            // dose_unitsLabel
            // 
            dose_unitsLabel.AutoSize = true;
            dose_unitsLabel.Location = new System.Drawing.Point(25, 103);
            dose_unitsLabel.Name = "dose_unitsLabel";
            dose_unitsLabel.Size = new System.Drawing.Size(60, 13);
            dose_unitsLabel.TabIndex = 9;
            dose_unitsLabel.Text = "Dose units:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "Drug";
            this.drugBindingSource.DataSource = this.dataSet1;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.DrugTableAdapter = this.drugTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.Prescription_DrugTableAdapter = null;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoctorPrescription.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(113, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(113, 48);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 6;
            // 
            // maximum_DoseTextBox
            // 
            this.maximum_DoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "Maximum_Dose", true));
            this.maximum_DoseTextBox.Location = new System.Drawing.Point(113, 74);
            this.maximum_DoseTextBox.Name = "maximum_DoseTextBox";
            this.maximum_DoseTextBox.Size = new System.Drawing.Size(100, 20);
            this.maximum_DoseTextBox.TabIndex = 8;
            // 
            // dose_unitsTextBox
            // 
            this.dose_unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "Dose_units", true));
            this.dose_unitsTextBox.Location = new System.Drawing.Point(113, 100);
            this.dose_unitsTextBox.Name = "dose_unitsTextBox";
            this.dose_unitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.dose_unitsTextBox.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmDrugAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(262, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(maximum_DoseLabel);
            this.Controls.Add(this.maximum_DoseTextBox);
            this.Controls.Add(dose_unitsLabel);
            this.Controls.Add(this.dose_unitsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrugAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Drug";
            this.Load += new System.EventHandler(this.frmDrugAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private DataSet1TableAdapters.DrugTableAdapter drugTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox maximum_DoseTextBox;
        private System.Windows.Forms.TextBox dose_unitsTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}