namespace StudentBilling
{
    partial class ModifyStudentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyStudentControl));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gridStd = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditStd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPayments = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPayMade = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtSchoolYear = new System.Windows.Forms.TextBox();
            this.btnEditBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteTuition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditTuition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridTuitionPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTuition = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteOther = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditOther = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridOther = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridOtherPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridOld = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.gridOldPay = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnDeleteOld = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditOld = new Bunifu.Framework.UI.BunifuFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStd)).BeginInit();
            this.tabPayments.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuitionPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuition)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtherPay)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOldPay)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gridStd);
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnEditStd);
            this.bunifuGradientPanel1.Controls.Add(this.tabPayments);
            this.bunifuGradientPanel1.Controls.Add(this.materialTabSelector1);
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Thistle;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1059, 647);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // gridStd
            // 
            this.gridStd.AllowEditing = false;
            this.gridStd.ColumnInfo = resources.GetString("gridStd.ColumnInfo");
            this.gridStd.Location = new System.Drawing.Point(30, 70);
            this.gridStd.Name = "gridStd";
            this.gridStd.Rows.DefaultSize = 19;
            this.gridStd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridStd.Size = new System.Drawing.Size(319, 465);
            this.gridStd.TabIndex = 6;
            this.gridStd.Click += new System.EventHandler(this.gridStd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "     Delete Student";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(30, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(192, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEditStd
            // 
            this.btnEditStd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditStd.BorderRadius = 0;
            this.btnEditStd.ButtonText = "Edit Student Name";
            this.btnEditStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditStd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditStd.Iconimage")));
            this.btnEditStd.Iconimage_right = null;
            this.btnEditStd.Iconimage_right_Selected = null;
            this.btnEditStd.Iconimage_Selected = null;
            this.btnEditStd.IconZoom = 90D;
            this.btnEditStd.IsTab = false;
            this.btnEditStd.Location = new System.Drawing.Point(30, 544);
            this.btnEditStd.Name = "btnEditStd";
            this.btnEditStd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditStd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditStd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditStd.selected = false;
            this.btnEditStd.Size = new System.Drawing.Size(192, 39);
            this.btnEditStd.TabIndex = 4;
            this.btnEditStd.Textcolor = System.Drawing.Color.White;
            this.btnEditStd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStd.Click += new System.EventHandler(this.btnEditStd_Click_1);
            // 
            // tabPayments
            // 
            this.tabPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPayments.Controls.Add(this.tabPage1);
            this.tabPayments.Controls.Add(this.tabPage2);
            this.tabPayments.Controls.Add(this.tabPage3);
            this.tabPayments.Depth = 0;
            this.tabPayments.Location = new System.Drawing.Point(367, 70);
            this.tabPayments.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.SelectedIndex = 0;
            this.tabPayments.Size = new System.Drawing.Size(669, 528);
            this.tabPayments.TabIndex = 3;
            this.tabPayments.SelectedIndexChanged += new System.EventHandler(this.tabPayments_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(138)))), ((int)(((byte)(135)))));
            this.tabPage1.Controls.Add(this.txtDiscount);
            this.tabPage1.Controls.Add(this.txtSemester);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBalance);
            this.tabPage1.Controls.Add(this.txtPayMade);
            this.tabPage1.Controls.Add(this.txtFinal);
            this.tabPage1.Controls.Add(this.txtSchoolYear);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.btnEditBill);
            this.tabPage1.Controls.Add(this.btnDeleteTuition);
            this.tabPage1.Controls.Add(this.btnEditTuition);
            this.tabPage1.Controls.Add(this.gridTuitionPay);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gridTuition);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tuition Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 30);
            this.label2.TabIndex = 60;
            this.label2.Text = "%";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalance.Location = new System.Drawing.Point(367, 74);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(145, 29);
            this.txtBalance.TabIndex = 59;
            // 
            // txtPayMade
            // 
            this.txtPayMade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtPayMade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayMade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPayMade.Location = new System.Drawing.Point(185, 74);
            this.txtPayMade.Name = "txtPayMade";
            this.txtPayMade.ReadOnly = true;
            this.txtPayMade.Size = new System.Drawing.Size(172, 29);
            this.txtPayMade.TabIndex = 58;
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFinal.Location = new System.Drawing.Point(19, 74);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(160, 29);
            this.txtFinal.TabIndex = 57;
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtSchoolYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSchoolYear.Location = new System.Drawing.Point(498, 21);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.ReadOnly = true;
            this.txtSchoolYear.Size = new System.Drawing.Size(160, 29);
            this.txtSchoolYear.TabIndex = 56;
            // 
            // btnEditBill
            // 
            this.btnEditBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditBill.BorderRadius = 0;
            this.btnEditBill.ButtonText = "Edit Tuition";
            this.btnEditBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditBill.Iconimage")));
            this.btnEditBill.Iconimage_right = null;
            this.btnEditBill.Iconimage_right_Selected = null;
            this.btnEditBill.Iconimage_Selected = null;
            this.btnEditBill.IconZoom = 90D;
            this.btnEditBill.IsTab = false;
            this.btnEditBill.Location = new System.Drawing.Point(518, 64);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditBill.selected = false;
            this.btnEditBill.Size = new System.Drawing.Size(137, 39);
            this.btnEditBill.TabIndex = 45;
            this.btnEditBill.Textcolor = System.Drawing.Color.White;
            this.btnEditBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // btnDeleteTuition
            // 
            this.btnDeleteTuition.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteTuition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteTuition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTuition.BorderRadius = 0;
            this.btnDeleteTuition.ButtonText = "Delete Partition";
            this.btnDeleteTuition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTuition.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteTuition.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTuition.Iconimage")));
            this.btnDeleteTuition.Iconimage_right = null;
            this.btnDeleteTuition.Iconimage_right_Selected = null;
            this.btnDeleteTuition.Iconimage_Selected = null;
            this.btnDeleteTuition.IconZoom = 90D;
            this.btnDeleteTuition.IsTab = false;
            this.btnDeleteTuition.Location = new System.Drawing.Point(354, 463);
            this.btnDeleteTuition.Name = "btnDeleteTuition";
            this.btnDeleteTuition.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteTuition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteTuition.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteTuition.selected = false;
            this.btnDeleteTuition.Size = new System.Drawing.Size(158, 39);
            this.btnDeleteTuition.TabIndex = 44;
            this.btnDeleteTuition.Textcolor = System.Drawing.Color.White;
            this.btnDeleteTuition.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTuition.Click += new System.EventHandler(this.btnDeleteTuition_Click);
            // 
            // btnEditTuition
            // 
            this.btnEditTuition.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditTuition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditTuition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTuition.BorderRadius = 0;
            this.btnEditTuition.ButtonText = "Edit Partition";
            this.btnEditTuition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTuition.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditTuition.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditTuition.Iconimage")));
            this.btnEditTuition.Iconimage_right = null;
            this.btnEditTuition.Iconimage_right_Selected = null;
            this.btnEditTuition.Iconimage_Selected = null;
            this.btnEditTuition.IconZoom = 90D;
            this.btnEditTuition.IsTab = false;
            this.btnEditTuition.Location = new System.Drawing.Point(197, 463);
            this.btnEditTuition.Name = "btnEditTuition";
            this.btnEditTuition.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditTuition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditTuition.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditTuition.selected = false;
            this.btnEditTuition.Size = new System.Drawing.Size(151, 39);
            this.btnEditTuition.TabIndex = 43;
            this.btnEditTuition.Textcolor = System.Drawing.Color.White;
            this.btnEditTuition.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTuition.Click += new System.EventHandler(this.btnEditTuition_Click);
            // 
            // gridTuitionPay
            // 
            this.gridTuitionPay.AllowEditing = false;
            this.gridTuitionPay.ColumnInfo = "5,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t4{Width:57;Caption:\"Id\";}\t";
            this.gridTuitionPay.Location = new System.Drawing.Point(420, 109);
            this.gridTuitionPay.Name = "gridTuitionPay";
            this.gridTuitionPay.Rows.DefaultSize = 19;
            this.gridTuitionPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridTuitionPay.Size = new System.Drawing.Size(241, 342);
            this.gridTuitionPay.TabIndex = 41;
            this.gridTuitionPay.Click += new System.EventHandler(this.gridTuitionPay_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(363, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Balance:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(185, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "Total Payment Made:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Final Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(495, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "School Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(350, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Semester:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Discount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Amount:";
            // 
            // gridTuition
            // 
            this.gridTuition.AllowEditing = false;
            this.gridTuition.ColumnInfo = resources.GetString("gridTuition.ColumnInfo");
            this.gridTuition.Location = new System.Drawing.Point(0, 109);
            this.gridTuition.Name = "gridTuition";
            this.gridTuition.Rows.DefaultSize = 19;
            this.gridTuition.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridTuition.Size = new System.Drawing.Size(414, 342);
            this.gridTuition.TabIndex = 42;
            this.gridTuition.Click += new System.EventHandler(this.gridTuition_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(138)))), ((int)(((byte)(135)))));
            this.tabPage2.Controls.Add(this.btnDeleteOther);
            this.tabPage2.Controls.Add(this.btnEditOther);
            this.tabPage2.Controls.Add(this.gridOther);
            this.tabPage2.Controls.Add(this.gridOtherPay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Fees";
            // 
            // btnDeleteOther
            // 
            this.btnDeleteOther.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteOther.BorderRadius = 0;
            this.btnDeleteOther.ButtonText = "   Delete Fee";
            this.btnDeleteOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOther.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteOther.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteOther.Iconimage")));
            this.btnDeleteOther.Iconimage_right = null;
            this.btnDeleteOther.Iconimage_right_Selected = null;
            this.btnDeleteOther.Iconimage_Selected = null;
            this.btnDeleteOther.IconZoom = 90D;
            this.btnDeleteOther.IsTab = false;
            this.btnDeleteOther.Location = new System.Drawing.Point(354, 463);
            this.btnDeleteOther.Name = "btnDeleteOther";
            this.btnDeleteOther.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteOther.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteOther.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteOther.selected = false;
            this.btnDeleteOther.Size = new System.Drawing.Size(158, 39);
            this.btnDeleteOther.TabIndex = 13;
            this.btnDeleteOther.Textcolor = System.Drawing.Color.White;
            this.btnDeleteOther.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOther.Click += new System.EventHandler(this.btnDeleteOther_Click);
            // 
            // btnEditOther
            // 
            this.btnEditOther.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOther.BorderRadius = 0;
            this.btnEditOther.ButtonText = "   Edit Fee";
            this.btnEditOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOther.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditOther.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditOther.Iconimage")));
            this.btnEditOther.Iconimage_right = null;
            this.btnEditOther.Iconimage_right_Selected = null;
            this.btnEditOther.Iconimage_Selected = null;
            this.btnEditOther.IconZoom = 90D;
            this.btnEditOther.IsTab = false;
            this.btnEditOther.Location = new System.Drawing.Point(197, 463);
            this.btnEditOther.Name = "btnEditOther";
            this.btnEditOther.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditOther.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditOther.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditOther.selected = false;
            this.btnEditOther.Size = new System.Drawing.Size(151, 39);
            this.btnEditOther.TabIndex = 12;
            this.btnEditOther.Textcolor = System.Drawing.Color.White;
            this.btnEditOther.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOther.Click += new System.EventHandler(this.btnEditOther_Click);
            // 
            // gridOther
            // 
            this.gridOther.AllowEditing = false;
            this.gridOther.ColumnInfo = resources.GetString("gridOther.ColumnInfo");
            this.gridOther.Location = new System.Drawing.Point(0, -1);
            this.gridOther.Name = "gridOther";
            this.gridOther.Rows.DefaultSize = 19;
            this.gridOther.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOther.Size = new System.Drawing.Size(414, 444);
            this.gridOther.TabIndex = 11;
            this.gridOther.Click += new System.EventHandler(this.gridOther_Click);
            // 
            // gridOtherPay
            // 
            this.gridOtherPay.AllowEditing = false;
            this.gridOtherPay.ColumnInfo = "5,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t4{Width:67;Caption:\"Id\";}\t";
            this.gridOtherPay.Location = new System.Drawing.Point(420, -1);
            this.gridOtherPay.Name = "gridOtherPay";
            this.gridOtherPay.Rows.DefaultSize = 19;
            this.gridOtherPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOtherPay.Size = new System.Drawing.Size(241, 444);
            this.gridOtherPay.TabIndex = 10;
            this.gridOtherPay.Click += new System.EventHandler(this.gridOtherPay_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(138)))), ((int)(((byte)(135)))));
            this.tabPage3.Controls.Add(this.gridOld);
            this.tabPage3.Controls.Add(this.gridOldPay);
            this.tabPage3.Controls.Add(this.btnDeleteOld);
            this.tabPage3.Controls.Add(this.btnEditOld);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(661, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Old Fees";
            // 
            // gridOld
            // 
            this.gridOld.AllowEditing = false;
            this.gridOld.ColumnInfo = resources.GetString("gridOld.ColumnInfo");
            this.gridOld.Location = new System.Drawing.Point(0, -1);
            this.gridOld.Name = "gridOld";
            this.gridOld.Rows.DefaultSize = 19;
            this.gridOld.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOld.Size = new System.Drawing.Size(414, 444);
            this.gridOld.TabIndex = 13;
            this.gridOld.Click += new System.EventHandler(this.gridOld_Click_1);
            // 
            // gridOldPay
            // 
            this.gridOldPay.AllowEditing = false;
            this.gridOldPay.ColumnInfo = "5,1,0,0,0,95,Columns:1{Width:69;Caption:\"Payment no.\";}\t2{Width:131;Caption:\"Paym" +
    "ent\";}\t3{Width:109;Caption:\"Date paid\";}\t4{Width:67;Caption:\"Id\";}\t";
            this.gridOldPay.Location = new System.Drawing.Point(420, -1);
            this.gridOldPay.Name = "gridOldPay";
            this.gridOldPay.Rows.DefaultSize = 19;
            this.gridOldPay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridOldPay.Size = new System.Drawing.Size(241, 444);
            this.gridOldPay.TabIndex = 12;
            this.gridOldPay.Click += new System.EventHandler(this.gridOldPay_Click);
            // 
            // btnDeleteOld
            // 
            this.btnDeleteOld.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteOld.BorderRadius = 0;
            this.btnDeleteOld.ButtonText = "   Delete Fee";
            this.btnDeleteOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOld.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteOld.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteOld.Iconimage")));
            this.btnDeleteOld.Iconimage_right = null;
            this.btnDeleteOld.Iconimage_right_Selected = null;
            this.btnDeleteOld.Iconimage_Selected = null;
            this.btnDeleteOld.IconZoom = 90D;
            this.btnDeleteOld.IsTab = false;
            this.btnDeleteOld.Location = new System.Drawing.Point(354, 463);
            this.btnDeleteOld.Name = "btnDeleteOld";
            this.btnDeleteOld.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnDeleteOld.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteOld.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteOld.selected = false;
            this.btnDeleteOld.Size = new System.Drawing.Size(158, 39);
            this.btnDeleteOld.TabIndex = 11;
            this.btnDeleteOld.Textcolor = System.Drawing.Color.White;
            this.btnDeleteOld.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOld.Click += new System.EventHandler(this.btnDeleteOld_Click);
            // 
            // btnEditOld
            // 
            this.btnEditOld.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOld.BorderRadius = 0;
            this.btnEditOld.ButtonText = "   Edit Fee";
            this.btnEditOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOld.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditOld.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditOld.Iconimage")));
            this.btnEditOld.Iconimage_right = null;
            this.btnEditOld.Iconimage_right_Selected = null;
            this.btnEditOld.Iconimage_Selected = null;
            this.btnEditOld.IconZoom = 90D;
            this.btnEditOld.IsTab = false;
            this.btnEditOld.Location = new System.Drawing.Point(197, 463);
            this.btnEditOld.Name = "btnEditOld";
            this.btnEditOld.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.btnEditOld.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditOld.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditOld.selected = false;
            this.btnEditOld.Size = new System.Drawing.Size(151, 39);
            this.btnEditOld.TabIndex = 10;
            this.btnEditOld.Textcolor = System.Drawing.Color.White;
            this.btnEditOld.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOld.Click += new System.EventHandler(this.btnEditOld_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabPayments;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(367, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(669, 23);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(48)))), ((int)(((byte)(219)))));
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(30, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 42);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.stdSearch_OnTextChange);
            // 
            // txtSemester
            // 
            this.txtSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtSemester.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemester.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSemester.Location = new System.Drawing.Point(354, 22);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(132, 29);
            this.txtSemester.TabIndex = 55;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiscount.Location = new System.Drawing.Point(185, 22);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(118, 29);
            this.txtDiscount.TabIndex = 54;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmount.Location = new System.Drawing.Point(19, 22);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(160, 29);
            this.txtAmount.TabIndex = 53;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // ModifyStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "ModifyStudentControl";
            this.Size = new System.Drawing.Size(1059, 647);
            this.Load += new System.EventHandler(this.ModifyStudentControl_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStd)).EndInit();
            this.tabPayments.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuitionPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTuition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtherPay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOldPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MaterialSkin.Controls.MaterialTabControl tabPayments;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditStd;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteOld;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditOld;
        private C1.Win.C1FlexGrid.C1FlexGrid gridTuition;
        private C1.Win.C1FlexGrid.C1FlexGrid gridTuitionPay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOther;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOtherPay;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOld;
        private C1.Win.C1FlexGrid.C1FlexGrid gridOldPay;
        private C1.Win.C1FlexGrid.C1FlexGrid gridStd;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteTuition;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditTuition;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteOther;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditOther;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditBill;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPayMade;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtSchoolYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtAmount;
    }
}
