namespace HSEMS
{
    partial class FrmTechnologicalEquipmentQuery
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
            this.ctChange = new System.Windows.Forms.ComboBox();
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
            this.panelFind.Controls.Add(this.ctChange);
            this.panelFind.Controls.SetChildIndex(this.ctChange, 0);
            this.panelFind.Controls.SetChildIndex(this.tbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btnFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btDisplayAll, 0);
            this.panelFind.Controls.SetChildIndex(this.lbFind, 0);
            // 
            // ctChange
            // 
            this.ctChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctChange.FormattingEnabled = true;
            this.ctChange.Items.AddRange(new object[] {
            "在用",
            "报废"});
            this.ctChange.Location = new System.Drawing.Point(272, 4);
            this.ctChange.Name = "ctChange";
            this.ctChange.Size = new System.Drawing.Size(121, 20);
            this.ctChange.TabIndex = 7;
            this.ctChange.SelectedIndexChanged += new System.EventHandler(this.ctChange_SelectedIndexChanged);
            // 
            // FrmTechnologicalEquipmentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Name = "FrmTechnologicalEquipmentQuery";
            this.Load += new System.EventHandler(this.FrmTechnologicalEquipmentQuery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctChange;
    }
}
