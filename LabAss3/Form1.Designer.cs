namespace LabAss3
{
    partial class frmCustomerDataEntry
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.redioFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.GroupBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(207, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 25);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nabil";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(6, 37);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 19);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // redioFemale
            // 
            this.redioFemale.AutoSize = true;
            this.redioFemale.Location = new System.Drawing.Point(169, 37);
            this.redioFemale.Name = "redioFemale";
            this.redioFemale.Size = new System.Drawing.Size(76, 19);
            this.redioFemale.TabIndex = 5;
            this.redioFemale.TabStop = true;
            this.redioFemale.Text = "Female";
            this.redioFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Controls.Add(this.radioMale);
            this.lblGender.Controls.Add(this.redioFemale);
            this.lblGender.Location = new System.Drawing.Point(38, 158);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(416, 81);
            this.lblGender.TabIndex = 6;
            this.lblGender.TabStop = false;
            this.lblGender.Text = "Gender";
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(198, 255);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(85, 19);
            this.chkReading.TabIndex = 7;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(346, 255);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(93, 19);
            this.chkPainting.TabIndex = 8;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            this.chkPainting.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hobbies";
            // 
            // rdoMarried
            // 
            this.rdoMarried.AutoSize = true;
            this.rdoMarried.Location = new System.Drawing.Point(6, 36);
            this.rdoMarried.Name = "rdoMarried";
            this.rdoMarried.Size = new System.Drawing.Size(68, 19);
            this.rdoMarried.TabIndex = 10;
            this.rdoMarried.TabStop = true;
            this.rdoMarried.Text = "Mamed";
            this.rdoMarried.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(161, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Unmamed";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdoMarried);
            this.groupBox1.Location = new System.Drawing.Point(44, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(198, 396);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(166, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "China",
            "Japan"});
            this.cmbCountry.Location = new System.Drawing.Point(207, 96);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(247, 23);
            this.cmbCountry.TabIndex = 14;
            this.cmbCountry.Text = "Bangladesh";
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerDataEntry";
            this.Text = "Form1";
            this.lblGender.ResumeLayout(false);
            this.lblGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton redioFemale;
        private System.Windows.Forms.GroupBox lblGender;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoMarried;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}

