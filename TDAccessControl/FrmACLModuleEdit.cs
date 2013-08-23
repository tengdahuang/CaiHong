using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TDAccessControl.BLL;
using TDAccessControl.DataAccess;
using XSolo.Common;

namespace TDAccessControl
{
    public partial class FrmACLModuleEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmACLModuleEdit()
        {
            InitializeComponent();
        }

        private void FrmACLModuleEdit_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                ctParentId.DataSource = BllACLModule.GetAllSysMenu();
                ctParentId.DisplayMember = "ChineseName";
                ctParentId.ValueMember = "Id";
            }
            else
            {

                MainModule mm = MainModule.FindById(long.Parse(ItemID));
                ctParentId.DataSource = BllACLModule.GetAllSysMenu();
                ctParentId.DisplayMember = "ChineseName";
                ctParentId.ValueMember = "Id";
                ctParentId.SelectedItem = BllACLModule.GetMainModuleByParentID(mm.ParentId).ChineseName;

                FrmAddEditBind.BindObjectToControls(mm, tabPage1);


            }
        }

        protected override void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                var currentMainModule = MainModule.New;
                FrmAddEditBind.BindControlsToObject(currentMainModule, tabPage1);
                currentMainModule.Save();
            }
            else
            {
                var currentMainModule = MainModule.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindControlsToObject(currentMainModule, tabPage1);
                currentMainModule.Save();
                Close();
            }
        }
    }
}