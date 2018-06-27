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
    public partial class AddOtherFeesForm : Form
    {
        public bool isConfirmed;
        public decimal balanceHolder = 0;
        public decimal editBalanceHold = 0;
        private OtherFeesItem transmitOtherFees = new OtherFeesItem();

        public OtherFeesItem pubTransmitOtherFees
        {
            get { return transmitOtherFees; }
            set { transmitOtherFees = value; }
        }
        public AddOtherFeesForm()
        {
            InitializeComponent();
        }
        public void TransmitOtherFees()
        {
            transmitOtherFees = new OtherFeesItem();
            transmitOtherFees.OtherFees_Description = txtDescription.text;
            transmitOtherFees.OtherFees_Amount = Decimal.Parse(txtAmount.text);
            transmitOtherFees.OtherFees_DueDate = calDueDate.Value.ToString("MM/dd/yyyy");
            transmitOtherFees.OtherFees_CutOffDate = calCutOff.Value.ToString("MM/dd/yyyy");
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
                TransmitOtherFees();
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
