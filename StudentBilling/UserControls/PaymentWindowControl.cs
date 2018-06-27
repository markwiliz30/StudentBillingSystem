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
    public partial class PaymentWindowControl : UserControl
    {
        int selectedId = 0;
        int selectedPartId = 0;
        int selectedOtherId = 0;
        int selectedOldId = 0;
        int payNumber = 0;
        int OldBillId = 0;
        int OldStdId = 0;
        bool isOld = false;
        decimal totalOldBal = 0;
        decimal amountPay = 0;
        decimal balanceHold = 0;
        decimal balanceDiff = 0;
        decimal totalBalDiff = 0;
        decimal payMadeSum = 0;
        decimal totalPayMadeSum = 0;

        string datePay;
        OtherFeesCollection loadOther = new OtherFeesCollection();
        StudentCollection loadStudentData = new StudentCollection();
        BillCollection loadSelectedBill = new BillCollection();
        TuitionPayments loadTuitionPay = new TuitionPayments();
        OtherPayments loadOtherPay = new OtherPayments();
        TuitionPaymentsOld loadOldTuitionPay = new TuitionPaymentsOld();
        OtherPaymentsOld loadOldOtherPay = new OtherPaymentsOld();
        PartialPaymentCollection loadPartialPay = new PartialPaymentCollection();
        PaymentCollection loadPayments = new PaymentCollection();
        OtherFeesPaymentCollection loadOtherPayments = new OtherFeesPaymentCollection();
        PaymentItem myPayItem = new PaymentItem();
        OtherFeesPaymentItem myOtherItem = new OtherFeesPaymentItem();
        OldTuitionItem myOldTuition = new OldTuitionItem();
        OldTuitionCollection myOldCollect = new OldTuitionCollection();
   
        public PaymentWindowControl()
        {
            InitializeComponent();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void PaymentWindowControl_Load(object sender, EventArgs e)
        {
            LoadStudents();
            StdClick();
        }
        private void LoadStudents()
        {
            loadStudentData = new StudentCollection();
            loadStudentData.LoadStudentsFromDb();

            gridStd.Rows.Count = 1;
        
            foreach (var popStd in loadStudentData.pubStudentCollect)
            {
                gridStd.Rows.Count++;
                gridStd[gridStd.Rows.Count - 1, 1] = popStd.Std_Id;
                gridStd[gridStd.Rows.Count - 1, 2] = popStd.Std_FName;
                gridStd[gridStd.Rows.Count - 1, 3] = popStd.Std_LName;
                gridStd[gridStd.Rows.Count - 1, 4] = popStd.Std_MName;
                gridStd[gridStd.Rows.Count - 1, 5] = popStd.Std_CourseCode;
                gridStd[gridStd.Rows.Count - 1, 6] = popStd.Std_CourseTitle;
                gridStd[gridStd.Rows.Count - 1, 7] = popStd.Std_Year;
                gridStd[gridStd.Rows.Count - 1, 8] = popStd.Std_Section;
            }
        }
        private void gridStd_Click(object sender, EventArgs e)
        {
            StdClick();
        }
        public void HoldBalance()
        {
            if (gridTuition.Rows.Count == 1)
            {
                balanceHold = 0;
            }
            else
            {
                balanceHold = Decimal.Parse(gridTuition[gridTuition.RowSel, 4].ToString());
            }
        }
        private void StdClick()
        {
            if (gridStd.Rows.Count == 1)
            {
                selectedId = 0;
            }
            else
            {
                selectedId = Int32.Parse(gridStd[gridStd.RowSel, 1].ToString());
            }
            //LoadSelectedPartPay();
            LoadSelectedBill();
            LoadSelectedTuitionpay();
            LoadSelectedOtherPay();
            ////LoadOld();
            if (gridTuition.Rows.Count != 1)
            {
                selectedPartId = Int32.Parse(gridTuition[gridTuition.RowSel, 1].ToString());
            }
            LoadSelectedPartPay();
            //LoadSelectedOldPayments();
            if (gridOther.Rows.Count != 1)
            {
                selectedOtherId = Int32.Parse(gridOther[gridOther.RowSel, 1].ToString());
            }
            else
            {
                selectedOtherId = 0;
            }
            LoadSelectedOtherPayments();
            if (lblHiddenBillId.Text == "")
            {
                lblTotalAmount.Text = "N/A";
                lblFinalAmount.Text = "N/A";
                lblDiscount.Text = "N/A";
                lblPaymentMade.Text = "N/A";
                lblSemester.Text = "N/A";
                lblBalance.Text = "N/A";
                lblSchoolYr.Text = "N/A";
            }
            LoadOldPart();
            LoadOld();
            if (gridOld.Rows.Count != 1)
            {
                selectedOldId = Int32.Parse(gridOld[gridOld.RowSel, 1].ToString());
            }
            else
            {
                selectedOldId = 0;
            }
            LoadSelectedOldPayments();
            BtnPayIsActive();
            BtnOtherIsActive();
            HoldBalance();
        }
        private void LoadOld()
        {
            gridOld.Rows.Count = 1;
            LoadOldBal();
            LoadSelectedOldOtherPay();
        }
        private void LoadOldBal()
        {
            myOldCollect = new OldTuitionCollection();
            myOldCollect.LoadOldTuitionWithStdIdFromDb(selectedId);

            gridOld.Rows.Count = 1;

            foreach (var popOld in myOldCollect.pubOldCollect)
            {
                gridOld.Rows.Count++;
                gridOld[gridOld.Rows.Count - 1, 1] = popOld.OldTuition_Id;
                gridOld[gridOld.Rows.Count - 1, 2] = popOld.OldTuition_Description;
                gridOld[gridOld.Rows.Count - 1, 3] = popOld.OldTuition_Amount;
                gridOld[gridOld.Rows.Count - 1, 4] = popOld.OldTuition_Balance;
                gridOld[gridOld.Rows.Count - 1, 5] = popOld.OldTuition_PayMade;
                gridOld[gridOld.Rows.Count - 1, 6] = popOld.OldTuition_Status;
            }
        }
        private void LoadSelectedOldTuitionPay()
        {
            //loadOldTuitionPay = new TuitionPaymentsOld();
            //loadOldTuitionPay.LoadJoinOldPartialPaymentsFromDb(selectedId);

            //gridOld.Rows.Count = 1;

            //foreach (var popOldPay in loadOldTuitionPay.pubBillCollect)
            //{
            //    gridOld.Rows.Count++;
            //    gridOld[gridOld.Rows.Count - 1, 1] = popOldPay.;
            //    gridTuition[gridTuition.Rows.Count - 1, 5] = popPay.Payment_Paid;
            //    gridTuition[gridTuition.Rows.Count - 1, 6] = popPay.Payment_DatePaid;

            //    foreach (var popPart in loadTuitionPay.pubPartialCollect)
            //    {
            //        gridTuition[gridTuition.Rows.Count - 1, 2] = popPart.PartPay_Id;
            //        gridTuition[gridTuition.Rows.Count - 1, 3] = popPart.PartPay_Amount;
            //        gridTuition[gridTuition.Rows.Count - 1, 7] = popPart.PartPay_Balance;
            //        gridTuition[gridTuition.Rows.Count - 1, 8] = popPart.PartPay_PaymentMade;
            //        gridTuition[gridTuition.Rows.Count - 1, 9] = popPart.PartPay_DueDate;
            //        gridTuition[gridTuition.Rows.Count - 1, 10] = popPart.PartPay_Status;
            //    }
            //}
        }
        //private void LoadSelectedOldBill()
        //{
        //    loadSelectedBill = new BillCollection();
        //    loadSelectedBill.LoadOldBillWithStdIdFromDb(selectedId);

        //    foreach (var popOldBill in loadSelectedBill.pubBillCollect)
        //    {
        //        gridOld.Rows.Count++;
        //        gridOld[gridOld.Rows.Count - 1, 1] = popOldBill.Bill_Id;
        //        gridOld[gridOld.Rows.Count - 1, 2] = popOldBill.Bill_Description;
        //        gridOld[gridOld.Rows.Count - 1, 3] = popOldBill.Bill_TotalAmount;
        //        gridOld[gridOld.Rows.Count - 1, 4] = popOldBill.Bill_Balance;
        //        gridOld[gridOld.Rows.Count - 1, 5] = popOldBill.Bill_PaymentMade;
        //        gridOld[gridOld.Rows.Count - 1, 6] = popOldBill.Bill_Status;
        //    }
        //}
        private void LoadOldPart()
        {
            loadPartialPay = new PartialPaymentCollection();
            loadPartialPay.LoadOldPartWithStdIdFromDb(selectedId);

            foreach (var popOld in loadPartialPay.pubOtherFeesCollect)
            {
                totalOldBal = totalOldBal + popOld.PartPay_Balance;
                OldBillId = popOld.PartPay_Bill_Id;
                OldStdId = popOld.PartPay_Std_Id;
            }
            myOldCollect = new OldTuitionCollection();
            myOldCollect.LoadOldTuitionFromDb();
            if (myOldCollect.pubOldCollect.All(x => (x.OldTuition_Bill_Id != OldBillId && x.OldTuition_Std_Id != OldStdId)))
            {
                if (totalOldBal != 0)
                {
                    InsertToOldTable();
                    totalOldBal = 0;
                }
            }
        }
        private void InsertToOldTable()
        {
            OldTuitionManager oldManage = new OldTuitionManager();
            SetOldData();
            oldManage.SaveOldTuition(myOldTuition);
        }
        private void SetOldData()
        {
            myOldTuition = new OldTuitionItem();

            myOldTuition.OldTuition_Bill_Id = OldBillId;
            myOldTuition.OldTuition_Std_Id = OldStdId;
            myOldTuition.OldTuition_Description = "Tuition Fee";
            myOldTuition.OldTuition_Amount = totalOldBal;
            myOldTuition.OldTuition_Balance = totalOldBal;
            myOldTuition.OldTuition_DatePaid = "N/A";
            myOldTuition.OldTuition_PayMade = 0;
            myOldTuition.OldTuition_Status = "false";
            myOldTuition.OldTuition_Deleted = "no";
        }
        private void LoadSelectedBill()
        {
            lblHiddenBillId.Text = "";
            loadSelectedBill = new BillCollection();
            loadSelectedBill.LoadBillWithStdIdFromDb(selectedId);

            foreach (var popBill in loadSelectedBill.pubBillCollect)
            {
                lblHiddenBillId.Text = popBill.Bill_Id.ToString();
                lblTotalAmount.Text = popBill.Bill_TotalAmount.ToString();
                lblDiscount.Text = popBill.Bill_Discount.ToString();
                lblFinalAmount.Text = popBill.Bill_FinalAmount.ToString();
                lblPaymentMade.Text = popBill.Bill_PaymentMade.ToString();
                lblSemester.Text = popBill.Bill_Semester;
                lblBalance.Text = popBill.Bill_Balance.ToString();
                lblSchoolYr.Text = popBill.Bill_SchoolYear;
            }
        }
        private void LoadSelectedTuitionpay()
        {
            if (lblHiddenBillId.Text != "")
            {
                loadPartialPay = new PartialPaymentCollection();
                loadPartialPay.LoadPartialPaymentWithIdsFromDb(Int32.Parse(lblHiddenBillId.Text), selectedId);

                gridTuition.Rows.Count = 1;

                foreach (var popPartial in loadPartialPay.pubOtherFeesCollect)
                {
                    gridTuition.Rows.Count++;
                    gridTuition[gridTuition.Rows.Count - 1, 1] = popPartial.PartPay_Id;
                    gridTuition[gridTuition.Rows.Count - 1, 2] = popPartial.PartPay_Partition;
                    gridTuition[gridTuition.Rows.Count - 1, 3] = popPartial.PartPay_Amount;
                    gridTuition[gridTuition.Rows.Count - 1, 4] = popPartial.PartPay_Balance;
                    gridTuition[gridTuition.Rows.Count - 1, 5] = popPartial.PartPay_DueDate;
                    gridTuition[gridTuition.Rows.Count - 1, 6] = popPartial.PartPay_PaymentMade;
                    gridTuition[gridTuition.Rows.Count - 1, 7] = popPartial.PartPay_Status;
                }
            }
            else
            {
                gridTuition.Rows.Count = 1;
            }
        }
        private void LoadSelectedOtherPay()
        {
            if (lblHiddenBillId.Text != "")
            {
                loadOther = new OtherFeesCollection();
                loadOther.LoadOtherFeesWithBillIdFromDb(Int32.Parse(lblHiddenBillId.Text));

                gridOther.Rows.Count = 1;

                foreach (var popOther in loadOther.pubOtherFeesCollect)
                {
                    gridOther.Rows.Count++;
                    gridOther[gridOther.Rows.Count - 1, 1] = popOther.OtherFees_Id;
                    gridOther[gridOther.Rows.Count - 1, 2] = popOther.OtherFees_Description;
                    gridOther[gridOther.Rows.Count - 1, 3] = popOther.OtherFees_Amount;
                    gridOther[gridOther.Rows.Count - 1, 4] = popOther.OtherFees_Balance;
                    gridOther[gridOther.Rows.Count - 1, 5] = popOther.OtherFees_DueDate;
                    gridOther[gridOther.Rows.Count - 1, 6] = popOther.OtherFees_PaymentMade;
                    gridOther[gridOther.Rows.Count - 1, 7] = popOther.OtherFees_Status;
                }
            }
            else
            {
                gridOther.Rows.Count = 1;
            }
        }
        private void LoadSelectedOldOtherPay()
        {
            loadOther = new OtherFeesCollection();
            loadOther.LoadOldOtherFeesWithStdIdFromDb(selectedId);

            foreach (var popOther in loadOther.pubOtherFeesCollect)
            {
                gridOld.Rows.Count++;
                gridOld[gridOld.Rows.Count - 1, 1] = popOther.OtherFees_Id;
                gridOld[gridOld.Rows.Count - 1, 2] = popOther.OtherFees_Description;
                gridOld[gridOld.Rows.Count - 1, 3] = popOther.OtherFees_Amount;
                gridOld[gridOld.Rows.Count - 1, 4] = popOther.OtherFees_Balance;
                gridOld[gridOld.Rows.Count - 1, 5] = popOther.OtherFees_PaymentMade;
                gridOld[gridOld.Rows.Count - 1, 6] = popOther.OtherFees_Status;
            }
        }

        private void LoadOtherPay()
        {
            //loadOther = new OtherFeesCollection();
            //loadOther.LoadOtherFeesWithBillIdFromDb(Int32.Parse(lblHiddenBillId.Text));

            //gridOtherPay.Rows.Count = 1;
            //foreach (var popOtherPay in loadOtherPay.pubOtherPaymentCollect)
            //{
            //    gridOtherPay.Rows.Count++;
            //    gridOtherPay[gridOtherPay.Rows.Count - 1, 1] = popOtherPay.OtherPay_Number;
            //    gridOtherPay[gridOtherPay.Rows.Count - 1, 2] = popOtherPay.OtherPay_Paid;
            //    gridOtherPay[gridOtherPay.Rows.Count - 1, 3] = popOtherPay.OtherPay_DatePaid;
            //}
        }

        private void txtSearchStd_OnTextChange(object sender, EventArgs e)
        {
            if (txtSearchStd.text == "")
            {
                LoadStudents();
                selectedId = Int32.Parse(gridStd[gridStd.RowSel, 1].ToString());
            }
            else
            {
                SearchStud();
                if (gridStd.Rows.Count == 1)
                {
                    lblTotalAmount.Text = "N/A";
                    lblFinalAmount.Text = "N/A";
                    lblDiscount.Text = "N/A";
                    lblPaymentMade.Text = "N/A";
                    lblSemester.Text = "N/A";
                    lblBalance.Text = "N/A";
                    lblSchoolYr.Text = "N/A";
                    gridOther.Rows.Count = 1;
                    gridTuition.Rows.Count = 1;
                }
                else
                {
                    selectedId = Int32.Parse(gridStd[gridStd.RowSel, 1].ToString());
                } 
            }
            StdClick();
        }
        private void SearchStud()
        {
            loadStudentData = new StudentCollection();
            loadStudentData.SearchStudent(txtSearchStd.text);

            gridStd.Rows.Count = 1;

            foreach (var popStd in loadStudentData.pubStudentCollect)
            {
                gridStd.Rows.Count++;
                gridStd[gridStd.Rows.Count - 1, 1] = popStd.Std_Id;
                gridStd[gridStd.Rows.Count - 1, 2] = popStd.Std_FName;
                gridStd[gridStd.Rows.Count - 1, 3] = popStd.Std_LName;
                gridStd[gridStd.Rows.Count - 1, 4] = popStd.Std_MName;
                gridStd[gridStd.Rows.Count - 1, 5] = popStd.Std_CourseCode;
                gridStd[gridStd.Rows.Count - 1, 6] = popStd.Std_CourseTitle;
                gridStd[gridStd.Rows.Count - 1, 7] = popStd.Std_Year;
                gridStd[gridStd.Rows.Count - 1, 8] = popStd.Std_Section;
            }

        }
        private void gridTuition_Click(object sender, EventArgs e)
        {
            selectedPartId = Int32.Parse(gridTuition[gridTuition.RowSel, 1].ToString());
            LoadSelectedPartPay();
        }
        public void BtnPayIsActive()
        {
            if (gridTuition.Rows.Count == 1)
            {
                btnAddPayTuition.Enabled = false;
            }
            else
            {
                btnAddPayTuition.Enabled = true;
            }
        }
        public void BtnOtherIsActive()
        {
            if (gridOther.Rows.Count == 1)
            {
                btnAddPayOther.Enabled = false;
            }
            else
            {
                btnAddPayOther.Enabled = true;
            }
        }
        private void LoadSelectedPartPay()
        {
            loadPayments = new PaymentCollection();
            loadPayments.LoadPaymentsWithPartialIdFromDb(selectedPartId);

            gridTuitionPay.Rows.Count = 1;

            foreach (var popPartPay in loadPayments.pubPayCollect)
            {
                gridTuitionPay.Rows.Count++;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 1] = popPartPay.Payment_Number;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 2] = popPartPay.Payment_Paid;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 3] = popPartPay.Payment_DatePaid;
            }
            if (gridTuitionPay[gridTuitionPay.Rows.Count - 1, 1].ToString() != "Payment no.")
            {
                payNumber = Int32.Parse(gridTuitionPay[gridTuitionPay.Rows.Count - 1, 1].ToString());
            }
            else
            {
                payNumber = 0;
            }
        }
        private void LoadSelectedOtherPayments()
        {
            loadOtherPayments = new OtherFeesPaymentCollection();
            loadOtherPayments.LoadOtherPayWithOtherIdFromDb(selectedOtherId);

            gridOtherPay.Rows.Count = 1;

            foreach (var popOtherPay in loadOtherPayments.pubOtherPayCollect)
            {
                gridOtherPay.Rows.Count++;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 1] = popOtherPay.OtherPay_Number;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 2] = popOtherPay.OtherPay_Paid;
                gridOtherPay[gridOtherPay.Rows.Count - 1, 3] = popOtherPay.OtherPay_DatePaid;
            }
            if (gridOtherPay[gridOtherPay.Rows.Count - 1, 1].ToString() != "Payment no.")
            {
                payNumber = Int32.Parse(gridOtherPay[gridOtherPay.Rows.Count - 1, 1].ToString());
            }
            else
            {
                payNumber = 0;
            }
        }

        private void gridTuition_RowColChange(object sender, EventArgs e)
        {
            if (gridTuition.Rows.Count == 1)
            {
                selectedPartId = 0;
            }
        }

        private void gridOther_Click(object sender, EventArgs e)
        {
            selectedOtherId = Int32.Parse(gridOther[gridOther.RowSel, 1].ToString());
            LoadSelectedOtherPayments();
        }

        private void gridOld_Click(object sender, EventArgs e)
        {
            selectedOldId = Int32.Parse(gridOld[gridOld.RowSel, 1].ToString());
            LoadSelectedOldPayments();
        }
        private void LoadSelectedOldPayments()
        {
            gridOldPay.Rows.Count = 1;
            LoadSelectedOldOtherPayments();
            LoadSelectedOldPartPay();
            if (gridOldPay[gridOldPay.Rows.Count - 1, 1].ToString() != "Payment no.")
            {
                payNumber = Int32.Parse(gridOldPay[gridOldPay.Rows.Count - 1, 1].ToString());
            }
            else
            {
                payNumber = 0;
            }
        }
        private void LoadSelectedOldOtherPayments()
        {
            loadOtherPayments = new OtherFeesPaymentCollection();
            loadOtherPayments.LoadOtherPayWithOtherIdOldFromDb(selectedOldId);

            foreach (var popOtherPay in loadOtherPayments.pubOtherPayCollect)
            {
                gridOldPay.Rows.Count++;
                gridOldPay[gridOldPay.Rows.Count - 1, 1] = popOtherPay.OtherPay_Number;
                gridOldPay[gridOldPay.Rows.Count - 1, 2] = popOtherPay.OtherPay_Paid;
                gridOldPay[gridOldPay.Rows.Count - 1, 3] = popOtherPay.OtherPay_DatePaid;
            }
        }
        private void LoadSelectedOldPartPay()
        {
            loadPayments = new PaymentCollection();
            loadPayments.LoadPaymentsWithBillIdFromDb(selectedOldId);

            foreach (var popPartPay in loadPayments.pubPayCollect)
            {
                gridOldPay.Rows.Count++;
                gridOldPay[gridOldPay.Rows.Count - 1, 1] = popPartPay.Payment_Number;
                gridOldPay[gridOldPay.Rows.Count - 1, 2] = popPartPay.Payment_Paid;
                gridOldPay[gridOldPay.Rows.Count - 1, 3] = popPartPay.Payment_DatePaid;
            }

        }

        private void btnAddPayTuition_Click(object sender, EventArgs e)
        {
            AddPayTuition();
            LoadSelectedPartPay();
        }
        public void AddPayTuition()
        {
            using (PaymentWindowForm addPay = new PaymentWindowForm())
            {
                addPay.lblSelectedFee.Text = "Tuition Fee";
                addPay.lblBalance.Text = gridTuition[gridTuition.RowSel, 4].ToString();
                addPay.payNum = payNumber;
                addPay.ShowDialog();
                if (addPay.isConfirmed == true)
                {
                    amountPay = addPay.amountHold;
                    datePay = addPay.dateHold;
                    balanceDiff = Decimal.Parse(gridTuition[gridTuition.RowSel, 4].ToString()) - amountPay;
                    totalBalDiff = Decimal.Parse(lblBalance.Text) - amountPay;
                    payMadeSum = Decimal.Parse(gridTuition[gridTuition.RowSel, 6].ToString()) + amountPay;
                    totalPayMadeSum = Decimal.Parse(lblPaymentMade.Text) + amountPay;
                    InsertTuitionPay();
                    UpdateBalance();

                    LoadSelectedBill();
                    LoadSelectedTuitionpay();

                    if (gridTuition.Rows.Count != 1)
                    {
                        selectedPartId = Int32.Parse(gridTuition[gridTuition.RowSel, 1].ToString());
                    }
                    LoadSelectedPartPay();
                }
                // do what ever with result...
            }
        }
        public void AddPayOther()
        {
            using (PaymentWindowForm addPay = new PaymentWindowForm())
            {
                addPay.lblSelectedFee.Text = gridOther[gridOther.RowSel, 2].ToString();
                addPay.lblBalance.Text = gridOther[gridOther.RowSel, 4].ToString();
                addPay.payNum = payNumber;
                addPay.ShowDialog();
                if (addPay.isConfirmed == true)
                {
                    amountPay = addPay.amountHold;
                    datePay = addPay.dateHold;
                    balanceDiff = Decimal.Parse(gridOther[gridOther.RowSel, 4].ToString()) - amountPay;
                    totalBalDiff = Decimal.Parse(lblBalance.Text) - amountPay;
                    payMadeSum = Decimal.Parse(gridOther[gridOther.RowSel, 6].ToString()) + amountPay;
                    totalPayMadeSum = Decimal.Parse(lblPaymentMade.Text) + amountPay;
                    InsertOtherPay();
                    UpdateOtherBalance();

                    LoadSelectedBill();
                    LoadSelectedOtherPay();

                    if (gridOther.Rows.Count != 1)
                    {
                        selectedOtherId = Int32.Parse(gridOther[gridOther.RowSel, 1].ToString());
                    }
                    else
                    {
                        selectedOtherId = 0;
                    }
                    LoadSelectedOtherPayments();
                }
                // do what ever with result...
            }
        }
        public void AddPayOld()
        {
            using (PaymentWindowForm addPay = new PaymentWindowForm())
            {
                addPay.lblSelectedFee.Text = gridOld[gridOld.RowSel, 2].ToString();
                addPay.lblBalance.Text = gridOld[gridOld.RowSel, 4].ToString();
                addPay.ShowDialog();
                if (addPay.isConfirmed == true)
                {
                    amountPay = addPay.amountHold;
                    datePay = addPay.dateHold;
                    balanceDiff = Decimal.Parse(gridOld[gridOld.RowSel, 4].ToString()) - amountPay;
                    payMadeSum = Decimal.Parse(gridOld[gridOld.RowSel, 5].ToString()) + amountPay;

                    isOld = true;
                    if (gridOld[gridOld.RowSel, 2].ToString() == "Tuition Fee")
                    {
                        InsertTuitionPay();
                        UpdateOldBalance();
                    }
                    else
                    {
                        InsertOtherPay();
                        UpdateOldOtherBalance();
                    }

                    LoadOld();

                    if (gridOld.Rows.Count != 1)
                    {
                        selectedOldId = Int32.Parse(gridOld[gridOld.RowSel, 1].ToString());
                    }
                    else
                    {
                        selectedOldId = 0;
                    }
                    isOld = false;
                }
                // do what ever with result...
            }
        }
        public void InsertTuitionPay()
        {
            PaymentManager payManage = new PaymentManager();
            SetPayData();
            payManage.SavePayment(myPayItem);
        }
        public void InsertOtherPay()
        {
            OtherFeesPaymentManager otherManage = new OtherFeesPaymentManager();
            SetOtherData();
            otherManage.SaveOtherPay(myOtherItem);
        }
        public void UpdateBalance()
        {
            PaymentManager payManage = new PaymentManager();
            payManage.UpdateBalance(balanceDiff, payMadeSum, selectedPartId, totalBalDiff, totalPayMadeSum, Int32.Parse(lblHiddenBillId.Text));
        }
        public void UpdateOtherBalance()
        {
            OtherFeesPaymentManager otherManage = new OtherFeesPaymentManager();
            otherManage.UpdateBalance(balanceDiff, payMadeSum, selectedOtherId, totalBalDiff, totalPayMadeSum, Int32.Parse(lblHiddenBillId.Text));
        }
        public void UpdateOldBalance()
        {
            OldTuitionManager oldManage = new OldTuitionManager();
            oldManage.UpdateOldBalance(balanceDiff, payMadeSum, selectedOldId);
        }
        public void UpdateOldOtherBalance()
        {
            OldTuitionManager oldManage = new OldTuitionManager();
            oldManage.UpdateOldOtherBalance(balanceDiff, payMadeSum, selectedOldId);
        }
        public void SetPayData()
        {
            myPayItem = new PaymentItem();

            if (isOld == true)
            {
                myPayItem.Payment_PartPay_Id = selectedOldId;
            }
            else
            { 
                myPayItem.Payment_PartPay_Id = selectedPartId;
            }
            if (isOld == true)
            {
                myPayItem.Payment_Bill_Id = OldBillId;
            }
            else
            {
                myPayItem.Payment_Bill_Id = Int32.Parse(lblHiddenBillId.Text);
            }
            myPayItem.Payment_Std_Id = selectedId;
            myPayItem.Payment_Number = payNumber + 1;
            myPayItem.Payment_Paid = amountPay;
            myPayItem.Payment_DatePaid = datePay;
            if (isOld == true)
            {
                myPayItem.Payment_IsOld = "true";
            }
            else
            {
                myPayItem.Payment_IsOld = "false";
            }
            myPayItem.Payment_Deleted = "no";
        }
        public void SetOtherData()
        {
            myOtherItem = new OtherFeesPaymentItem();

            if (isOld == true)
            {
                myOtherItem.OtherPay_OtherFees_Id = selectedOldId;
            }
            else
            { 
                myOtherItem.OtherPay_OtherFees_Id = selectedOtherId;
            }
            if (isOld == true)
            {
                myOtherItem.OtherPay_Bill_Id = OldBillId;
            }
            else
            {
                myOtherItem.OtherPay_Bill_Id = Int32.Parse(lblHiddenBillId.Text);
            }
            myOtherItem.OtherPay_Std_Id = selectedId;
            myOtherItem.OtherPay_Number = payNumber + 1;
            myOtherItem.OtherPay_Paid = amountPay;
            myOtherItem.OtherPay_DatePaid = datePay;
            if (isOld == true)
            {
                myOtherItem.OtherPay_IsOld = "true";
            }
            else
            {
                myOtherItem.OtherPay_IsOld = "false";
            }
            myOtherItem.OtherPay_Deleted = "no";
        }

        private void btnAddPayOther_Click(object sender, EventArgs e)
        {
            AddPayOther();
            LoadSelectedOtherPayments();
        }

        private void btnAddPayOld_Click(object sender, EventArgs e)
        {
            AddPayOld();
            LoadSelectedOldPayments();
        }
    }
}
