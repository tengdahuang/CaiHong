using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmEquipmentAllQueryEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentAllQueryEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void FrmEquipmentAllQueryEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
        }

        protected override void Saving()
        {
            //设置flag，当取不到修复时间时，保存时继续确保修复时间为空
            int flag1 = 1, flag2 = 1;
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            if (obj.RestoreDate1 == null) flag1 = 0;
            if (obj.RestoreDate2 == null) flag2 = 0;
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            if (flag1 == 0) obj.RestoreDate1 = null;
            if (flag2 == 0) obj.RestoreDate2 = null;
            obj.Save();

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
