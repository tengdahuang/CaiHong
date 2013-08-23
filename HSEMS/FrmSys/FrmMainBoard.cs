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
    public partial class FrmMainBoard : Form
    {
        public FrmMainBoard()
        {
            InitializeComponent();
        }

        private void FrmMainBoard_Load(object sender, EventArgs e)
        {

            //取得该用户的所有模块权限
            var table = BllFrmAppMain.GetUserAccessModules(UserStatics.OptrId);
            SetButtons(table);
            GetCounts();


        }

        private void GetCounts()
        {
            ctFrmEquipmentAccept.Text = "待接单数" + BllEquipmentAccept.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentRepairFirst.Text = "待维修数" + BllEquipmentRepairFirst.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentRepairSecond.Text = "未修复数" + BllEquipmentRepairSecond.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentProductHandle.Text = "待处理数" + BllEquipmentProductHandle.GetCount(UserStatics.OptrType) + "台";

            if (UserStatics.OptrType == "Test")
            {
                //todo 增加工装录入
                ctFrmTechnologicalEquipmentOverrun.Text = "失效工装" + BllTechnologicalEquipment.GetTableTestOverrunCount() + "台";
                ctFrmTechnologicalEquipmentSharpening.Text = "待磨工装" + BllTechnologicalEquipment.GetTableTestSharpeningCount() + "台";

            }

            ctFrmEquipmentOfflineRepair.Text = "待接单数" + BllEquipmentOffline.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentVariationAccept.Text = "变更接单" + BllEquipmentVariationAccept.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentVariationHandle.Text = "变更处理" + BllEquipmentVariationHandle.GetCount(UserStatics.OptrType) + "台";

            ctFrmEquipmentVariationHandle2.Text = "变更未完成" + BllEquipmentVariationHandle2.GetCount(UserStatics.OptrType) + "台";

        }

        private void SetButtons(DataTable dt)
        {
            DataView dv = dt.DefaultView;

            //将所有ct开头的按钮全部隐藏
            foreach (var c in this.Controls)
            {
                if (c is Button)
                {

                    Button ct = (Button)c;
                    if (ct.Name.StartsWith("ct"))
                    {
                        ct.Visible = false;
                        ct.Click += new System.EventHandler(this.CheckBoxClick); ;
                    }

                }
            }

            ///2.遍历控件，如果窗体名=ct+控件名+，则按钮显示
            foreach (var c in this.Controls)
            {
                if (c is Button)
                {
                    Button ct = (Button)c;
                    foreach (DataRowView dataRowView in dv)
                    {
                        if (ct.Name.StartsWith("ct") && ct.Name == "ct" + dataRowView.Row["Name"])
                        {
                            ct.Visible = true;
                            ct.Tag = dataRowView.Row["Name"] + "." + dataRowView.Row["Id"] + "." + dataRowView.Row["ChineseName"];

                        }
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCounts();
        }

        private void CheckBoxClick(object sender, System.EventArgs e)
        {
            ((FrmAppMain)this.MdiParent).CreateFormInstance(((Button)sender).Tag.ToString());

        }
    }
}
