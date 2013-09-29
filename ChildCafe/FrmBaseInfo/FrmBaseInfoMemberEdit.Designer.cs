namespace ChildCafe
{
    partial class FrmBaseInfoMemberEdit
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
            this.ctMemberName = new System.Windows.Forms.TextBox();
            this.ctCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctPinYin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctBirth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ctMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ctRemainingSum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ctTotalBonusPoint = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ctFrequency = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ctTotalSpending = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ctJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRemainingSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTotalBonusPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTotalSpending)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(606, 264);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctJoinedDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ctTotalSpending);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.ctFrequency);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ctTotalBonusPoint);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ctRemainingSum);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctDiscountRate);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ctPhone);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ctMobile);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ctBirth);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ctPassword);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctPinYin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctMemberName);
            this.tabPage1.Controls.Add(this.ctCardNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(598, 238);
            // 
            // ctMemberName
            // 
            this.ctMemberName.Location = new System.Drawing.Point(259, 6);
            this.ctMemberName.Name = "ctMemberName";
            this.ctMemberName.Size = new System.Drawing.Size(121, 21);
            this.ctMemberName.TabIndex = 34;
            this.ctMemberName.TextChanged += new System.EventHandler(this.ctName_TextChanged);
            // 
            // ctCardNumber
            // 
            this.ctCardNumber.Location = new System.Drawing.Point(67, 6);
            this.ctCardNumber.Name = "ctCardNumber";
            this.ctCardNumber.Size = new System.Drawing.Size(121, 21);
            this.ctCardNumber.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "姓名*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "卡号*";
            // 
            // ctPinYin
            // 
            this.ctPinYin.Location = new System.Drawing.Point(454, 6);
            this.ctPinYin.Name = "ctPinYin";
            this.ctPinYin.Size = new System.Drawing.Size(121, 21);
            this.ctPinYin.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "简拼";
            // 
            // ctPassword
            // 
            this.ctPassword.Location = new System.Drawing.Point(67, 114);
            this.ctPassword.Name = "ctPassword";
            this.ctPassword.Size = new System.Drawing.Size(121, 21);
            this.ctPassword.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "密码";
            // 
            // ctBirth
            // 
            this.ctBirth.CustomFormat = "";
            this.ctBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctBirth.Location = new System.Drawing.Point(259, 33);
            this.ctBirth.Name = "ctBirth";
            this.ctBirth.ShowUpDown = true;
            this.ctBirth.Size = new System.Drawing.Size(121, 21);
            this.ctBirth.TabIndex = 42;
            this.ctBirth.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "生日";
            // 
            // ctMobile
            // 
            this.ctMobile.Location = new System.Drawing.Point(454, 33);
            this.ctMobile.Name = "ctMobile";
            this.ctMobile.Size = new System.Drawing.Size(121, 21);
            this.ctMobile.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "手机*";
            // 
            // ctPhone
            // 
            this.ctPhone.Location = new System.Drawing.Point(67, 60);
            this.ctPhone.Name = "ctPhone";
            this.ctPhone.Size = new System.Drawing.Size(121, 21);
            this.ctPhone.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "电话";
            // 
            // ctDiscountRate
            // 
            this.ctDiscountRate.DecimalPlaces = 2;
            this.ctDiscountRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctDiscountRate.Location = new System.Drawing.Point(259, 60);
            this.ctDiscountRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctDiscountRate.Name = "ctDiscountRate";
            this.ctDiscountRate.Size = new System.Drawing.Size(121, 21);
            this.ctDiscountRate.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "折扣率";
            // 
            // ctRemainingSum
            // 
            this.ctRemainingSum.DecimalPlaces = 2;
            this.ctRemainingSum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctRemainingSum.Location = new System.Drawing.Point(454, 61);
            this.ctRemainingSum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctRemainingSum.Name = "ctRemainingSum";
            this.ctRemainingSum.Size = new System.Drawing.Size(121, 21);
            this.ctRemainingSum.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 49;
            this.label10.Text = "会员余额";
            // 
            // ctTotalBonusPoint
            // 
            this.ctTotalBonusPoint.Location = new System.Drawing.Point(67, 87);
            this.ctTotalBonusPoint.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctTotalBonusPoint.Name = "ctTotalBonusPoint";
            this.ctTotalBonusPoint.Size = new System.Drawing.Size(121, 21);
            this.ctTotalBonusPoint.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "会员积分";
            // 
            // ctFrequency
            // 
            this.ctFrequency.Location = new System.Drawing.Point(259, 89);
            this.ctFrequency.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctFrequency.Name = "ctFrequency";
            this.ctFrequency.Size = new System.Drawing.Size(121, 21);
            this.ctFrequency.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 53;
            this.label12.Text = "消费次数";
            // 
            // ctTotalSpending
            // 
            this.ctTotalSpending.DecimalPlaces = 2;
            this.ctTotalSpending.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ctTotalSpending.Location = new System.Drawing.Point(454, 88);
            this.ctTotalSpending.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctTotalSpending.Name = "ctTotalSpending";
            this.ctTotalSpending.Size = new System.Drawing.Size(121, 21);
            this.ctTotalSpending.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 55;
            this.label14.Text = "消费总额";
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(67, 141);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(508, 65);
            this.ctRemark.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 57;
            this.label19.Text = "备注";
            // 
            // ctJoinedDate
            // 
            this.ctJoinedDate.CustomFormat = "";
            this.ctJoinedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctJoinedDate.Location = new System.Drawing.Point(67, 33);
            this.ctJoinedDate.Name = "ctJoinedDate";
            this.ctJoinedDate.ShowUpDown = true;
            this.ctJoinedDate.Size = new System.Drawing.Size(121, 21);
            this.ctJoinedDate.TabIndex = 39;
            this.ctJoinedDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 59;
            this.label4.Text = "开卡日期";
            // 
            // FrmBaseInfoMemberEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(606, 299);
            this.Name = "FrmBaseInfoMemberEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRemainingSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTotalBonusPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTotalSpending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctMemberName;
        private System.Windows.Forms.TextBox ctCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctPinYin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ctBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ctMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ctDiscountRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ctRemainingSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ctTotalBonusPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ctFrequency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ctTotalSpending;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker ctJoinedDate;
        private System.Windows.Forms.Label label4;
    }
}
