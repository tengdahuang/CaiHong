using System;
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
    public partial class FrmACLOptr : XSolo.BaseForm.FrmBTree
    {
        public FrmACLOptr()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;

        }

        private void FrmACLOptr_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllACLOptr.GetMainOptrDataTable(UserStatics.OptrType);
        }

        override protected void DeleteCurrentRow()
        {

            //管理员不能删除
            string name = baseDataGridView.SelectedCells[1].Value.ToString();
            if (name == "root" || name == "rtadmin" || name == "rpadmin" || name == "raadmin" || name == "roadmin")
                MessageBox.Show("管理员用户不能删除！！");
            else
                BllACLOptr.DelCell((long)baseDataGridView.SelectedCells[0].Value);
        }

        protected override void SetOperation()
        {
            if (UserStatics.OptrType == "All")
            {
                FrmACLUserModules frmAclUserModules = new FrmACLUserModules();
                frmAclUserModules.OptrId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
                frmAclUserModules.ShowDialog();
            }
            else
            {
                string name = baseDataGridView.SelectedCells[1].Value.ToString();
                //if (name == "rtadmin" || name == "rpadmin" || name == "raadmin" || name == "roadmin")
                //    MessageBox.Show("管理员拥有已分配最高权限！！");
                //else
                //{
                    FrmACLUserModules frmAclUserModules = new FrmACLUserModules();
                    frmAclUserModules.OptrId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
                    frmAclUserModules.ShowDialog();
                //}
            }


        }
    }
}
