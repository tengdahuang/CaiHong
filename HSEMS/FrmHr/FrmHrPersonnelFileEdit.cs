using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Dal;
using HSEMS.Common;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmHrPersonnelFileEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmHrPersonnelFileEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            ctSex.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "性别");
            ctSex.DisplayMember = "Name";

            ctMarries.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "婚姻状况");
            ctMarries.DisplayMember = "Name";

            ctPoliticalBackground.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "政治面貌");
            ctPoliticalBackground.DisplayMember = "Name";

            ctWorkShop.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "车间");
            ctWorkShop.DisplayMember = "Name";

            ctProcess.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工序");
            ctProcess.DisplayMember = "Name";

            ctPosition.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "职务");
            ctPosition.DisplayMember = "Name";

            ctProfessionalTitle.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "职称");
            ctProfessionalTitle.DisplayMember = "Name";

            ctWageGrade.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工资级别");
            ctWageGrade.DisplayMember = "Name";

            ctHighestEducation.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "学历");
            ctHighestEducation.DisplayMember = "Name";

            ctStatus.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "在职状态");
            ctStatus.DisplayMember = "Name";

            if (!IsAdd)
            {
                var obj = HrPersonnelFile.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            }
            else
            {
                ctBirthday.Value = DateTime.Now.Date;
                ctDateEmployed.Value = DateTime.Now.Date;
            }

        }

        protected override void DefineControlErrors()
        {
            if (ctCardNumber.Text == "") errorProvider.SetError(ctCardNumber, "卡号不能为空");
            else errorProvider.SetError(ctCardNumber, "");
            if (ctName.Text == "") errorProvider.SetError(ctName, "名称不能为空");
            else errorProvider.SetError(ctName, "");
            if (ctSex.Text == "") errorProvider.SetError(ctSex, "性别不能为空");
            else errorProvider.SetError(ctSex, "");
            if (ctHometown.Text == "") errorProvider.SetError(ctHometown, "籍贯不能为空");
            else errorProvider.SetError(ctHometown, "");
            if (ctHighestEducation.Text == "") errorProvider.SetError(ctHighestEducation,"学历不能为空");
            else errorProvider.SetError(ctHighestEducation,"");
            if (ctStatus.Text == "") errorProvider.SetError(ctStatus,"在职状态不能为空");
            else errorProvider.SetError(ctStatus,"");
        }

        protected override void Saving()
        {
            if (IsAdd)
            {

                var obj = HrPersonnelFile.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();


            }
            else
            {

                var obj = HrPersonnelFile.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();

            }
        }

        private void ctBirthday_ValueChanged(object sender, EventArgs e)
        {
            //int age = (DateTime.Now.Date- ctBirthday.Value.Date).Days;
            //ctAge.Text = age.ToString();
            //ctAgeType.Text = BllHrPersonnelFile.GetAgeType(age);
        }

    }
}
