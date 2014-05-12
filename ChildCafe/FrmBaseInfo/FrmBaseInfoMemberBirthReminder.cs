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
    public partial class FrmBaseInfoMemberBirthReminder : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoMemberBirthReminder()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmBaseInfoMemberBirthReminder_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllBaseInfoMember.GetRemain(UserStatics.OptrType, 7);
        }



        protected override void btnFind_Click(object sender, EventArgs e)
        {
            int result = 0;
            int.TryParse(tbFind.Text, out result);
            if (result != 0)
            {
                TableForLoad = BllBaseInfoMember.GetRemain(UserStatics.OptrType, result);
                reloadDataGridView();
                resetDataGridView();
            }

        }


    }
}
