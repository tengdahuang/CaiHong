namespace HSEMS
{
    partial class FrmEquipmentClassifiedStatistic
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
            this.ctChoose = new System.Windows.Forms.ComboBox();
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
            this.panelFind.Controls.Add(this.ctChoose);
            this.panelFind.Controls.SetChildIndex(this.ctChoose, 0);
            this.panelFind.Controls.SetChildIndex(this.tbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btnFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btDisplayAll, 0);
            this.panelFind.Controls.SetChildIndex(this.lbFind, 0);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(418, 3);
            this.tbFind.Visible = false;
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(601, 2);
            this.btDisplayAll.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(522, 2);
            this.btnFind.Visible = false;
            // 
            // ctChoose
            // 
            this.ctChoose.FormattingEnabled = true;
            this.ctChoose.Items.AddRange(new object[] {
            "分类统计-维修-班组",
            "分类统计-维修-个人",
            "分类统计-测试系统-月份",
            "分类统计-测试系统-测试系统",
            "分类统计-测试系统-故障分类",
            "分类统计-机械手-月份",
            "分类统计-机械手-机台号",
            "分类统计-机械手-故障分类"});
            this.ctChoose.Location = new System.Drawing.Point(12, 3);
            this.ctChoose.Name = "ctChoose";
            this.ctChoose.Size = new System.Drawing.Size(201, 20);
            this.ctChoose.TabIndex = 7;
            this.ctChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmEquipmentClassifiedStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Name = "FrmEquipmentClassifiedStatistic";
            this.Load += new System.EventHandler(this.FrmEquipmentClassifiedStatistic_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctChoose;
    }
}
