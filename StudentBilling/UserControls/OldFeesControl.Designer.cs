namespace StudentBilling
{
    partial class OldFeesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldFeesControl));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTuition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridOld = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridOldPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOldPay)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gridOld);
            this.bunifuGradientPanel1.Controls.Add(this.gridOldPay);
            this.bunifuGradientPanel1.Controls.Add(this.lblTuition);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Turquoise;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SaddleBrown;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumPurple;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(979, 551);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lblTuition
            // 
            this.lblTuition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuition.AutoSize = true;
            this.lblTuition.BackColor = System.Drawing.Color.Transparent;
            this.lblTuition.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuition.ForeColor = System.Drawing.Color.Black;
            this.lblTuition.Location = new System.Drawing.Point(293, 17);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(448, 40);
            this.lblTuition.TabIndex = 11;
            this.lblTuition.Text = "Other Balance Payment History";
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
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 10);
            this.panel1.TabIndex = 9;
            // 
            // gridOld
            // 
            this.gridOld.AllowEditing = false;
            this.gridOld.ColumnInfo = resources.GetString("gridOld.ColumnInfo");
            this.gridOld.Location = new System.Drawing.Point(46, 116);
            this.gridOld.Name = "gridOld";
            this.gridOld.Rows.DefaultSize = 19;
            this.gridOld.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOld.Size = new System.Drawing.Size(560, 400);
            this.gridOld.TabIndex = 15;
            this.gridOld.Click += new System.EventHandler(this.gridOld_Click);
            // 
            // gridOldPay
            // 
            this.gridOldPay.AllowEditing = false;
            this.gridOldPay.ColumnInfo = "4,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t";
            this.gridOldPay.Location = new System.Drawing.Point(612, 116);
            this.gridOldPay.Name = "gridOldPay";
            this.gridOldPay.Rows.DefaultSize = 19;
            this.gridOldPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOldPay.Size = new System.Drawing.Size(328, 400);
            this.gridOldPay.TabIndex = 14;
            // 
            // OldFeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "OldFeesControl";
            this.Size = new System.Drawing.Size(979, 551);
            this.Load += new System.EventHandler(this.OldFeesControl_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOldPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblTuition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOld;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOldPay;
    }
}
