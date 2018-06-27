namespace StudentBilling
{
    partial class TuitionFeeAddPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuitionFeeAddPaymentForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btnConfirm = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.lblData = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtPartition = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calDueDate = new Bunifu.Framework.UI.BunifuCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnConfirm);
            this.bunifuGradientPanel1.Controls.Add(this.lblData);
            this.bunifuGradientPanel1.Controls.Add(this.txtAmount);
            this.bunifuGradientPanel1.Controls.Add(this.txtPartition);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitle);
            this.bunifuGradientPanel1.Controls.Add(this.calDueDate);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Salmon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SandyBrown;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(336, 474);
            this.bunifuGradientPanel1.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(175, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 36);
            this.btnCancel.TabIndex = 14;
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
            this.btnConfirm.Location = new System.Drawing.Point(23, 407);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 36);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(32, 44);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(101, 25);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data Here";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAmount.Icon")));
            this.txtAmount.Location = new System.Drawing.Point(37, 223);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(254, 42);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.text = "";
            // 
            // txtPartition
            // 
            this.txtPartition.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtPartition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPartition.BackgroundImage")));
            this.txtPartition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPartition.ForeColor = System.Drawing.Color.White;
            this.txtPartition.Icon = ((System.Drawing.Image)(resources.GetObject("txtPartition.Icon")));
            this.txtPartition.Location = new System.Drawing.Point(37, 126);
            this.txtPartition.Name = "txtPartition";
            this.txtPartition.Size = new System.Drawing.Size(129, 42);
            this.txtPartition.TabIndex = 7;
            this.txtPartition.text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(32, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Remaining Tuition Fee:";
            // 
            // calDueDate
            // 
            this.calDueDate.BackColor = System.Drawing.Color.LightSlateGray;
            this.calDueDate.BorderRadius = 0;
            this.calDueDate.ForeColor = System.Drawing.Color.White;
            this.calDueDate.Location = new System.Drawing.Point(37, 332);
            this.calDueDate.Name = "calDueDate";
            this.calDueDate.Size = new System.Drawing.Size(274, 36);
            this.calDueDate.TabIndex = 5;
            this.calDueDate.Value = new System.DateTime(2018, 3, 6, 0, 0, 0, 0);
            this.calDueDate.onValueChanged += new System.EventHandler(this.bunifuCalendar1_onValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partition:";
            // 
            // TuitionFeeAddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 479);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TuitionFeeAddPaymentForm";
            this.Text = "TuitionFeeAddPaymentForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuThinButton btnCancel;
        private WindowsFormsControlLibrary1.BunifuThinButton btnConfirm;
        public Bunifu.Framework.UI.BunifuCalendar calDueDate;
        public Bunifu.Framework.UI.BunifuTextbox txtAmount;
        public Bunifu.Framework.UI.BunifuTextbox txtPartition;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblData;
    }
}