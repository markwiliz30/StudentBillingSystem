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
    public partial class SchoolStaffForm : Form
    {
        PaymentWindowControl pW = new PaymentWindowControl();
        ModifyStudentControl mS = new ModifyStudentControl();
        RegisterStudentControl rS = new RegisterStudentControl();
        AccountsControl aC = new AccountsControl();
        HistoryControl hC = new HistoryControl();
        public SchoolStaffForm()
        {
            InitializeComponent();
            controlContiainer.Controls.Add(pW);
            pW.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(mS);
            mS.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(rS);
            rS.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(aC);
            aC.Dock = DockStyle.Fill;
            controlContiainer.Controls.Add(hC);
            hC.Dock = DockStyle.Fill;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 58)
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 194;
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

        private void SchoolStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPaymentWindow_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnPaymentWindow.Height;
            buttonSelector.Top = btnPaymentWindow.Top;
            mS.Hide();
            rS.Hide();
            aC.Hide();
            hC.Hide();
            pW.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnModify.Height;
            buttonSelector.Top = btnModify.Top;
            pW.Hide();
            rS.Hide();
            aC.Hide();
            hC.Hide();
            mS.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnRegister.Height;
            buttonSelector.Top = btnRegister.Top;
            mS.Hide();
            pW.Hide();
            aC.Hide();
            hC.Hide();
            rS.Show();
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnManageAcc.Height;
            buttonSelector.Top = btnManageAcc.Top;
            mS.Hide();
            rS.Hide();
            pW.Hide();
            hC.Hide();
            aC.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            buttonSelector.Height = btnHistory.Height;
            buttonSelector.Top = btnHistory.Top;
            mS.Hide();
            rS.Hide();
            aC.Hide();
            pW.Hide();
            hC.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
            GC.Collect();
        }
    }
}
