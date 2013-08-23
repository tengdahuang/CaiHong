using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Dal;

namespace HSEMS
{
    public partial class FrmACLOptrActions : Form
    {
        public long OptrId { get; set; }
        public long ModuleId { get; set; }

    public FrmACLOptrActions()
        {
            InitializeComponent();

        }

    private void FrmACLOptrActions_Load(object sender, EventArgs e)
    {
        ProduceControls();
    }
    private void ProduceControls()
    {
        //1.取得所有action,生成checkbox,所有checkbox的checkchanged绑定一个action
        IList<MainAction> mainActions = BllACLOptrAction.GetAllActions(ModuleId);


        int count = mainActions.Count;
        int tmp = 0;
        for (int i = 0; i < count; i++)
        {
            int n = i % 18;
            if (n == 0 && i != 0)
                tmp++;
            int x = tmp * 160, y = n * 25;
            var cb = new CheckBox { Name = mainActions[i].Name + '.' + mainActions[i].Id, Text = mainActions[i].ChineseName, Size = new Size(75, 23), Location = new Point(x + 10, y) };
            cb.Click += new System.EventHandler(this.CheckBoxClick); ;
            this.Controls.Add(cb);

        }

        //2.取得这个Optr的action,遍历control，如果checkbox的id = action.id,checkbox.checked = true
        mainActions = BllACLOptrAction.GetOptrActions(OptrId,ModuleId);
        foreach (var c in this.Controls)
        {
            if (c is CheckBox)
            {
                //CheckBox ct = (CheckBox)c;
                foreach (var mainAction in mainActions)
                {
                    if (((CheckBox)c).Name.Split('.')[0] == mainAction.Name)
                    {
                        ((CheckBox)c).Checked = true;
                    }
                }
            }

        }

    }

    private void CheckBoxClick(object sender, System.EventArgs e)
    {
        //MessageBox.Show("Entering!");
        //3.如果点击某个checkbox，取得这个checkbox的id的checked状态
        //4.如果为checked，则为module添加一条该操作的记录
        //5.如果不为checked，则查找是否有操作记录，如果有，删除该条记录
        if (((CheckBox)sender).CheckState == CheckState.Unchecked)
        {
            try
            {
                BllACLOptrAction.DeleteOptrAction(OptrId, ModuleId, long.Parse(((CheckBox)sender).Name.Split('.')[1]));
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
                BllACLOptrAction.InsertOptrAction(OptrId, ModuleId, long.Parse(((CheckBox)sender).Name.Split('.')[1]));
            }
            catch (DataException exception)
            {
                MessageBox.Show("保存不成功,请联系开发者\n" + exception);
            }


        }
        //MessageBox.Show("Exiting");
    }
    }
}
