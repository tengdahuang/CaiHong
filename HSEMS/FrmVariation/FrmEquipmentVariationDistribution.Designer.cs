namespace HSEMS
{
    partial class FrmEquipmentVariationDistribution
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
            this.ctDistributor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctDistributeDate = new System.Windows.Forms.DateTimePicker();
            this.ctEquipmentNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctVariationType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctVariationReason = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctBeforeVariation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctAfterVariation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(432, 231);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctAfterVariation);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctBeforeVariation);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ctVariationReason);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctVariationType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctDistributor);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctProcess);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctDistributeDate);
            this.tabPage1.Controls.Add(this.ctEquipmentNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Size = new System.Drawing.Size(424, 205);
            // 
            // ctDistributor
            // 
            this.ctDistributor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctDistributor.FormattingEnabled = true;
            this.ctDistributor.Location = new System.Drawing.Point(268, 120);
            this.ctDistributor.Name = "ctDistributor";
            this.ctDistributor.Size = new System.Drawing.Size(121, 20);
            this.ctDistributor.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 55;
            this.label10.Text = "安排人";
            // 
            // ctProcess
            // 
            this.ctProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctProcess.FormattingEnabled = true;
            this.ctProcess.Location = new System.Drawing.Point(77, 14);
            this.ctProcess.Name = "ctProcess";
            this.ctProcess.Size = new System.Drawing.Size(121, 20);
            this.ctProcess.TabIndex = 0;
            this.ctProcess.SelectedIndexChanged += new System.EventHandler(this.ctProcess_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "工序";
            // 
            // ctDistributeDate
            // 
            this.ctDistributeDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ctDistributeDate.Enabled = false;
            this.ctDistributeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDistributeDate.Location = new System.Drawing.Point(77, 119);
            this.ctDistributeDate.Name = "ctDistributeDate";
            this.ctDistributeDate.ShowUpDown = true;
            this.ctDistributeDate.Size = new System.Drawing.Size(138, 21);
            this.ctDistributeDate.TabIndex = 6;
            // 
            // ctEquipmentNo
            // 
            this.ctEquipmentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctEquipmentNo.FormattingEnabled = true;
            this.ctEquipmentNo.Location = new System.Drawing.Point(268, 14);
            this.ctEquipmentNo.Name = "ctEquipmentNo";
            this.ctEquipmentNo.Size = new System.Drawing.Size(121, 20);
            this.ctEquipmentNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "安排时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "机台号";
            // 
            // ctVariationType
            // 
            this.ctVariationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctVariationType.FormattingEnabled = true;
            this.ctVariationType.Location = new System.Drawing.Point(77, 40);
            this.ctVariationType.Name = "ctVariationType";
            this.ctVariationType.Size = new System.Drawing.Size(121, 20);
            this.ctVariationType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "变更类别";
            // 
            // ctVariationReason
            // 
            this.ctVariationReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctVariationReason.FormattingEnabled = true;
            this.ctVariationReason.Location = new System.Drawing.Point(268, 40);
            this.ctVariationReason.Name = "ctVariationReason";
            this.ctVariationReason.Size = new System.Drawing.Size(121, 20);
            this.ctVariationReason.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 59;
            this.label4.Text = "变更原因";
            // 
            // ctBeforeVariation
            // 
            this.ctBeforeVariation.Location = new System.Drawing.Point(77, 66);
            this.ctBeforeVariation.Multiline = true;
            this.ctBeforeVariation.Name = "ctBeforeVariation";
            this.ctBeforeVariation.Size = new System.Drawing.Size(312, 21);
            this.ctBeforeVariation.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 61;
            this.label8.Text = "变更前";
            // 
            // ctAfterVariation
            // 
            this.ctAfterVariation.Location = new System.Drawing.Point(77, 93);
            this.ctAfterVariation.Multiline = true;
            this.ctAfterVariation.Name = "ctAfterVariation";
            this.ctAfterVariation.Size = new System.Drawing.Size(312, 21);
            this.ctAfterVariation.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "变更后";
            // 
            // FrmEquipmentVariationDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(432, 266);
            this.Name = "FrmEquipmentVariationDistribution";
            this.Load += new System.EventHandler(this.FrmEquipmentVariationDistribution_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctDistributor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ctProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ctDistributeDate;
        private System.Windows.Forms.ComboBox ctEquipmentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ctVariationReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctVariationType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctAfterVariation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctBeforeVariation;
        private System.Windows.Forms.Label label8;
    }
}
