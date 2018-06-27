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
    public partial class StudentDash : Form
    {
        StudentCollection loadStudentData = new StudentCollection();
        BillCollection loadBillData = new BillCollection();
        TuitionFeeControl f = new TuitionFeeControl();
        OtherFeesControl o = new OtherFeesControl();
        OldFeesControl d = new OldFeesControl();
        public StudentDash()
        {
            InitializeComponent();
            controlContiainer.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(o);
            o.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(d);
            d.Dock = DockStyle.Fill;
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLogStudents();
            //LoadStudents();
            bunifuFlatButton1_Click(sender, e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 58)
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 187;
                PanelAnimator.ShowSync(pnlMenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                logo.Visible = false;
                pnlMenu.Visible = false;
                pnlMenu.Width = 58;
                PanelAnimator2.ShowSync(pnlMenu);
            }
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            buttonSelector.Height = btnOldBalance.Height;
            buttonSelector.Top = btnOldBalance.Top;
            o.Hide();
            f.Hide();
            UserControlAnimator.ShowSync(d);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnTuition.Height;
            buttonSelector.Top = btnTuition.Top;
            d.Hide();
            o.Hide();
            UserControlAnimator.ShowSync(f);
        }

        private void btnOtherFees_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnOtherFees.Height;
            buttonSelector.Top = btnOtherFees.Top;
            d.Hide();
            f.Hide();
            UserControlAnimator.ShowSync(o);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudents()
        {
            
            loadStudentData.LoadStudentsFromDb();
            loadBillData.LoadBillFromDb();
            
            foreach (var popStudents in loadStudentData.pubStudentCollect)
            {
                lblStudentNumberContainer.Text = popStudents.Std_Id.ToString();
                char middleName = popStudents.Std_MName.ToString().FirstOrDefault();
                lblStudentNameContainer.Text = $"{popStudents.Std_FName.ToString()} {middleName}. {popStudents.Std_LName}";
                lblCourseCodeContainer.Text = popStudents.Std_CourseCode.ToString();
                lblYearContainer.Text = popStudents.Std_Year.ToString();
                lblSectionContainer.Text = popStudents.Std_Section.ToString();
            }
            foreach (var popBill in loadBillData.pubBillCollect)
            {
                lblSemesterContainer.Text = popBill.Bill_Semester.ToString();
                lblSchoolYearContainer.Text = popBill.Bill_SchoolYear.ToString();
            }
        }
        private void LoadLogStudents()
        {

            loadStudentData.LoadLogStudentsWithIdFromDb(LoginUser.stdLogStudentFname, LoginUser.stdLogStudentLname, Int32.Parse(LoginUser.stdLogStudentId));
            loadBillData.LoadBillWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var popStudents in loadStudentData.pubStudentCollect)
            {
                lblStudentNumberContainer.Text = popStudents.Std_Id.ToString();
                char middleName = popStudents.Std_MName.ToString().FirstOrDefault();
                lblStudentNameContainer.Text = $"{popStudents.Std_FName.ToString()} {middleName}. {popStudents.Std_LName}";
                lblCourseCodeContainer.Text = popStudents.Std_CourseCode.ToString();
                lblYearContainer.Text = popStudents.Std_Year.ToString();
                lblSectionContainer.Text = popStudents.Std_Section.ToString();
            }
            foreach (var popBill in loadBillData.pubBillCollect)
            {
                lblSemesterContainer.Text = popBill.Bill_Semester.ToString();
                lblSchoolYearContainer.Text = popBill.Bill_SchoolYear.ToString();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
            GC.Collect();
        }
    }
}
