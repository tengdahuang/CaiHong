namespace ChildCafe
{
    partial class FrmBaseInfoMemberRechargeEdit
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
            this.ctRechargeDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctRemainingSum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctPayValue = new XSolo.ExtendedControls.NumericUpDownEx();
            this.ctRechargeValue = new XSolo.ExtendedControls.NumericUpDownEx();
            this.ctDescription = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRemainingSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRechargeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(258, 333);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctDescription);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ctRechargeValue);
            this.tabPage1.Controls.Add(this.ctPayValue);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctRemainingSum);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctSerialNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.ctCardNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctRechargeDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Size = new System.Drawing.Size(250, 307);
            // 
            // ctRechargeDate
            // 
            this.ctRechargeDate.CustomFormat = "";
            this.ctRechargeDate.Enabled = false;
            this.ctRechargeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ctRechargeDate.Location = new System.Drawing.Point(92, 79);
            this.ctRechargeDate.Name = "ctRechargeDate";
            this.ctRechargeDate.ShowUpDown = true;
            this.ctRechargeDate.Size = new System.Drawing.Size(121, 21);
            this.ctRechargeDate.TabIndex = 60;
            this.ctRechargeDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "充值日期";
            // 
            // ctName
            // 
            this.ctName.Enabled = false;
            this.ctName.Location = new System.Drawing.Point(92, 52);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(121, 21);
            this.ctName.TabIndex = 65;
            // 
            // ctCardNumber
            // 
            this.ctCardNumber.Enabled = false;
            this.ctCardNumber.Location = new System.Drawing.Point(92, 25);
            this.ctCardNumber.Name = "ctCardNumber";
            this.ctCardNumber.Size = new System.Drawing.Size(121, 21);
            this.ctCardNumber.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "卡号";
            // 
            // ctSerialNumber
            // 
            this.ctSerialNumber.Enabled = false;
            this.ctSerialNumber.Location = new System.Drawing.Point(92, 106);
            this.ctSerialNumber.Name = "ctSerialNumber";
            this.ctSerialNumber.Size = new System.Drawing.Size(121, 21);
            this.ctSerialNumber.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 66;
            this.label1.Text = "流水号";
            // 
            // ctRemainingSum
            // 
            this.ctRemainingSum.DecimalPlaces = 2;
            this.ctRemainingSum.Enabled = false;
            this.ctRemainingSum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctRemainingSum.Location = new System.Drawing.Point(93, 187);
            this.ctRemainingSum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctRemainingSum.Name = "ctRemainingSum";
            this.ctRemainingSum.Size = new System.Drawing.Size(121, 21);
            this.ctRemainingSum.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 68;
            this.label10.Text = "会员余额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 70;
            this.label5.Text = "付款金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "充值金额";
            // 
            // ctPayValue
            // 
            this.ctPayValue.DecimalPlaces = 2;
            this.ctPayValue.Location = new System.Drawing.Point(93, 133);
            this.ctPayValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctPayValue.Name = "ctPayValue";
            this.ctPayValue.Size = new System.Drawing.Size(120, 21);
            this.ctPayValue.TabIndex = 71;
            this.ctPayValue.ValueChanged += new System.EventHandler(this.ctPayValue_ValueChanged);
            // 
            // ctRechargeValue
            // 
            this.ctRechargeValue.DecimalPlaces = 2;
            this.ctRechargeValue.Location = new System.Drawing.Point(93, 160);
            this.ctRechargeValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctRechargeValue.Name = "ctRechargeValue";
            this.ctRechargeValue.Size = new System.Drawing.Size(120, 21);
            this.ctRechargeValue.TabIndex = 74;
            this.ctRechargeValue.ValueChanged += new System.EventHandler(this.ctRechargeValue_ValueChanged);
            // 
            // ctDescription
            // 
            this.ctDescription.Location = new System.Drawing.Point(92, 214);
            this.ctDescription.Multiline = true;
            this.ctDescription.Name = "ctDescription";
            this.ctDescription.Size = new System.Drawing.Size(121, 65);
            this.ctDescription.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 75;
            this.label19.Text = "备注";
            // 
            // FrmBaseInfoMemberRechargeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(258, 368);
            this.Name = "FrmBaseInfoMemberRechargeEdit";
            this.Text = "会员充值";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRemainingSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRechargeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ctRechargeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.TextBox ctCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ctRemainingSum;
        private System.Windows.Forms.Label label10;
        private XSolo.ExtendedControls.NumericUpDownEx ctPayValue;
        private XSolo.ExtendedControls.NumericUpDownEx ctRechargeValue;
        private System.Windows.Forms.TextBox ctDescription;
        private System.Windows.Forms.Label label19;
    }
}
