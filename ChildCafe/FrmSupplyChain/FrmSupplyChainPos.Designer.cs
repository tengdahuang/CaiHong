﻿namespace ChildCafe
{
    partial class FrmSupplyChainPos
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
            this.ctMealTableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctSerialNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSelectItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctMemberName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRemainingSum = new System.Windows.Forms.Label();
            this.dgvPosDetail = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ctRemainingSum = new System.Windows.Forms.Label();
            this.ctFrequency = new System.Windows.Forms.Label();
            this.ctTotalSpending = new System.Windows.Forms.Label();
            this.ctCardNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSelectItem = new System.Windows.Forms.DataGridView();
            this.ssPos = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ctUnderPay = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ctUnPayAmount = new System.Windows.Forms.Label();
            this.ctPosAmount = new System.Windows.Forms.Label();
            this.ctGiftQuantity = new System.Windows.Forms.Label();
            this.ctUnPaidQuantity = new System.Windows.Forms.Label();
            this.ctPaidQuantity = new System.Windows.Forms.Label();
            this.ctQuantity = new System.Windows.Forms.Label();
            this.ctRealPay = new XSolo.ExtendedControls.NumericUpDownEx();
            this.btnPartPay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFullPay = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bsPosDetail = new System.Windows.Forms.BindingSource(this.components);
            this.bsSelectItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosDetail)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).BeginInit();
            this.ssPos.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctRealPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ctMealTableName
            // 
            this.ctMealTableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctMealTableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctMealTableName.FormattingEnabled = true;
            this.ctMealTableName.Location = new System.Drawing.Point(243, 6);
            this.ctMealTableName.Name = "ctMealTableName";
            this.ctMealTableName.Size = new System.Drawing.Size(121, 20);
            this.ctMealTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "桌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "会员号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "小票流水号";
            // 
            // ctSerialNumber
            // 
            this.ctSerialNumber.AutoSize = true;
            this.ctSerialNumber.Location = new System.Drawing.Point(557, 9);
            this.ctSerialNumber.Name = "ctSerialNumber";
            this.ctSerialNumber.Size = new System.Drawing.Size(71, 12);
            this.ctSerialNumber.TabIndex = 6;
            this.ctSerialNumber.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "录入";
            // 
            // tbSelectItem
            // 
            this.tbSelectItem.Location = new System.Drawing.Point(59, 32);
            this.tbSelectItem.Name = "tbSelectItem";
            this.tbSelectItem.Size = new System.Drawing.Size(100, 21);
            this.tbSelectItem.TabIndex = 2;
            this.tbSelectItem.TextChanged += new System.EventHandler(this.tbSelectItem_TextChanged);
            this.tbSelectItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSelectItem_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "姓名";
            // 
            // ctMemberName
            // 
            this.ctMemberName.AutoSize = true;
            this.ctMemberName.Location = new System.Drawing.Point(240, 35);
            this.ctMemberName.Name = "ctMemberName";
            this.ctMemberName.Size = new System.Drawing.Size(29, 12);
            this.ctMemberName.TabIndex = 10;
            this.ctMemberName.Text = "    ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "消费累计";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "消费次数";
            // 
            // lbRemainingSum
            // 
            this.lbRemainingSum.AutoSize = true;
            this.lbRemainingSum.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRemainingSum.Location = new System.Drawing.Point(24, 111);
            this.lbRemainingSum.Name = "lbRemainingSum";
            this.lbRemainingSum.Size = new System.Drawing.Size(148, 27);
            this.lbRemainingSum.TabIndex = 13;
            this.lbRemainingSum.Text = "会员余额 ¥";
            this.lbRemainingSum.Visible = false;
            // 
            // dgvPosDetail
            // 
            this.dgvPosDetail.AllowUserToAddRows = false;
            this.dgvPosDetail.AllowUserToResizeRows = false;
            this.dgvPosDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPosDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPosDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvPosDetail.Name = "dgvPosDetail";
            this.dgvPosDetail.ReadOnly = true;
            this.dgvPosDetail.RowTemplate.Height = 23;
            this.dgvPosDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosDetail.Size = new System.Drawing.Size(744, 166);
            this.dgvPosDetail.TabIndex = 10;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.ctFrequency);
            this.panelTop.Controls.Add(this.ctTotalSpending);
            this.panelTop.Controls.Add(this.ctCardNumber);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.ctMemberName);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.ctSerialNumber);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.tbSelectItem);
            this.panelTop.Controls.Add(this.ctMealTableName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(744, 58);
            this.panelTop.TabIndex = 15;
            // 
            // ctRemainingSum
            // 
            this.ctRemainingSum.AutoSize = true;
            this.ctRemainingSum.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctRemainingSum.ForeColor = System.Drawing.Color.Red;
            this.ctRemainingSum.Location = new System.Drawing.Point(169, 104);
            this.ctRemainingSum.Name = "ctRemainingSum";
            this.ctRemainingSum.Size = new System.Drawing.Size(37, 40);
            this.ctRemainingSum.TabIndex = 17;
            this.ctRemainingSum.Text = "0";
            this.ctRemainingSum.Visible = false;
            // 
            // ctFrequency
            // 
            this.ctFrequency.AutoSize = true;
            this.ctFrequency.Location = new System.Drawing.Point(511, 35);
            this.ctFrequency.Name = "ctFrequency";
            this.ctFrequency.Size = new System.Drawing.Size(29, 12);
            this.ctFrequency.TabIndex = 16;
            this.ctFrequency.Text = "    ";
            // 
            // ctTotalSpending
            // 
            this.ctTotalSpending.AutoSize = true;
            this.ctTotalSpending.Location = new System.Drawing.Point(392, 35);
            this.ctTotalSpending.Name = "ctTotalSpending";
            this.ctTotalSpending.Size = new System.Drawing.Size(29, 12);
            this.ctTotalSpending.TabIndex = 15;
            this.ctTotalSpending.Text = "    ";
            // 
            // ctCardNumber
            // 
            this.ctCardNumber.Location = new System.Drawing.Point(59, 6);
            this.ctCardNumber.Name = "ctCardNumber";
            this.ctCardNumber.Size = new System.Drawing.Size(100, 21);
            this.ctCardNumber.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSelectItem);
            this.panel2.Controls.Add(this.dgvPosDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 288);
            this.panel2.TabIndex = 16;
            // 
            // dgvSelectItem
            // 
            this.dgvSelectItem.AllowUserToAddRows = false;
            this.dgvSelectItem.AllowUserToResizeRows = false;
            this.dgvSelectItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSelectItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelectItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSelectItem.Location = new System.Drawing.Point(0, 172);
            this.dgvSelectItem.Name = "dgvSelectItem";
            this.dgvSelectItem.ReadOnly = true;
            this.dgvSelectItem.RowTemplate.Height = 23;
            this.dgvSelectItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectItem.Size = new System.Drawing.Size(744, 116);
            this.dgvSelectItem.TabIndex = 11;
            this.dgvSelectItem.SelectionChanged += new System.EventHandler(this.dgvSelectItem_SelectionChanged);
            // 
            // ssPos
            // 
            this.ssPos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPos});
            this.ssPos.Location = new System.Drawing.Point(0, 569);
            this.ssPos.Name = "ssPos";
            this.ssPos.Size = new System.Drawing.Size(744, 22);
            this.ssPos.TabIndex = 17;
            this.ssPos.Text = "statusStrip1";
            // 
            // toolStripStatusPos
            // 
            this.toolStripStatusPos.Name = "toolStripStatusPos";
            this.toolStripStatusPos.Size = new System.Drawing.Size(523, 17);
            this.toolStripStatusPos.Text = "快捷键: 会员F1 桌号F2 商品F3 现金实收F4 删行Del 增加+ 减少- 修改F8 打折/ 移桌F11 关闭ESC";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.ctRemainingSum);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.ctUnderPay);
            this.panelBottom.Controls.Add(this.label27);
            this.panelBottom.Controls.Add(this.lbRemainingSum);
            this.panelBottom.Controls.Add(this.ctUnPayAmount);
            this.panelBottom.Controls.Add(this.ctPosAmount);
            this.panelBottom.Controls.Add(this.ctGiftQuantity);
            this.panelBottom.Controls.Add(this.ctUnPaidQuantity);
            this.panelBottom.Controls.Add(this.ctPaidQuantity);
            this.panelBottom.Controls.Add(this.ctQuantity);
            this.panelBottom.Controls.Add(this.ctRealPay);
            this.panelBottom.Controls.Add(this.btnPartPay);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.button7);
            this.panelBottom.Controls.Add(this.button6);
            this.panelBottom.Controls.Add(this.button5);
            this.panelBottom.Controls.Add(this.button4);
            this.panelBottom.Controls.Add(this.button3);
            this.panelBottom.Controls.Add(this.button2);
            this.panelBottom.Controls.Add(this.btnFullPay);
            this.panelBottom.Controls.Add(this.label23);
            this.panelBottom.Controls.Add(this.label22);
            this.panelBottom.Controls.Add(this.label21);
            this.panelBottom.Controls.Add(this.label20);
            this.panelBottom.Controls.Add(this.label19);
            this.panelBottom.Controls.Add(this.label18);
            this.panelBottom.Controls.Add(this.label17);
            this.panelBottom.Controls.Add(this.label16);
            this.panelBottom.Controls.Add(this.label15);
            this.panelBottom.Controls.Add(this.label14);
            this.panelBottom.Controls.Add(this.label13);
            this.panelBottom.Controls.Add(this.label12);
            this.panelBottom.Controls.Add(this.label11);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 346);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(744, 245);
            this.panelBottom.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(500, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 71;
            this.label7.Text = "    ";
            // 
            // ctUnderPay
            // 
            this.ctUnderPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ctUnderPay.AutoSize = true;
            this.ctUnderPay.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctUnderPay.ForeColor = System.Drawing.Color.Blue;
            this.ctUnderPay.Location = new System.Drawing.Point(169, 57);
            this.ctUnderPay.Name = "ctUnderPay";
            this.ctUnderPay.Size = new System.Drawing.Size(37, 40);
            this.ctUnderPay.TabIndex = 70;
            this.ctUnderPay.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(403, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 68;
            this.label27.Text = "    ";
            // 
            // ctUnPayAmount
            // 
            this.ctUnPayAmount.AutoSize = true;
            this.ctUnPayAmount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctUnPayAmount.Location = new System.Drawing.Point(240, 25);
            this.ctUnPayAmount.Name = "ctUnPayAmount";
            this.ctUnPayAmount.Size = new System.Drawing.Size(29, 12);
            this.ctUnPayAmount.TabIndex = 67;
            this.ctUnPayAmount.Text = "    ";
            // 
            // ctPosAmount
            // 
            this.ctPosAmount.AutoSize = true;
            this.ctPosAmount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctPosAmount.Location = new System.Drawing.Point(89, 25);
            this.ctPosAmount.Name = "ctPosAmount";
            this.ctPosAmount.Size = new System.Drawing.Size(29, 12);
            this.ctPosAmount.TabIndex = 66;
            this.ctPosAmount.Text = "    ";
            // 
            // ctGiftQuantity
            // 
            this.ctGiftQuantity.AutoSize = true;
            this.ctGiftQuantity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctGiftQuantity.Location = new System.Drawing.Point(634, 7);
            this.ctGiftQuantity.Name = "ctGiftQuantity";
            this.ctGiftQuantity.Size = new System.Drawing.Size(29, 12);
            this.ctGiftQuantity.TabIndex = 65;
            this.ctGiftQuantity.Text = "    ";
            // 
            // ctUnPaidQuantity
            // 
            this.ctUnPaidQuantity.AutoSize = true;
            this.ctUnPaidQuantity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctUnPaidQuantity.Location = new System.Drawing.Point(403, 7);
            this.ctUnPaidQuantity.Name = "ctUnPaidQuantity";
            this.ctUnPaidQuantity.Size = new System.Drawing.Size(29, 12);
            this.ctUnPaidQuantity.TabIndex = 64;
            this.ctUnPaidQuantity.Text = "    ";
            // 
            // ctPaidQuantity
            // 
            this.ctPaidQuantity.AutoSize = true;
            this.ctPaidQuantity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctPaidQuantity.Location = new System.Drawing.Point(240, 7);
            this.ctPaidQuantity.Name = "ctPaidQuantity";
            this.ctPaidQuantity.Size = new System.Drawing.Size(29, 12);
            this.ctPaidQuantity.TabIndex = 63;
            this.ctPaidQuantity.Text = "    ";
            // 
            // ctQuantity
            // 
            this.ctQuantity.AutoSize = true;
            this.ctQuantity.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctQuantity.Location = new System.Drawing.Point(89, 7);
            this.ctQuantity.Name = "ctQuantity";
            this.ctQuantity.Size = new System.Drawing.Size(29, 12);
            this.ctQuantity.TabIndex = 62;
            this.ctQuantity.Text = "    ";
            // 
            // ctRealPay
            // 
            this.ctRealPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ctRealPay.DecimalPlaces = 2;
            this.ctRealPay.Font = new System.Drawing.Font("SimSun", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctRealPay.ForeColor = System.Drawing.Color.Red;
            this.ctRealPay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctRealPay.Location = new System.Drawing.Point(500, 51);
            this.ctRealPay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctRealPay.Name = "ctRealPay";
            this.ctRealPay.Size = new System.Drawing.Size(185, 53);
            this.ctRealPay.TabIndex = 20;
            // 
            // btnPartPay
            // 
            this.btnPartPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartPay.Location = new System.Drawing.Point(358, 156);
            this.btnPartPay.Name = "btnPartPay";
            this.btnPartPay.Size = new System.Drawing.Size(86, 23);
            this.btnPartPay.TabIndex = 33;
            this.btnPartPay.TabStop = false;
            this.btnPartPay.Text = "部分结算(F6)";
            this.btnPartPay.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(634, 156);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "关闭(ESC)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(542, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 31;
            this.button7.TabStop = false;
            this.button7.Text = "备注(ctrl+B)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(450, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 30;
            this.button6.TabStop = false;
            this.button6.Text = "删单(ctrl+3)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(358, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 29;
            this.button5.TabStop = false;
            this.button5.Text = "取单(ctrl+2)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(266, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 28;
            this.button4.TabStop = false;
            this.button4.Text = "挂单(ctrl+1)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(542, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 27;
            this.button3.TabStop = false;
            this.button3.Text = "退菜(ctrl+R)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(450, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 26;
            this.button2.TabStop = false;
            this.button2.Text = "赠送(ctrl+G)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFullPay
            // 
            this.btnFullPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullPay.Location = new System.Drawing.Point(266, 156);
            this.btnFullPay.Name = "btnFullPay";
            this.btnFullPay.Size = new System.Drawing.Size(86, 23);
            this.btnFullPay.TabIndex = 25;
            this.btnFullPay.TabStop = false;
            this.btnFullPay.Text = "整单结算(F5)";
            this.btnFullPay.UseVisualStyleBackColor = true;
            this.btnFullPay.Click += new System.EventHandler(this.btnFullPay_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(400, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 27);
            this.label23.TabIndex = 24;
            this.label23.Text = "找零 ¥";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(118, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 23;
            this.label22.Text = "折扣额";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "折扣(/)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(524, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 21;
            this.label20.Text = "扣除储值待收";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(346, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 27);
            this.label19.TabIndex = 20;
            this.label19.Text = "现金实收 ¥";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(24, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 27);
            this.label18.TabIndex = 19;
            this.label18.Text = "本次应收 ¥";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(317, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "扣除本次待付";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(162, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "待付金额";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "本单总额";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(524, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "赠送数量";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(317, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "未付数量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(162, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "已付数量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(11, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "商品数量";
            // 
            // FrmSupplyChainPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(744, 591);
            this.Controls.Add(this.ssPos);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmSupplyChainPos";
            this.Text = "收银台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSupplyChainPos_FormClosing);
            this.Load += new System.EventHandler(this.FrmSupplyChainPos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSupplyChainPos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosDetail)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectItem)).EndInit();
            this.ssPos.ResumeLayout(false);
            this.ssPos.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctRealPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctMealTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ctSerialNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSelectItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ctMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRemainingSum;
        private System.Windows.Forms.DataGridView dgvPosDetail;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSelectItem;
        private System.Windows.Forms.StatusStrip ssPos;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnFullPay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPos;
        private System.Windows.Forms.TextBox ctCardNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPartPay;
        private System.Windows.Forms.BindingSource bsPosDetail;
        private System.Windows.Forms.BindingSource bsSelectItem;
        private XSolo.ExtendedControls.NumericUpDownEx ctRealPay;
        private System.Windows.Forms.Label ctQuantity;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label ctUnPayAmount;
        private System.Windows.Forms.Label ctPosAmount;
        private System.Windows.Forms.Label ctGiftQuantity;
        private System.Windows.Forms.Label ctUnPaidQuantity;
        private System.Windows.Forms.Label ctPaidQuantity;
        private System.Windows.Forms.Label ctFrequency;
        private System.Windows.Forms.Label ctTotalSpending;
        private System.Windows.Forms.Label ctRemainingSum;
        private System.Windows.Forms.Label ctUnderPay;
        private System.Windows.Forms.Label label7;
    }
}
