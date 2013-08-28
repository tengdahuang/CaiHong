namespace ChildCafe
{
    partial class FrmBaseInfoVendorEdit
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
            this.ctShortCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctQQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctContactPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(402, 206);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ctAddress);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctPhone);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctQQ);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctContactPerson);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctShortCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Size = new System.Drawing.Size(394, 180);
            // 
            // ctShortCode
            // 
            this.ctShortCode.Location = new System.Drawing.Point(257, 6);
            this.ctShortCode.Name = "ctShortCode";
            this.ctShortCode.Size = new System.Drawing.Size(121, 21);
            this.ctShortCode.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "简拼";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(62, 6);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(121, 21);
            this.ctName.TabIndex = 40;
            this.ctName.TextChanged += new System.EventHandler(this.ctName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "供应商名";
            // 
            // ctQQ
            // 
            this.ctQQ.Location = new System.Drawing.Point(257, 33);
            this.ctQQ.Name = "ctQQ";
            this.ctQQ.Size = new System.Drawing.Size(121, 21);
            this.ctQQ.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "QQ";
            // 
            // ctContactPerson
            // 
            this.ctContactPerson.Location = new System.Drawing.Point(62, 33);
            this.ctContactPerson.Name = "ctContactPerson";
            this.ctContactPerson.Size = new System.Drawing.Size(121, 21);
            this.ctContactPerson.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "联系人";
            // 
            // ctAddress
            // 
            this.ctAddress.Location = new System.Drawing.Point(257, 60);
            this.ctAddress.Name = "ctAddress";
            this.ctAddress.Size = new System.Drawing.Size(121, 21);
            this.ctAddress.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 49;
            this.label5.Text = "地址";
            // 
            // ctPhone
            // 
            this.ctPhone.Location = new System.Drawing.Point(62, 60);
            this.ctPhone.Name = "ctPhone";
            this.ctPhone.Size = new System.Drawing.Size(121, 21);
            this.ctPhone.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "电话";
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(62, 87);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(316, 65);
            this.ctRemark.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 61;
            this.label19.Text = "备注";
            // 
            // FrmBaseInfoVendorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(402, 241);
            this.Name = "FrmBaseInfoVendorEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctShortCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctQQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctContactPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label19;
    }
}
