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
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.GroupBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.Hobby = new System.Windows.Forms.Label();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.radioUnmarried = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGender.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
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
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(169, 37);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(76, 19);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Controls.Add(this.radioMale);
            this.lblGender.Controls.Add(this.radioFemale);
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
            // Hobby
            // 
            this.Hobby.AutoSize = true;
            this.Hobby.Location = new System.Drawing.Point(41, 259);
            this.Hobby.Name = "Hobby";
            this.Hobby.Size = new System.Drawing.Size(63, 15);
            this.Hobby.TabIndex = 9;
            this.Hobby.Text = "Hobbies";
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
            // radioUnmarried
            // 
            this.radioUnmarried.AutoSize = true;
            this.radioUnmarried.Location = new System.Drawing.Point(161, 36);
            this.radioUnmarried.Name = "radioUnmarried";
            this.radioUnmarried.Size = new System.Drawing.Size(84, 19);
            this.radioUnmarried.TabIndex = 11;
            this.radioUnmarried.TabStop = true;
            this.radioUnmarried.Text = "Unmamed";
            this.radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.radioUnmarried);
            this.Status.Controls.Add(this.rdoMarried);
            this.Status.Location = new System.Drawing.Point(44, 294);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(341, 76);
            this.Status.TabIndex = 12;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
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
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(553, 46);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 27;
            this.dtgCustomer.Size = new System.Drawing.Size(966, 281);
            this.dtgCustomer.TabIndex = 15;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(121, 455);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 15);
            this.lblID.TabIndex = 18;
            this.lblID.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Hobby);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerDataEntry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCustomerDataEntry_Load);
            this.lblGender.ResumeLayout(false);
            this.lblGender.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox lblGender;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.Label Hobby;
        private System.Windows.Forms.RadioButton rdoMarried;
        private System.Windows.Forms.RadioButton radioUnmarried;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button3;
    }
}

