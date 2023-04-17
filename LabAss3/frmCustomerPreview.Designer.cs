namespace LabAss3
{
    partial class frmCustomerPreview
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(111, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(344, 196);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(39, 15);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Male";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(111, 196);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(31, 15);
            this.sex.TabIndex = 2;
            this.sex.Text = "Sex";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(344, 90);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(47, 15);
            this.CustomerName.TabIndex = 3;
            this.CustomerName.Text = "Nabil";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(111, 304);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unmamed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reading";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(111, 242);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(63, 15);
            this.lblHobby.TabIndex = 7;
            this.lblHobby.Text = "Hobbies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bangladesh";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(111, 141);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(103, 15);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country Name";
            // 
            // frmCustomerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Name = "frmCustomerPreview";
            this.Text = "frmCustomerPreview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCountry;
    }
}