namespace XSolo.BaseForm
{
    partial class FrmBTree
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBTree));
            this.baseDataGridView = new System.Windows.Forms.DataGridView();
            this.baseTreeView = new System.Windows.Forms.TreeView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.baseStatusStrip = new System.Windows.Forms.StatusStrip();
            this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelFind = new System.Windows.Forms.Panel();
            this.lbFind = new System.Windows.Forms.Label();
            this.btDisplayAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.baseToolStrip = new System.Windows.Forms.ToolStrip();
            this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView)).BeginInit();
            this.panelMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.baseStatusStrip.SuspendLayout();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataGridView
            // 
            this.baseDataGridView.AllowUserToAddRows = false;
            this.baseDataGridView.AllowUserToOrderColumns = true;
            this.baseDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.baseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.baseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.baseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.baseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.baseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.baseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.baseDataGridView.Name = "baseDataGridView";
            this.baseDataGridView.ReadOnly = true;
            this.baseDataGridView.RowHeadersWidth = 10;
            this.baseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.baseDataGridView.RowTemplate.Height = 23;
            this.baseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.baseDataGridView.Size = new System.Drawing.Size(531, 375);
            this.baseDataGridView.StandardTab = true;
            this.baseDataGridView.TabIndex = 3;
            this.baseDataGridView.Tag = "修改";
            this.baseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.baseDataGridView_CellDoubleClick);
            this.baseDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.baseDataGridView_CellPainting);
            this.baseDataGridView.SelectionChanged += new System.EventHandler(this.baseDataGridView_SelectionChanged);
            this.baseDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.baseDataGridView_KeyUp);
            // 
            // baseTreeView
            // 
            this.baseTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTreeView.Location = new System.Drawing.Point(0, 0);
            this.baseTreeView.Name = "baseTreeView";
            this.baseTreeView.Size = new System.Drawing.Size(180, 397);
            this.baseTreeView.TabIndex = 2;
            this.baseTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.baseTreeView_BeforeExpand);
            this.baseTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.baseTreeView_AfterSelect);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(715, 397);
            this.panelMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.baseTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.baseDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.baseStatusStrip);
            this.splitContainer1.Size = new System.Drawing.Size(715, 397);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // baseStatusStrip
            // 
            this.baseStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripStatusLabel});
            this.baseStatusStrip.Location = new System.Drawing.Point(0, 375);
            this.baseStatusStrip.Name = "baseStatusStrip";
            this.baseStatusStrip.Size = new System.Drawing.Size(531, 22);
            this.baseStatusStrip.TabIndex = 4;
            this.baseStatusStrip.Text = "statusStrip1";
            // 
            // countToolStripStatusLabel
            // 
            this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
            this.countToolStripStatusLabel.Size = new System.Drawing.Size(71, 17);
            this.countToolStripStatusLabel.Text = "共有 条记录";
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.lbFind);
            this.panelFind.Controls.Add(this.btDisplayAll);
            this.panelFind.Controls.Add(this.btnFind);
            this.panelFind.Controls.Add(this.tbFind);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFind.Location = new System.Drawing.Point(0, 25);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(715, 28);
            this.panelFind.TabIndex = 2;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Location = new System.Drawing.Point(266, 7);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(0, 12);
            this.lbFind.TabIndex = 6;
            // 
            // btDisplayAll
            // 
            this.btDisplayAll.Location = new System.Drawing.Point(185, 3);
            this.btDisplayAll.Name = "btDisplayAll";
            this.btDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btDisplayAll.TabIndex = 5;
            this.btDisplayAll.Text = "重置";
            this.btDisplayAll.UseVisualStyleBackColor = true;
            this.btDisplayAll.Click += new System.EventHandler(this.btDisplayAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(106, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "筛选";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(2, 4);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(100, 21);
            this.tbFind.TabIndex = 3;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            this.tbFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyDown);
            // 
            // baseToolStrip
            // 
            this.baseToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.baseToolStrip.Location = new System.Drawing.Point(0, 0);
            this.baseToolStrip.Name = "baseToolStrip";
            this.baseToolStrip.Size = new System.Drawing.Size(715, 25);
            this.baseToolStrip.TabIndex = 1;
            this.baseToolStrip.TabStop = true;
            this.baseToolStrip.Text = "toolStrip2";
            // 
            // baseImageList
            // 
            this.baseImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("baseImageList.ImageStream")));
            this.baseImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.baseImageList.Images.SetKeyName(0, "note_add.png");
            this.baseImageList.Images.SetKeyName(1, "note_edit.png");
            this.baseImageList.Images.SetKeyName(2, "note_remove.png");
            this.baseImageList.Images.SetKeyName(3, "refresh.png");
            this.baseImageList.Images.SetKeyName(4, "process.png");
            this.baseImageList.Images.SetKeyName(5, "Save.png");
            this.baseImageList.Images.SetKeyName(6, "export.png");
            this.baseImageList.Images.SetKeyName(7, "import.png");
            this.baseImageList.Images.SetKeyName(8, "note_accept.png");
            this.baseImageList.Images.SetKeyName(9, "Print.png");
            this.baseImageList.Images.SetKeyName(10, "Back.png");
            this.baseImageList.Images.SetKeyName(11, "buttonClose.bmp");
            this.baseImageList.Images.SetKeyName(12, "LineChart.png");
            this.baseImageList.Images.SetKeyName(13, "Load.png");
            this.baseImageList.Images.SetKeyName(14, "notes_edit.png");
            this.baseImageList.Images.SetKeyName(15, "search.png");
            this.baseImageList.Images.SetKeyName(16, "up.png");
            // 
            // FrmBTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.baseToolStrip);
            this.Name = "FrmBTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frmBTree.1";
            this.Text = "frmBTree";
            this.Activated += new System.EventHandler(this.FrmBTree_Activated);
            this.Load += new System.EventHandler(this.frmBTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.baseStatusStrip.ResumeLayout(false);
            this.baseStatusStrip.PerformLayout();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView baseDataGridView;
        protected System.Windows.Forms.TreeView baseTreeView;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.BindingSource baseBindingSource;
        private System.Windows.Forms.Panel panelMain;
        protected System.Windows.Forms.Panel panelFind;
        protected System.Windows.Forms.ToolStrip baseToolStrip;
        private System.Windows.Forms.ImageList baseImageList;
        protected System.Windows.Forms.TextBox tbFind;
        protected System.Windows.Forms.Label lbFind;
        protected System.Windows.Forms.Button btDisplayAll;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.StatusStrip baseStatusStrip;
        protected System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
    }
}