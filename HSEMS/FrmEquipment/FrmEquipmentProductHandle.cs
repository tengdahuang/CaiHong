﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmEquipmentProductHandle : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentProductHandle()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmEquipmentProductHandle_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentProductHandle.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["OptrType"].Visible = false;
            baseDataGridView.Columns["WaitingTakes"].Visible = false;
            baseDataGridView.Columns["RepairingTakes1"].Visible = false;
            baseDataGridView.Columns["RepairingTakes2"].Visible = false;
        }
    }
}
