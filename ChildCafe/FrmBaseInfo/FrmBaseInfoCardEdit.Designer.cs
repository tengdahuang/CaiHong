namespace ChildCafe
{
    partial class FrmBaseInfoCardEdit
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
            this.ctChildName = new System.Windows.Forms.TextBox();
            this.ctCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctPinYin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ctMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctCountLeft = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ctJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ctCardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctMemberCardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctPictureDir = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDelPicture = new System.Windows.Forms.Button();
            this.ctPictureFilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCountLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPictureDir)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(584, 266);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctPictureFilePath);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnDelPicture);
            this.tabPage1.Controls.Add(this.btnCapture);
            this.tabPage1.Controls.Add(this.ctPictureDir);
            this.tabPage1.Controls.Add(this.ctMemberCardNumber);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctCardType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctJoinedDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ctCountLeft);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ctMobile);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ctExpirationDate);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ctPinYin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctChildName);
            this.tabPage1.Controls.Add(this.ctCardNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(576, 240);
            // 
            // ctChildName
            // 
            this.ctChildName.Location = new System.Drawing.Point(67, 33);
            this.ctChildName.Name = "ctChildName";
            this.ctChildName.Size = new System.Drawing.Size(121, 21);
            this.ctChildName.TabIndex = 11;
            this.ctChildName.TextChanged += new System.EventHandler(this.ctChildName_TextChanged);
            // 
            // ctCardNumber
            // 
            this.ctCardNumber.Location = new System.Drawing.Point(259, 6);
            this.ctCardNumber.Name = "ctCardNumber";
            this.ctCardNumber.Size = new System.Drawing.Size(121, 21);
            this.ctCardNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "宝宝名*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "卡号*";
            // 
            // ctPinYin
            // 
            this.ctPinYin.Enabled = false;
            this.ctPinYin.Location = new System.Drawing.Point(259, 60);
            this.ctPinYin.Name = "ctPinYin";
            this.ctPinYin.Size = new System.Drawing.Size(121, 21);
            this.ctPinYin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "简拼";
            // 
            // ctExpirationDate
            // 
            this.ctExpirationDate.CustomFormat = "";
            this.ctExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctExpirationDate.Location = new System.Drawing.Point(67, 113);
            this.ctExpirationDate.Name = "ctExpirationDate";
            this.ctExpirationDate.ShowUpDown = true;
            this.ctExpirationDate.Size = new System.Drawing.Size(121, 21);
            this.ctExpirationDate.TabIndex = 35;
            this.ctExpirationDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "到期日";
            // 
            // ctMobile
            // 
            this.ctMobile.Location = new System.Drawing.Point(259, 33);
            this.ctMobile.Name = "ctMobile";
            this.ctMobile.Size = new System.Drawing.Size(121, 21);
            this.ctMobile.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "手机*";
            // 
            // ctCountLeft
            // 
            this.ctCountLeft.Location = new System.Drawing.Point(67, 86);
            this.ctCountLeft.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctCountLeft.Name = "ctCountLeft";
            this.ctCountLeft.Size = new System.Drawing.Size(121, 21);
            this.ctCountLeft.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "剩余次数";
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(67, 154);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(313, 65);
            this.ctRemark.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 57;
            this.label19.Text = "备注";
            // 
            // ctJoinedDate
            // 
            this.ctJoinedDate.CustomFormat = "";
            this.ctJoinedDate.Enabled = false;
            this.ctJoinedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctJoinedDate.Location = new System.Drawing.Point(259, 113);
            this.ctJoinedDate.Name = "ctJoinedDate";
            this.ctJoinedDate.ShowUpDown = true;
            this.ctJoinedDate.Size = new System.Drawing.Size(121, 21);
            this.ctJoinedDate.TabIndex = 41;
            this.ctJoinedDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 59;
            this.label4.Text = "办卡日期";
            // 
            // ctCardType
            // 
            this.ctCardType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctCardType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctCardType.FormattingEnabled = true;
            this.ctCardType.Items.AddRange(new object[] {
            "十次卡",
            "二十次卡",
            "月卡",
            "年卡",
            "暑假卡"});
            this.ctCardType.Location = new System.Drawing.Point(67, 60);
            this.ctCardType.Name = "ctCardType";
            this.ctCardType.Size = new System.Drawing.Size(121, 20);
            this.ctCardType.TabIndex = 25;
            this.ctCardType.SelectedIndexChanged += new System.EventHandler(this.ctCardType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 75;
            this.label5.Text = "卡类型*";
            // 
            // ctMemberCardNumber
            // 
            this.ctMemberCardNumber.Location = new System.Drawing.Point(67, 6);
            this.ctMemberCardNumber.Name = "ctMemberCardNumber";
            this.ctMemberCardNumber.Size = new System.Drawing.Size(121, 21);
            this.ctMemberCardNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 77;
            this.label6.Text = "会员卡号";
            // 
            // ctPictureDir
            // 
            this.ctPictureDir.Location = new System.Drawing.Point(404, 6);
            this.ctPictureDir.Name = "ctPictureDir";
            this.ctPictureDir.Size = new System.Drawing.Size(120, 180);
            this.ctPictureDir.TabIndex = 78;
            this.ctPictureDir.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(386, 192);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 79;
            this.btnCapture.Text = "&Take拍照";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDelPicture
            // 
            this.btnDelPicture.Location = new System.Drawing.Point(467, 192);
            this.btnDelPicture.Name = "btnDelPicture";
            this.btnDelPicture.Size = new System.Drawing.Size(75, 23);
            this.btnDelPicture.TabIndex = 80;
            this.btnDelPicture.Text = "&Del删照";
            this.btnDelPicture.UseVisualStyleBackColor = true;
            // 
            // ctPictureFilePath
            // 
            this.ctPictureFilePath.Location = new System.Drawing.Point(259, 85);
            this.ctPictureFilePath.Name = "ctPictureFilePath";
            this.ctPictureFilePath.Size = new System.Drawing.Size(121, 21);
            this.ctPictureFilePath.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 82;
            this.label8.Text = "保存路径";
            // 
            // FrmBaseInfoCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Name = "FrmBaseInfoCardEdit";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmBaseInfoCardEdit_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCountLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPictureDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctChildName;
        private System.Windows.Forms.TextBox ctCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctPinYin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ctExpirationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ctMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ctCountLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker ctJoinedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctCardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctMemberCardNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ctPictureDir;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDelPicture;
        private System.Windows.Forms.TextBox ctPictureFilePath;
        private System.Windows.Forms.Label label8;
    }
}
