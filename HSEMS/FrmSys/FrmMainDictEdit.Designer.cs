namespace HSEMS
{
    partial class FrmMainDictEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctDictType = new System.Windows.Forms.ComboBox();
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.ctDictType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注";
            // 
            // ctDictType
            // 
            this.ctDictType.FormattingEnabled = true;
            this.ctDictType.Location = new System.Drawing.Point(98, 41);
            this.ctDictType.Name = "ctDictType";
            this.ctDictType.Size = new System.Drawing.Size(121, 20);
            this.ctDictType.TabIndex = 4;
            this.ctDictType.Click += new System.EventHandler(this.ctDictType_Click);
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(98, 14);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 5;
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(98, 67);
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(100, 21);
            this.ctRemark.TabIndex = 6;
            // 
            // FrmMainDictEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmMainDictEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.ComboBox ctDictType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
