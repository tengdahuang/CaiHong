namespace XSolo.ModuleActions
{
    partial class FrmACLActionEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctChineseName = new System.Windows.Forms.TextBox();
            this.ctImageOrder = new System.Windows.Forms.TextBox();
            this.ctShortCut = new System.Windows.Forms.TextBox();
            this.ctStatus = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctStatus);
            this.tabPage1.Controls.Add(this.ctShortCut);
            this.tabPage1.Controls.Add(this.ctImageOrder);
            this.tabPage1.Controls.Add(this.ctChineseName);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "中文名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图片顺序";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "快捷方式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "状态";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(153, 24);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 5;
            // 
            // ctChineseName
            // 
            this.ctChineseName.Location = new System.Drawing.Point(153, 48);
            this.ctChineseName.Name = "ctChineseName";
            this.ctChineseName.Size = new System.Drawing.Size(100, 21);
            this.ctChineseName.TabIndex = 6;
            // 
            // ctImageOrder
            // 
            this.ctImageOrder.Location = new System.Drawing.Point(153, 76);
            this.ctImageOrder.Name = "ctImageOrder";
            this.ctImageOrder.Size = new System.Drawing.Size(100, 21);
            this.ctImageOrder.TabIndex = 7;
            // 
            // ctShortCut
            // 
            this.ctShortCut.Location = new System.Drawing.Point(153, 103);
            this.ctShortCut.Name = "ctShortCut";
            this.ctShortCut.Size = new System.Drawing.Size(100, 21);
            this.ctShortCut.TabIndex = 8;
            // 
            // ctStatus
            // 
            this.ctStatus.Location = new System.Drawing.Point(153, 130);
            this.ctStatus.Name = "ctStatus";
            this.ctStatus.Size = new System.Drawing.Size(100, 21);
            this.ctStatus.TabIndex = 9;
            // 
            // FrmACLActionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmACLActionEdit";
            this.Load += new System.EventHandler(this.FrmACLActionEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctStatus;
        private System.Windows.Forms.TextBox ctShortCut;
        private System.Windows.Forms.TextBox ctImageOrder;
        private System.Windows.Forms.TextBox ctChineseName;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
