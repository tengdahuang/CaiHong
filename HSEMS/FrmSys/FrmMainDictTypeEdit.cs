using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using HSEMS.Common;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmMainDictTypeEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmMainDictTypeEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            if (!IsAdd)
            {
                var optr = MainDictType.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(optr, tabPage1);
            }

            if (UserStatics.OptrType != "All")
            {
                ctOptrType.Text = UserStatics.OptrType;
            }
        }

        protected override void Saving()
        {
            if (IsAdd)
            {
                var optr = MainDictType.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(optr, tabPage1);
                optr.Save();
            }
            else
            {
                var optr = MainDictType.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(optr, tabPage1);
                optr.Save();
            }
            

        }

        private void ctOptrType_Click(object sender, EventArgs e)
        {
            //除了All类型用户，其他用户直接显示它的类型
            if (UserStatics.OptrType == "All")
            {
                ctOptrType.DataSource = UserStatics.GetUserTypes(UserStatics.OptrId);
                ctOptrType.DisplayMember = "Name";
            }
            else
            {
                ctOptrType.Text = UserStatics.OptrType;
            }

        }



    }
}
