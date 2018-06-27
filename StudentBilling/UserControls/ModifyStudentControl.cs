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
    public partial class ModifyStudentControl : UserControl
    {
        public ModifyStudentControl()
        {
            InitializeComponent();
        }
        BillCollection loadSelectedBill = new BillCollection();
        StudentCollection loadStudentData = new StudentCollection();
        PartialPaymentCollection loadPartialPay = new PartialPaymentCollection();
        OtherFeesCollection loadOther = new OtherFeesCollection();
        PaymentCollection loadPayments = new PaymentCollection();
        OtherFeesPaymentCollection loadOtherPayments = new OtherFeesPaymentCollection();
        OldTuitionCollection myOldCollect = new OldTuitionCollection();
        OldTuitionItem myOldTuition = new OldTuitionItem();
        StudentManager stdManage = new StudentManager();
        int selectedId = 0;
        int billId = 0;
        int selectedPartId = 0;
        int selectedPayId = 0;
        int payNumber = 0;
        int selectedOtherId = 0;
        int oldBillId = 0;
        int oldStdId = 0;
        int selectedOldId = 0;
        decimal totalOldBal = 0;
        bool isEdit = false;
        string billStatus;
        string billDueDate;
        string billDatePaid;
        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyStudentControl_Load(object sender, EventArgs e)
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

        private void stdSearch_OnTextChange(object sender, EventArgs e)
        {
            if (txtSearch.text == "")
            {
                LoadStudents();
                selectedId = Int32.Parse(gridStd[gridStd.RowSel, 1].ToString());
            }
            else
            {
                SearchStud();
                if (gridStd.Rows.Count == 1)
                {
                    txtAmount.Text = "N/A";
                    txtFinal.Text = "N/A";
                    txtDiscount.Text = "N/A";
                    txtPayMade.Text = "N/A";
                    txtSemester.Text = "N/A";
                    txtBalance.Text = "N/A";
                    txtSchoolYear.Text = "N/A";
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
            loadStudentData.SearchStudent(txtSearch.text);

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
        private void LoadSelectedBill()
        {
            billId = 0;
            loadSelectedBill = new BillCollection();
            loadSelectedBill.LoadBillWithStdIdFromDb(selectedId);

            foreach (var popBill in loadSelectedBill.pubBillCollect)
            {
                billId = popBill.Bill_Id;
                txtAmount.Text = popBill.Bill_TotalAmount.ToString();
                txtDiscount.Text = popBill.Bill_Discount.ToString();
                txtFinal.Text = popBill.Bill_FinalAmount.ToString();
                txtPayMade.Text = popBill.Bill_PaymentMade.ToString();
                txtSemester.Text = popBill.Bill_Semester;
                txtBalance.Text = popBill.Bill_Balance.ToString();
                txtSchoolYear.Text = popBill.Bill_SchoolYear;
                billStatus = popBill.Bill_Status;
                billDueDate = popBill.Bill_DueDate;
                billDatePaid = popBill.Bill_DatePaid;
            }
        }
        private void LoadSelectedTuitionpay()
        {
            if (billId != 0)
            {
                loadPartialPay = new PartialPaymentCollection();
                loadPartialPay.LoadPartialPaymentWithIdsFromDb(billId, selectedId);

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
                    gridTuition[gridTuition.Rows.Count - 1, 8] = popPartial.PartPay_DatePaid;
                }
            }
            else
            {
                gridTuition.Rows.Count = 1;
            }
        }
        private void LoadSelectedOtherPay()
        {
            if (billId != 0)
            {
                loadOther = new OtherFeesCollection();
                loadOther.LoadOtherFeesWithBillIdFromDb(billId);

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
                    gridOther[gridOther.Rows.Count - 1, 8] = popOther.OtherFees_DatePaid;
                    gridOther[gridOther.Rows.Count - 1, 9] = popOther.OtherFees_CutOffDate;
                }
            }
            else
            {
                gridOther.Rows.Count = 1;
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
            else
            {
                selectedPartId = 0;
            }
            LoadSelectedPartPay();
            if (gridTuitionPay.Rows.Count != 1)
            {
                selectedPayId = Int32.Parse(gridTuitionPay[gridTuitionPay.RowSel, 4].ToString());
            }
            else
            {
                selectedPayId = 0;
            }
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
            if (billId == 0)
            {
                txtAmount.Text = "n/a";
                txtFinal.Text = "n/a";
                txtDiscount.Text = "n/a";
                txtPayMade.Text = "n/a";
                txtSemester.Text = "n/a";
                txtBalance.Text = "n/a";
                txtSchoolYear.Text = "n/a";
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
                gridTuitionPay[gridTuitionPay.Rows.Count - 1, 4] = popPartPay.Payment_Id;
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
                gridOtherPay[gridOtherPay.Rows.Count - 1, 4] = popOtherPay.OtherPay_Id;
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
        private void LoadOldPart()
        {
            loadPartialPay = new PartialPaymentCollection();
            loadPartialPay.LoadOldPartWithStdIdFromDb(selectedId);

            foreach (var popOld in loadPartialPay.pubOtherFeesCollect)
            {
                totalOldBal = totalOldBal + popOld.PartPay_Balance;
                oldBillId = popOld.PartPay_Bill_Id;
                oldStdId = popOld.PartPay_Std_Id;
            }
            myOldCollect = new OldTuitionCollection();
            myOldCollect.LoadOldTuitionFromDb();
            if (myOldCollect.pubOldCollect.All(x => (x.OldTuition_Bill_Id != oldBillId && x.OldTuition_Std_Id != oldStdId)))
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

            myOldTuition.OldTuition_Bill_Id = oldBillId;
            myOldTuition.OldTuition_Std_Id = oldStdId;
            myOldTuition.OldTuition_Description = "Tuition Fee";
            myOldTuition.OldTuition_Amount = totalOldBal;
            myOldTuition.OldTuition_Balance = totalOldBal;
            myOldTuition.OldTuition_DatePaid = "N/A";
            myOldTuition.OldTuition_PayMade = 0;
            myOldTuition.OldTuition_Status = "false";
            myOldTuition.OldTuition_Deleted = "no";
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
                gridOld[gridOld.Rows.Count - 1, 7] = popOld.OldTuition_DatePaid;
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
                gridOld[gridOld.Rows.Count - 1, 7] = popOther.OtherFees_DatePaid;
            }
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
                gridOldPay[gridOldPay.Rows.Count - 1, 4] = popOtherPay.OtherPay_Id;
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
                gridOldPay[gridOldPay.Rows.Count - 1, 4] = popPartPay.Payment_Id;
            }

        }
        public void BtnPayIsActive()
        {
            if (gridTuition.Rows.Count == 1)
            {
                btnEditTuition.Enabled = false;
                btnDeleteTuition.Enabled = false;
            }
            else
            {
                btnEditTuition.Enabled = true;
                btnDeleteTuition.Enabled = true;
            }
        }
        public void BtnOtherIsActive()
        {
            if (gridOther.Rows.Count == 1)
            {
                btnEditOther.Enabled = false;
                btnDeleteOther.Enabled = false;
            }
            else
            {
                btnEditOther.Enabled = true;
                btnDeleteOther.Enabled = true;
            }
        }

        private void gridStd_Click(object sender, EventArgs e)
        {
            StdClick();
        }

        private void gridOther_Click(object sender, EventArgs e)
        {
            btnEditOther.ButtonText = "   Edit Fee";
            btnDeleteOther.ButtonText = "   Delete Fee";
            selectedOtherId = Int32.Parse(gridOther[gridOther.RowSel, 1].ToString());
            LoadSelectedOtherPayments();
        }

        private void gridOtherPay_Click(object sender, EventArgs e)
        {
            selectedPayId = Int32.Parse(gridOtherPay[gridOtherPay.RowSel, 4].ToString());
            btnEditOther.ButtonText = "Edit Payment";
            btnDeleteOther.ButtonText = "Delete Payment";
        }

        private void gridTuition_Click(object sender, EventArgs e)
        {
            btnEditTuition.ButtonText = "Edit Partition";
            btnDeleteTuition.ButtonText = "Delete Partition";
            selectedPartId = Int32.Parse(gridTuition[gridTuition.RowSel, 1].ToString());
            LoadSelectedPartPay();
        }

        private void gridOld_Click(object sender, EventArgs e)
        {
            selectedOldId = Int32.Parse(gridOld[gridOld.RowSel, 1].ToString());
            LoadSelectedOldPayments();
        }

        private void btnEditStd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridOld_Click_1(object sender, EventArgs e)
        {
            btnEditOld.ButtonText = "   Edit Fee";
            btnDeleteOld.ButtonText = "   Delete Fee";
            selectedOldId = Int32.Parse(gridOld[gridOld.RowSel, 1].ToString());
            LoadSelectedOldPayments();
        }

        private void tabPayments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditOld_Click(object sender, EventArgs e)
        {
            if (btnEditOld.ButtonText == "   Edit Fee")
            {
                UpdateOldBalance();
            }
            else if (btnEditOld.ButtonText == "Edit Payment")
            {
                UpdateOldPayment();
            }
        }
        private void UpdateOldBalance()
        {
            using (EditOld editOld = new EditOld())
            {
                editOld.txtDescription.text = gridOld[gridOld.RowSel, 2].ToString();
                editOld.txtAmount.text = gridOld[gridOld.RowSel, 3].ToString();
                editOld.txtBalance.text = gridOld[gridOld.RowSel, 4].ToString();
                editOld.txtPaymade.text = gridOld[gridOld.RowSel, 5].ToString();  
                string comp = gridOld[gridOld.RowSel, 6].ToString();
                if (comp == "false")
                {
                    editOld.cmbStatus.selectedIndex = 1;
                    editOld.calDatePaid.Enabled = false;
                }
                else
                {
                    editOld.calDatePaid.Value = DateTime.Parse(gridOld[gridOld.RowSel, 7].ToString());
                    editOld.cmbStatus.selectedIndex = 0;
                    editOld.calDatePaid.Enabled = true;
                }
                editOld.ShowDialog();
                if (editOld.isConfirmed == true)
                {
                    if (gridOld[gridOld.RowSel, 2].ToString() == "Tuition Fee")
                    {
                        var oldManage = new OldTuitionManager();
                        var item = new OldTuitionItem();

                        item.OldTuition_Description = editOld.txtDescription.text;
                        item.OldTuition_Amount = Decimal.Parse(editOld.txtAmount.text);
                        item.OldTuition_Balance = Decimal.Parse(editOld.txtBalance.text);
                        item.OldTuition_PayMade = Decimal.Parse(editOld.txtPaymade.text);
                        item.OldTuition_Id = selectedOldId;
                        if (editOld.cmbStatus.selectedIndex == 0)
                        {
                            item.OldTuition_Status = "true";
                            item.OldTuition_DatePaid = editOld.calDatePaid.Value.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            item.OldTuition_Status = "false";
                            item.OldTuition_DatePaid = "N/A";
                        }

                        oldManage.UpdatOld(item);
                    }
                    else
                    {
                        var oldOtherManage = new OtherFeesManager();
                        var item = new OtherFeesItem();

                        item.OtherFees_Description = editOld.txtDescription.text;
                        item.OtherFees_Amount = Decimal.Parse(editOld.txtAmount.text);
                        item.OtherFees_Balance = Decimal.Parse(editOld.txtBalance.text);
                        item.OtherFees_PaymentMade = Decimal.Parse(editOld.txtPaymade.text);
                        item.OtherFees_Id = selectedOldId;
                        if (editOld.cmbStatus.selectedIndex == 0)
                        {
                            item.OtherFees_Status = "true";
                            item.OtherFees_DatePaid = editOld.calDatePaid.Value.ToString("MM/dd/yyyy");
                        }
                        else
                        {
                            item.OtherFees_Status = "false";
                            item.OtherFees_DatePaid = "N/A";
                        }

                        oldOtherManage.UpdateOldOther(item);
                    }
                }
            }
            StdClick();
        }
        private void UpdateOldPayment()
        {
            using (EditPayments editPay = new EditPayments())
            {
                editPay.txtPayNo.text = gridOtherPay[gridOtherPay.RowSel, 1].ToString();
                editPay.txtAmount.text = gridOtherPay[gridOtherPay.RowSel, 2].ToString();
                editPay.calDatePaid.Value = DateTime.Parse(gridOtherPay[gridOtherPay.RowSel, 3].ToString());
                editPay.ShowDialog();
                if (editPay.isConfirmed == true)
                {
                    if (gridOld[gridOld.RowSel, 2].ToString() == "Tuition Fee")
                    {
                        var payManage = new PaymentManager();
                        var item = new PaymentItem();

                        item.Payment_Number = Int32.Parse(editPay.txtPayNo.text);
                        item.Payment_Paid = Decimal.Parse(editPay.txtAmount.text);
                        item.Payment_DatePaid = editPay.calDatePaid.Value.ToString("MM/dd/yyyy");
                        item.Payment_Id = selectedPayId;

                        payManage.UpdatePayment(item);
                    }
                    else
                    {
                        var otherPay = new OtherFeesPaymentManager();
                        var item = new OtherFeesPaymentItem();

                        item.OtherPay_Number = Int32.Parse(editPay.txtPayNo.text);
                        item.OtherPay_Paid = Decimal.Parse(editPay.txtAmount.text);
                        item.OtherPay_DatePaid = editPay.calDatePaid.Value.ToString("MM/dd/yyyy");
                        item.OtherPay_Id = selectedPayId;

                        otherPay.UpdateOtherPayment(item);
                    }
                }
            }
            StdClick();
        }
        private void btnDeleteOld_Click(object sender, EventArgs e)
        {
            if (btnDeleteOld.ButtonText == "   Delete Fee")
            {
                DeleteOld();
            }
            else if (btnDeleteOld.ButtonText == "Delete Payment")
            {
                DeleteOldPayments();
            }
            StdClick();
        }
        private void DeleteOld()
        {
            var otherManage = new OtherFeesManager();
            var oldManage = new OldTuitionManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridOld[gridOld.RowSel, 2].ToString() == "Tuition Fee")
                {
                    oldManage.DeleteOld(selectedOldId);
                }
                else
                {
                    otherManage.DeleteOther(selectedOldId);
                }
            }
        }
        private void DeleteOldPayments()
        {
            var tuitionPayManage = new PaymentManager();
            var otherPayManage = new OtherFeesPaymentManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridOld[gridOld.RowSel, 2].ToString() == "Tuition Fee")
                {
                    tuitionPayManage.DeletePayment(selectedPayId);
                }
                else
                {
                    otherPayManage.DeleteOtherPayments(selectedPayId);
                }
            }
        }

        private void gridTuitionPay_Click(object sender, EventArgs e)
        {
            selectedPayId = Int32.Parse(gridTuitionPay[gridTuitionPay.RowSel, 4].ToString());
            btnEditTuition.ButtonText = "Edit Payment";
            btnDeleteTuition.ButtonText = "Delete Payment";
        }

        private void gridOldPay_Click(object sender, EventArgs e)
        {
            selectedPayId = Int32.Parse(gridOldPay[gridOldPay.RowSel, 4].ToString());
            btnEditOld.ButtonText = "Edit Payment";
            btnDeleteOld.ButtonText = "Delete Payment";
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            UpdateBill();
        }
        private void UpdateBill()
        {
            using (EditBill editBill = new EditBill())
            {
                editBill.txtDiscount.text = txtDiscount.Text;
                editBill.txtTotal.text = txtAmount.Text;
                editBill.txtFinal.text = txtFinal.Text;
                editBill.txtPayMade.text = txtPayMade.Text;
                editBill.txtBalance.text = txtBalance.Text;
                editBill.txtSem.text = txtSemester.Text;
                editBill.txtSchoolYear.text = txtSchoolYear.Text;
                editBill.calDueDate.Value = DateTime.Parse(billDueDate);
                string comp = billStatus;
                if (comp == "false")
                {
                    editBill.cmbStatus.selectedIndex = 1;
                    editBill.calDatePaid.Enabled = false;
                }
                else
                {
                    editBill.calDatePaid.Value = DateTime.Parse(billDatePaid);
                    editBill.cmbStatus.selectedIndex = 0;
                    editBill.calDatePaid.Enabled = true;
                }
                editBill.isEdit = true;
                editBill.ShowDialog();
                if (editBill.isConfirmed == true)
                {
                    var billManage = new BillManager();
                    var item = new BillItem();

                    item.Bill_Discount = Double.Parse(editBill.txtDiscount.text);
                    item.Bill_TotalAmount = Decimal.Parse(editBill.txtTotal.text);
                    item.Bill_FinalAmount = Decimal.Parse(editBill.txtFinal.text);
                    item.Bill_PaymentMade = Decimal.Parse(editBill.txtPayMade.text);
                    item.Bill_Balance = Decimal.Parse(editBill.txtBalance.text);
                    item.Bill_Semester = editBill.txtSem.text;
                    item.Bill_SchoolYear = editBill.txtSchoolYear.text;
                    item.Bill_DueDate = editBill.calDueDate.Value.ToString("MM/dd/yyyy");
                    item.Bill_Id = billId;
                    if (editBill.cmbStatus.selectedIndex == 0)
                    {
                        item.Bill_Status = "true";
                        item.Bill_DatePaid = editBill.calDatePaid.Value.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        item.Bill_Status = "false";
                        item.Bill_DatePaid = "N/A";
                    }
                    billManage.UpdateBill(item);
                }
            }
            StdClick();
        }
        private void btnEditTuition_Click(object sender, EventArgs e)
        {
            if (btnEditTuition.ButtonText == "Edit Partition")
            {
                UpdatePartition();
            }
            else if (btnEditTuition.ButtonText == "Edit Payment")
            {
                UpdatePayment();
            }
        }
        private void UpdatePartition()
        {
            using (EditPartition editPart = new EditPartition())
            {
                editPart.txtPart.text = gridTuition[gridTuition.RowSel, 2].ToString();
                editPart.txtAmount.text = gridTuition[gridTuition.RowSel, 3].ToString();
                editPart.txtBalance.text = gridTuition[gridTuition.RowSel, 4].ToString();
                editPart.txtPaymade.text = gridTuition[gridTuition.RowSel, 6].ToString();
                editPart.calDueDate.Value = DateTime.Parse(gridTuition[gridTuition.RowSel, 5].ToString());
                string comp = gridTuition[gridTuition.RowSel, 7].ToString();
                if (comp == "false")
                {
                    editPart.cmbStatus.selectedIndex = 1;
                    editPart.calDatePaid.Enabled = false;
                }
                else
                {
                    editPart.calDatePaid.Value = DateTime.Parse(gridTuition[gridTuition.RowSel, 8].ToString());
                    editPart.cmbStatus.selectedIndex = 0;
                    editPart.calDatePaid.Enabled = true;
                }
                editPart.ShowDialog();
                if (editPart.isConfirmed == true)
                {
                    var partManage = new PartialPaymentManager();
                    var item = new PartialPaymentItem();

                    item.PartPay_Partition = editPart.txtPart.text;
                    item.PartPay_Amount = Decimal.Parse(editPart.txtAmount.text);
                    item.PartPay_Balance = Decimal.Parse(editPart.txtBalance.text);
                    item.PartPay_PaymentMade = Decimal.Parse(editPart.txtPaymade.text);
                    item.PartPay_DueDate = editPart.calDueDate.Value.ToString("MM/dd/yyyy");
                    item.PartPay_Id = selectedPartId;
                    if (editPart.cmbStatus.selectedIndex == 0)
                    {
                        item.PartPay_Status = "true";
                        item.PartPay_DatePaid = editPart.calDatePaid.Value.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        item.PartPay_Status = "false";
                        item.PartPay_DatePaid = "N/A";
                    }

                    partManage.UpdatePartialPayments(item);
                    LoadSelectedTuitionpay();
                }
            }
            StdClick();
        }
        private void UpdatePayment()
        {
            using (EditPayments editPay = new EditPayments())
            {
                editPay.txtPayNo.text = gridTuitionPay[gridTuitionPay.RowSel, 1].ToString();
                editPay.txtAmount.text = gridTuitionPay[gridTuitionPay.RowSel, 2].ToString();
                editPay.calDatePaid.Value = DateTime.Parse(gridTuitionPay[gridTuitionPay.RowSel, 3].ToString());
                editPay.ShowDialog();
                if (editPay.isConfirmed == true)
                {
                    var payManage = new PaymentManager();
                    var item = new PaymentItem();

                    item.Payment_Number = Int32.Parse(editPay.txtPayNo.text);
                    item.Payment_Paid = Decimal.Parse(editPay.txtAmount.text);
                    item.Payment_DatePaid = editPay.calDatePaid.Value.ToString("MM/dd/yyyy");
                    item.Payment_Id = selectedPayId;

                    payManage.UpdatePayment(item);
                }
            }
            StdClick();
        }
        private void btnEditStd_Click_1(object sender, EventArgs e)
        {
            UpdateStudent();
            LoadStudents();
            StdClick();
        }
        public void UpdateStudent()
        {
            using (EditStudentForm editStd = new EditStudentForm())
            {
                editStd.txtFName.text = gridStd[gridStd.RowSel, 2].ToString();
                editStd.txtLName.text = gridStd[gridStd.RowSel, 3].ToString();
                editStd.txtMName.text = gridStd[gridStd.RowSel, 4].ToString();
                editStd.txtCCode.text = gridStd[gridStd.RowSel, 5].ToString();
                editStd.txtCtitle.text = gridStd[gridStd.RowSel, 6].ToString();
                editStd.txtYear.text = gridStd[gridStd.RowSel, 7].ToString();
                editStd.txtSection.text = gridStd[gridStd.RowSel, 8].ToString();
                editStd.ShowDialog();
                if (editStd.isConfirmed == true)
                {
                    var stdManage = new StudentManager();
                    var item = new StudentItem();

                    item.Std_FName = editStd.txtFName.text;
                    item.Std_LName = editStd.txtLName.text;
                    item.Std_MName = editStd.txtMName.text;
                    item.Std_CourseCode = editStd.txtCCode.text;
                    item.Std_CourseTitle = editStd.txtCtitle.text;
                    item.Std_Year = editStd.txtYear.text;
                    item.Std_Section = editStd.txtSection.text;
                    item.Std_Id = selectedId;

                    stdManage.UpdateStudent(item);
                }
                // do what ever with result...
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteStd();
            LoadStudents();
            StdClick();
        }
        private void DeleteStd()
        {
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var stdManage = new StudentManager();

                stdManage.DeleteStudent(selectedId);
            }
        }

        private void btnEditOther_Click(object sender, EventArgs e)
        {
            if (btnEditOther.ButtonText == "   Edit Fee")
            {
                UpdateOtherFees();
            }
            else if (btnEditOther.ButtonText == "Edit Payment")
            {
                UpdateOtherPayment();
            }
        }
        private void UpdateOtherFees()
        {
            using (EditOther editOther = new EditOther())
            {
                editOther.txtDescription.text = gridOther[gridOther.RowSel, 2].ToString();
                editOther.txtAmount.text = gridOther[gridOther.RowSel, 3].ToString();
                editOther.txtBalance.text = gridOther[gridOther.RowSel, 4].ToString();
                editOther.txtPaymade.text = gridOther[gridOther.RowSel, 6].ToString();
                editOther.calDueDate.Value = DateTime.Parse(gridOther[gridOther.RowSel, 5].ToString());
                editOther.calCutOff.Value = DateTime.Parse(gridOther[gridOther.RowSel, 9].ToString());
                string comp = gridOther[gridOther.RowSel, 7].ToString();
                if (comp == "false")
                {
                    editOther.cmbStatus.selectedIndex = 1;
                    editOther.calDatePaid.Enabled = false;
                }
                else
                {
                    editOther.calDatePaid.Value = DateTime.Parse(gridOther[gridOther.RowSel, 8].ToString());
                    editOther.cmbStatus.selectedIndex = 0;
                    editOther.calDatePaid.Enabled = true;
                }
                editOther.ShowDialog();
                if (editOther.isConfirmed == true)
                {
                    var otherManage = new OtherFeesManager();
                    var item = new OtherFeesItem();

                    item.OtherFees_Description = editOther.txtDescription.text;
                    item.OtherFees_Amount = Decimal.Parse(editOther.txtAmount.text);
                    item.OtherFees_Balance = Decimal.Parse(editOther.txtBalance.text);
                    item.OtherFees_PaymentMade = Decimal.Parse(editOther.txtPaymade.text);
                    item.OtherFees_DueDate = editOther.calDueDate.Value.ToString("MM/dd/yyyy");
                    item.OtherFees_CutOffDate = editOther.calCutOff.Value.ToString("MM/dd/yyyy");
                    item.OtherFees_Id = selectedOtherId;
                    if (editOther.cmbStatus.selectedIndex == 0)
                    {
                        item.OtherFees_Status = "true";
                        item.OtherFees_DatePaid = editOther.calDatePaid.Value.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        item.OtherFees_Status = "false";
                        item.OtherFees_DatePaid = "N/A";
                    }

                    otherManage.UpdateOther(item);
                }
            }
            StdClick();
        }
        private void UpdateOtherPayment()
        {
            using (EditPayments editPay = new EditPayments())
            {
                editPay.txtPayNo.text = gridOtherPay[gridOtherPay.RowSel, 1].ToString();
                editPay.txtAmount.text = gridOtherPay[gridOtherPay.RowSel, 2].ToString();
                editPay.calDatePaid.Value = DateTime.Parse(gridOtherPay[gridOtherPay.RowSel, 3].ToString());
                editPay.ShowDialog();
                if (editPay.isConfirmed == true)
                {
                    var otherPay = new OtherFeesPaymentManager();
                    var item = new OtherFeesPaymentItem();

                    item.OtherPay_Number = Int32.Parse(editPay.txtPayNo.text);
                    item.OtherPay_Paid = Decimal.Parse(editPay.txtAmount.text);
                    item.OtherPay_DatePaid = editPay.calDatePaid.Value.ToString("MM/dd/yyyy");
                    item.OtherPay_Id = selectedPayId;

                    otherPay.UpdateOtherPayment(item);
                }
            }
            StdClick();
        }

        private void btnDeleteTuition_Click(object sender, EventArgs e)
        {
            if (btnDeleteTuition.ButtonText == "Delete Partition")
            {
                DeleteTuitionPart();
            }
            else if (btnDeleteTuition.ButtonText == "Delete Payment")
            {
                DeleteTuitionPayment();
            }
            StdClick();
        }
        private void DeleteTuitionPart()
        {
            var partManage = new PartialPaymentManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                partManage.DeletePartition(selectedPartId);
            }
        }
        private void DeleteTuitionPayment()
        {
            var payManage = new PaymentManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                payManage.DeletePayment(selectedPayId);
            }
        }

        private void btnDeleteOther_Click(object sender, EventArgs e)
        {
            if (btnDeleteOther.ButtonText == "   Delete Fee")
            {
                DeleteOther();
            }
            else if (btnDeleteOther.ButtonText == "Delete Payment")
            {
                DeleteOtherPayments();
            }
            StdClick();
        }
        private void DeleteOther()
        {
            var otherManage = new OtherFeesManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                otherManage.DeleteOther(selectedOtherId);
            }
        }
        private void DeleteOtherPayments()
        {
            var otherPayManage = new OtherFeesPaymentManager();
            var result = MessageBox.Show("Do you want to delete this record?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                otherPayManage.DeleteOtherPayments(selectedPayId);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                if (txtAmount.Text == "")
                {
                    txtAmount.Text = "0";
                }
                decimal result = Decimal.Parse(txtAmount.Text) - (Decimal.Parse(txtAmount.Text) * (Decimal.Parse(txtDiscount.Text) / 100));
                txtFinal.Text = result.ToString();
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                }
                decimal result = Decimal.Parse(txtAmount.Text) - (Decimal.Parse(txtAmount.Text) * (Decimal.Parse(txtDiscount.Text) / 100));
                txtFinal.Text = result.ToString();
            }
        }
    }
}
