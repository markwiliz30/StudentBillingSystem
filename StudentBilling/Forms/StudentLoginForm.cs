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
    public partial class StudentLoginForm : Form
    {
        private List<StudentItem> myStudentItem = new List<StudentItem>();
        public List<StudentItem> pubMyStudentItem
        {
            get { return myStudentItem; }
        }
        //public List<StudentItem> myStudentItem = new List<StudentItem>();
        StudentCollection myStudentCollection = new StudentCollection();
        public StudentLoginForm()
        {
            InitializeComponent();
        }
        public void LoginDetails()
        {
            myStudentItem = new List<StudentItem>();
            myStudentItem.Clear();
            string logStatus = myStudentCollection.LoadLogStudentsFromDb(txtStdFname.text, txtStdLname.text);

            if (logStatus == "Name Not Found")
            {
                pbWarning.Visible = true;
                lblWarning.Visible = true;
            }
            else
            {
                foreach (var popStudentItem in myStudentCollection.pubStudentCollect)
                {
                    var myItem = new StudentItem();

                    myItem.Std_FName = popStudentItem.Std_FName;
                    myItem.Std_LName = popStudentItem.Std_LName;
                    myItem.Std_Id = popStudentItem.Std_Id;

                    myStudentItem.Add(myItem);
                }
                var passForm = new PasswordForm();
                passForm.Owner = this;
                passForm.holdStdList = myStudentItem;
                passForm.lblPassword.Text = "Enter Id:";
                passForm.btnLogin.ButtonText = "Enter";
                this.Hide();

                passForm.ShowDialog();
                txtStdFname.text = "";
                txtStdLname.text = "";
                passForm.Dispose();
                myStudentItem.Clear();
                GC.Collect();
            }
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtStdFname_Click(object sender, EventArgs e)
        {

        }

        private void txtStdLname_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoginDetails();
        }

        private void txtStdFname_OnTextChange(object sender, EventArgs e)
        {
            pbWarning.Visible = false;
            lblWarning.Visible = false;
        }

        private void txtStdLname_OnTextChange(object sender, EventArgs e)
        {
            pbWarning.Visible = false;
            lblWarning.Visible = false;
        }

        private void btnStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var staffLog = new LoginForm();
            staffLog.Owner = this;
            this.Hide();
            staffLog.ShowDialog();
        }
    }
}
