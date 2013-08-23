namespace XSolo.BaseForm
{
    partial class FrmBUserManagement
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
            this.tvEmployee = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvEmployee
            // 
            this.tvEmployee.AllowDrop = true;
            this.tvEmployee.Location = new System.Drawing.Point(12, 26);
            this.tvEmployee.Name = "tvEmployee";
            this.tvEmployee.Size = new System.Drawing.Size(191, 208);
            this.tvEmployee.TabIndex = 0;
            this.tvEmployee.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvEmployee_DragDrop);
            this.tvEmployee.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvEmployee_DragEnter);
            this.tvEmployee.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvEmployee_ItemDrag);
            // 
            // FrmBUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.tvEmployee);
            this.Name = "FrmBUserManagement";
            this.Text = "用户管理";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView tvEmployee;


    }
}