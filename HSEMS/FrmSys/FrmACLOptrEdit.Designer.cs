namespace HSEMS
{
    partial class FrmACLUserEdit
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
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctMainOptrType = new System.Windows.Forms.ComboBox();
            this.cbSavePassword = new System.Windows.Forms.CheckBox();
            this.ctChineseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctPassword = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctPassword);
            this.tabPage1.Controls.Add(this.ctChineseName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbSavePassword);
            this.tabPage1.Controls.Add(this.ctMainOptrType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctDescription);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(75, 7);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 1;
            // 
            // ctDescription
            // 
            this.ctDescription.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ctDescription.Location = new System.Drawing.Point(75, 61);
            this.ctDescription.Multiline = true;
            this.ctDescription.Name = "ctDescription";
            this.ctDescription.Size = new System.Drawing.Size(226, 106);
            this.ctDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "类别";
            // 
            // ctMainOptrType
            // 
            this.ctMainOptrType.FormattingEnabled = true;
            this.ctMainOptrType.Location = new System.Drawing.Point(75, 170);
            this.ctMainOptrType.Name = "ctMainOptrType";
            this.ctMainOptrType.Size = new System.Drawing.Size(121, 20);
            this.ctMainOptrType.TabIndex = 6;
            this.ctMainOptrType.Click += new System.EventHandler(this.ctMainOptrType_Click);
            // 
            // cbSavePassword
            // 
            this.cbSavePassword.AutoSize = true;
            this.cbSavePassword.Location = new System.Drawing.Point(197, 36);
            this.cbSavePassword.Name = "cbSavePassword";
            this.cbSavePassword.Size = new System.Drawing.Size(96, 16);
            this.cbSavePassword.TabIndex = 4;
            this.cbSavePassword.Text = "是否保存密码";
            this.cbSavePassword.UseVisualStyleBackColor = true;
            // 
            // ctChineseName
            // 
            this.ctChineseName.Location = new System.Drawing.Point(254, 7);
            this.ctChineseName.Name = "ctChineseName";
            this.ctChineseName.Size = new System.Drawing.Size(100, 21);
            this.ctChineseName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "中文名(*)：";
            // 
            // ctPassword
            // 
            this.ctPassword.Location = new System.Drawing.Point(75, 34);
            this.ctPassword.Name = "ctPassword";
            this.ctPassword.Size = new System.Drawing.Size(100, 21);
            this.ctPassword.TabIndex = 11;
            this.ctPassword.UseSystemPasswordChar = true;
            // 
            // FrmACLUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmACLUserEdit";
            this.Text = "用户";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctDescription;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctMainOptrType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSavePassword;
        private System.Windows.Forms.TextBox ctChineseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctPassword;
    }
}
