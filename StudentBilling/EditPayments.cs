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
    public partial class EditPayments : Form
    {
        public bool isConfirmed = false;
        public EditPayments()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValidatePay();
        }
        private void ValidatePay()
        {
            if (txtPayNo.text == "" || txtAmount.text == "")
            {
                MessageBox.Show("Please fill up all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                isConfirmed = true;
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
