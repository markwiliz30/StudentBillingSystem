namespace StudentBilling
{
    partial class testForm
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
            this.calDatePaid = new Bunifu.Framework.UI.BunifuCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calDatePaid
            // 
            this.calDatePaid.BackColor = System.Drawing.Color.SeaGreen;
            this.calDatePaid.BorderRadius = 0;
            this.calDatePaid.ForeColor = System.Drawing.Color.White;
            this.calDatePaid.Location = new System.Drawing.Point(99, 29);
            this.calDatePaid.Name = "calDatePaid";
            this.calDatePaid.Size = new System.Drawing.Size(243, 36);
            this.calDatePaid.TabIndex = 31;
            this.calDatePaid.Value = new System.DateTime(2018, 3, 6, 21, 21, 13, 558);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calDatePaid);
            this.Name = "testForm";
            this.Text = "testForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCalendar calDatePaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}