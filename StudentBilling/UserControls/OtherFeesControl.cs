using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentBillingLibrary;

namespace StudentBilling
{
    public partial class OtherFeesControl : UserControl
    {
        OtherFeesCollection loadOtherFeesGrid = new OtherFeesCollection();
        OtherFeesCollection loadOther = new OtherFeesCollection();
        OtherFeesPaymentCollection loadOtherPay = new OtherFeesPaymentCollection();
        int otherId;
        bool stop = false;
        public OtherFeesControl()
        {
            InitializeComponent();
        }
        public void LoadOtherFees()
        {
            loadOtherFeesGrid.LoadOtherFeesFromDb();

            //gridOtherFees.Rows.Count = 1;

            foreach (var popOtherFees in loadOtherFeesGrid.pubOtherFeesCollect)
            {
                //gridOtherFees.Rows.Count++;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 1] = popOtherFees.OtherFees_Description;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 2] = popOtherFees.OtherFees_PayNumber;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 3] = popOtherFees.OtherFees_Amount;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 4] = popOtherFees.OtherFees_Payment;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 5] = popOtherFees.OtherFees_DatePaid;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 6] = popOtherFees.OtherFees_Balance;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 7] = popOtherFees.OtherFees_PaymentMade;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 8] = popOtherFees.OtherFees_DueDate;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 9] = popOtherFees.OtherFees_CutOffDate;
            }
        }
        public void LoadOtherFeesWithBillId()
        {
            loadOtherFeesGrid.LoadOtherFeesWithBillIdFromDb(Int32.Parse(LoginUser.stdLogStudentBillId));

           // gridOtherFees.Rows.Count = 1;

            foreach (var popOtherFees in loadOtherFeesGrid.pubOtherFeesCollect)
            {
                //gridOtherFees.Rows.Count++;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 1] = popOtherFees.OtherFees_Description;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 2] = popOtherFees.OtherFees_PayNumber;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 3] = popOtherFees.OtherFees_Amount;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 4] = popOtherFees.OtherFees_Payment;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 5] = popOtherFees.OtherFees_DatePaid;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 6] = popOtherFees.OtherFees_Balance;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 7] = popOtherFees.OtherFees_PaymentMade;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 8] = popOtherFees.OtherFees_DueDate;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 9] = popOtherFees.OtherFees_CutOffDate;
            }
        }
        public void LoadSelectedOtherFees()
        {
           // loadOtherFeesGrid.LoadSelectedOtherFeesFromDb(drdOtherFeesDescription.selectedValue);

            //gridOtherFees.Rows.Count = 1;

            foreach (var popOtherFees in loadOtherFeesGrid.pubOtherFeesCollect)
            {
                //gridOtherFees.Rows.Count++;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 1] = popOtherFees.OtherFees_Description;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 2] = popOtherFees.OtherFees_PayNumber;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 3] = popOtherFees.OtherFees_Amount;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 4] = popOtherFees.OtherFees_Payment;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 5] = popOtherFees.OtherFees_DatePaid;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 6] = popOtherFees.OtherFees_Balance;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 7] = popOtherFees.OtherFees_PaymentMade;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 8] = popOtherFees.OtherFees_DueDate;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 9] = popOtherFees.OtherFees_CutOffDate;
            }
        }
        public void LoadSelectedOtherFeesWithBillId()
        {
           // loadOtherFeesGrid.LoadSelectedOtherFeesWithBillIdFromDb(drdOtherFeesDescription.selectedValue, Int32.Parse(LoginUser.stdLogStudentBillId));

           // gridOtherFees.Rows.Count = 1;

            foreach (var popOtherFees in loadOtherFeesGrid.pubOtherFeesCollect)
            {
                //gridOtherFees.Rows.Count++;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 1] = popOtherFees.OtherFees_Description;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 2] = popOtherFees.OtherFees_PayNumber;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 3] = popOtherFees.OtherFees_Amount;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 4] = popOtherFees.OtherFees_Payment;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 5] = popOtherFees.OtherFees_DatePaid;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 6] = popOtherFees.OtherFees_Balance;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 7] = popOtherFees.OtherFees_PaymentMade;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 8] = popOtherFees.OtherFees_DueDate;
                //gridOtherFees[gridOtherFees.Rows.Count - 1, 9] = popOtherFees.OtherFees_CutOffDate;
            }
        }
        public void PopulateOtherFeesDropDown()
        {
            loadOtherFeesGrid.GetOtherFeesDescriptionFromDb();

            foreach (var populateDropDown in loadOtherFeesGrid.pubOtherFeesCollect)
            {
                //drdOtherFeesDescription.AddItem(populateDropDown.OtherFees_Description);
            }
        }
        public void PopulateOtherFeesWithBillIdDropDown()
        {
            loadOtherFeesGrid.GetOtherFeesDescriptionWithBillIdFromDb(Int32.Parse(LoginUser.stdLogStudentBillId));

            foreach (var populateDropDown in loadOtherFeesGrid.pubOtherFeesCollect)
            {
              //  drdOtherFeesDescription.AddItem(populateDropDown.OtherFees_Description);
            }
        }

        private void OtherFeesControl_Load(object sender, EventArgs e)
        {
            //PopulateOtherFeesWithBillIdDropDown();
            //LoadOtherFeesWithBillId();
            LoadStdOtherPay();
            LoadStdOtherPayments();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drdOtherFeesDescription_onItemSelected(object sender, EventArgs e)
        {
            PopulateSelectedDescriptionDropDown();
        }
        public void PopulateSelectedDescriptionDropDown()
        {
            //if (drdOtherFeesDescription.selectedValue == "All")
            //{
            //    LoadOtherFeesWithBillId();
            //}
            //else
            //{
            //    LoadSelectedOtherFeesWithBillId();
            //}
        }
        private void drdOtherFeesDescription_RegionChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadStdOtherPay()
        {
            loadOther = new OtherFeesCollection();
            loadOther.LoadOtherFeesWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            gridOther.Rows.Count = 1;

            foreach (var popOther in loadOther.pubOtherFeesCollect)
            {
                if (DateTime.Parse(popOther.OtherFees_CutOffDate) < DateTime.Today)
                {
                    var setOldOtherManage = new OtherFeesManager();
                    setOldOtherManage.SetOtherToOld(popOther.OtherFees_Id);
                    stop = true;
                }
                else
                {
                    gridOther.Rows.Count++;
                    gridOther[gridOther.Rows.Count - 1, 9] = popOther.OtherFees_Id;
                    gridOther[gridOther.Rows.Count - 1, 1] = popOther.OtherFees_Description;
                    gridOther[gridOther.Rows.Count - 1, 2] = popOther.OtherFees_Amount;
                    gridOther[gridOther.Rows.Count - 1, 3] = popOther.OtherFees_Balance;
                    gridOther[gridOther.Rows.Count - 1, 4] = popOther.OtherFees_DueDate;
                    gridOther[gridOther.Rows.Count - 1, 5] = popOther.OtherFees_PaymentMade;
                    gridOther[gridOther.Rows.Count - 1, 6] = popOther.OtherFees_Status;
                    gridOther[gridOther.Rows.Count - 1, 7] = popOther.OtherFees_DatePaid;
                    gridOther[gridOther.Rows.Count - 1, 8] = popOther.OtherFees_CutOffDate;
                }
            }
        }
        private void LoadStdOtherPayments()
        {
            if (stop == true)
            {
                gridOtherPay.Rows.Count = 1;
                return;
            }
            if (gridOther.Rows.Count == 1)
            {
                otherId = 0;
            }
            else
            {
                otherId = Int32.Parse(gridOther[gridOther.RowSel, 9].ToString());
            }
            loadOtherPay = new OtherFeesPaymentCollection();
            loadOtherPay.LoadOtherPayWithOtherIdFromDb(otherId);

            gridOtherPay.Rows.Count = 1;

            foreach (var popOtherPay in loadOtherPay.pubOtherPayCollect)
            {
                gridOtherPay.Rows.Count++;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 1] = popOtherPay.OtherPay_Number;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 2] = popOtherPay.OtherPay_Paid;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 3] = popOtherPay.OtherPay_DatePaid;
            }
        }

        private void gridOther_Click(object sender, EventArgs e)
        {
            otherId = Int32.Parse(gridOther[gridOther.RowSel, 9].ToString());
            LoadStdOtherPayments();
        }
    }
}
