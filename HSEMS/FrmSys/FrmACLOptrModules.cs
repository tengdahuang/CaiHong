using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using HSEMS.Bll;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmACLUserModules : Form
    {
        public long OptrId { get; set; }

        public FrmACLUserModules()
        {
            InitializeComponent();
        }


        private void FrmACLUserModules_Load(object sender, EventArgs e)
        {
            ProduceControls();
        }

        private void ProduceControls()
        {
            //1.取得所有Module,生成checkbox,所有checkbox的checkchanged绑定一个Module
            IList<MainModule> mainModules = BllACLOptrModule.GetAllModules(UserStatics.OptrName);
            
            
            int count = mainModules.Count;
            int tmp = 0;
            for (int i = 0; i < count; i++)
            {
                int n = i%16;
                if (n == 0 && i != 0)
                    tmp++;
                int x = tmp*185, y = n*25;
                var cb = new CheckBox { Name = mainModules[i].Name + "." + mainModules[i].Id, Text = mainModules[i].ChineseName, Size = new Size(100, 23), Location = new Point(x + 10, y + 20) };
                var bt = new Button { Name = mainModules[i].Name + "." + mainModules[i].Id, Text = "操作设置", Size = new Size(75, 23), Location = new Point(x+110, y+20) };
                cb.Click += new System.EventHandler(this.CheckBoxClick); ;
                bt.Click += ButtonClick;
                this.Controls.Add(cb);
                this.Controls.Add(bt);

            }

            //2.取得这个Optr的Module,遍历control，如果checkbox的id = Module.id,checkbox.checked = true
            mainModules = BllACLOptrModule.GetOptrModules(OptrId);
            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    //CheckBox ct = (CheckBox)c;
                    foreach (var mainAction in mainModules)
                    {
                        if (((CheckBox)c).Name.Split('.')[1] == mainAction.Id.ToString())
                        {
                            ((CheckBox)c).Checked = true;
                        }
                    }
                }

            }
            //3.如果点击某个checkbox，取得这个checkbox的id的checked状态
            //4.如果为checked，则为module添加一条该操作的记录
            //5.如果不为checked，则查找是否有操作记录，如果有，删除该条记录
        }

        private void CheckBoxClick(object sender, System.EventArgs e)
        {
            //MessageBox.Show("Entering!");
            if (((CheckBox)sender).CheckState == CheckState.Unchecked)
            {
                try
                {
                    BllACLOptrModule.DeleteUserModule(OptrId, long.Parse(((CheckBox)sender).Name.Split('.')[1]));
                }
                catch (Exception exception)
                {
                    MessageBox.Show("删除不成功,请联系开发者\n" + exception);
                }

            }
            else
            {
                try
                {
                    BllACLOptrModule.InsertUserModule(OptrId, long.Parse(((CheckBox)sender).Name.Split('.')[1]));
                }
                catch (DataException exception)
                {
                    MessageBox.Show("保存不成功,请联系开发者\n" + exception);
                }


            }
            //MessageBox.Show("Exiting");
        }

        private void ButtonClick(object sender, System.EventArgs e)
        {
            FrmACLOptrActions frmAclOptrActions = new FrmACLOptrActions();
            frmAclOptrActions.OptrId = this.OptrId;
            frmAclOptrActions.ModuleId = long.Parse(((Button) sender).Name.Split('.')[1]);
            frmAclOptrActions.ShowDialog();
        }


    }
}
