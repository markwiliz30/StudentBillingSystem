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
    public partial class OldFeesControl : UserControl
    {
        OldBalanceCollection loadOldBalanceGrid = new OldBalanceCollection();
        OldTuitionCollection myOldCollect = new OldTuitionCollection();
        OtherFeesCollection loadOther = new OtherFeesCollection();
        OtherFeesPaymentCollection loadOtherPayments = new OtherFeesPaymentCollection();
        PaymentCollection loadPayments = new PaymentCollection();
        int oldId;
        public OldFeesControl()
        {
            InitializeComponent();
            LoadOldBalanceWithStdId();
            PopulateOldBalanceWithStdIdDropDown();
        }
        public void LoadOldBalance()
        {
            loadOldBalanceGrid.LoadOldBalanceFromDb();

            //gridOldBalance.Rows.Count = 1;

            //foreach (var popOldBalance in loadOldBalanceGrid.pubOldBalanceCollect)
            //{
            //    gridOldBalance.Rows.Count++;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 1] = popOldBalance.OldFees_Description;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 2] = popOldBalance.OldFees_PaymentNumber;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 3] = popOldBalance.OldFees_Amount;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 4] = popOldBalance.OldFees_Payment;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 5] = popOldBalance.OldFees_DatePaid;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 6] = popOldBalance.OldFees_Balance;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 7] = popOldBalance.OldFees_PaymentMade;
            //}
        }
        public void LoadOldBalanceWithStdId()
        {
            loadOldBalanceGrid.LoadOldBalanceWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            //gridOldBalance.Rows.Count = 1;

            //foreach (var popOldBalance in loadOldBalanceGrid.pubOldBalanceCollect)
            //{
            //    gridOldBalance.Rows.Count++;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 1] = popOldBalance.OldFees_Description;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 2] = popOldBalance.OldFees_PaymentNumber;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 3] = popOldBalance.OldFees_Amount;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 4] = popOldBalance.OldFees_Payment;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 5] = popOldBalance.OldFees_DatePaid;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 6] = popOldBalance.OldFees_Balance;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 7] = popOldBalance.OldFees_PaymentMade;
            //}
        }
        public void LoadSelectedOldBalance()
        {
            //loadOldBalanceGrid.LoadSelectedOldBalanceFromDb(drdOldFeeDescription.selectedValue);

            //gridOldBalance.Rows.Count = 1;

            //foreach (var popOtherFees in loadOldBalanceGrid.pubOldBalanceCollect)
            //{
            //    gridOldBalance.Rows.Count++;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 1] = popOtherFees.OldFees_Description;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 2] = popOtherFees.OldFees_PaymentNumber;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 3] = popOtherFees.OldFees_Amount;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 4] = popOtherFees.OldFees_Payment;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 5] = popOtherFees.OldFees_DatePaid;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 6] = popOtherFees.OldFees_Balance;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 7] = popOtherFees.OldFees_PaymentMade;
            //}
        }
        public void LoadSelectedOldBalanceWithStdId()
        {
            //loadOldBalanceGrid.LoadSelectedOldBalanceWithStdIdFromDb(drdOldFeeDescription.selectedValue, Int32.Parse(LoginUser.stdLogStudentId));

            //gridOldBalance.Rows.Count = 1;

            //foreach (var popOtherFees in loadOldBalanceGrid.pubOldBalanceCollect)
            //{
            //    gridOldBalance.Rows.Count++;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 1] = popOtherFees.OldFees_Description;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 2] = popOtherFees.OldFees_PaymentNumber;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 3] = popOtherFees.OldFees_Amount;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 4] = popOtherFees.OldFees_Payment;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 5] = popOtherFees.OldFees_DatePaid;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 6] = popOtherFees.OldFees_Balance;
            //    gridOldBalance[gridOldBalance.Rows.Count - 1, 7] = popOtherFees.OldFees_PaymentMade;
            //}
        }
        public void PopulateOldBalanceDropDown()
        {
            loadOldBalanceGrid.GetOldBalanceDescriptionFromDb();

            foreach (var populateDropDown in loadOldBalanceGrid.pubOldBalanceCollect)
            {
                //drdOldFeeDescription.AddItem(populateDropDown.OldFees_Description);
            }
        }
        public void PopulateOldBalanceWithStdIdDropDown()
        {
            loadOldBalanceGrid.GetOldBalanceWithStdIdDescriptionFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var populateDropDown in loadOldBalanceGrid.pubOldBalanceCollect)
            {
                //drdOldFeeDescription.AddItem(populateDropDown.OldFees_Description);
            }
        }
        public void PopulateSelectedDescriptionDropDown()
        {
            //if (drdOldFeeDescription.selectedValue == "All")
            //{
            //    LoadOldBalanceWithStdId();
            //}
            //else
            //{
            //    LoadSelectedOldBalanceWithStdId();
            //}
        }
        private void OldFeesControl_Load(object sender, EventArgs e)
        {
            LoadOld();
            LoadStdOldPayments();
        }

        private void drdOldFeeDescription_onItemSelected(object sender, EventArgs e)
        {
            PopulateSelectedDescriptionDropDown();
        }
        private void LoadOld()
        {
            gridOld.Rows.Count = 1;
            LoadOldBal();
            LoadStdOldOtherPay();
        }
        private void LoadOldBal()
        {
            myOldCollect = new OldTuitionCollection();
            myOldCollect.LoadOldTuitionWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            gridOld.Rows.Count = 1;

            foreach (var popOld in myOldCollect.pubOldCollect)
            {
                gridOld.Rows.Count++;
                gridOld[gridOld.Rows.Count - 1, 7] = popOld.OldTuition_Id;
                gridOld[gridOld.Rows.Count - 1, 1] = popOld.OldTuition_Description;
                gridOld[gridOld.Rows.Count - 1, 2] = popOld.OldTuition_Amount;
                gridOld[gridOld.Rows.Count - 1, 3] = popOld.OldTuition_Balance;
                gridOld[gridOld.Rows.Count - 1, 4] = popOld.OldTuition_PayMade;
                gridOld[gridOld.Rows.Count - 1, 5] = popOld.OldTuition_Status;
                gridOld[gridOld.Rows.Count - 1, 6] = popOld.OldTuition_DatePaid;
            }
        }
        private void LoadStdOldOtherPay()
        {
            loadOther = new OtherFeesCollection();
            loadOther.LoadOldOtherFeesWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var popOther in loadOther.pubOtherFeesCollect)
            {
                gridOld.Rows.Count++;
                gridOld[gridOld.Rows.Count - 1, 7] = popOther.OtherFees_Id;
                gridOld[gridOld.Rows.Count - 1, 1] = popOther.OtherFees_Description;
                gridOld[gridOld.Rows.Count - 1, 2] = popOther.OtherFees_Amount;
                gridOld[gridOld.Rows.Count - 1, 3] = popOther.OtherFees_Balance;
                gridOld[gridOld.Rows.Count - 1, 4] = popOther.OtherFees_PaymentMade;
                gridOld[gridOld.Rows.Count - 1, 5] = popOther.OtherFees_Status;
                gridOld[gridOld.Rows.Count - 1, 6] = popOther.OtherFees_DatePaid;
            }
        }
        private void LoadStdOldPayments()
        {
            gridOldPay.Rows.Count = 1;
            LoadStdOldOtherPayments();
            LoadStdOldPartPay();
        }
        private void LoadStdOldOtherPayments()
        {
            int oldId;
            if (gridOld.Rows.Count == 1)
            {
                oldId = 0;
            }
            else
            {
                oldId = Int32.Parse(gridOld[gridOld.RowSel, 7].ToString());
            }
            loadOtherPayments = new OtherFeesPaymentCollection();
            loadOtherPayments.LoadOtherPayWithOtherIdOldFromDb(oldId);

            foreach (var popOtherPay in loadOtherPayments.pubOtherPayCollect)
            {
                gridOldPay.Rows.Count++;
                gridOldPay[gridOldPay.Rows.Count - 1, 1] = popOtherPay.OtherPay_Number;
                gridOldPay[gridOldPay.Rows.Count - 1, 2] = popOtherPay.OtherPay_Paid;
                gridOldPay[gridOldPay.Rows.Count - 1, 3] = popOtherPay.OtherPay_DatePaid;
            }
        }
        private void LoadStdOldPartPay()
        { 
            if (gridOld.Rows.Count == 1)
            {
                oldId = 0;
            }
            else
            {
                oldId = Int32.Parse(gridOld[gridOld.RowSel, 7].ToString());
            }
            loadPayments = new PaymentCollection();
            loadPayments.LoadPaymentsWithBillIdFromDb(oldId);

            foreach (var popPartPay in loadPayments.pubPayCollect)
            {
                gridOldPay.Rows.Count++;
                gridOldPay[gridOldPay.Rows.Count - 1, 1] = popPartPay.Payment_Number;
                gridOldPay[gridOldPay.Rows.Count - 1, 2] = popPartPay.Payment_Paid;
                gridOldPay[gridOldPay.Rows.Count - 1, 3] = popPartPay.Payment_DatePaid;
            }

        }

        private void gridOld_Click(object sender, EventArgs e)
        {
            oldId = Int32.Parse(gridOld[gridOld.RowSel, 7].ToString());
            LoadStdOldPayments();
        }
    }
}
