namespace StudentBilling
{
    partial class OtherFeesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherFeesControl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTuition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridOther = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridOtherPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtherPay)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.gridOther);
            this.bunifuGradientPanel1.Controls.Add(this.gridOtherPay);
            this.bunifuGradientPanel1.Controls.Add(this.lblTuition);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Turquoise;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SandyBrown;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(979, 551);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // lblTuition
            // 
            this.lblTuition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuition.AutoSize = true;
            this.lblTuition.BackColor = System.Drawing.Color.Transparent;
            this.lblTuition.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuition.ForeColor = System.Drawing.Color.Black;
            this.lblTuition.Location = new System.Drawing.Point(300, 17);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(401, 40);
            this.lblTuition.TabIndex = 5;
            this.lblTuition.Text = "Other Fees Payment History";
            this.lblTuition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 10);
            this.panel1.TabIndex = 3;
            // 
            // gridOther
            // 
            this.gridOther.AllowEditing = false;
            this.gridOther.ColumnInfo = resources.GetString("gridOther.ColumnInfo");
            this.gridOther.Location = new System.Drawing.Point(49, 127);
            this.gridOther.Name = "gridOther";
            this.gridOther.Rows.DefaultSize = 19;
            this.gridOther.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOther.Size = new System.Drawing.Size(514, 376);
            this.gridOther.TabIndex = 13;
            this.gridOther.Click += new System.EventHandler(this.gridOther_Click);
            // 
            // gridOtherPay
            // 
            this.gridOtherPay.AllowEditing = false;
            this.gridOtherPay.ColumnInfo = "4,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t";
            this.gridOtherPay.Location = new System.Drawing.Point(578, 127);
            this.gridOtherPay.Name = "gridOtherPay";
            this.gridOtherPay.Rows.DefaultSize = 19;
            this.gridOtherPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOtherPay.Size = new System.Drawing.Size(356, 376);
            this.gridOtherPay.TabIndex = 12;
            // 
            // OtherFeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "OtherFeesControl";
            this.Size = new System.Drawing.Size(979, 551);
            this.Load += new System.EventHandler(this.OtherFeesControl_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtherPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOther;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOtherPay;
    }
}
