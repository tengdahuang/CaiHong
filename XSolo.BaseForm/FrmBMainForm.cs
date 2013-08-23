using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;


namespace XSolo.BaseForm
{
    public partial class FrmBMainForm : Form
    {


        public FrmBMainForm()
        {
            InitializeComponent();
        }


        #region 窗体附加属性

        public string MainAsmName { get; set; }

        #endregion

        #region 窗体操作部分
        /// <summary>
        /// 窗体状态修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        //点击任务栏图标，恢复窗体
        private void notifyIconToTaskbar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                this.Activate();
            }
        }


        //如果窗体最小化，则直接隐藏到任务栏，如果是其他两种状态，则显示窗体
        private void FrmBMainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconToTaskbar.Visible = true;
            }

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIconToTaskbar.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        #endregion //结束窗体操作


        #region 动态创建GUID为编号的菜单

        /**/
        /// <summary>
        /// 根据数据库表动态创建以GUID为编号的菜单
        /// </summary>
        protected void CreateMenuByGuidColumn(ref DataTable mTable)
        {

            //定义一个主菜单
            mainMenu = new MenuStrip();
            try
            {

                //从XML中读取数据。数据结构后面详细讲一下。
                DataView dv = mTable.DefaultView;

                //MessageBox.Show("错误：" + dv[0]["Text"].ToString(), "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //通过DataView来过滤数据首先得到最顶层的菜单
                dv.RowFilter = "ParentID = '4d248cc4-aa91-4808-9c2a-0aa5d1de84ba'";
                for (int i = 0; i < dv.Count; i++)
                {
                    //创建一个菜单项,并且给菜单赋Text值。也就是在界面上看到的值
                    var topMenu = new ToolStripMenuItem { Text = dv[i]["ChineseName"].ToString() };

                    //如果是有下级菜单则通过CreateSubMenu方法来创建下级菜单
                    if (Convert.ToInt16(dv[i]["IsEndNode"]) == 0)
                    {
                        //以ref的方式将顶层菜单传递参数，因为他可以在赋值后再回传。－－也许还有更好的方法^_^.
                        CreateSubMenuByGuidColumn(ref topMenu, dv[i]["ItemID"].ToString(), mTable);
                    }
                    //显示应用程序中已打开的 MDI 子窗体列表的菜单项
                    mainMenu.MdiWindowListItem = topMenu;
                    //将递归附加好的菜单加到菜单根项上。
                    mainMenu.Items.Add(topMenu);
                }
                mainMenu.Dock = DockStyle.Top;
                //将窗体的MainMenuStrip梆定为mainMenu.
                MainMenuStrip = mainMenu;
                //这句很重要。如果不写这句菜单将不会出现在主窗体中。
                Controls.Add(mainMenu);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " 您没有有效设置或连接数据库！程序无法运行！");

            }
        }

        /**/
        /// <summary>
        /// 创建以GUID为编号的子菜单
        /// </summary>
        /// <param name="topMenu">父菜单项</param>
        /// <param name="itemId">父菜单的ID</param>
        /// <param name="dt">所有菜单数据集</param>
        private void CreateSubMenuByGuidColumn(ref ToolStripMenuItem topMenu, string itemId, DataTable dt)
        {
            //过滤出当前父菜单下在所有子菜单数据(仅为下一层的)
            var dv = new DataView(dt) { RowFilter = "ParentID = '" + itemId + "' " };

            for (int i = 0; i < dv.Count; i++)
            {
                //创建子菜单项
                var subMenu = new ToolStripMenuItem { Text = dv[i]["ChineseName"].ToString() };
                //如果还有子菜单则继续递归加载。
                if (Convert.ToInt16(dv[i]["IsEndNode"]) == 0)
                {
                    //递归调用
                    CreateSubMenuByGuidColumn(ref subMenu, dv[i]["ItemID"].ToString(), dt);
                }
                else
                {
                    //扩展属性可以加任何想要的值。这里用formName属性来加载窗体。
                    subMenu.Tag = dv[i]["Name"].ToString();
                    //给没有子菜单的菜单项加事件。
                    subMenu.Click += SubMenuClick;
                }
                //if (dv[i]["ImageName"].ToString().Length > 0)
                //{
                //    ////设置菜单项前面的图票为16X16的图片文件。
                //    //Image img = Image.FromFile(@"..\..\Image\" + dv[i]["ImageName"].ToString());
                //    //subMenu.Image = img;
                //    //subMenu.Image.Tag = dv[i]["ImageName"].ToString();
                //}
                //将菜单加到顶层菜单下。
                topMenu.DropDownItems.Add(subMenu);
            }
        }
        #endregion 动态创建菜单结束



        #region 动态创建bigint为编号的菜单

        /**/
        /// <summary>
        /// 根据数据库表动态创建以数字为编号的菜单
        /// </summary>
        protected void CreateMenuByIntColumn(DataTable mTable)
        {

            //定义一个主菜单
            //mainMenu = new MenuStrip();
            try
            {
                DataView dv = mTable.DefaultView;

                //MessageBox.Show("错误：" + dv[0]["Text"].ToString(), "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                //通过DataView来过滤数据首先得到最顶层的菜单
                dv.RowFilter = "ParentID = 0";
                for (int i = 0; i < dv.Count; i++)
                {
                    //创建一个菜单项,并且给菜单赋Text值。也就是在界面上看到的值
                    var topMenu = new ToolStripMenuItem { Text = dv[i]["ChineseName"].ToString() };

                    //如果是有下级菜单则通过CreateSubMenu方法来创建下级菜单
                    //if (Convert.ToInt16(dv[i]["IsEndNode"]) == 0)
                    if (IfHasChildren((int)dv[i]["Id"]))
                    {
                        //以ref的方式将顶层菜单传递参数，因为他可以在赋值后再回传。－－也许还有更好的方法^_^.
                        CreateSubMenuByIntColumn(topMenu, (int)dv[i]["Id"] , mTable);
                    }
                    //显示应用程序中已打开的 MDI 子窗体列表的菜单项
                    mainMenu.MdiWindowListItem = topMenu;
                    //将递归附加好的菜单加到菜单根项上。
                    mainMenu.Items.Add(topMenu);
                }
                mainMenu.Dock = DockStyle.Top;
                //将窗体的MainMenuStrip梆定为mainMenu.
                MainMenuStrip = mainMenu;
                //这句很重要。如果不写这句菜单将不会出现在主窗体中。
                //Controls.Add(mainMenu);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " 您没有有效设置或连接数据库！程序无法运行！");

            }
        }

        /**/
        /// <summary>
        /// 创建以bigint为编号的子菜单
        /// </summary>
        /// <param name="topMenu">父菜单项</param>
        /// <param name="itemId">父菜单的ID</param>
        /// <param name="dt">所有菜单数据集</param>
        private void CreateSubMenuByIntColumn(ToolStripMenuItem topMenu, int itemId, DataTable dt)
        {
            //过滤出当前父菜单下在所有子菜单数据(仅为下一层的)
            var dv = new DataView(dt) { RowFilter = "ParentID = '" + itemId + "' " };

            for (int i = 0; i < dv.Count; i++)
            {
                //如果是分割线，则不注册submenuClick
                if (dv[i]["Name"].ToString() == "-")
                {
                    var sep = new ToolStripSeparator();
                    sep.Name = dv[i]["Id"].ToString();
                    topMenu.DropDownItems.Add(sep);

                }
                else
                {
                    //创建子菜单项
                    var subMenu = new ToolStripMenuItem();


                    //如果还有子菜单则继续递归加载。
                    if (IfHasChildren((int)dv[i]["Id"]))
                    {
                        //递归调用
                        CreateSubMenuByIntColumn(subMenu, (int)dv[i]["Id"], dt);
                    }
                    else
                    {

                        subMenu.Text = dv[i]["ChineseName"].ToString();
                        //扩展属性可以加任何想要的值。
                        subMenu.Tag = dv[i]["Name"] + "." + dv[i]["Id"] + "." + dv[i]["ChineseName"];
                        //给没有子菜单的菜单项加事件。
                        subMenu.Click += SubMenuClick;


                    }
                    topMenu.DropDownItems.Add(subMenu);

                }
                
                //if (dv[i]["ImageName"].ToString().Length > 0)
                //{
                //    ////设置菜单项前面的图票为16X16的图片文件。
                //    //Image img = Image.FromFile(@"..\..\Image\" + dv[i]["ImageName"].ToString());
                //    //subMenu.Image = img;
                //    //subMenu.Image.Tag = dv[i]["ImageName"].ToString();
                //}
                //将菜单加到顶层菜单下。

            }
        }
 
        #endregion 动态创建int为编号的菜单结束


        #region 菜单单击事件及打开子窗体
        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubMenuClick(object sender, EventArgs e)
        {
            //tag属性在这里有用到。
            string fullName = ((ToolStripMenuItem)sender).Tag.ToString();
            if (fullName.Split('.')[0] == "FrmMainExit")
            {
                Application.Exit();
            }
            else
            {
                CreateFormInstance(fullName);
            }

        }

        /**/
        /// <summary>
        /// 创建form实例。并且不会出现窗体重复打开。
        /// </summary>
        /// <param name="formName">form的类名</param>
        public void CreateFormInstance(string formName)
        {

            bool flag = false;
            //遍历主窗口上的所有子菜单
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                //如果所点的窗口被打开则重新激活，窗体必须要有tag属性
                ///* MainModel.cs --> CutString(string)

                    if (MdiChildren[i].Tag.ToString().ToLower() == formName.ToLower())
                    {
                        MdiChildren[i].Activate();
                        MdiChildren[i].WindowState = FormWindowState.Normal;
                        MdiChildren[i].Show();
                        flag = true;
                        break;
                    }

            }
            if (!flag)
            {
                //如果不存在则用反射创建form窗体实例。
                try
                {
                    ReflectShowForm(formName);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("无此窗口！\n " + ex);
                }

            }
        }
        /// <summary>
        /// 反射生成窗体
        /// </summary>
        /// <param name="formName">string</param>
        private void ReflectShowForm(string formName)
        {
            string myFormName = formName.Split('.')[0];
            Assembly asm = Assembly.Load(MainAsmName);//程序集名
            object frmObj = asm.CreateInstance(MainAsmName + "." + myFormName);//程序集+form的类名。
            var frms = (Form)frmObj;

            //tag属性要重新写一次，否则在第二次的时候取不到。原因还不清楚。有知道的望告知。
            //frms.Tag = this.CutString(formName);
            //frms.WindowState = FormWindowState.Normal;
            frms.Text = formName.Split('.')[2];
            frms.StartPosition = FormStartPosition.CenterScreen;
            frms.Tag = formName;
            frms.MdiParent = this;
            frms.Show();
        }

        #endregion 菜单单击事件及打开子窗体

        //#region 截取从数据库取出的fullNmae成formName
        //protected string CutString(string fullName)
        //{
        //    int lastIndex = fullName.LastIndexOf(".");
        //    lastIndex++;
        //    string formName = fullName.Substring(lastIndex);
        //    return formName;
        //}
        //#endregion

        /// <summary>
        /// 是否含有某id的子目录
        /// </summary>
        /// <param name="id">目录ID</param>
        /// <returns>true/false</returns>
        virtual protected bool IfHasChildren(int id)
        {
            return false;
        }











    }
}
