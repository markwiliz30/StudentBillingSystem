﻿namespace StudentBilling
{
    partial class EditOther
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOther));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.calCutOff = new Bunifu.Framework.UI.BunifuCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.calDatePaid = new Bunifu.Framework.UI.BunifuCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymade = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btnConfirm = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.txtBalance = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmbStatus = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.calDueDate = new Bunifu.Framework.UI.BunifuCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new Bunifu.Framework.UI.BunifuTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.calCutOff);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.calDatePaid);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtPaymade);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnConfirm);
            this.bunifuGradientPanel1.Controls.Add(this.txtBalance);
            this.bunifuGradientPanel1.Controls.Add(this.cmbStatus);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.calDueDate);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.txtAmount);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtDescription);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Thistle;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(577, 422);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // calCutOff
            // 
            this.calCutOff.BackColor = System.Drawing.Color.SeaGreen;
            this.calCutOff.BorderRadius = 0;
            this.calCutOff.ForeColor = System.Drawing.Color.White;
            this.calCutOff.Location = new System.Drawing.Point(312, 226);
            this.calCutOff.Name = "calCutOff";
            this.calCutOff.Size = new System.Drawing.Size(243, 36);
            this.calCutOff.TabIndex = 32;
            this.calCutOff.Value = new System.DateTime(2018, 3, 6, 21, 21, 13, 558);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cut Off Date:";
            // 
            // calDatePaid
            // 
            this.calDatePaid.BackColor = System.Drawing.Color.SeaGreen;
            this.calDatePaid.BorderRadius = 0;
            this.calDatePaid.Enabled = false;
            this.calDatePaid.ForeColor = System.Drawing.Color.White;
            this.calDatePaid.Location = new System.Drawing.Point(312, 155);
            this.calDatePaid.Name = "calDatePaid";
            this.calDatePaid.Size = new System.Drawing.Size(243, 36);
            this.calDatePaid.TabIndex = 30;
            this.calDatePaid.Value = new System.DateTime(2018, 3, 6, 21, 21, 13, 558);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date Paid:";
            // 
            // txtPaymade
            // 
            this.txtPaymade.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtPaymade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPaymade.BackgroundImage")));
            this.txtPaymade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPaymade.ForeColor = System.Drawing.Color.White;
            this.txtPaymade.Icon = ((System.Drawing.Image)(resources.GetObject("txtPaymade.Icon")));
            this.txtPaymade.Location = new System.Drawing.Point(15, 297);
            this.txtPaymade.Name = "txtPaymade";
            this.txtPaymade.Size = new System.Drawing.Size(267, 42);
            this.txtPaymade.TabIndex = 27;
            this.txtPaymade.text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Payment Made:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ForeColorHoverState = System.Drawing.Color.White;
            this.btnCancel.Iconimage = null;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.ImageIconOverlay = false;
            this.btnCancel.Location = new System.Drawing.Point(318, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 36);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.ForeColorHoverState = System.Drawing.Color.White;
            this.btnConfirm.Iconimage = null;
            this.btnConfirm.IconVisible = true;
            this.btnConfirm.IconZoom = 90D;
            this.btnConfirm.ImageIconOverlay = false;
            this.btnConfirm.Location = new System.Drawing.Point(157, 368);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 36);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBalance.BackgroundImage")));
            this.txtBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.Icon = ((System.Drawing.Image)(resources.GetObject("txtBalance.Icon")));
            this.txtBalance.Location = new System.Drawing.Point(15, 224);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(267, 42);
            this.txtBalance.TabIndex = 22;
            this.txtBalance.text = "";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.Items = new string[] {
        "Paid",
        "Not Paid"};
            this.cmbStatus.Location = new System.Drawing.Point(312, 300);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbStatus.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbStatus.selectedIndex = -1;
            this.cmbStatus.Size = new System.Drawing.Size(150, 35);
            this.cmbStatus.TabIndex = 20;
            this.cmbStatus.onItemSelected += new System.EventHandler(this.cmbStatus_onItemSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(307, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Due Date:";
            // 
            // calDueDate
            // 
            this.calDueDate.BackColor = System.Drawing.Color.SeaGreen;
            this.calDueDate.BorderRadius = 0;
            this.calDueDate.ForeColor = System.Drawing.Color.White;
            this.calDueDate.Location = new System.Drawing.Point(312, 84);
            this.calDueDate.Name = "calDueDate";
            this.calDueDate.Size = new System.Drawing.Size(243, 36);
            this.calDueDate.TabIndex = 17;
            this.calDueDate.Value = new System.DateTime(2018, 3, 6, 21, 21, 13, 558);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(187, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Edit Other Fee Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(307, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Payment Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAmount.Icon")));
            this.txtAmount.Location = new System.Drawing.Point(15, 151);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(267, 42);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescription.BackgroundImage")));
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Icon = ((System.Drawing.Image)(resources.GetObject("txtDescription.Icon")));
            this.txtDescription.Location = new System.Drawing.Point(15, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 42);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // EditOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOther";
            this.Text = "EditOther";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuCalendar calDatePaid;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuTextbox txtPaymade;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuThinButton btnCancel;
        private WindowsFormsControlLibrary1.BunifuThinButton btnConfirm;
        public Bunifu.Framework.UI.BunifuTextbox txtBalance;
        public Bunifu.Framework.UI.BunifuDropdown cmbStatus;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuCalendar calDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuTextbox txtAmount;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuTextbox txtDescription;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuCalendar calCutOff;
        private System.Windows.Forms.Label label5;
    }
}