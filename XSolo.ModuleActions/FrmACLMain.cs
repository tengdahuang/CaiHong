using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSolo.ModuleActions.BLL;

namespace XSolo.ModuleActions
{
    public partial class FrmACLMain : XSolo.BaseForm.FrmBMainForm
    {
        public FrmACLMain()
        {
            InitializeComponent();
        }

        private void FrmAppMain_Load(object sender, EventArgs e)
        {
            this.MainAsmName = "XSolo.ModuleActions";
            //var mTable = BllFrmAppMain.GetUserAccessModules(Common.UserStatics.UserId);
            var table = BllACLMain.GetAccessModules();
            CreateMenuByIntColumn(table);
        }


        /// <summary>
        /// 是否含有某id的子目录
        /// </summary>
        /// <param name="id">目录ID</param>
        /// <returns>true/false</returns>
        protected override bool IfHasChildren(long id)
        {
            return BllACLMain.CheckIfHasChildren(id);
        }
    }
}
