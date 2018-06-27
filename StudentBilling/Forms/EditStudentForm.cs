using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBilling
{
    public partial class EditStudentForm : Form
    {
        public bool isConfirmed = false;
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValidateStd();
        }
        private void ValidateStd()
        {
            if (txtFName.text == "" || txtLName.text == "" || txtMName.text == "" || txtCCode.text == "" || txtCtitle.text == "" || txtYear.text == "" || txtSection.text == "")
            {
                MessageBox.Show("Please fill up all text box", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                isConfirmed = true;
                this.Close();
            }
        }
    }
}
