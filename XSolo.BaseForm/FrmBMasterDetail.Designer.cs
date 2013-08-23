namespace XSolo.BaseForm
{
    partial class FrmBMasterDetail
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddNewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefeshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExporttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewToolStripButton,
            this.EditToolStripButton,
            this.DeleteToolStripButton,
            this.RefeshToolStripButton,
            this.ExporttoolStripButton,
            this.toolStripButton6,
            this.CloseToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddNewToolStripButton
            // 
            this.AddNewToolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.note_add;
            this.AddNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddNewToolStripButton.Name = "AddNewToolStripButton";
            this.AddNewToolStripButton.Size = new System.Drawing.Size(51, 32);
            this.AddNewToolStripButton.Tag = "新增";
            this.AddNewToolStripButton.Text = "新增(&A)";
            this.AddNewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.note_edit;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(51, 32);
            this.EditToolStripButton.Tag = "编辑";
            this.EditToolStripButton.Text = "编辑(&E)";
            this.EditToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.note_remove;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(51, 32);
            this.DeleteToolStripButton.Tag = "删除";
            this.DeleteToolStripButton.Text = "删除(&D)";
            this.DeleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RefeshToolStripButton
            // 
            this.RefeshToolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.refresh;
            this.RefeshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefeshToolStripButton.Name = "RefeshToolStripButton";
            this.RefeshToolStripButton.Size = new System.Drawing.Size(51, 32);
            this.RefeshToolStripButton.Text = "刷新(&R)";
            this.RefeshToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ExporttoolStripButton
            // 
            this.ExporttoolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.export;
            this.ExporttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExporttoolStripButton.Name = "ExporttoolStripButton";
            this.ExporttoolStripButton.Size = new System.Drawing.Size(51, 32);
            this.ExporttoolStripButton.Text = "导出(&I)";
            this.ExporttoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::XSolo.BaseForm.Properties.Resources.Print;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(51, 32);
            this.toolStripButton6.Text = "打印(&P)";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CloseToolStripButton
            // 
            this.CloseToolStripButton.Image = global::XSolo.BaseForm.Properties.Resources.up;
            this.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStripButton.Name = "CloseToolStripButton";
            this.CloseToolStripButton.Size = new System.Drawing.Size(51, 32);
            this.CloseToolStripButton.Text = "关闭(&X)";
            this.CloseToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // FrmBMasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 446);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBMasterDetail";
            this.Text = "FrmBMasterDetail";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton AddNewToolStripButton;
        protected System.Windows.Forms.ToolStripButton EditToolStripButton;
        protected System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        protected System.Windows.Forms.ToolStripButton RefeshToolStripButton;
        private System.Windows.Forms.ToolStripButton ExporttoolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton CloseToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;

    }
}