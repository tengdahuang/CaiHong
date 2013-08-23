namespace HSEMS
{
    partial class FrmEquipmentAllQuery
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
            this.label13 = new System.Windows.Forms.Label();
            this.ctBegin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ctEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ctAccepter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctManageType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctEquipmentNo = new System.Windows.Forms.TextBox();
            this.ctGroupMonitor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctMonitor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTreeView
            // 
            this.baseTreeView.LineColor = System.Drawing.Color.Black;
            this.baseTreeView.Size = new System.Drawing.Size(187, 369);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(745, 369);
            this.splitContainer1.SplitterDistance = 187;
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.ctMonitor);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.ctGroupMonitor);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.ctEquipmentNo);
            this.panelFind.Controls.Add(this.ctManageType);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Controls.Add(this.ctAccepter);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.ctEnd);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Controls.Add(this.ctBegin);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label13);
            this.panelFind.Size = new System.Drawing.Size(745, 56);
            this.panelFind.Controls.SetChildIndex(this.tbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btnFind, 0);
            this.panelFind.Controls.SetChildIndex(this.btDisplayAll, 0);
            this.panelFind.Controls.SetChildIndex(this.lbFind, 0);
            this.panelFind.Controls.SetChildIndex(this.label13, 0);
            this.panelFind.Controls.SetChildIndex(this.label5, 0);
            this.panelFind.Controls.SetChildIndex(this.ctBegin, 0);
            this.panelFind.Controls.SetChildIndex(this.label1, 0);
            this.panelFind.Controls.SetChildIndex(this.ctEnd, 0);
            this.panelFind.Controls.SetChildIndex(this.label2, 0);
            this.panelFind.Controls.SetChildIndex(this.ctAccepter, 0);
            this.panelFind.Controls.SetChildIndex(this.label3, 0);
            this.panelFind.Controls.SetChildIndex(this.ctManageType, 0);
            this.panelFind.Controls.SetChildIndex(this.ctEquipmentNo, 0);
            this.panelFind.Controls.SetChildIndex(this.label6, 0);
            this.panelFind.Controls.SetChildIndex(this.ctGroupMonitor, 0);
            this.panelFind.Controls.SetChildIndex(this.label7, 0);
            this.panelFind.Controls.SetChildIndex(this.ctMonitor, 0);
            // 
            // tbFind
            // 
            this.tbFind.Enabled = false;
            this.tbFind.Location = new System.Drawing.Point(672, 7);
            this.tbFind.Size = new System.Drawing.Size(70, 21);
            this.tbFind.Visible = false;
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(600, 28);
            this.btDisplayAll.Size = new System.Drawing.Size(40, 23);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(554, 28);
            this.btnFind.Size = new System.Drawing.Size(40, 23);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 102;
            this.label13.Text = "机台号";
            // 
            // ctBegin
            // 
            this.ctBegin.CustomFormat = "yyyy-MM-DD";
            this.ctBegin.Location = new System.Drawing.Point(55, 3);
            this.ctBegin.Name = "ctBegin";
            this.ctBegin.Size = new System.Drawing.Size(87, 21);
            this.ctBegin.TabIndex = 105;
            this.ctBegin.Value = new System.DateTime(2012, 8, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 104;
            this.label5.Text = "开始日期";
            // 
            // ctEnd
            // 
            this.ctEnd.CustomFormat = "yyyy-MM-DD";
            this.ctEnd.Location = new System.Drawing.Point(55, 29);
            this.ctEnd.Name = "ctEnd";
            this.ctEnd.Size = new System.Drawing.Size(88, 21);
            this.ctEnd.TabIndex = 107;
            this.ctEnd.Value = new System.DateTime(2012, 8, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 106;
            this.label1.Text = "结束日期";
            // 
            // ctAccepter
            // 
            this.ctAccepter.FormattingEnabled = true;
            this.ctAccepter.Location = new System.Drawing.Point(207, 30);
            this.ctAccepter.Name = "ctAccepter";
            this.ctAccepter.Size = new System.Drawing.Size(59, 20);
            this.ctAccepter.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 108;
            this.label2.Text = "接单人";
            // 
            // ctManageType
            // 
            this.ctManageType.FormattingEnabled = true;
            this.ctManageType.Location = new System.Drawing.Point(331, 4);
            this.ctManageType.Name = "ctManageType";
            this.ctManageType.Size = new System.Drawing.Size(84, 20);
            this.ctManageType.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 110;
            this.label3.Text = "管理分类";
            // 
            // ctEquipmentNo
            // 
            this.ctEquipmentNo.Location = new System.Drawing.Point(207, 4);
            this.ctEquipmentNo.Name = "ctEquipmentNo";
            this.ctEquipmentNo.Size = new System.Drawing.Size(60, 21);
            this.ctEquipmentNo.TabIndex = 112;
            this.ctEquipmentNo.Click += new System.EventHandler(this.ctEquipmentNo_Click);
            // 
            // ctGroupMonitor
            // 
            this.ctGroupMonitor.Enabled = false;
            this.ctGroupMonitor.FormattingEnabled = true;
            this.ctGroupMonitor.Location = new System.Drawing.Point(441, 30);
            this.ctGroupMonitor.Name = "ctGroupMonitor";
            this.ctGroupMonitor.Size = new System.Drawing.Size(59, 20);
            this.ctGroupMonitor.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(406, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 115;
            this.label6.Text = "组长";
            // 
            // ctMonitor
            // 
            this.ctMonitor.FormattingEnabled = true;
            this.ctMonitor.Location = new System.Drawing.Point(331, 30);
            this.ctMonitor.Name = "ctMonitor";
            this.ctMonitor.Size = new System.Drawing.Size(59, 20);
            this.ctMonitor.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 117;
            this.label7.Text = "当班班长";
            // 
            // FrmEquipmentAllQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Name = "FrmEquipmentAllQuery";
            this.Load += new System.EventHandler(this.FrmEquipmentAllQuery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ctManageType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ctAccepter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ctEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ctBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctEquipmentNo;
        private System.Windows.Forms.ComboBox ctMonitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ctGroupMonitor;
        private System.Windows.Forms.Label label6;
    }
}
