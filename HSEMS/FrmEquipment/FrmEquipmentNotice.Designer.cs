namespace HSEMS
{
    partial class FrmEquipmentNotice
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctEquipmentNo = new System.Windows.Forms.ComboBox();
            this.ctNoticeDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ctManagementType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctProcess = new System.Windows.Forms.ComboBox();
            this.ctTestSystem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctTester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctModeNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctProductClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctLotNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctWhoNotice = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctFailurePhenomenon = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(432, 238);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctFailurePhenomenon);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ctWhoNotice);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctLotNo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ctProductClass);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ctModeNo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ctTester);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctTestSystem);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctProcess);
            this.tabPage1.Controls.Add(this.ctManagementType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctNoticeDate);
            this.tabPage1.Controls.Add(this.ctEquipmentNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Size = new System.Drawing.Size(424, 212);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "机台号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "报修时间";
            // 
            // ctEquipmentNo
            // 
            this.ctEquipmentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctEquipmentNo.FormattingEnabled = true;
            this.ctEquipmentNo.Location = new System.Drawing.Point(69, 74);
            this.ctEquipmentNo.Name = "ctEquipmentNo";
            this.ctEquipmentNo.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentNo.TabIndex = 2;
            this.ctEquipmentNo.SelectedValueChanged += new System.EventHandler(this.ctEquipmentNo_SelectedValueChanged);
            // 
            // ctNoticeDate
            // 
            this.ctNoticeDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ctNoticeDate.Enabled = false;
            this.ctNoticeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctNoticeDate.Location = new System.Drawing.Point(280, 21);
            this.ctNoticeDate.Name = "ctNoticeDate";
            this.ctNoticeDate.ShowUpDown = true;
            this.ctNoticeDate.Size = new System.Drawing.Size(138, 21);
            this.ctNoticeDate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "工序";
            // 
            // ctManagementType
            // 
            this.ctManagementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctManagementType.FormattingEnabled = true;
            this.ctManagementType.Location = new System.Drawing.Point(281, 48);
            this.ctManagementType.Name = "ctManagementType";
            this.ctManagementType.Size = new System.Drawing.Size(121, 20);
            this.ctManagementType.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "管理分类";
            // 
            // ctProcess
            // 
            this.ctProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctProcess.FormattingEnabled = true;
            this.ctProcess.Location = new System.Drawing.Point(69, 22);
            this.ctProcess.Name = "ctProcess";
            this.ctProcess.Size = new System.Drawing.Size(121, 20);
            this.ctProcess.TabIndex = 0;
            this.ctProcess.SelectedIndexChanged += new System.EventHandler(this.ctProcess_SelectedIndexChanged);
            // 
            // ctTestSystem
            // 
            this.ctTestSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctTestSystem.FormattingEnabled = true;
            this.ctTestSystem.Location = new System.Drawing.Point(69, 48);
            this.ctTestSystem.Name = "ctTestSystem";
            this.ctTestSystem.Size = new System.Drawing.Size(121, 20);
            this.ctTestSystem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "测试系统";
            // 
            // ctTester
            // 
            this.ctTester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctTester.FormattingEnabled = true;
            this.ctTester.Location = new System.Drawing.Point(69, 100);
            this.ctTester.Name = "ctTester";
            this.ctTester.Size = new System.Drawing.Size(121, 20);
            this.ctTester.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "测试仪";
            // 
            // ctModeNo
            // 
            this.ctModeNo.FormattingEnabled = true;
            this.ctModeNo.Location = new System.Drawing.Point(69, 126);
            this.ctModeNo.Name = "ctModeNo";
            this.ctModeNo.Size = new System.Drawing.Size(121, 20);
            this.ctModeNo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "模具号";
            // 
            // ctProductClass
            // 
            this.ctProductClass.Location = new System.Drawing.Point(281, 74);
            this.ctProductClass.Name = "ctProductClass";
            this.ctProductClass.Size = new System.Drawing.Size(121, 21);
            this.ctProductClass.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "品种";
            // 
            // ctLotNo
            // 
            this.ctLotNo.Location = new System.Drawing.Point(281, 99);
            this.ctLotNo.Name = "ctLotNo";
            this.ctLotNo.Size = new System.Drawing.Size(121, 21);
            this.ctLotNo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "批号";
            // 
            // ctWhoNotice
            // 
            this.ctWhoNotice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctWhoNotice.FormattingEnabled = true;
            this.ctWhoNotice.Location = new System.Drawing.Point(281, 126);
            this.ctWhoNotice.Name = "ctWhoNotice";
            this.ctWhoNotice.Size = new System.Drawing.Size(121, 20);
            this.ctWhoNotice.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "报修人";
            // 
            // ctFailurePhenomenon
            // 
            this.ctFailurePhenomenon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctFailurePhenomenon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctFailurePhenomenon.FormattingEnabled = true;
            this.ctFailurePhenomenon.Location = new System.Drawing.Point(69, 152);
            this.ctFailurePhenomenon.Name = "ctFailurePhenomenon";
            this.ctFailurePhenomenon.Size = new System.Drawing.Size(333, 20);
            this.ctFailurePhenomenon.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "故障现象";
            // 
            // FrmEquipmentNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(432, 273);
            this.Name = "FrmEquipmentNotice";
            this.Load += new System.EventHandler(this.FrmEquipmentNotice_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctEquipmentNo;
        private System.Windows.Forms.DateTimePicker ctNoticeDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ctManagementType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctProcess;
        private System.Windows.Forms.ComboBox ctTestSystem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ctTester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ctModeNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctProductClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ctLotNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ctWhoNotice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ctFailurePhenomenon;
        private System.Windows.Forms.Label label11;
    }
}
