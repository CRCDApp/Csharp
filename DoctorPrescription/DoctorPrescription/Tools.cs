using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorPrescription
{
    public enum UserType
    {
        Doctor,
        Patient,
        Admin        
    }
    public enum MainView
    {
        Drug,
        Patient,
        Prescription,
        Report
    }
    class Tools
    {
        public static void setBackgroundGridview(Control controls)
        {
            foreach (Control control in controls.Controls)
                if (control is DataGridView)
                    (control as DataGridView).BackgroundColor = System.Drawing.SystemColors.Control;
                else
                    setBackgroundGridview(control);
        }
        public static void clearForm(Control controls)
        {
            foreach (Control control in controls.Controls)
                if (control is TextBox)
                    (control as TextBox).Clear();
                else
                    clearForm(control);
        }

        public static UserType userType;
        public static String UserName="";
    }
}
