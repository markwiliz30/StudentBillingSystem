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
    public partial class EditBill : Form
    {
        public bool isConfirmed = false;
        public bool isPaid = false;
        public bool isEdit = false;
        public EditBill()
        {
            InitializeComponent();
        }
        private void ValidateBill()
        {
            if (txtDiscount.text == "" || txtTotal.text == "" || txtFinal.text == "" || txtPayMade.text == "" || txtBalance.text == "" || txtSem.text == "" || txtSchoolYear.text == "")
            {
                MessageBox.Show("Please fill up all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cmbStatus.selectedIndex == 0 && Decimal.Parse(txtBalance.text) != 0)
                {
                    MessageBox.Show("Payment status is paid the remaining balance must be equal to zero", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((Decimal.Parse(txtBalance.text) + Decimal.Parse(txtPayMade.text)) != Decimal.Parse(txtFinal.text))
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
            ValidateBill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }

        private void txtTotal_OnTextChange(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                if (txtTotal.text == "")
                {
                    txtTotal.text = "0";
                }
                decimal result = Decimal.Parse(txtTotal.text) - (Decimal.Parse(txtTotal.text) * (Decimal.Parse(txtDiscount.text) / 100));
                txtFinal.text = result.ToString();
            }
        }

        private void txtDiscount_OnTextChange(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                if (txtDiscount.text == "")
                {
                    txtDiscount.text = "0";
                }
                decimal result = Decimal.Parse(txtTotal.text) - (Decimal.Parse(txtTotal.text) * (Decimal.Parse(txtDiscount.text) / 100));
                txtFinal.text = result.ToString();
            }
        }
    }
}
