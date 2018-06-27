namespace StudentBilling
{
    partial class AccountsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsControl));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAccDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridUsers = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnAccDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnAccEdit);
            this.bunifuGradientPanel1.Controls.Add(this.btnAccAdd);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.gridUsers);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.PaleVioletRed;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1059, 647);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // btnAccDelete
            // 
            this.btnAccDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccDelete.BorderRadius = 0;
            this.btnAccDelete.ButtonText = "    Delete";
            this.btnAccDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccDelete.Iconimage")));
            this.btnAccDelete.Iconimage_right = null;
            this.btnAccDelete.Iconimage_right_Selected = null;
            this.btnAccDelete.Iconimage_Selected = null;
            this.btnAccDelete.IconZoom = 90D;
            this.btnAccDelete.IsTab = false;
            this.btnAccDelete.Location = new System.Drawing.Point(640, 562);
            this.btnAccDelete.Name = "btnAccDelete";
            this.btnAccDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccDelete.selected = false;
            this.btnAccDelete.Size = new System.Drawing.Size(140, 48);
            this.btnAccDelete.TabIndex = 5;
            this.btnAccDelete.Textcolor = System.Drawing.Color.White;
            this.btnAccDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccDelete.Click += new System.EventHandler(this.btnAccDelete_Click);
            // 
            // btnAccEdit
            // 
            this.btnAccEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccEdit.BorderRadius = 0;
            this.btnAccEdit.ButtonText = "      Edit";
            this.btnAccEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccEdit.Iconimage")));
            this.btnAccEdit.Iconimage_right = null;
            this.btnAccEdit.Iconimage_right_Selected = null;
            this.btnAccEdit.Iconimage_Selected = null;
            this.btnAccEdit.IconZoom = 90D;
            this.btnAccEdit.IsTab = false;
            this.btnAccEdit.Location = new System.Drawing.Point(452, 562);
            this.btnAccEdit.Name = "btnAccEdit";
            this.btnAccEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccEdit.selected = false;
            this.btnAccEdit.Size = new System.Drawing.Size(140, 48);
            this.btnAccEdit.TabIndex = 4;
            this.btnAccEdit.Textcolor = System.Drawing.Color.White;
            this.btnAccEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccEdit.Click += new System.EventHandler(this.btnAccEdit_Click);
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccAdd.BorderRadius = 0;
            this.btnAccAdd.ButtonText = "     Add";
            this.btnAccAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccAdd.Iconimage")));
            this.btnAccAdd.Iconimage_right = null;
            this.btnAccAdd.Iconimage_right_Selected = null;
            this.btnAccAdd.Iconimage_Selected = null;
            this.btnAccAdd.IconZoom = 90D;
            this.btnAccAdd.IsTab = false;
            this.btnAccAdd.Location = new System.Drawing.Point(258, 562);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.btnAccAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccAdd.selected = false;
            this.btnAccAdd.Size = new System.Drawing.Size(140, 48);
            this.btnAccAdd.TabIndex = 3;
            this.btnAccAdd.Textcolor = System.Drawing.Color.White;
            this.btnAccAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccAdd.Click += new System.EventHandler(this.btnAccAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Table";
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnInfo = resources.GetString("gridUsers.ColumnInfo");
            this.gridUsers.Location = new System.Drawing.Point(136, 94);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Rows.DefaultSize = 19;
            this.gridUsers.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridUsers.Size = new System.Drawing.Size(752, 446);
            this.gridUsers.TabIndex = 1;
            this.gridUsers.Click += new System.EventHandler(this.gridUsers_Click);
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(1059, 647);
            this.Load += new System.EventHandler(this.AccountsControl_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccAdd;
    }
}
