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
    public partial class AccountsControl : UserControl
    {
        StaffCollection loadStaffs = new StaffCollection();
        int selectedStaffId = 0;
        public AccountsControl()
        {
            InitializeComponent();
        }

        private void btnAccAdd_Click(object sender, EventArgs e)
        {
            AddAcc();
        }
        private void AddAcc()
        {
            using (RegisterAccountForm regAcc = new RegisterAccountForm())
            {
                regAcc.ShowDialog();
                if (regAcc.isConfirmed == true)
                {
                    var staffManage = new StaffManager();
                    var item = new StaffItem();

                    item.Staff_Position = regAcc.cmbPosition.selectedValue;
                    item.Staff_FName = regAcc.txtFName.text;
                    item.Staff_LName = regAcc.txtLName.text;
                    item.Staff_MName = regAcc.txtMName.text;
                    item.Staff_Username = regAcc.txtUserName.text;
                    item.Staff_Password = regAcc.txtPassword.Text;

                    staffManage.SaveStaff(item);
                }
            }
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            loadStaffs = new StaffCollection();
            loadStaffs.LoadStaffFromDb();

            gridUsers.Rows.Count = 1;

            foreach (var popStaff in loadStaffs.pubStaffCollect)
            {
                gridUsers.Rows.Count++;
                gridUsers[gridUsers.Rows.Count - 1, 1] = popStaff.Staff_FName;
                gridUsers[gridUsers.Rows.Count - 1, 2] = popStaff.Staff_LName;
                gridUsers[gridUsers.Rows.Count - 1, 3] = popStaff.Staff_MName;
                gridUsers[gridUsers.Rows.Count - 1, 4] = popStaff.Staff_Username;
                gridUsers[gridUsers.Rows.Count - 1, 5] = popStaff.Staff_Position;
                gridUsers[gridUsers.Rows.Count - 1, 6] = popStaff.Staff_Password;
                gridUsers[gridUsers.Rows.Count - 1, 7] = popStaff.Staff_Id;
            }
        }

        private void AccountsControl_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            SetId();
        }

        private void btnAccEdit_Click(object sender, EventArgs e)
        {
            EditAcc();
        }
        private void EditAcc()
        {
            using (EditAccountForm editAcc = new EditAccountForm())
            {
                if (gridUsers[gridUsers.RowSel, 5].ToString() == "Administrator")
                {
                    editAcc.cmbPosition.selectedIndex = 0;
                }
                else if (gridUsers[gridUsers.RowSel, 5].ToString() == "Encoder")
                {
                    editAcc.cmbPosition.selectedIndex = 1;
                }
                editAcc.txtFName.text = gridUsers[gridUsers.RowSel, 1].ToString();
                editAcc.txtLName.text = gridUsers[gridUsers.RowSel, 2].ToString();
                editAcc.txtMName.text = gridUsers[gridUsers.RowSel, 3].ToString();
                editAcc.txtUserName.text = gridUsers[gridUsers.RowSel, 4].ToString();
                editAcc.currentPass = gridUsers[gridUsers.RowSel, 6].ToString();
                editAcc.ShowDialog();
                if (editAcc.isConfirmed == true)
                {
                    var staffManage = new StaffManager();
                    var item = new StaffItem();

                    item.Staff_Position = editAcc.cmbPosition.selectedValue;
                    item.Staff_FName = editAcc.txtFName.text;
                    item.Staff_LName = editAcc.txtLName.text;
                    item.Staff_MName = editAcc.txtMName.text;
                    item.Staff_Username = editAcc.txtUserName.text;
                    item.Staff_Password = editAcc.txtPassword.Text;
                    item.Staff_Id = selectedStaffId;

                    staffManage.UpdateStaff(item);
                }
            }
            LoadAccounts();
        }

        private void gridUsers_Click(object sender, EventArgs e)
        {
            SetId();
        }
        private void SetId()
        {
            if (gridUsers.Rows.Count == 1)
            {
                selectedStaffId = 0;
            }
            else
            {
                selectedStaffId = Int32.Parse(gridUsers[gridUsers.RowSel, 7].ToString());
            }
        }

        private void btnAccDelete_Click(object sender, EventArgs e)
        {
            DeleteAcc();
        }
        private void DeleteAcc()
        {
            var result = MessageBox.Show("Do you want to delete this record", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StaffManager staffManage = new StaffManager();

                staffManage.DeleteAcc(selectedStaffId);
                LoadAccounts();
            }
        }
    }
}
