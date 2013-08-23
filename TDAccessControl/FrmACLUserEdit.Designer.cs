namespace TDAccessControl
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
            this.ctPassword = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctDescription);
            this.tabPage1.Controls.Add(this.ctPassword);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注：";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(75, 7);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 3;
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
            // ctPassword
            // 
            this.ctPassword.Location = new System.Drawing.Point(75, 34);
            this.ctPassword.Name = "ctPassword";
            this.ctPassword.Size = new System.Drawing.Size(100, 21);
            this.ctPassword.TabIndex = 4;
            // 
            // FrmACLUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmACLUserEdit";
            this.Text = "用户";
            this.Load += new System.EventHandler(this.FrmACLUserEdit_Load);
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
        private System.Windows.Forms.TextBox ctPassword;
    }
}
