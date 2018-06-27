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
    public partial class RegisterAccountForm : Form
    {
        public bool isConfirmed = false;
        public RegisterAccountForm()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCofirm_Click(object sender, EventArgs e)
        {
            ValidateAcc();
        }
        private void ValidateAcc()
        {
            if (txtFName.text == "" || txtLName.text == "" || txtMName.text == "" || txtUserName.text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Password not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                isConfirmed = true;
                this.Close();
            }
        }

        private void RegisterAccountForm_Load(object sender, EventArgs e)
        {
            cmbPosition.selectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
    }
}
