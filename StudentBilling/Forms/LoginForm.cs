using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentBillingLibrary;

namespace StudentBilling
{
    public partial class LoginForm : Form
    {
        List<StaffItem> myStaffItem = new List<StaffItem>();
        StaffCollection myStaffCollection = new StaffCollection();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            LoginDetails();
        }
        public void LoginDetails()
        {
            myStaffItem = new List<StaffItem>();
            myStaffItem.Clear();
            string logStatus = myStaffCollection.LoadLogStaffFromDb(txtUserName.text);

            if (logStatus == "Name Not Found")
            {
                pbWarning.Visible = true;
                lblWarning.Visible = true;
            }
            else
            {
                foreach (var popStaffItem in myStaffCollection.pubStaffCollect)
                {
                    var myItem = new StaffItem();

                    myItem.Staff_FName = popStaffItem.Staff_FName;
                    myItem.Staff_LName = popStaffItem.Staff_LName;
                    myItem.Staff_Username = popStaffItem.Staff_Username;
                    myItem.Staff_Password = popStaffItem.Staff_Password;

                    myStaffItem.Add(myItem);
                }
                var passForm = new PasswordForm();
                passForm.Owner = this;
                passForm.holdStaffList = myStaffItem;
                this.Hide();

                passForm.ShowDialog();
                txtUserName.text = "";
                passForm.Dispose();
                myStaffItem.Clear();
                GC.Collect();
            }
        }

        private void txtUserName_OnTextChange(object sender, EventArgs e)
        {
            pbWarning.Visible = false;
            lblWarning.Visible = false;
        }
    }
}
