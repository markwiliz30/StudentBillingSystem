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
    public partial class TuitionFeeAddPaymentForm : Form
    {
        public bool isConfirmed;
        public decimal balanceHolder = 0;
        public decimal editBalanceHold = 0;
        private PartialPaymentItem transmitPartPay = new PartialPaymentItem();

        public PartialPaymentItem pubTransmitPartPay
        {
            get { return transmitPartPay; }
            set { transmitPartPay = value; }
        }
        public TuitionFeeAddPaymentForm()
        {
            InitializeComponent();
        }

        private void bunifuCalendar1_onValueChanged(object sender, EventArgs e)
        {

        }
        public void TransmitPartData()
        {
            transmitPartPay = new PartialPaymentItem();
            transmitPartPay.PartPay_Partition = txtPartition.text;
            transmitPartPay.PartPay_Amount = Decimal.Parse(txtAmount.text);
            transmitPartPay.PartPay_DueDate = calDueDate.Value.ToString("MM/dd/yyyy");
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            decimal compBalance = (balanceHolder + editBalanceHold) - Int32.Parse(txtAmount.text);
            if (compBalance < 0)
            {
                MessageBox.Show("The amount you input exceed from the remaining balance", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                balanceHolder = (balanceHolder + editBalanceHold) - Int32.Parse(txtAmount.text);
                isConfirmed = true;
                TransmitPartData();
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
