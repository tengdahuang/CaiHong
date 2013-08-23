using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.BLL;
using HSEMS.Dal;

namespace HSEMS
{
    public partial class FrmACLModuleAction : Form
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public long ModuleId { get; set; }

        public FrmACLModuleAction()
        {
            InitializeComponent();

        }

        private void FrmACLModuleAction_Load(object sender, EventArgs e)
        {
            ProduceControls();
        }

        private void ProduceControls()
        {
            //1.取得所有action,生成checkbox,所有checkbox的checkchanged绑定一个action
            List<MainAction> mainActions = BllACLModuleAction.GetActionList();
            int j = 0;
            foreach (MainAction mainAction in mainActions)
            {
                var cb = new CheckBox { Name = mainAction.Name,Text = mainAction.ChineseName, Location = new System.Drawing.Point(0, j) };
                //cb.Name = mainAction.Id.ToString();
                //cb.AutoCheck = false;
                cb.Click += new System.EventHandler(this.CheckBoxClick); ;
                this.Controls.Add(cb);
                j += 20;
            }

            //2.取得这个Module的action,遍历control，如果checkbox的id = action.id,checkbox.checked = true
            mainActions = BllACLModuleAction.GetModuleActions(ModuleId);
            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ct = (CheckBox)c;
                    foreach (var mainAction in mainActions)
                    {
                        if (((CheckBox)c).Name == mainAction.Name)
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
            if (((CheckBox)sender).CheckState == CheckState.Unchecked )
            {
                try
                {
                    BllACLModuleAction.DeleteModuleAction(ModuleId, ((CheckBox)sender).Text);
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
                    BllACLModuleAction.InsertModuleAction(ModuleId, ((CheckBox)sender).Text);
                }
                catch (DataException exception)
                {
                    MessageBox.Show("保存不成功,请联系开发者\n" + exception);
                }


            }
            //MessageBox.Show("Exiting");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    this.Controls.Remove((Control)c);
                }

            }
            ProduceControls();
        }
    }
}
