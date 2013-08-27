using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmAppMain : XSolo.BaseForm.FrmBMainForm
    {
        public FrmAppMain()
        {
            InitializeComponent();
            if (SystemVersion.GetSystemVertion() > 5)
                skinUI1.Active = false;
        }

        private void FrmAppMain_Load(object sender, EventArgs e)
        {
            this.MainAsmName = "ChildCafe";
            var table = BllFrmAppMain.GetUserAccessModules(UserStatics.OptrId);
            CreateMenuByIntColumn(table);
            WindowState = FormWindowState.Maximized;
            //FrmMainBoard mb = new FrmMainBoard();
            //mb.MdiParent = this;
            //mb.StartPosition = FormStartPosition.CenterScreen;
            //mb.Tag = "FrmMainBoard";
            //mb.Show();
        }

        /// <summary>
        /// 是否含有某id的子目录
        /// </summary>
        /// <param name="id">目录ID</param>
        /// <returns>true/false</returns>
        protected override bool IfHasChildren(int id)
        {
            return BllFrmAppMain.CheckIfHasChildren(id);
        }
    }
}
