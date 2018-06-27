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
    public partial class TuitionFeeControl : UserControl
    {
        PaymentCollection loadPaymentGrid = new PaymentCollection();
        BillCollection loadBillData = new BillCollection();
        PartialPaymentCollection loadPartialPay = new PartialPaymentCollection();
        PaymentCollection loadPayments = new PaymentCollection();
        OldTuitionCollection myOldCollect = new OldTuitionCollection();
        OldTuitionItem myOldTuition = new OldTuitionItem();
        int billId;
        int stdId;
        int partId;
        bool stop = false;
        decimal totalOldBal;
        public TuitionFeeControl()
        {
            InitializeComponent();
        }

        private void TuitionFeeControl_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void LoadPayments()
        {
            loadPaymentGrid.LoadPaymentsFromDb();

            //gridPayments.Rows.Count = 1;

            foreach (var popPayments in loadPaymentGrid.pubPayCollect)
            {
                //gridPayments.Rows.Count++;
                //gridPayments[gridPayments.Rows.Count - 1, 1] = popPayments.Payment_Number;
                //gridPayments[gridPayments.Rows.Count - 1, 2] = popPayments.Payment_Amount;
                //gridPayments[gridPayments.Rows.Count - 1, 3] = popPayments.Payment_Balance;
                //gridPayments[gridPayments.Rows.Count - 1, 4] = popPayments.Payment_AmountPaid;
                //gridPayments[gridPayments.Rows.Count - 1, 5] = popPayments.Payment_PaymentMade;
                //gridPayments[gridPayments.Rows.Count - 1, 6] = popPayments.Payment_DatePaid;
                //gridPayments[gridPayments.Rows.Count - 1, 7] = popPayments.Payment_CutOffDate;
            }
        }
        private void LoadStdBill()
        {
            loadBillData = new BillCollection();
            loadBillData.LoadBillWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var popBill in loadBillData.pubBillCollect)
            {
                if (DateTime.Parse(popBill.Bill_DueDate) < DateTime.Today)
                {
                    var setOldManage = new BillManager();
                    setOldManage.SetTuitionToOld(popBill.Bill_Id);
                    SetOldPart();
                    stop = true;
                    return;
                }
                lblTotalTuitionContainer.Text = popBill.Bill_FinalAmount.ToString();
                lblDiscountContainer.Text = $"{popBill.Bill_Discount.ToString()}%";
                lblTotalBalanceContainer.Text = popBill.Bill_Balance.ToString();
                lblTotalPaymentMadeContainer.Text = popBill.Bill_PaymentMade.ToString();
                lblFullPaidDateContainer.Text = popBill.Bill_DatePaid.ToString();
                lblTuitionDueDateContainer.Text = popBill.Bill_DueDate.ToString();
                billId = popBill.Bill_Id;
            }
        }
        private void SetOldPart()
        {
            loadPartialPay = new PartialPaymentCollection();
            loadPartialPay.LoadOldPartWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var popOld in loadPartialPay.pubOtherFeesCollect)
            {
                totalOldBal = totalOldBal + popOld.PartPay_Balance;
                billId = popOld.PartPay_Bill_Id;
                stdId = popOld.PartPay_Std_Id;
            }
            myOldCollect = new OldTuitionCollection();
            myOldCollect.LoadOldTuitionFromDb();
            if (myOldCollect.pubOldCollect.All(x => (x.OldTuition_Bill_Id != billId && x.OldTuition_Std_Id != stdId)))
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

            myOldTuition.OldTuition_Bill_Id = billId;
            myOldTuition.OldTuition_Std_Id = stdId;
            myOldTuition.OldTuition_Description = "Tuition Fee";
            myOldTuition.OldTuition_Amount = totalOldBal;
            myOldTuition.OldTuition_Balance = totalOldBal;
            myOldTuition.OldTuition_DatePaid = "N/A";
            myOldTuition.OldTuition_PayMade = 0;
            myOldTuition.OldTuition_Status = "false";
            myOldTuition.OldTuition_Deleted = "no";
        }
        private void LoadStdPartition()
        {
            if (stop == true)
            {
                gridTuition.Rows.Count = 1;
                return;
            }
            loadPartialPay = new PartialPaymentCollection();
            loadPartialPay.LoadPartialPaymentWithIdsFromDb(billId, Int32.Parse(LoginUser.stdLogStudentId));

            gridTuition.Rows.Count = 1;

            foreach (var popPartial in loadPartialPay.pubOtherFeesCollect)
            {
                gridTuition.Rows.Count++;

                gridTuition[gridTuition.Rows.Count - 1, 1] = popPartial.PartPay_Partition;
                gridTuition[gridTuition.Rows.Count - 1, 2] = popPartial.PartPay_Amount;
                gridTuition[gridTuition.Rows.Count - 1, 3] = popPartial.PartPay_Balance;
                gridTuition[gridTuition.Rows.Count - 1, 4] = popPartial.PartPay_DueDate;
                gridTuition[gridTuition.Rows.Count - 1, 5] = popPartial.PartPay_PaymentMade;
                if (popPartial.PartPay_Status.ToString() == "true")
                {
                    gridTuition[gridTuition.Rows.Count - 1, 6] = "Paid";
                }
                else
                {
                    gridTuition[gridTuition.Rows.Count - 1, 6] = "Not Paid";
                }
                gridTuition[gridTuition.Rows.Count - 1, 7] = popPartial.PartPay_DatePaid;
                gridTuition[gridTuition.Rows.Count - 1, 8] = popPartial.PartPay_Id;
            }
        }
        private void LoadStdPayments()
        {
            if (stop == true)
            {
                gridTuitionPay.Rows.Count = 1;
                return;
            }
            if (gridTuition.Rows.Count == 1)
            {
                partId = 0;
            }
            else
            {
                partId = Int32.Parse(gridTuition[gridTuition.RowSel, 8].ToString());
            }
            loadPayments = new PaymentCollection();
            loadPayments.LoadPaymentsWithPartialIdFromDb(partId);

            gridTuitionPay.Rows.Count = 1;

            foreach (var popPartPay in loadPayments.pubPayCollect)
            {
                gridTuitionPay.Rows.Count++;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 1] = popPartPay.Payment_Number;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 2] = popPartPay.Payment_Paid;
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 3] = popPartPay.Payment_DatePaid;
            }
        }
        public void LoadBill()
        {
            loadBillData.LoadBillFromDb();

            foreach (var popBill in loadBillData.pubBillCollect)
            {
                lblTotalTuitionContainer.Text = popBill.Bill_TotalAmount.ToString();
                lblDiscountContainer.Text = $"{popBill.Bill_Discount.ToString()}%";
                lblTotalBalanceContainer.Text = popBill.Bill_Balance.ToString();
                lblTotalPaymentMadeContainer.Text = popBill.Bill_PaymentMade.ToString();
                lblTuitionDueDateContainer.Text = popBill.Bill_DueDate.ToString();
                
            }
        }
        public void LoadBillWithStdId()
        {
            loadBillData.LoadBillWithStdIdFromDb(Int32.Parse(LoginUser.stdLogStudentId));

            foreach (var popBill in loadBillData.pubBillCollect)
            {
                lblTotalTuitionContainer.Text = popBill.Bill_TotalAmount.ToString();
                lblDiscountContainer.Text = $"{popBill.Bill_Discount.ToString()}%";
                lblTotalBalanceContainer.Text = popBill.Bill_Balance.ToString();
                lblTotalPaymentMadeContainer.Text = popBill.Bill_PaymentMade.ToString();
                lblTuitionDueDateContainer.Text = popBill.Bill_DueDate.ToString();

            }
        }

        private void TuitionFeeControl_Load(object sender, EventArgs e)
        {
            LoadStdBill();
            LoadStdPartition();
            LoadStdPayments();
            
            //LoadBillWithStdId();
            //LoadPaymentsWithBillId();
            //LoadPayments();
            //LoadBill();
        }

        private void gridTuition_Click(object sender, EventArgs e)
        {
            partId = Int32.Parse(gridTuition[gridTuition.RowSel, 8].ToString());
            LoadStdPayments();
        } 
    }
}
