using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TDAccessControl.BLL;
using TDAccessControl.Common;
using TDAccessControl.DataAccess;

namespace TDAccessControl
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
            //1.取得所有action,生成checkbox,所有checkbox的checkchanged绑定一个action
            IList<MainModule> mainModules = BllACLUserModule.GetAllModules(UserStatics.Username);
            int j = 0;
            foreach (MainModule mainModule in mainModules)
            {
                var cb = new CheckBox { Name = mainModule.Name, Text = mainModule.ChineseName, Location = new System.Drawing.Point(0, j) };
                //cb.Name = mainAction.Id.ToString();
                //cb.AutoCheck = false;
                cb.Click += new System.EventHandler(this.CheckBoxClick); ;
                this.Controls.Add(cb);
                j += 20;
            }

            //2.取得这个Module的action,遍历control，如果checkbox的id = action.id,checkbox.checked = true
            mainModules = BllACLUserModule.GetOptrModules(OptrId);
            foreach (var c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ct = (CheckBox)c;
                    foreach (var mainAction in mainModules)
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
            MessageBox.Show("Entering!");
            if (((CheckBox)sender).CheckState == CheckState.Unchecked)
            {
                try
                {
                    BllACLUserModule.DeleteUserModule(OptrId, ((CheckBox)sender).Text);
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
                    BllACLUserModule.InsertUserModule(OptrId, ((CheckBox)sender).Text);
                }
                catch (DataException exception)
                {
                    MessageBox.Show("保存不成功,请联系开发者\n" + exception);
                }


            }
            MessageBox.Show("Exiting");
        }


    }
}
