namespace HSEMS
{
    partial class FrmEquipmentOfflineApply
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
            this.label2 = new System.Windows.Forms.Label();
            this.ctEquipmentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctOfflineReason = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ctWhoApplied = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctOfflineDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ctEquipmentNo = new System.Windows.Forms.ComboBox();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(422, 218);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctRemark);
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
            this.tabPage1.Size = new System.Drawing.Size(414, 193);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "机台号";
            // 
            // ctEquipmentType
            // 
            this.ctEquipmentType.FormattingEnabled = true;
            this.ctEquipmentType.Location = new System.Drawing.Point(272, 18);
            this.ctEquipmentType.Name = "ctEquipmentType";
            this.ctEquipmentType.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "设备分类";
            // 
            // ctOfflineReason
            // 
            this.ctOfflineReason.Location = new System.Drawing.Point(66, 44);
            this.ctOfflineReason.Multiline = true;
            this.ctOfflineReason.Name = "ctOfflineReason";
            this.ctOfflineReason.Size = new System.Drawing.Size(327, 45);
            this.ctOfflineReason.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "离线原因";
            // 
            // ctWhoApplied
            // 
            this.ctWhoApplied.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctWhoApplied.FormattingEnabled = true;
            this.ctWhoApplied.Location = new System.Drawing.Point(272, 96);
            this.ctWhoApplied.Name = "ctWhoApplied";
            this.ctWhoApplied.Size = new System.Drawing.Size(121, 20);
            this.ctWhoApplied.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 51;
            this.label10.Text = "提交人";
            // 
            // ctOfflineDate
            // 
            this.ctOfflineDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ctOfflineDate.Enabled = false;
            this.ctOfflineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctOfflineDate.Location = new System.Drawing.Point(66, 95);
            this.ctOfflineDate.Name = "ctOfflineDate";
            this.ctOfflineDate.ShowUpDown = true;
            this.ctOfflineDate.Size = new System.Drawing.Size(138, 21);
            this.ctOfflineDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "提交日期";
            // 
            // ctEquipmentNo
            // 
            this.ctEquipmentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctEquipmentNo.FormattingEnabled = true;
            this.ctEquipmentNo.Location = new System.Drawing.Point(66, 18);
            this.ctEquipmentNo.Name = "ctEquipmentNo";
            this.ctEquipmentNo.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentNo.TabIndex = 0;
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(66, 122);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(327, 45);
            this.ctRemark.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "备注";
            // 
            // FrmEquipmentOfflineApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Name = "FrmEquipmentOfflineApply";
            this.Load += new System.EventHandler(this.FrmEquipmentOfflineApply_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctOfflineReason;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ctWhoApplied;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ctOfflineDate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ctEquipmentType;
        private System.Windows.Forms.ComboBox ctEquipmentNo;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label4;
    }
}
