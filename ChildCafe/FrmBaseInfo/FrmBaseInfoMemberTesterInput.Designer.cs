namespace ChildCafe
{
    partial class FrmBaseInfoMemberTesterInput
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dgvTester = new System.Windows.Forms.DataGridView();
            this.timerWarning = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bsTester = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTester)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(108, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 35);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(135, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "请录入手机号";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(127, 155);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(104, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "欢迎来彩虹乐园体验";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(227, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "退出";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dgvTester
            // 
            this.dgvTester.AllowUserToAddRows = false;
            this.dgvTester.AllowUserToResizeRows = false;
            this.dgvTester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTester.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvTester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTester.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTester.Location = new System.Drawing.Point(0, 241);
            this.dgvTester.Name = "dgvTester";
            this.dgvTester.ReadOnly = true;
            this.dgvTester.RowTemplate.Height = 23;
            this.dgvTester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTester.Size = new System.Drawing.Size(434, 170);
            this.dgvTester.TabIndex = 9;
            // 
            // timerWarning
            // 
            this.timerWarning.Interval = 60000;
            this.timerWarning.Tick += new System.EventHandler(this.timerWarning_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(66, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "10分钟内体验到时间的宝宝";
            // 
            // FrmBaseInfoMemberTesterInput
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTester);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmBaseInfoMemberTesterInput";
            this.Text = "BaseInfoMemberTesterInput";
            this.Load += new System.EventHandler(this.FrmBaseInfoMemberTesterInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dgvTester;
        private System.Windows.Forms.Timer timerWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsTester;
    }
}