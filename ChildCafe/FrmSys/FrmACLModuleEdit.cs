using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmACLModuleEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmACLModuleEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
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

        protected override void Saving()
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