namespace ChildCafe
{
    partial class FrmACLModuleEdit
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label parentIDLabel;
            System.Windows.Forms.Label chineseNameLabel;
            System.Windows.Forms.Label nStateLabel;
            System.Windows.Forms.Label SequenceLabel;
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctParentId = new System.Windows.Forms.ComboBox();
            this.ctChineseName = new System.Windows.Forms.TextBox();
            this.ctStatus = new System.Windows.Forms.TextBox();
            this.ctSequence = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            parentIDLabel = new System.Windows.Forms.Label();
            chineseNameLabel = new System.Windows.Forms.Label();
            nStateLabel = new System.Windows.Forms.Label();
            SequenceLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(SequenceLabel);
            this.tabPage1.Controls.Add(this.ctSequence);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(parentIDLabel);
            this.tabPage1.Controls.Add(this.ctParentId);
            this.tabPage1.Controls.Add(chineseNameLabel);
            this.tabPage1.Controls.Add(this.ctChineseName);
            this.tabPage1.Controls.Add(nStateLabel);
            this.tabPage1.Controls.Add(this.ctStatus);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(59, 12);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "菜单名称:";
            // 
            // parentIDLabel
            // 
            parentIDLabel.AutoSize = true;
            parentIDLabel.Location = new System.Drawing.Point(22, 83);
            parentIDLabel.Name = "parentIDLabel";
            parentIDLabel.Size = new System.Drawing.Size(47, 12);
            parentIDLabel.TabIndex = 22;
            parentIDLabel.Text = "父菜单:";
            // 
            // chineseNameLabel
            // 
            chineseNameLabel.AutoSize = true;
            chineseNameLabel.Location = new System.Drawing.Point(22, 109);
            chineseNameLabel.Name = "chineseNameLabel";
            chineseNameLabel.Size = new System.Drawing.Size(59, 12);
            chineseNameLabel.TabIndex = 24;
            chineseNameLabel.Text = "中文名称:";
            // 
            // nStateLabel
            // 
            nStateLabel.AutoSize = true;
            nStateLabel.Location = new System.Drawing.Point(22, 136);
            nStateLabel.Name = "nStateLabel";
            nStateLabel.Size = new System.Drawing.Size(35, 12);
            nStateLabel.TabIndex = 27;
            nStateLabel.Text = "状态:";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(105, 53);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(100, 21);
            this.ctName.TabIndex = 21;
            // 
            // ctParentId
            // 
            this.ctParentId.FormattingEnabled = true;
            this.ctParentId.Location = new System.Drawing.Point(105, 80);
            this.ctParentId.Name = "ctParentId";
            this.ctParentId.Size = new System.Drawing.Size(100, 20);
            this.ctParentId.TabIndex = 23;
            // 
            // ctChineseName
            // 
            this.ctChineseName.Location = new System.Drawing.Point(105, 106);
            this.ctChineseName.Name = "ctChineseName";
            this.ctChineseName.Size = new System.Drawing.Size(100, 21);
            this.ctChineseName.TabIndex = 25;
            // 
            // ctStatus
            // 
            this.ctStatus.Location = new System.Drawing.Point(105, 133);
            this.ctStatus.Name = "ctStatus";
            this.ctStatus.Size = new System.Drawing.Size(100, 21);
            this.ctStatus.TabIndex = 28;
            this.ctStatus.Text = "0";
            // 
            // SequenceLabel
            // 
            SequenceLabel.AutoSize = true;
            SequenceLabel.Location = new System.Drawing.Point(22, 163);
            SequenceLabel.Name = "SequenceLabel";
            SequenceLabel.Size = new System.Drawing.Size(35, 12);
            SequenceLabel.TabIndex = 29;
            SequenceLabel.Text = "顺序:";
            // 
            // ctSequence
            // 
            this.ctSequence.Location = new System.Drawing.Point(105, 160);
            this.ctSequence.Name = "ctSequence";
            this.ctSequence.Size = new System.Drawing.Size(100, 21);
            this.ctSequence.TabIndex = 30;
            this.ctSequence.Text = "0";
            // 
            // FrmACLModuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Name = "FrmACLModuleEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.ComboBox ctParentId;
        private System.Windows.Forms.TextBox ctChineseName;
        private System.Windows.Forms.TextBox ctStatus;
        private System.Windows.Forms.TextBox ctSequence;
    }
}
