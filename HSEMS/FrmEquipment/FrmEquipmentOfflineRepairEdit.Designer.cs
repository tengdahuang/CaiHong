namespace HSEMS
{
    partial class FrmEquipmentOfflineRepairEdit
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
            this.ctEquipmentNo = new System.Windows.Forms.ComboBox();
            this.ctWhoApplied = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctOfflineDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ctOfflineReason = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ctEquipmentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctOfflineRepairRecord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctOfflineResultConfirm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctOfflineWhoRepaired = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctOfflineRepairDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(442, 328);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ctOfflineWhoRepaired);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctOfflineRepairDate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ctOfflineResultConfirm);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctOfflineRepairRecord);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctEquipmentNo);
            this.tabPage1.Controls.Add(this.ctWhoApplied);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctOfflineDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ctOfflineReason);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.ctEquipmentType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(434, 303);
            // 
            // ctEquipmentNo
            // 
            this.ctEquipmentNo.Enabled = false;
            this.ctEquipmentNo.FormattingEnabled = true;
            this.ctEquipmentNo.Location = new System.Drawing.Point(78, 17);
            this.ctEquipmentNo.Name = "ctEquipmentNo";
            this.ctEquipmentNo.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentNo.TabIndex = 52;
            // 
            // ctWhoApplied
            // 
            this.ctWhoApplied.Enabled = false;
            this.ctWhoApplied.FormattingEnabled = true;
            this.ctWhoApplied.Location = new System.Drawing.Point(284, 95);
            this.ctWhoApplied.Name = "ctWhoApplied";
            this.ctWhoApplied.Size = new System.Drawing.Size(121, 20);
            this.ctWhoApplied.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 61;
            this.label10.Text = "提交人";
            // 
            // ctOfflineDate
            // 
            this.ctOfflineDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ctOfflineDate.Enabled = false;
            this.ctOfflineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctOfflineDate.Location = new System.Drawing.Point(78, 94);
            this.ctOfflineDate.Name = "ctOfflineDate";
            this.ctOfflineDate.ShowUpDown = true;
            this.ctOfflineDate.Size = new System.Drawing.Size(138, 21);
            this.ctOfflineDate.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "提交日期";
            // 
            // ctOfflineReason
            // 
            this.ctOfflineReason.Enabled = false;
            this.ctOfflineReason.Location = new System.Drawing.Point(78, 43);
            this.ctOfflineReason.Multiline = true;
            this.ctOfflineReason.Name = "ctOfflineReason";
            this.ctOfflineReason.Size = new System.Drawing.Size(327, 45);
            this.ctOfflineReason.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 59;
            this.label15.Text = "离线原因";
            // 
            // ctEquipmentType
            // 
            this.ctEquipmentType.Enabled = false;
            this.ctEquipmentType.FormattingEnabled = true;
            this.ctEquipmentType.Location = new System.Drawing.Point(284, 17);
            this.ctEquipmentType.Name = "ctEquipmentType";
            this.ctEquipmentType.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "设备分类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 57;
            this.label2.Text = "机台号";
            // 
            // ctOfflineRepairRecord
            // 
            this.ctOfflineRepairRecord.Location = new System.Drawing.Point(78, 121);
            this.ctOfflineRepairRecord.Multiline = true;
            this.ctOfflineRepairRecord.Name = "ctOfflineRepairRecord";
            this.ctOfflineRepairRecord.Size = new System.Drawing.Size(327, 45);
            this.ctOfflineRepairRecord.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 63;
            this.label4.Text = "维修记录";
            // 
            // ctOfflineResultConfirm
            // 
            this.ctOfflineResultConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctOfflineResultConfirm.FormattingEnabled = true;
            this.ctOfflineResultConfirm.Location = new System.Drawing.Point(78, 172);
            this.ctOfflineResultConfirm.Name = "ctOfflineResultConfirm";
            this.ctOfflineResultConfirm.Size = new System.Drawing.Size(121, 20);
            this.ctOfflineResultConfirm.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 65;
            this.label5.Text = "效果确认";
            // 
            // ctOfflineWhoRepaired
            // 
            this.ctOfflineWhoRepaired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctOfflineWhoRepaired.FormattingEnabled = true;
            this.ctOfflineWhoRepaired.Location = new System.Drawing.Point(284, 199);
            this.ctOfflineWhoRepaired.Name = "ctOfflineWhoRepaired";
            this.ctOfflineWhoRepaired.Size = new System.Drawing.Size(121, 20);
            this.ctOfflineWhoRepaired.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 69;
            this.label6.Text = "修复人";
            // 
            // ctOfflineRepairDate
            // 
            this.ctOfflineRepairDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ctOfflineRepairDate.Enabled = false;
            this.ctOfflineRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctOfflineRepairDate.Location = new System.Drawing.Point(78, 198);
            this.ctOfflineRepairDate.Name = "ctOfflineRepairDate";
            this.ctOfflineRepairDate.ShowUpDown = true;
            this.ctOfflineRepairDate.Size = new System.Drawing.Size(138, 21);
            this.ctOfflineRepairDate.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "修复日期";
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(78, 225);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(327, 45);
            this.ctRemark.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "备注";
            // 
            // FrmEquipmentOfflineRepairEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(442, 363);
            this.Name = "FrmEquipmentOfflineRepairEdit";
            this.Load += new System.EventHandler(this.FrmEquipmentOfflineRepairEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctEquipmentNo;
        private System.Windows.Forms.ComboBox ctWhoApplied;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ctOfflineDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctOfflineReason;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox ctEquipmentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctOfflineRepairRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctOfflineResultConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ctOfflineWhoRepaired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ctOfflineRepairDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label8;
    }
}
