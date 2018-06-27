namespace StudentBilling
{
    partial class PaymentWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentWindowForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayAmount = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calPayDate = new Bunifu.Framework.UI.BunifuCalendar();
            this.btnConfirm = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btnCancel = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblSelectedFee = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Fee:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtPayAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPayAmount.BackgroundImage")));
            this.txtPayAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPayAmount.ForeColor = System.Drawing.Color.White;
            this.txtPayAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtPayAmount.Icon")));
            this.txtPayAmount.Location = new System.Drawing.Point(36, 97);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(238, 42);
            this.txtPayAmount.TabIndex = 4;
            this.txtPayAmount.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Paid:";
            // 
            // calPayDate
            // 
            this.calPayDate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.calPayDate.BorderRadius = 0;
            this.calPayDate.ForeColor = System.Drawing.Color.White;
            this.calPayDate.Location = new System.Drawing.Point(347, 97);
            this.calPayDate.Name = "calPayDate";
            this.calPayDate.Size = new System.Drawing.Size(238, 36);
            this.calPayDate.TabIndex = 8;
            this.calPayDate.Value = new System.DateTime(2018, 3, 6, 18, 50, 1, 875);
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
            this.btnConfirm.Location = new System.Drawing.Point(138, 177);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 36);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(347, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblBalance);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.lblSelectedFee);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnConfirm);
            this.bunifuGradientPanel1.Controls.Add(this.calPayDate);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtPayAmount);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Turquoise;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(614, 232);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // lblSelectedFee
            // 
            this.lblSelectedFee.AutoSize = true;
            this.lblSelectedFee.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFee.ForeColor = System.Drawing.Color.White;
            this.lblSelectedFee.Location = new System.Drawing.Point(33, 34);
            this.lblSelectedFee.Name = "lblSelectedFee";
            this.lblSelectedFee.Size = new System.Drawing.Size(86, 21);
            this.lblSelectedFee.TabIndex = 11;
            this.lblSelectedFee.Text = "Data Here";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(343, 34);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(86, 21);
            this.lblBalance.TabIndex = 13;
            this.lblBalance.Text = "Data Here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(343, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ramaining Balance:";
            // 
            // PaymentWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 238);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentWindowForm";
            this.Text = "PaymentWindowForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private WindowsFormsControlLibrary1.BunifuThinButton btnCancel;
        private WindowsFormsControlLibrary1.BunifuThinButton btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuCalendar calPayDate;
        public Bunifu.Framework.UI.BunifuTextbox txtPayAmount;
        public System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblSelectedFee;
    }
}