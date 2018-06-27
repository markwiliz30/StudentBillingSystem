namespace StudentBilling
{
    partial class EditPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPayments));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.calDatePaid = new Bunifu.Framework.UI.BunifuCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btnConfirm = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayNo = new Bunifu.Framework.UI.BunifuTextbox();
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
            this.bunifuGradientPanel1.Controls.Add(this.calDatePaid);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnConfirm);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.txtAmount);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtPayNo);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Thistle;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(335, 393);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // calDatePaid
            // 
            this.calDatePaid.BackColor = System.Drawing.Color.SeaGreen;
            this.calDatePaid.BorderRadius = 0;
            this.calDatePaid.ForeColor = System.Drawing.Color.White;
            this.calDatePaid.Location = new System.Drawing.Point(15, 247);
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
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date Paid:";
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
            this.btnCancel.Location = new System.Drawing.Point(168, 321);
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
            this.btnConfirm.Location = new System.Drawing.Point(15, 321);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 36);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Edit Payment Data";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAmount.Icon")));
            this.txtAmount.Location = new System.Drawing.Point(15, 162);
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
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // txtPayNo
            // 
            this.txtPayNo.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtPayNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPayNo.BackgroundImage")));
            this.txtPayNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPayNo.ForeColor = System.Drawing.Color.White;
            this.txtPayNo.Icon = ((System.Drawing.Image)(resources.GetObject("txtPayNo.Icon")));
            this.txtPayNo.Location = new System.Drawing.Point(15, 78);
            this.txtPayNo.Name = "txtPayNo";
            this.txtPayNo.Size = new System.Drawing.Size(140, 42);
            this.txtPayNo.TabIndex = 3;
            this.txtPayNo.text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment no.:";
            // 
            // EditPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPayments";
            this.Text = "EditPayments";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuCalendar calDatePaid;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuThinButton btnCancel;
        private WindowsFormsControlLibrary1.BunifuThinButton btnConfirm;
        private System.Windows.Forms.Label label9;
        public Bunifu.Framework.UI.BunifuTextbox txtAmount;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuTextbox txtPayNo;
        private System.Windows.Forms.Label label2;
    }
}