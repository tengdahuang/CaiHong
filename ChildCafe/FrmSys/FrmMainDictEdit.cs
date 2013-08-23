using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Dal;
using ChildCafe.Common;
using XSolo.Common;


namespace ChildCafe
{
    public partial class FrmMainDictEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmMainDictEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            if (!IsAdd)
            {
                var dict = MainDict.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(dict, tabPage1);
            }
        }


        protected override void Saving()
        {
            if (IsAdd)
            {
                var dict = MainDict.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(dict, tabPage1);
                dict.OptrType = UserStatics.OptrType;
                dict.Save();
            }
            else
            {
                var dict = MainDict.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(dict, tabPage1);
                dict.OptrType = UserStatics.OptrType;
                dict.Save();
            }
        }


        private void ctDictType_Click(object sender, EventArgs e)
        {
            ctDictType.DataSource = BllMainDict.GetDictType(UserStatics.OptrType);
            ctDictType.DisplayMember = "Name";
        }
    }
}
