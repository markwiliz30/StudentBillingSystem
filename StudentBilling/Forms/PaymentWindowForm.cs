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
    public partial class PaymentWindowForm : Form
    {
        public int payNum = 0;
        public bool isConfirmed = false;
        public decimal amountHold = 0;
        public decimal newBalance = 0;
        public string dateHold;
        public PaymentWindowForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckDiff();
        }
        private void CheckDiff()
        {
            if ((Decimal.Parse(lblBalance.Text) - Decimal.Parse(txtPayAmount.text)) < 0)
            {
                MessageBox.Show("The payment amount is exceeded to the reamining balance", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPayAmount.text == "")
            {
                MessageBox.Show("Please input amount", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                isConfirmed = true;
                amountHold = Decimal.Parse(txtPayAmount.text);
                dateHold = calPayDate.Value.ToString("MM/dd/yyyy");
                newBalance = Decimal.Parse(lblBalance.Text) - amountHold;
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
    }
}
