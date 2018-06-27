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
    public partial class RegisterStudentControl : UserControl
    {
        public List<PartialPaymentItem> partialPaymentsList;
        public List<OtherFeesItem> otherFeesList;
        private PartialPaymentItem receivePartPay;
        int passStdID;
        int passBillID;
        public decimal balanceHold;

        public PartialPaymentItem pubReceivePartPay
        {
            get { return receivePartPay; }
            set { receivePartPay = value; }
        }
        private OtherFeesItem receiveOtherFees;

        public OtherFeesItem pubReceiveOtherFees
        {
            get { return receiveOtherFees; }
            set { receiveOtherFees = value; }
        }
        private StudentItem myStudItem;
        public StudentItem pubMyStudItem
        {
            get { return myStudItem; }
            set { myStudItem = value; }
        }
        private BillItem myBillItem;
        public BillItem pubMyBillItem
        {
            get { return myBillItem; }
            set { myBillItem = value; }
        }
        public RegisterStudentControl()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Validation();
        }
        public void Validation()
        {
            if (txtFName.text == "" || txtLName.text == "" || txtMName.text == "" || txtCourseCode.text == "" || txtCourseTitle.text == "" || txtYear.text == "" || txtSection.text == "")
            {
                MessageBox.Show("Please fill out all student's information", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSemester.text == "" || txtSchoolYear.text == "")
                {
                    MessageBox.Show("Please fill out all Student's bill information", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Int32.Parse(txtTotalAmount.text) == 0 && txtDiscount.text != "100")
                    {
                        MessageBox.Show("Please input total tuition fee amount", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else
                    {
                        if (gridPayPart.Rows.Count == 1)
                        {
                            MessageBox.Show("There is no payment partition(s) please create atleast 1 payment partition", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (balanceHold != 0)
                            {
                                MessageBox.Show($"The remaining balance is {balanceHold}. Please distribute the remaining balance", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                InsertStudent();
                                InsertBill();
                                InsertPartPay();
                                InsertOtherFees();
                                MessageBox.Show("Record successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearImmediate();
                            }
                        }
                    } 
                }
            }
        }
        public void InsertStudent()
        {
            StudentManager studManage = new StudentManager();
            SetStudData();
            studManage.SaveStudent(myStudItem);
            passStdID = studManage.myReturnedID;
        }
        public void InsertBill()
        {
            BillManager billManage = new BillManager();
            SetBillData();
            billManage.SaveBill(myBillItem);
            passBillID = billManage.myReturnedID;
        }
        public void InsertPartPay()
        {
            PartialPaymentManager partPayManage = new PartialPaymentManager();
            Register();
            partPayManage.SavePartialPayment(partialPaymentsList);
        }
        public void InsertOtherFees()
        {
            OtherFeesManager otherFeesManage = new OtherFeesManager();
            RegisterOtherFees();
            otherFeesManage.SaveOtherFees(otherFeesList);
        }
        public void SetStudData()
        {
            myStudItem = new StudentItem();

            myStudItem.Std_FName = txtFName.text;
            myStudItem.Std_LName = txtLName.text;
            myStudItem.Std_MName = txtMName.text;
            myStudItem.Std_CourseCode = txtCourseCode.text;
            myStudItem.Std_CourseTitle = txtCourseTitle.text;
            myStudItem.Std_Year = txtYear.text;
            myStudItem.Std_Section = txtSection.text;
            myStudItem.Std_Deleted = "no";
        }
        public void SetBillData()
        {
            myBillItem = new BillItem();

            myBillItem.Bill_Std_Id = passStdID;
            myBillItem.Bill_Description = "Tuition Fee";
            myBillItem.Bill_TotalAmount = Decimal.Parse(txtTotalAmount.text);
            myBillItem.Bill_FinalAmount = Decimal.Parse(txtFinalAmount.text);
            myBillItem.Bill_Discount = Double.Parse(txtDiscount.text);
            myBillItem.Bill_Status = "false";
            myBillItem.Bill_PaymentMade = 0;
            myBillItem.Bill_Balance = Decimal.Parse(txtFinalAmount.text);
            myBillItem.Bill_Semester = txtSemester.text;
            myBillItem.Bill_SchoolYear = txtSchoolYear.text;
            myBillItem.Bill_DueDate = calDueDate.Value.ToString("MM/dd/yyyy");
            myBillItem.Bill_DatePaid = "N/A";
            myBillItem.Bill_IsOld = "false";
            myBillItem.Bill_Deleted = "no";
        }
        public void Register()
        {
            partialPaymentsList = new List<PartialPaymentItem>();
            partialPaymentsList.Clear();
            int b = gridPayPart.Rows.Count;

            for (int a = 1; a < b; a++)
            {
                var item = new PartialPaymentItem();

                item.PartPay_Bill_Id = passBillID;
                item.PartPay_Std_Id = passStdID;
                item.PartPay_Partition = gridPayPart[a, 1].ToString();
                item.PartPay_Amount = Decimal.Parse(gridPayPart[a, 2].ToString());
                item.PartPay_Balance = Decimal.Parse(gridPayPart[a, 2].ToString());
                item.PartPay_DueDate = gridPayPart[a, 3].ToString();
                item.PartPay_DatePaid = "N/A";
                item.PartPay_PaymentMade = 0;
                item.PartPay_Status = "false";
                item.PartPay_Deleted = "no";

                partialPaymentsList.Add(item);
            }
        }
        public void RegisterOtherFees()
        {
            otherFeesList = new List<OtherFeesItem>();
            otherFeesList.Clear();
            int b = gridOtherFees.Rows.Count;

            for (int a = 1; a < b; a++)
            {
                var item = new OtherFeesItem();

                item.OtherFees_Bill_Id = passBillID;
                item.OtherFees_Std_Id = passStdID;
                item.OtherFees_Description = gridOtherFees[a, 1].ToString();
                item.OtherFees_Amount = Decimal.Parse(gridOtherFees[a, 2].ToString());
                item.OtherFees_Balance = Decimal.Parse(gridOtherFees[a, 2].ToString());
                item.OtherFees_DueDate = gridOtherFees[a, 3].ToString();
                item.OtherFees_DatePaid = "N/A";
                item.OtherFees_PaymentMade = 0;
                item.OtherFees_CutOffDate = gridOtherFees[a, 4].ToString();
                item.OtherFees_Status = "false";
                item.OtherFees_IsOld = "false";
                item.OtherFees_Deleted = "no";

                otherFeesList.Add(item);
            }
        }
        public void ReceivePartPayData()
        {
            using (TuitionFeeAddPaymentForm payForm = new TuitionFeeAddPaymentForm())
            {
                payForm.balanceHolder = balanceHold;
                payForm.lblData.Text = balanceHold.ToString();
                payForm.ShowDialog();
                if (payForm.isConfirmed == true)
                {
                    pubReceivePartPay = payForm.pubTransmitPartPay;
                    balanceHold = payForm.balanceHolder;
                    gridPayPart.Rows.Count++;
                    gridPayPart[gridPayPart.Rows.Count - 1, 1] = pubReceivePartPay.PartPay_Partition;
                    gridPayPart[gridPayPart.Rows.Count - 1, 2] = pubReceivePartPay.PartPay_Amount;
                    gridPayPart[gridPayPart.Rows.Count - 1, 3] = pubReceivePartPay.PartPay_DueDate;
                }
                // do what ever with result...
            }
        }
        public void ReceiveOtherFeesData()
        {
            using (AddOtherFeesForm otherForm = new AddOtherFeesForm())
            {
                otherForm.balanceHolder = balanceHold;
                otherForm.lblData.Text = balanceHold.ToString();
                otherForm.ShowDialog();
                if (otherForm.isConfirmed == true)
                {
                    pubReceiveOtherFees = otherForm.pubTransmitOtherFees;
                    balanceHold = otherForm.balanceHolder;
                    gridOtherFees.Rows.Count++;
                    gridOtherFees[gridOtherFees.Rows.Count - 1, 1] = pubReceiveOtherFees.OtherFees_Description;
                    gridOtherFees[gridOtherFees.Rows.Count - 1, 2] = pubReceiveOtherFees.OtherFees_Amount;
                    gridOtherFees[gridOtherFees.Rows.Count - 1, 3] = pubReceiveOtherFees.OtherFees_DueDate;
                    gridOtherFees[gridOtherFees.Rows.Count - 1, 4] = pubReceiveOtherFees.OtherFees_CutOffDate;
                }
                // do what ever with result...
            }
            
        }
        public void TransmitPartPayData()
        {
            if (gridPayPart.Rows.Count != 1)
            { 
                int a = gridPayPart.RowSel;
                using (TuitionFeeAddPaymentForm payForm = new TuitionFeeAddPaymentForm())
                {
                    pubReceivePartPay = payForm.pubTransmitPartPay;
                    payForm.txtPartition.text = gridPayPart[a, 1].ToString();
                    payForm.txtAmount.text = gridPayPart[a, 2].ToString();
                    payForm.calDueDate.Value = DateTime.Parse(gridPayPart[a, 3].ToString());
                    payForm.lblTitle.Text = "Edit Payment Partition";
                    payForm.lblData.Text = "Remaining: " + balanceHold.ToString();
                    payForm.balanceHolder = balanceHold;
                    payForm.editBalanceHold = Decimal.Parse(gridPayPart[a, 2].ToString());
                    payForm.ShowDialog();
                    if (payForm.isConfirmed == true)
                    {
                        pubReceivePartPay = payForm.pubTransmitPartPay;
                        balanceHold = payForm.balanceHolder;
                        gridPayPart[a, 1] = pubReceivePartPay.PartPay_Partition;
                        gridPayPart[a, 2] = pubReceivePartPay.PartPay_Amount;
                        gridPayPart[a, 3] = pubReceivePartPay.PartPay_DueDate;
                    }
                    // do what ever with result...
                }
            }
        }
        public void TransmitOtherFeesData()
        {
            if (gridOtherFees.Rows.Count != 1)
            {
                int a = gridOtherFees.RowSel;
                using (AddOtherFeesForm otherForm = new AddOtherFeesForm())
                {
                    pubReceiveOtherFees = otherForm.pubTransmitOtherFees;
                    otherForm.txtDescription.text = gridOtherFees[a, 1].ToString();
                    otherForm.txtAmount.text = gridOtherFees[a, 2].ToString();
                    otherForm.calDueDate.Value = DateTime.Parse(gridOtherFees[a, 3].ToString());
                    otherForm.calCutOff.Value = DateTime.Parse(gridOtherFees[a, 4].ToString());
                    otherForm.lblTitle.Text = "Edit Other Fees data";
                    otherForm.lblData.Text = "Remaining: " + balanceHold;
                    otherForm.balanceHolder = balanceHold;
                    otherForm.editBalanceHold = Decimal.Parse(gridOtherFees[a, 2].ToString());
                    otherForm.ShowDialog();
                    if (otherForm.isConfirmed == true)
                    {
                        pubReceiveOtherFees = otherForm.pubTransmitOtherFees;
                        balanceHold = otherForm.balanceHolder;
                        gridOtherFees[a, 1] = pubReceiveOtherFees.OtherFees_Description;
                        gridOtherFees[a, 2] = pubReceiveOtherFees.OtherFees_Amount;
                        gridOtherFees[a, 3] = pubReceiveOtherFees.OtherFees_DueDate;
                        gridOtherFees[a, 4] = pubReceiveOtherFees.OtherFees_CutOffDate;
                    }
                    // do what ever with result...
                }
            }
        }
        public void DeleteSelectedRow()
        {
            if (gridPayPart.Rows.Count != 1)
            {
                var result = MessageBox.Show("Do you want to delete this record", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    decimal returnFee = Decimal.Parse(gridPayPart[gridPayPart.RowSel, 2].ToString());
                    balanceHold = balanceHold + returnFee;
                    gridPayPart.RemoveItem(gridPayPart.RowSel);
                }
            }
        }
        public void DeleteSelectedRowOtherFees()
        {
           
            if (gridOtherFees.Rows.Count != 1)
            {
                var result = MessageBox.Show("Do you want to delete this record", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    decimal returnFee = Decimal.Parse(gridOtherFees[gridOtherFees.RowSel, 2].ToString());
                    balanceHold = balanceHold + returnFee;
                    gridOtherFees.RemoveItem(gridOtherFees.RowSel);
                }
            }
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddPayPartValidation();
        }
        private void AddPayPartValidation()
        {
            if (btnSetAmount.ButtonText == "Set Amount")
            {
                MessageBox.Show("Please set tuition fee amount first", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReceivePartPayData();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            TransmitPartPayData();
        }

        private void RegisterStudentControl_Load(object sender, EventArgs e)
        {
            //txtFinalAmount.text = "wew";
            gridPayPart.Rows.Count = 1;
            gridOtherFees.Rows.Count = 1;
        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void btnAddOtherFees_Click(object sender, EventArgs e)
        {
            AddOtherFeesValidation();
        }
        private void AddOtherFeesValidation()
        {
            if (btnSetAmount.ButtonText == "Set Amount")
            {
                MessageBox.Show("Please set tuition fee amount first", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReceiveOtherFeesData();
            }
        }
        private void btnEditOtherFees_Click(object sender, EventArgs e)
        {
            TransmitOtherFeesData();
        }

        private void btnDeleteOtherFees_Click(object sender, EventArgs e)
        {
            DeleteSelectedRowOtherFees();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotalAmount_Leave(object sender, EventArgs e)
        {

        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtSchoolYear_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalAmount.text == "")
                {
                    txtTotalAmount.text = "0";
                }
                if (txtDiscount.text == "0")
                {
                    txtFinalAmount.text = txtTotalAmount.text;
                }
                else
                {
                    decimal i = (Decimal.Parse(txtTotalAmount.text) * (Decimal.Parse(txtDiscount.text) / 100));
                    txtFinalAmount.text = (Decimal.Parse(txtTotalAmount.text) - i).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtDiscount_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.text == "")
                {
                    txtDiscount.text = "0";
                }
                if (txtDiscount.text == "0")
                {
                    txtFinalAmount.text = txtTotalAmount.text;
                }
                else
                {
                    decimal i = (Decimal.Parse(txtTotalAmount.text) * (Decimal.Parse(txtDiscount.text) / 100));
                    txtFinalAmount.text = (Decimal.Parse(txtTotalAmount.text) - i).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalAmount_ControlRemoved(object sender, ControlEventArgs e)
        {
   
        }

        private void txtSetAmount_Click(object sender, EventArgs e)
        {
            SetTotalAmount();
        }
        public void SetTotalAmount()
        {
            if (btnSetAmount.ButtonText == "Set Amount")
            {
                if (Decimal.Parse(txtFinalAmount.text) < 0)
                {
                    MessageBox.Show("Final tuition fee amount is less than zero. Please input correct data", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnSetAmount.ButtonText = "Edit Amount";
                    txtTotalAmount.Enabled = false;
                    txtDiscount.Enabled = false;
                    balanceHold = Decimal.Parse(txtFinalAmount.text);
                    MessageBox.Show("Tuition fee is set", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnSetAmount.ButtonText == "Edit Amount")
            {
                var resut = MessageBox.Show("Editing Tuition Fee amount will clear all created payment partition and other fees", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resut == DialogResult.Yes)
                {
                    btnSetAmount.ButtonText = "Set Amount";
                    txtTotalAmount.Enabled = true;
                    txtDiscount.Enabled = true;
                    gridPayPart.Rows.Count = 1;
                    gridOtherFees.Rows.Count = 1;
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ClearData();   
        }
        private void ClearData()
        {
            var result = MessageBox.Show("Do you want to clear all input data?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                passBillID = 0;
                passStdID = 0;
                txtTotalAmount.Enabled = true;
                txtDiscount.Enabled = true;
                txtFName.text = "";
                txtMName.text = "";
                txtLName.text = "";
                txtCourseCode.text = "";
                txtCourseTitle.text = "";
                txtYear.text = "";
                txtSection.text = "";
                txtTotalAmount.text = "0";
                txtDiscount.text = "0";
                txtFinalAmount.text = "0";
                txtSemester.text = "";
                txtSchoolYear.text = "";
                gridPayPart.Rows.Count = 1;
                gridOtherFees.Rows.Count = 1;
                btnSetAmount.ButtonText = "Set Amount";
            }
        }
        private void ClearImmediate()
        {
            passBillID = 0;
            passStdID = 0;
            txtTotalAmount.Enabled = true;
            txtDiscount.Enabled = true;
            txtFName.text = "";
            txtMName.text = "";
            txtLName.text = "";
            txtCourseCode.text = "";
            txtCourseTitle.text = "";
            txtYear.text = "";
            txtSection.text = "";
            txtTotalAmount.text = "0";
            txtDiscount.text = "0";
            txtFinalAmount.text = "0";
            txtSemester.text = "";
            txtSchoolYear.text = "";
            gridPayPart.Rows.Count = 1;
            gridOtherFees.Rows.Count = 1;
            btnSetAmount.ButtonText = "Set Amount";
        }
    }
}
