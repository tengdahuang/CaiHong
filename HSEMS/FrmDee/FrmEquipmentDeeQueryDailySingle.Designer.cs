namespace HSEMS
{
    partial class FrmEquipmentDeeQueryDailySingle
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
            this.ctEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ctBegin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panelFind.Controls.Add(this.ctEnd);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.ctBegin);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.SetChildIndex(this.tbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btnFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btDisplayAll, 0);
            this.panelFind.Controls.SetChildIndex(this.lbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.label5, 0);
            this.panelFind.Controls.SetChildIndex(this.ctBegin, 0);
            this.panelFind.Controls.SetChildIndex(this.label1, 0);
            this.panelFind.Controls.SetChildIndex(this.ctEnd, 0);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(297, 3);
            //this.tbFind.Click += new System.EventHandler(this.tbFind_Click);
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(480, 2);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(401, 2);
            // 
            // ctEnd
            // 
            this.ctEnd.CustomFormat = "yyyy-MM-DD";
            this.ctEnd.Location = new System.Drawing.Point(203, 3);
            this.ctEnd.Name = "ctEnd";
            this.ctEnd.Size = new System.Drawing.Size(88, 21);
            this.ctEnd.TabIndex = 115;
            this.ctEnd.Value = new System.DateTime(2012, 8, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "结束日期";
            // 
            // ctBegin
            // 
            this.ctBegin.CustomFormat = "yyyy-MM-DD";
            this.ctBegin.Location = new System.Drawing.Point(55, 3);
            this.ctBegin.Name = "ctBegin";
            this.ctBegin.Size = new System.Drawing.Size(87, 21);
            this.ctBegin.TabIndex = 113;
            this.ctBegin.Value = new System.DateTime(2012, 8, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 112;
            this.label5.Text = "开始日期";
            // 
            // FrmEquipmentDeeQueryDailySingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Name = "FrmEquipmentDeeQueryDailySingle";
            this.Load += new System.EventHandler(this.FrmEquipmentDeeQueryDailySingle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ctEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ctBegin;
        private System.Windows.Forms.Label label5;
    }
}
