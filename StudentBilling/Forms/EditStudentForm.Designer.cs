namespace StudentBilling
{
    partial class EditStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.btnConfirm = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.txtMName = new Bunifu.Framework.UI.BunifuTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new Bunifu.Framework.UI.BunifuTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCode = new Bunifu.Framework.UI.BunifuTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCtitle = new Bunifu.Framework.UI.BunifuTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new Bunifu.Framework.UI.BunifuTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSection = new Bunifu.Framework.UI.BunifuTextbox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.bunifuGradientPanel1.Controls.Add(this.txtSection);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.txtYear);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.txtCtitle);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.txtCCode);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btnConfirm);
            this.bunifuGradientPanel1.Controls.Add(this.txtMName);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtLName);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtFName);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Thistle;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(591, 467);
            this.bunifuGradientPanel1.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(314, 406);
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
            this.btnConfirm.Location = new System.Drawing.Point(132, 406);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 36);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMName.BackgroundImage")));
            this.txtMName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMName.ForeColor = System.Drawing.Color.White;
            this.txtMName.Icon = ((System.Drawing.Image)(resources.GetObject("txtMName.Icon")));
            this.txtMName.Location = new System.Drawing.Point(39, 317);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(229, 42);
            this.txtMName.TabIndex = 10;
            this.txtMName.text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Middle Name:";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtLName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLName.BackgroundImage")));
            this.txtLName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtLName.ForeColor = System.Drawing.Color.White;
            this.txtLName.Icon = ((System.Drawing.Image)(resources.GetObject("txtLName.Icon")));
            this.txtLName.Location = new System.Drawing.Point(39, 215);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(229, 42);
            this.txtLName.TabIndex = 8;
            this.txtLName.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Student Data";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtFName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFName.BackgroundImage")));
            this.txtFName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFName.ForeColor = System.Drawing.Color.White;
            this.txtFName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFName.Icon")));
            this.txtFName.Location = new System.Drawing.Point(39, 118);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(229, 42);
            this.txtFName.TabIndex = 5;
            this.txtFName.text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // txtCCode
            // 
            this.txtCCode.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtCCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCCode.BackgroundImage")));
            this.txtCCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCCode.ForeColor = System.Drawing.Color.White;
            this.txtCCode.Icon = ((System.Drawing.Image)(resources.GetObject("txtCCode.Icon")));
            this.txtCCode.Location = new System.Drawing.Point(314, 111);
            this.txtCCode.Name = "txtCCode";
            this.txtCCode.Size = new System.Drawing.Size(229, 42);
            this.txtCCode.TabIndex = 16;
            this.txtCCode.text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(309, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Course Code:";
            // 
            // txtCtitle
            // 
            this.txtCtitle.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtCtitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCtitle.BackgroundImage")));
            this.txtCtitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCtitle.ForeColor = System.Drawing.Color.White;
            this.txtCtitle.Icon = ((System.Drawing.Image)(resources.GetObject("txtCtitle.Icon")));
            this.txtCtitle.Location = new System.Drawing.Point(314, 184);
            this.txtCtitle.Name = "txtCtitle";
            this.txtCtitle.Size = new System.Drawing.Size(229, 42);
            this.txtCtitle.TabIndex = 18;
            this.txtCtitle.text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Course Title:";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtYear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtYear.BackgroundImage")));
            this.txtYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtYear.ForeColor = System.Drawing.Color.White;
            this.txtYear.Icon = ((System.Drawing.Image)(resources.GetObject("txtYear.Icon")));
            this.txtYear.Location = new System.Drawing.Point(314, 257);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(229, 42);
            this.txtYear.TabIndex = 20;
            this.txtYear.text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(309, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Year/Grade Leve:";
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtSection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSection.BackgroundImage")));
            this.txtSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSection.ForeColor = System.Drawing.Color.White;
            this.txtSection.Icon = ((System.Drawing.Image)(resources.GetObject("txtSection.Icon")));
            this.txtSection.Location = new System.Drawing.Point(314, 330);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(229, 42);
            this.txtSection.TabIndex = 22;
            this.txtSection.text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(309, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Section:";
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 473);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuThinButton btnCancel;
        private WindowsFormsControlLibrary1.BunifuThinButton btnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuTextbox txtCtitle;
        public Bunifu.Framework.UI.BunifuTextbox txtCCode;
        public Bunifu.Framework.UI.BunifuTextbox txtSection;
        public Bunifu.Framework.UI.BunifuTextbox txtYear;
        public Bunifu.Framework.UI.BunifuTextbox txtMName;
        public Bunifu.Framework.UI.BunifuTextbox txtLName;
        public Bunifu.Framework.UI.BunifuTextbox txtFName;
    }
}