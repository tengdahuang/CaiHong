namespace HSEMS
{
    partial class FrmMainDictTypeEdit
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
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctOptrType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctOptrType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(99, 26);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 2;
            // 
            // ctOptrType
            // 
            this.ctOptrType.FormattingEnabled = true;
            this.ctOptrType.Location = new System.Drawing.Point(99, 69);
            this.ctOptrType.Name = "ctOptrType";
            this.ctOptrType.Size = new System.Drawing.Size(121, 20);
            this.ctOptrType.TabIndex = 4;
            this.ctOptrType.Click += new System.EventHandler(this.ctOptrType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "类别";
            // 
            // FrmMainDictTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmMainDictTypeEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctOptrType;
        private System.Windows.Forms.Label label4;

    }
}
