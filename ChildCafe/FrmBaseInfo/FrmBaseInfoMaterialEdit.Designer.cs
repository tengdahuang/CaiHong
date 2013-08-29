namespace ChildCafe
{
    partial class FrmBaseInfoMaterialEdit
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
            this.ctShortCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctName = new System.Windows.Forms.TextBox();
            this.ctCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctItemNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctSpecification = new System.Windows.Forms.TextBox();
            this.ctBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctPurchaseUnitName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctSaleUnitName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctUnitConvValue = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label11 = new System.Windows.Forms.Label();
            this.ctUnitPrice = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label12 = new System.Windows.Forms.Label();
            this.ctConvPrice = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label13 = new System.Windows.Forms.Label();
            this.ctAvgPrice = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label14 = new System.Windows.Forms.Label();
            this.ctInvQuantity = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label15 = new System.Windows.Forms.Label();
            this.ctMemberPrice = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label16 = new System.Windows.Forms.Label();
            this.ctRetailPrice = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label17 = new System.Windows.Forms.Label();
            this.ctConvQuantity = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label18 = new System.Windows.Forms.Label();
            this.ctStockLowAlarm = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label19 = new System.Windows.Forms.Label();
            this.ctInventoryCost = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label20 = new System.Windows.Forms.Label();
            this.ctBonusPoint = new XSolo.ExtendedControls.NumericUpDownEx();
            this.label21 = new System.Windows.Forms.Label();
            this.ctIsAddToInventory = new System.Windows.Forms.CheckBox();
            this.ctIsIngredient = new System.Windows.Forms.CheckBox();
            this.ctStatus = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.chooseIngredient = new System.Windows.Forms.Button();
            this.IsIncludeIngredient = new System.Windows.Forms.CheckBox();
            this.ctRemark = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctUnitConvValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctConvPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctAvgPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctInvQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMemberPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctConvQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockLowAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctInventoryCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctBonusPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(606, 482);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctRemark);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.IsIncludeIngredient);
            this.tabPage1.Controls.Add(this.chooseIngredient);
            this.tabPage1.Controls.Add(this.dgvIngredients);
            this.tabPage1.Controls.Add(this.ctStatus);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.ctIsIngredient);
            this.tabPage1.Controls.Add(this.ctIsAddToInventory);
            this.tabPage1.Controls.Add(this.ctBonusPoint);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.ctStockLowAlarm);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ctInventoryCost);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.ctConvQuantity);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.ctInvQuantity);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.ctMemberPrice);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.ctRetailPrice);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.ctAvgPrice);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.ctConvPrice);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ctUnitPrice);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ctUnitConvValue);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ctSaleUnitName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ctPurchaseUnitName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ctBrand);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ctCategory);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ctItemNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctSpecification);
            this.tabPage1.Controls.Add(this.ctBarcode);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctShortCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctName);
            this.tabPage1.Controls.Add(this.ctCode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(598, 456);
            // 
            // ctShortCode
            // 
            this.ctShortCode.Location = new System.Drawing.Point(464, 33);
            this.ctShortCode.Name = "ctShortCode";
            this.ctShortCode.Size = new System.Drawing.Size(121, 21);
            this.ctShortCode.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "简拼";
            // 
            // ctName
            // 
            this.ctName.Location = new System.Drawing.Point(464, 7);
            this.ctName.Name = "ctName";
            this.ctName.Size = new System.Drawing.Size(121, 21);
            this.ctName.TabIndex = 10;
            this.ctName.TextChanged += new System.EventHandler(this.ctName_TextChanged);
            // 
            // ctCode
            // 
            this.ctCode.Location = new System.Drawing.Point(269, 7);
            this.ctCode.Name = "ctCode";
            this.ctCode.Size = new System.Drawing.Size(121, 21);
            this.ctCode.TabIndex = 5;
            this.ctCode.TextChanged += new System.EventHandler(this.ctCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "物料名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "物料编码";
            // 
            // ctItemNo
            // 
            this.ctItemNo.Location = new System.Drawing.Point(463, 167);
            this.ctItemNo.Name = "ctItemNo";
            this.ctItemNo.Size = new System.Drawing.Size(121, 21);
            this.ctItemNo.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "货号";
            // 
            // ctSpecification
            // 
            this.ctSpecification.Location = new System.Drawing.Point(269, 33);
            this.ctSpecification.Name = "ctSpecification";
            this.ctSpecification.Size = new System.Drawing.Size(121, 21);
            this.ctSpecification.TabIndex = 20;
            // 
            // ctBarcode
            // 
            this.ctBarcode.Location = new System.Drawing.Point(77, 33);
            this.ctBarcode.Name = "ctBarcode";
            this.ctBarcode.Size = new System.Drawing.Size(121, 21);
            this.ctBarcode.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "规格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "条码";
            // 
            // ctCategory
            // 
            this.ctCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctCategory.FormattingEnabled = true;
            this.ctCategory.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ctCategory.Location = new System.Drawing.Point(77, 7);
            this.ctCategory.Name = "ctCategory";
            this.ctCategory.Size = new System.Drawing.Size(121, 20);
            this.ctCategory.TabIndex = 1;
            this.ctCategory.SelectedIndexChanged += new System.EventHandler(this.ctCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 69;
            this.label7.Text = "物料分类";
            // 
            // ctBrand
            // 
            this.ctBrand.Location = new System.Drawing.Point(269, 167);
            this.ctBrand.Name = "ctBrand";
            this.ctBrand.Size = new System.Drawing.Size(121, 21);
            this.ctBrand.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 70;
            this.label8.Text = "品牌";
            // 
            // ctPurchaseUnitName
            // 
            this.ctPurchaseUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctPurchaseUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctPurchaseUnitName.FormattingEnabled = true;
            this.ctPurchaseUnitName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ctPurchaseUnitName.Location = new System.Drawing.Point(77, 60);
            this.ctPurchaseUnitName.Name = "ctPurchaseUnitName";
            this.ctPurchaseUnitName.Size = new System.Drawing.Size(121, 20);
            this.ctPurchaseUnitName.TabIndex = 40;
            this.ctPurchaseUnitName.TextChanged += new System.EventHandler(this.ctPurchaseUnitName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 73;
            this.label9.Text = "采购单位";
            // 
            // ctSaleUnitName
            // 
            this.ctSaleUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctSaleUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctSaleUnitName.FormattingEnabled = true;
            this.ctSaleUnitName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ctSaleUnitName.Location = new System.Drawing.Point(269, 60);
            this.ctSaleUnitName.Name = "ctSaleUnitName";
            this.ctSaleUnitName.Size = new System.Drawing.Size(121, 20);
            this.ctSaleUnitName.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 75;
            this.label10.Text = "销售单位";
            // 
            // ctUnitConvValue
            // 
            this.ctUnitConvValue.DecimalPlaces = 2;
            this.ctUnitConvValue.Location = new System.Drawing.Point(464, 59);
            this.ctUnitConvValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctUnitConvValue.Name = "ctUnitConvValue";
            this.ctUnitConvValue.Size = new System.Drawing.Size(120, 21);
            this.ctUnitConvValue.TabIndex = 50;
            this.ctUnitConvValue.ValueChanged += new System.EventHandler(this.ctUnitConvValue_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 76;
            this.label11.Text = "换算率";
            // 
            // ctUnitPrice
            // 
            this.ctUnitPrice.DecimalPlaces = 2;
            this.ctUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctUnitPrice.Location = new System.Drawing.Point(77, 86);
            this.ctUnitPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctUnitPrice.Name = "ctUnitPrice";
            this.ctUnitPrice.Size = new System.Drawing.Size(120, 21);
            this.ctUnitPrice.TabIndex = 55;
            this.ctUnitPrice.ValueChanged += new System.EventHandler(this.ctUnitPrice_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 78;
            this.label12.Text = "单位进价";
            // 
            // ctConvPrice
            // 
            this.ctConvPrice.DecimalPlaces = 2;
            this.ctConvPrice.Enabled = false;
            this.ctConvPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctConvPrice.Location = new System.Drawing.Point(77, 140);
            this.ctConvPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctConvPrice.Name = "ctConvPrice";
            this.ctConvPrice.Size = new System.Drawing.Size(120, 21);
            this.ctConvPrice.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 80;
            this.label13.Text = "换算进价";
            // 
            // ctAvgPrice
            // 
            this.ctAvgPrice.DecimalPlaces = 2;
            this.ctAvgPrice.Enabled = false;
            this.ctAvgPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctAvgPrice.Location = new System.Drawing.Point(464, 140);
            this.ctAvgPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctAvgPrice.Name = "ctAvgPrice";
            this.ctAvgPrice.Size = new System.Drawing.Size(120, 21);
            this.ctAvgPrice.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 82;
            this.label14.Text = "平均进价";
            // 
            // ctInvQuantity
            // 
            this.ctInvQuantity.DecimalPlaces = 2;
            this.ctInvQuantity.Location = new System.Drawing.Point(269, 86);
            this.ctInvQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctInvQuantity.Name = "ctInvQuantity";
            this.ctInvQuantity.Size = new System.Drawing.Size(120, 21);
            this.ctInvQuantity.TabIndex = 60;
            this.ctInvQuantity.ValueChanged += new System.EventHandler(this.ctInvQuantity_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 88;
            this.label15.Text = "库存数";
            // 
            // ctMemberPrice
            // 
            this.ctMemberPrice.DecimalPlaces = 2;
            this.ctMemberPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctMemberPrice.Location = new System.Drawing.Point(269, 113);
            this.ctMemberPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctMemberPrice.Name = "ctMemberPrice";
            this.ctMemberPrice.Size = new System.Drawing.Size(120, 21);
            this.ctMemberPrice.TabIndex = 75;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(209, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 86;
            this.label16.Text = "会员价";
            // 
            // ctRetailPrice
            // 
            this.ctRetailPrice.DecimalPlaces = 2;
            this.ctRetailPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctRetailPrice.Location = new System.Drawing.Point(77, 113);
            this.ctRetailPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctRetailPrice.Name = "ctRetailPrice";
            this.ctRetailPrice.Size = new System.Drawing.Size(120, 21);
            this.ctRetailPrice.TabIndex = 70;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 84;
            this.label17.Text = "零售价";
            // 
            // ctConvQuantity
            // 
            this.ctConvQuantity.DecimalPlaces = 2;
            this.ctConvQuantity.Enabled = false;
            this.ctConvQuantity.Location = new System.Drawing.Point(464, 86);
            this.ctConvQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctConvQuantity.Name = "ctConvQuantity";
            this.ctConvQuantity.Size = new System.Drawing.Size(120, 21);
            this.ctConvQuantity.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(404, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 90;
            this.label18.Text = "折算库存";
            // 
            // ctStockLowAlarm
            // 
            this.ctStockLowAlarm.DecimalPlaces = 2;
            this.ctStockLowAlarm.Location = new System.Drawing.Point(464, 113);
            this.ctStockLowAlarm.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctStockLowAlarm.Name = "ctStockLowAlarm";
            this.ctStockLowAlarm.Size = new System.Drawing.Size(120, 21);
            this.ctStockLowAlarm.TabIndex = 80;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(404, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 94;
            this.label19.Text = "最低库存";
            // 
            // ctInventoryCost
            // 
            this.ctInventoryCost.DecimalPlaces = 2;
            this.ctInventoryCost.Enabled = false;
            this.ctInventoryCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctInventoryCost.Location = new System.Drawing.Point(269, 140);
            this.ctInventoryCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctInventoryCost.Name = "ctInventoryCost";
            this.ctInventoryCost.Size = new System.Drawing.Size(120, 21);
            this.ctInventoryCost.TabIndex = 90;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(209, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 92;
            this.label20.Text = "库存成本";
            // 
            // ctBonusPoint
            // 
            this.ctBonusPoint.DecimalPlaces = 2;
            this.ctBonusPoint.Location = new System.Drawing.Point(77, 167);
            this.ctBonusPoint.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctBonusPoint.Name = "ctBonusPoint";
            this.ctBonusPoint.Size = new System.Drawing.Size(120, 21);
            this.ctBonusPoint.TabIndex = 100;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 96;
            this.label21.Text = "积分";
            // 
            // ctIsAddToInventory
            // 
            this.ctIsAddToInventory.AutoSize = true;
            this.ctIsAddToInventory.Location = new System.Drawing.Point(19, 196);
            this.ctIsAddToInventory.Name = "ctIsAddToInventory";
            this.ctIsAddToInventory.Size = new System.Drawing.Size(96, 16);
            this.ctIsAddToInventory.TabIndex = 105;
            this.ctIsAddToInventory.Text = "是否计入库存";
            this.ctIsAddToInventory.UseVisualStyleBackColor = true;
            this.ctIsAddToInventory.CheckedChanged += new System.EventHandler(this.ctIsAddToInventory_CheckedChanged);
            // 
            // ctIsIngredient
            // 
            this.ctIsIngredient.AutoSize = true;
            this.ctIsIngredient.Location = new System.Drawing.Point(121, 196);
            this.ctIsIngredient.Name = "ctIsIngredient";
            this.ctIsIngredient.Size = new System.Drawing.Size(84, 16);
            this.ctIsIngredient.TabIndex = 110;
            this.ctIsIngredient.Text = "是否半成品";
            this.ctIsIngredient.UseVisualStyleBackColor = true;
            // 
            // ctStatus
            // 
            this.ctStatus.Location = new System.Drawing.Point(463, 194);
            this.ctStatus.Name = "ctStatus";
            this.ctStatus.Size = new System.Drawing.Size(121, 21);
            this.ctStatus.TabIndex = 103;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(404, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 100;
            this.label22.Text = "状态";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(19, 252);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.RowTemplate.Height = 23;
            this.dgvIngredients.Size = new System.Drawing.Size(565, 104);
            this.dgvIngredients.TabIndex = 130;
            // 
            // chooseIngredient
            // 
            this.chooseIngredient.Location = new System.Drawing.Point(20, 223);
            this.chooseIngredient.Name = "chooseIngredient";
            this.chooseIngredient.Size = new System.Drawing.Size(75, 23);
            this.chooseIngredient.TabIndex = 125;
            this.chooseIngredient.Text = "选择耗材";
            this.chooseIngredient.UseVisualStyleBackColor = true;
            // 
            // IsIncludeIngredient
            // 
            this.IsIncludeIngredient.AutoSize = true;
            this.IsIncludeIngredient.Location = new System.Drawing.Point(211, 196);
            this.IsIncludeIngredient.Name = "IsIncludeIngredient";
            this.IsIncludeIngredient.Size = new System.Drawing.Size(132, 16);
            this.IsIncludeIngredient.TabIndex = 120;
            this.IsIncludeIngredient.Text = "是否由其他耗材组成";
            this.IsIncludeIngredient.UseVisualStyleBackColor = true;
            // 
            // ctRemark
            // 
            this.ctRemark.Location = new System.Drawing.Point(76, 363);
            this.ctRemark.Multiline = true;
            this.ctRemark.Name = "ctRemark";
            this.ctRemark.Size = new System.Drawing.Size(508, 65);
            this.ctRemark.TabIndex = 150;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 366);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 105;
            this.label23.Text = "备注";
            // 
            // FrmBaseInfoMaterialEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(606, 517);
            this.Name = "FrmBaseInfoMaterialEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctUnitConvValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctConvPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctAvgPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctInvQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctMemberPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctConvQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockLowAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctInventoryCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctBonusPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctShortCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctName;
        private System.Windows.Forms.TextBox ctCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctItemNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctSpecification;
        private System.Windows.Forms.TextBox ctBarcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ctCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ctSaleUnitName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ctPurchaseUnitName;
        private System.Windows.Forms.Label label9;
        private XSolo.ExtendedControls.NumericUpDownEx ctUnitConvValue;
        private System.Windows.Forms.Label label11;
        private XSolo.ExtendedControls.NumericUpDownEx ctAvgPrice;
        private System.Windows.Forms.Label label14;
        private XSolo.ExtendedControls.NumericUpDownEx ctConvPrice;
        private System.Windows.Forms.Label label13;
        private XSolo.ExtendedControls.NumericUpDownEx ctUnitPrice;
        private System.Windows.Forms.Label label12;
        private XSolo.ExtendedControls.NumericUpDownEx ctInvQuantity;
        private System.Windows.Forms.Label label15;
        private XSolo.ExtendedControls.NumericUpDownEx ctMemberPrice;
        private System.Windows.Forms.Label label16;
        private XSolo.ExtendedControls.NumericUpDownEx ctRetailPrice;
        private System.Windows.Forms.Label label17;
        private XSolo.ExtendedControls.NumericUpDownEx ctConvQuantity;
        private System.Windows.Forms.Label label18;
        private XSolo.ExtendedControls.NumericUpDownEx ctStockLowAlarm;
        private System.Windows.Forms.Label label19;
        private XSolo.ExtendedControls.NumericUpDownEx ctInventoryCost;
        private System.Windows.Forms.Label label20;
        private XSolo.ExtendedControls.NumericUpDownEx ctBonusPoint;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox ctIsAddToInventory;
        private System.Windows.Forms.CheckBox ctIsIngredient;
        private System.Windows.Forms.TextBox ctStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.CheckBox IsIncludeIngredient;
        private System.Windows.Forms.Button chooseIngredient;
        private System.Windows.Forms.TextBox ctRemark;
        private System.Windows.Forms.Label label23;
    }
}
