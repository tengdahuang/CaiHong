namespace TDAccessControl
{
    partial class FrmLogin
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
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbUser
            // 
            this.cbUser.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Name = "FrmLogin";
            this.Text = "权限管理-用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
