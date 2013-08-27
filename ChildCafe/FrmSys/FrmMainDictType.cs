using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;

namespace ChildCafe
{
    public partial class FrmMainDictType : XSolo.BaseForm.FrmBTree
    {
        public FrmMainDictType()
        {
            InitializeComponent(); 
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmMainDictType_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllMainDictType.GetTable(UserStatics.OptrType);
        }

        override protected void DeleteCurrentRow()
        {

                BllMainDictType.DelCell(DeletingRowId);
                
        }
    }
}
