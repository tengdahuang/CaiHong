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
    public partial class FrmAppMain : XSolo.BaseForm.FrmBMainForm
    {
        public FrmAppMain()
        {
            InitializeComponent();
        }

        private void FrmAppMain_Load(object sender, EventArgs e)
        {
            this.MainAsmName = "HSEMS";
            var table = BllFrmAppMain.GetUserAccessModules(UserStatics.OptrId);
            CreateMenuByIntColumn(table);

            FrmMainBoard mb = new FrmMainBoard();
            mb.MdiParent = this;
            mb.StartPosition = FormStartPosition.CenterScreen;
            mb.Tag = "FrmMainBoard";
            mb.Show();
        }

        /// <summary>
        /// 是否含有某id的子目录
        /// </summary>
        /// <param name="id">目录ID</param>
        /// <returns>true/false</returns>
        protected override bool IfHasChildren(long id)
        {
            return BllFrmAppMain.CheckIfHasChildren(id);
        }
    }
}
