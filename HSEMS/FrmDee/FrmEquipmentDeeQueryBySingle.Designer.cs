namespace HSEMS
{
    partial class FrmEquipmentDeeQueryBySingle
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTreeView
            // 
            this.baseTreeView.LineColor = System.Drawing.Color.Black;
            // 
            // splitContainer1
            // 
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.tbMonth);
            this.panelFind.Controls.Add(this.tbYear);
            this.panelFind.Controls.SetChildIndex(this.tbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btnFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btDisplayAll, 0);
            this.panelFind.Controls.SetChildIndex(this.lbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.tbYear, 0);
            this.panelFind.Controls.SetChildIndex(this.tbMonth, 0);
            this.panelFind.Controls.SetChildIndex(this.label1, 0);
            this.panelFind.Controls.SetChildIndex(this.label2, 0);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(443, 4);
            this.tbFind.Visible = false;
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(362, 3);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(179, 2);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(12, 4);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(59, 21);
            this.tbYear.TabIndex = 1;
            this.tbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYear_KeyDown);
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(100, 4);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(50, 21);
            this.tbMonth.TabIndex = 2;
            this.tbMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMonth_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "月";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "年";
            // 
            // FrmEquipmentDeeQueryBySingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Name = "FrmEquipmentDeeQueryBySingle";
            this.Load += new System.EventHandler(this.FrmEquipmentDeeQueryBySingle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbYear;
    }
}
