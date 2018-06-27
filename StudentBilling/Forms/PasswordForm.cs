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
    public partial class PasswordForm : Form
    {
        StudentLoginForm stdForm = new StudentLoginForm();
        public List<StudentItem> holdStdList { get; set; }
        public List<StaffItem> holdStaffList { get; set; }
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.ButtonText == "Enter")
            {
                EnterStdDash();
            }
            else if (btnLogin.ButtonText == "     Login")
            {
                EnterStaffDash();
            }
        }
        private void EnterStdDash()
        {
            foreach (var matchId in holdStdList)
            {
                if (holdStdList.Any(x => (x.Std_Id.ToString() == txtPassword.Text)))
                {
                    foreach (var item in holdStdList)
                    {
                        LoginUser.stdLogStudentFname = item.Std_FName;
                        LoginUser.stdLogStudentLname = item.Std_LName;
                        LoginUser.stdLogStudentId = txtPassword.Text;
                    }
                    var a = stdForm.pubMyStudentItem;
                    var stdDash = new StudentDash();
                    stdDash.Owner = this.Owner;
                    this.Hide();
                    stdDash.ShowDialog();
                    stdDash.Dispose();
                    this.Close();
                    GC.Collect();
                    return;
                }
                else
                {
                    pbWarning.Visible = true;
                    lblWarning.Visible = true;
                    return;
                }
            }
        }
        private void EnterStaffDash()
        {
            foreach (var matchId in holdStaffList)
            {
                if (holdStaffList.Any(x => (x.Staff_Password == txtPassword.Text)))
                {
                    foreach (var item in holdStaffList)
                    {
                        LoginUser.staffFName = item.Staff_FName;
                        LoginUser.staffLName = item.Staff_LName;
                        LoginUser.staffLogUsername = item.Staff_Username;
                        LoginUser.staffLogPassword = txtPassword.Text;
                    }
                    var staffDash = new SchoolStaffForm();
                    staffDash.Owner = this.Owner;
                    this.Hide();
                    staffDash.ShowDialog();
                    staffDash.Dispose();
                    this.Close();
                    GC.Collect();
                    return;
                }
                else
                {
                    pbWarning.Visible = true;
                    lblWarning.Visible = true;
                    return;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Refresh();
            Owner.Show();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            pbWarning.Visible = false;
            lblWarning.Visible = false;
        }
    }
}
