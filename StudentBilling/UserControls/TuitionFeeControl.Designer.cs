namespace StudentBilling
{
    partial class TuitionFeeControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuitionFeeControl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTuitionDueDateContainer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFullPaidDateContainer = new System.Windows.Forms.Label();
            this.lblTotalPaymentMadeContainer = new System.Windows.Forms.Label();
            this.lblTotalBalanceContainer = new System.Windows.Forms.Label();
            this.lblDiscountContainer = new System.Windows.Forms.Label();
            this.lblTotalTuitionContainer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTuition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridTuitionPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridTuition = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuitionPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuition)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gridTuitionPay);
            this.bunifuGradientPanel1.Controls.Add(this.gridTuition);
            this.bunifuGradientPanel1.Controls.Add(this.lblTuitionDueDateContainer);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.lblFullPaidDateContainer);
            this.bunifuGradientPanel1.Controls.Add(this.lblTotalPaymentMadeContainer);
            this.bunifuGradientPanel1.Controls.Add(this.lblTotalBalanceContainer);
            this.bunifuGradientPanel1.Controls.Add(this.lblDiscountContainer);
            this.bunifuGradientPanel1.Controls.Add(this.lblTotalTuitionContainer);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lblTuition);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Sienna;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Wheat;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(979, 551);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lblTuitionDueDateContainer
            // 
            this.lblTuitionDueDateContainer.AutoSize = true;
            this.lblTuitionDueDateContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTuitionDueDateContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionDueDateContainer.ForeColor = System.Drawing.Color.Black;
            this.lblTuitionDueDateContainer.Location = new System.Drawing.Point(730, 165);
            this.lblTuitionDueDateContainer.Name = "lblTuitionDueDateContainer";
            this.lblTuitionDueDateContainer.Size = new System.Drawing.Size(80, 21);
            this.lblTuitionDueDateContainer.TabIndex = 16;
            this.lblTuitionDueDateContainer.Text = "Data here";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(643, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Due Date:";
            // 
            // lblFullPaidDateContainer
            // 
            this.lblFullPaidDateContainer.AutoSize = true;
            this.lblFullPaidDateContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblFullPaidDateContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullPaidDateContainer.ForeColor = System.Drawing.Color.Black;
            this.lblFullPaidDateContainer.Location = new System.Drawing.Point(730, 131);
            this.lblFullPaidDateContainer.Name = "lblFullPaidDateContainer";
            this.lblFullPaidDateContainer.Size = new System.Drawing.Size(80, 21);
            this.lblFullPaidDateContainer.TabIndex = 13;
            this.lblFullPaidDateContainer.Text = "Data here";
            // 
            // lblTotalPaymentMadeContainer
            // 
            this.lblTotalPaymentMadeContainer.AutoSize = true;
            this.lblTotalPaymentMadeContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPaymentMadeContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentMadeContainer.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPaymentMadeContainer.Location = new System.Drawing.Point(730, 97);
            this.lblTotalPaymentMadeContainer.Name = "lblTotalPaymentMadeContainer";
            this.lblTotalPaymentMadeContainer.Size = new System.Drawing.Size(80, 21);
            this.lblTotalPaymentMadeContainer.TabIndex = 12;
            this.lblTotalPaymentMadeContainer.Text = "Data here";
            // 
            // lblTotalBalanceContainer
            // 
            this.lblTotalBalanceContainer.AutoSize = true;
            this.lblTotalBalanceContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalanceContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceContainer.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBalanceContainer.Location = new System.Drawing.Point(276, 165);
            this.lblTotalBalanceContainer.Name = "lblTotalBalanceContainer";
            this.lblTotalBalanceContainer.Size = new System.Drawing.Size(80, 21);
            this.lblTotalBalanceContainer.TabIndex = 11;
            this.lblTotalBalanceContainer.Text = "Data here";
            // 
            // lblDiscountContainer
            // 
            this.lblDiscountContainer.AutoSize = true;
            this.lblDiscountContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountContainer.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountContainer.Location = new System.Drawing.Point(276, 131);
            this.lblDiscountContainer.Name = "lblDiscountContainer";
            this.lblDiscountContainer.Size = new System.Drawing.Size(80, 21);
            this.lblDiscountContainer.TabIndex = 10;
            this.lblDiscountContainer.Text = "Data here";
            // 
            // lblTotalTuitionContainer
            // 
            this.lblTotalTuitionContainer.AutoSize = true;
            this.lblTotalTuitionContainer.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTuitionContainer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTuitionContainer.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTuitionContainer.Location = new System.Drawing.Point(276, 97);
            this.lblTotalTuitionContainer.Name = "lblTotalTuitionContainer";
            this.lblTotalTuitionContainer.Size = new System.Drawing.Size(80, 21);
            this.lblTotalTuitionContainer.TabIndex = 9;
            this.lblTotalTuitionContainer.Text = "Data here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(612, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Full Paid Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Balance:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(560, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Payment Made:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(165, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Tuition Fee:";
            // 
            // lblTuition
            // 
            this.lblTuition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuition.AutoSize = true;
            this.lblTuition.BackColor = System.Drawing.Color.Transparent;
            this.lblTuition.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuition.ForeColor = System.Drawing.Color.Black;
            this.lblTuition.Location = new System.Drawing.Point(293, 19);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(408, 40);
            this.lblTuition.TabIndex = 2;
            this.lblTuition.Text = "Tuition Fee Payment History";
            this.lblTuition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 10);
            this.panel1.TabIndex = 0;
            // 
            // gridTuitionPay
            // 
            this.gridTuitionPay.AllowEditing = false;
            this.gridTuitionPay.ColumnInfo = "4,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t";
            this.gridTuitionPay.Location = new System.Drawing.Point(597, 190);
            this.gridTuitionPay.Name = "gridTuitionPay";
            this.gridTuitionPay.Rows.DefaultSize = 19;
            this.gridTuitionPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridTuitionPay.Size = new System.Drawing.Size(350, 342);
            this.gridTuitionPay.TabIndex = 43;
            // 
            // gridTuition
            // 
            this.gridTuition.AllowEditing = false;
            this.gridTuition.ColumnInfo = resources.GetString("gridTuition.ColumnInfo");
            this.gridTuition.Location = new System.Drawing.Point(33, 190);
            this.gridTuition.Name = "gridTuition";
            this.gridTuition.Rows.DefaultSize = 19;
            this.gridTuition.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridTuition.Size = new System.Drawing.Size(558, 342);
            this.gridTuition.TabIndex = 44;
            this.gridTuition.Click += new System.EventHandler(this.gridTuition_Click);
            // 
            // TuitionFeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "TuitionFeeControl";
            this.Size = new System.Drawing.Size(979, 551);
            this.Load += new System.EventHandler(this.TuitionFeeControl_Load);
            this.SizeChanged += new System.EventHandler(this.TuitionFeeControl_SizeChanged);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuitionPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullPaidDateContainer;
        private System.Windows.Forms.Label lblTotalPaymentMadeContainer;
        private System.Windows.Forms.Label lblTotalBalanceContainer;
        private System.Windows.Forms.Label lblDiscountContainer;
        private System.Windows.Forms.Label lblTotalTuitionContainer;
        private System.Windows.Forms.Label lblTuitionDueDateContainer;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1FlexGrid.C1FlexGrid gridTuitionPay;
        private C1.Win.C1FlexGrid.C1FlexGrid gridTuition;
    }
}
