namespace DoctorPrescription.EditTables
{
    partial class frmPrescriptionItemsAE
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
            System.Windows.Forms.Label numOfUnitsLabel;
            System.Windows.Forms.Label drugIDLabel;
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataSet1 = new DoctorPrescription.DataSet1();
            this.prescription_DrugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescription_DrugTableAdapter = new DoctorPrescription.DataSet1TableAdapters.Prescription_DrugTableAdapter();
            this.tableAdapterManager = new DoctorPrescription.DataSet1TableAdapters.TableAdapterManager();
            this.numOfUnitsTextBox = new System.Windows.Forms.TextBox();
            this.drugIDComboBox = new System.Windows.Forms.ComboBox();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new DoctorPrescription.DataSet1TableAdapters.DrugTableAdapter();
            numOfUnitsLabel = new System.Windows.Forms.Label();
            drugIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_DrugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numOfUnitsLabel
            // 
            numOfUnitsLabel.AutoSize = true;
            numOfUnitsLabel.Location = new System.Drawing.Point(35, 51);
            numOfUnitsLabel.Name = "numOfUnitsLabel";
            numOfUnitsLabel.Size = new System.Drawing.Size(73, 13);
            numOfUnitsLabel.TabIndex = 7;
            numOfUnitsLabel.Text = "Num Of Units:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(145, 94);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(33, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescription_DrugBindingSource
            // 
            this.prescription_DrugBindingSource.DataMember = "Prescription_Drug";
            this.prescription_DrugBindingSource.DataSource = this.dataSet1;
            // 
            // prescription_DrugTableAdapter
            // 
            this.prescription_DrugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.DrugTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.Prescription_DrugTableAdapter = this.prescription_DrugTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoctorPrescription.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numOfUnitsTextBox
            // 
            this.numOfUnitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_DrugBindingSource, "NumOfUnits", true));
            this.numOfUnitsTextBox.Location = new System.Drawing.Point(120, 48);
            this.numOfUnitsTextBox.Name = "numOfUnitsTextBox";
            this.numOfUnitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numOfUnitsTextBox.TabIndex = 8;
            // 
            // drugIDComboBox
            // 
            this.drugIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prescription_DrugBindingSource, "DrugID", true));
            this.drugIDComboBox.DataSource = this.drugBindingSource;
            this.drugIDComboBox.DisplayMember = "Name";
            this.drugIDComboBox.FormattingEnabled = true;
            this.drugIDComboBox.Location = new System.Drawing.Point(114, 20);
            this.drugIDComboBox.Name = "drugIDComboBox";
            this.drugIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.drugIDComboBox.TabIndex = 9;
            this.drugIDComboBox.ValueMember = "ID";
            // 
            // drugIDLabel
            // 
            drugIDLabel.AutoSize = true;
            drugIDLabel.Location = new System.Drawing.Point(61, 23);
            drugIDLabel.Name = "drugIDLabel";
            drugIDLabel.Size = new System.Drawing.Size(47, 13);
            drugIDLabel.TabIndex = 8;
            drugIDLabel.Text = "Drug ID:";
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
            // frmPrescriptionItemsAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(277, 141);
            this.Controls.Add(drugIDLabel);
            this.Controls.Add(this.drugIDComboBox);
            this.Controls.Add(numOfUnitsLabel);
            this.Controls.Add(this.numOfUnitsTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrescriptionItemsAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPrescriptionItemsAE";
            this.Load += new System.EventHandler(this.frmPrescriptionItemsAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_DrugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingNavigator prescription_DrugBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prescription_DrugBindingNavigatorSaveItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource prescription_DrugBindingSource;
        private DataSet1TableAdapters.Prescription_DrugTableAdapter prescription_DrugTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numOfUnitsTextBox;
        private System.Windows.Forms.ComboBox drugIDComboBox;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private DataSet1TableAdapters.DrugTableAdapter drugTableAdapter;
    }
}