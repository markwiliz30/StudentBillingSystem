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
    public partial class EditAccountForm : Form
    {
        public bool isConfirmed = false;
        public string currentPass;
        public EditAccountForm()
        {
            InitializeComponent();
        }
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            ValidateAcc();
        }
        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
        private void ValidateAcc()
        {
            if (txtFName.text == "" || txtLName.text == "" || txtMName.text == "" || txtUserName.text == "")
            {
                MessageBox.Show("Please fill up all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (grpPass.Enabled == true)
                {
                    if (currentPass != txtCurrentPass.Text)
                    {
                        MessageBox.Show("Current password not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (txtPassword.Text != txtConfirm.Text)
                    {
                        MessageBox.Show("Password not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Please input Password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        isConfirmed = true;
                        this.Close();
                    }

                }
                else
                {
                    isConfirmed = true;
                    this.Close();
                }
            }
        }
        private void EditAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.ButtonText == "Change Password")
            {
                grpPass.Enabled = true;
                btnChange.ButtonText = "Cancel";
            }
            else if (btnChange.ButtonText == "Cancel")
            {
                grpPass.Enabled = false;
                btnChange.ButtonText = "Change Password";
            }

        }
    }
}
