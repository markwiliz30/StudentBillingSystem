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
    public partial class EditPartition : Form
    {
        public bool isConfirmed = false;
        public bool isPaid = false;
        public EditPartition()
        {
            InitializeComponent();
        }

        private void EditPartition_Load(object sender, EventArgs e)
        {

        }
        private void ValidatePart()
        {
            if (txtPart.text == "" || txtAmount.text == "" || txtBalance.text == "" || txtPaymade.text == "")
            {
                MessageBox.Show("Please fill up all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cmbStatus.selectedIndex == 0 && Decimal.Parse(txtBalance.text) != 0)
                {
                    MessageBox.Show("Payment status is paid the remaining balance must be equal to zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((Decimal.Parse(txtBalance.text) + Decimal.Parse(txtPaymade.text)) != Decimal.Parse(txtAmount.text))
                {
                    MessageBox.Show("Invalid input please check the data again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cmbStatus.selectedIndex != 0 && Decimal.Parse(txtBalance.text) == 0)
                {
                    MessageBox.Show("Invalid input please check the data again", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    isConfirmed = true;
                    this.Close();
                }
            }
        }
        private void cmbStatus_onItemSelected(object sender, EventArgs e)
        {
            if (cmbStatus.selectedIndex == 0)
            {
                isPaid = true;
                calDatePaid.Enabled = true;
            }
            else
            {
                isPaid = false;
                calDatePaid.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValidatePart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
    }
}
