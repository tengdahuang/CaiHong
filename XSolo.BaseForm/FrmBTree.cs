// 包含TreeView的DataGridView基类窗体，用于普通CRUD
// *其中this.Tag在FrmBMainForm自动生成菜单时生成，包含三个信息 1. formName; 2. Id  3. ChineseName
// *
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using XSolo.Common;

namespace XSolo.BaseForm
{
    public partial class FrmBTree : Form
    {

        #region 窗体附加属性

        /// <summary>
        /// 用于用作选择窗口时的序号返回值
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// 用于设置该查询窗口不能双击
        /// </summary>
        public bool IsNoDoubleClick { get; set; }

        /// <summary>
        /// 记录当前DataGridView的所选值
        /// </summary>
        public long SelectedValue { get; set; }

        /// <summary>
        /// 用于生成DataGridView和TreeView的主要表格
        /// </summary>
        protected DataTable TableForLoad;

        /// <summary>
        /// 用于自动生成按钮
        /// </summary>
        protected DataTable ActionTable;

        /// <summary>
        /// 保护成员，用于设置是否载入树形
        /// </summary>
        protected bool IsTree { get; set; }

        /// <summary>
        /// 保护成员，用于设置载入树形时该树形只有2级
        /// </summary>
        protected bool IsTreeWithoutChildrens { get; set; }

        /// <summary>
        /// 保护成员，项目Assembly前缀
        /// </summary>
        protected string AsmName { get; set; }

        /// <summary>
        /// 保护成员，该表第一列ID在数据库中的实际名称
        /// </summary>
        protected string IdNameInTable { get; set; }

        /// <summary>
        /// 保护成员，用于生成树时的第一个节点名称
        /// </summary>
        protected string FormTreeRootName { get; set; }

        /// <summary>
        /// 保护成员，定义父级ID在数据表中的列名称，用于treeview中的中间变量和筛选父Id
        /// </summary>
        protected string ParentItemId { get; set; }

        /// <summary>
        /// 当前模块的Id
        /// </summary>
        protected long ModuleId { get; set; }

        protected bool IsDataGridViewToExcelShortDate { get; set; }

        /// <summary>
        /// 私有成员，用于记录点击datagridview时的该条记录的Id
        /// </summary>
        private string _itemId;

        protected long DeletingRowId;

        //protected DataTable treeTable;
        //protected DataTable dt;
        //protected string TreeItemId = "";
        #endregion

        public FrmBTree()
        {
            InitializeComponent();
        }

        #region 加载时初始化设置
        private void frmBTree_Load(object sender, EventArgs e)
        {
            //设置项目Assembly Name和一般数据表的Id名称，用于生成绑定treeview,datagridview等
            AsmName = "ChildCafe";
            IdNameInTable = "Id";
            FormTreeRootName = "所有";
            ParentItemId = "上一级";
            IsDataGridViewToExcelShortDate = false;

            if (Tag.ToString() != "")
            {
                ModuleId = long.Parse(this.Tag.ToString().Split('.')[1]);
                InitControls();
                InitData();
                CreateActionButtons();
                InitTree();
                reloadDataGridView();
                SetCountToolStripStatusLabel();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            if (IsSelect)
            {
                btnFind.Text = "选择";
            }
        }

        private void FrmBTree_Activated(object sender, EventArgs e)
        {
            tbFind.Focus();
        }

        /// <summary>
        /// 初始化控件数据
        /// </summary>
        virtual protected void InitControls()
        {

        }

        /// <summary>
        /// 初始化数据，一般是定义"菜单权限ActionTable"和"TableForLoad"。
        /// </summary>
        virtual protected void InitData()
        {

        }

        /// <summary>
        /// 初始化树形结构
        /// </summary>
        virtual protected void InitTree()
        {
            if (IsTree)
            {
                baseTreeView.Nodes.Clear();
                CreateTree(ref TableForLoad);
            }

        }

        virtual protected void resetDataGridView()
        {
            reloadDataGridView();
            SetCountToolStripStatusLabel();
        }

        /// <summary>
        /// 重新按照TableForLoad的内容加载数据到DataGridView.  
        /// 来源: XSolo.BaseForm.FrmBTree
        /// </summary>
        virtual protected void reloadDataGridView()
        {
            baseDataGridView.DataSource = null;
            baseBindingSource.DataSource = TableForLoad;
            baseDataGridView.DataSource = baseBindingSource;
        }

        #endregion 加载时初始化设置

        ///<summary>
        ///设置GridView必需隐藏的行
        /// </summary>
        protected void DataGridViewMustHideColumns()
        {
            if (baseDataGridView.Columns["IsDeleted"] != null) baseDataGridView.Columns["IsDeleted"].Visible = false;
            if (baseDataGridView.Columns[IdNameInTable] != null) baseDataGridView.Columns[IdNameInTable].Visible = false;
            if (baseDataGridView.Columns["用户类型"] != null) baseDataGridView.Columns["用户类型"].Visible = false;
        }

        /// <summary>
        /// 设置GridView显示的行
        /// </summary>
        virtual protected void SetDataGridViewColumns()
        {

        }

        #region 生成按钮栏
        /// <summary>
        /// 生成按钮栏入口
        /// </summary>
        /// <param name="mTable">DataTable</param>
        protected void CreateActionButtons()
        {
            //var dv = new DataView(ActionTable);
            ToolStripButton toolStripButton = null;
            if (ActionTable != null)
            {
                foreach (DataRow dr in ActionTable.Rows)
                {
                    int i = Int32.Parse(dr["ImageOrder"].ToString());
                    toolStripButton = new ToolStripButton();
                    toolStripButton.Image = baseImageList.Images[i];
                    toolStripButton.ImageTransparentColor = Color.Magenta;
                    toolStripButton.Name = dr["Name"].ToString();
                    toolStripButton.Size = new Size(50, 32);
                    toolStripButton.Text = dr["ChineseName"] + "(" + dr["ShortCut"] + ")";
                    toolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
                    toolStripButton.Click += new System.EventHandler(this.ButtonAll_Click);
                    toolStripButton.Tag = dr["ChineseName"].ToString();
                    toolStripButton.ToolTipText = GetToolTipText(dr["Name"].ToString());
                    baseToolStrip.Items.Add(toolStripButton);
                    //i++;

                }
            }
        }

        protected string GetToolTipText(string text)
        {
            switch (text)
            {
                case "ctAdd":
                    return "快捷键: Alt+A";
                case "ctEdit":
                    return "快捷键: Alt+E";
                case "ctDelete":
                    return "快捷键: Alt+D";
                case "ctRefresh":
                    return "快捷键: Alt+R";
                case "ctExport":
                    return "快捷键: Alt+X";
                case "ctClose":
                    return "快捷键: Alt+C";
                default:
                    return text;

            }

        }
        #endregion 生成按钮栏结束

        #region 生成树形
        /// <summary>
        /// 生成树的函数入口
        /// </summary>
        /// <param name="mTable">DataTable</param>
        /// <param name="FormTreeRootName">string</param>
        protected void CreateTree(ref DataTable mTable)
        {
            TreeNode tnRoot = null;
            tnRoot = this.baseTreeView.Nodes.Add(FormTreeRootName);
            tnRoot.Tag = "0";
            CreateFirstNode(ref tnRoot, ref mTable);
        }

        private void CreateFirstNode(ref TreeNode tnParent1, ref DataTable mTable)
        {
            TreeNode tnNew = null;

            var dv = new DataView(mTable)
                              {
                                  RowFilter = ParentItemId + " = ' " + long.Parse(tnParent1.Tag.ToString()) + " '"
                              };

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                string tnName = dr["中文名"].ToString();
                tnNew = tnParent1.Nodes.Add(tnName);
                tnNew.Tag = dr[IdNameInTable].ToString();
                CreateSecondNode(ref tnNew, ref mTable);
            }
        }

        private void CreateSecondNode(ref TreeNode tnParent2, ref DataTable mTable)
        {
            TreeNode tnNew = null;

            var dv = new DataView(mTable)
                         {
                             RowFilter = ParentItemId + " = ' " + long.Parse(tnParent2.Tag.ToString()) + " '"
                         };

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                string tnName = dr["中文名"].ToString();
                tnNew = tnParent2.Nodes.Add(tnName);
                tnNew.Tag = dr[IdNameInTable].ToString();
                CreateSecondNode(ref tnNew, ref mTable);
            }
        }

        protected void RefreshCurrentNode(ref DataTable mTable)
        {
            this.baseTreeView.SelectedNode.Nodes.Clear();
            TreeNode tnNew = null;
            string tnName;

            DataView dv = new DataView(mTable);
            dv.RowFilter = ParentItemId + " = " + long.Parse(baseTreeView.SelectedNode.Tag.ToString());

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                tnName = dr["中文名"].ToString();
                tnNew = this.baseTreeView.SelectedNode.Nodes.Add(tnName);
                tnNew.Tag = dr[IdNameInTable].ToString();
                CreateSecondNode(ref tnNew, ref mTable);
            }
        }

        protected void CreateTreeWithNoChildren(ref DataTable mTable)
        {
            this.baseTreeView.Nodes.Clear();

            TreeNode tnRoot = null;
            TreeNode tnNew = null;

            tnRoot = this.baseTreeView.Nodes.Add(FormTreeRootName);
            tnRoot.Tag = "0";
            foreach (DataRow dr in mTable.Rows)
            {
                string tnName = dr["中文名"].ToString();
                tnNew = tnRoot.Nodes.Add(tnName);
                tnNew.Tag = dr[ParentItemId].ToString();
            }
            tnRoot.ExpandAll();
        }

        #endregion 生成树形结束

        #region 树形操作
        private void baseTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!IsTreeWithoutChildrens)
            {
                TreeNode curNode = new TreeNode();
                curNode = e.Node;
                e.Node.Nodes.Clear();

                CreateFirstNode(ref curNode, ref TableForLoad);
            }
        }

        virtual protected void baseTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsTree)
            {
                if (e.Node.Tag.ToString() == "0")
                {
                    baseBindingSource.Filter = "";
                }
                else
                {
                    baseBindingSource.Filter = ParentItemId + "= ' " + long.Parse(e.Node.Tag.ToString()) + " '";
                }
                baseDataGridView.DataSource = baseBindingSource;
            }
            else
            {
                //reloadDataGridView(long.Parse(e.Node.Tag.ToString()));

            }


        }
        #endregion

        #region 按钮操作

        private void ButtonAll_Click(object sender, System.EventArgs e)
        {
            string fullName = ((ToolStripButton)sender).Tag.ToString();
            chooseAction(fullName);
        }

        protected void chooseAction(string fullName)
        {
            #region 新增
            if (fullName == "新增" && AsmName != "")
            {
                //如果不用继承，则可用Assembly.GetExecutingAssembly()代替
                Assembly asm = Assembly.Load(AsmName);//程序集名
                object frmObj = asm.CreateInstance(AsmName + "." + this.Name + "Edit");//程序集+form的类名。
                XSolo.BaseForm.FrmAddEdit frms = (XSolo.BaseForm.FrmAddEdit)frmObj;
                //Assembly asm = Assembly.GetExecutingAssembly();
                //object frmObj = asm.CreateInstance(asm.FullName + "." + this.Name + "Edit");//程序集+form的类名。
                //Type myType = asm.GetType(frmObj.ToString());
                //Object o = Activator.CreateInstance(myType);
                try
                {
                    frms.IsAdd = true;
                    frms.Text = this.Text + "<新增>";
                    frms.ShowDialog();
                    frms.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("可能没有该窗体的实例，有问题请联系电脑室\n" + ex);
                }
                InitData();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
                if (IsTree)
                {
                    RefreshCurrentNode(ref TableForLoad);
                }
            }
            #endregion 新增结束

            #region 修改
            if (fullName == "修改" && AsmName != "")
            {
                Assembly asm = Assembly.Load(AsmName);//程序集名
                object frmObj = asm.CreateInstance(AsmName + "." + this.Name + "Edit");//程序集+form的类名。
                FrmAddEdit frms = (FrmAddEdit)frmObj;

                //tag属性要重新写一次，否则在第二次的时候取不到。原因还不清楚。有知道的望告知。
                try
                {
                    frms.IsAdd = false;
                    frms.ItemID = _itemId;
                    frms.Text = this.Text + "<修改>";
                    frms.ShowDialog();
                    frms.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("当前没有可修改内容或没有该窗体，有问题请联系电脑室\n");
                }
                InitData();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
                if (IsTree)
                {
                    RefreshCurrentNode(ref TableForLoad);
                }
            }
            #endregion 编辑结束

            #region 删除
            if (fullName == "删除" && AsmName != "")
            {
                //删除记录
                if (MessageBox.Show("确认删除这(条/些)记录吗？", "询问",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (baseDataGridView.Rows.Count > 0)
                        {
                            int count = 0;

                            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
                            {
                                DeletingRowId = long.Parse(row.Cells[IdNameInTable].Value.ToString());
                                DeleteCurrentRow();
                                count++;
                            }
                            delCountToolStripStatusLabel.Text = "已删除" + count + "条记录！";
                            
                            resetDataGridView();
                            DataGridViewMustHideColumns();
                            SetDataGridViewColumns();
                            if (IsTree)
                            {
                                RefreshCurrentNode(ref TableForLoad);
                            }
                        }
                        else
                        {
                            MessageBox.Show("没有可删除的数据", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            #endregion 删除结束

            #region 刷新

            if (fullName == "刷新" && AsmName != "")
            {
                InitData();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
                if (IsTree)
                {
                    RefreshCurrentNode(ref TableForLoad);
                }
            }

            #endregion 刷新结束

            #region 关闭

            if (fullName == "关闭" && AsmName != "")
            {
                this.Close();
                this.Dispose();
            }

            #endregion 关闭结束

            #region 导出

            if (fullName == "导出" && AsmName != "")
            {
                if (IsDataGridViewToExcelShortDate)
                {
                    NPOIGvToExcel.DataGridViewToExcelShortDate(baseDataGridView);
                }
                else
                {
                    NPOIGvToExcel.DataGridViewToExcel(baseDataGridView);
                    //GvToExcel.DataGridViewToExcel(baseDataGridView);

                }
            }

            #endregion 导出结束

            #region 操作

            if (fullName == "操作" && AsmName != "")
            {
                SetOperation();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            #endregion 操作结束

            #region 导入

            if (fullName == "导入" && AsmName != "")
            {
                SetImportOptration();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            #endregion 导入结束

            #region 充值

            if (fullName == "充值" && AsmName != "")
            {
                SetRechargeOptration();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            #endregion 充值结束


            #region 耗材

            if (fullName == "耗材" && AsmName != "")
            {
                SetIngredientOptration();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            #endregion 耗材结束
            #region 历史

            if (fullName == "历史" && AsmName != "")
            {
                SetHistoryOptration();
                resetDataGridView();
                DataGridViewMustHideColumns();
                SetDataGridViewColumns();
            }

            #endregion 历史结束

        }



        #endregion 按钮操作结束


        virtual protected void SetOperation()
        {
            throw new NotImplementedException();
        }

        virtual protected void SetImportOptration()
        {
            throw new NotImplementedException();
        }

        virtual protected void SetRechargeOptration()
        {
            throw new NotImplementedException();
        }

        virtual protected void SetIngredientOptration()
        {
            throw new NotImplementedException();
        }

        virtual protected void SetHistoryOptration()
        {
            throw new NotImplementedException();
        }

        virtual protected void DeleteCurrentRow()
        {
            throw new NotImplementedException();
        }



        //virtual protected void reloadDataGridView(long id)
        //{

        //}

        virtual protected void reloadTree()
        {

        }


        virtual protected void baseDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.baseDataGridView.CurrentRow != null)
            {
                if (this.baseDataGridView.CurrentRow.Cells[IdNameInTable].Value != null)
                {
                    this._itemId = this.baseDataGridView.CurrentRow.Cells[IdNameInTable].Value.ToString();

                }
            }
        }

        virtual protected void baseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果窗体标记了选择，则返回窗体值
            if (IsSelect)
            {
                GetSelectedValue();
                this.Close();
            }
            //如果不允许双击，则不变动
            else if (IsNoDoubleClick)
            {

            }
            //其它
            else
            {
                //如果有修改的权限，则执行双击，否则什么都不做
                if (ActionTable != null)
                {
                    foreach (DataRow dr in ActionTable.Rows)
                    {
                        if (dr["ChineseName"].ToString() == "修改")
                        {
                            string fullName = ((DataGridView)sender).Tag.ToString();
                            chooseAction(fullName);
                        }

                    }
                }

            }

        }

        virtual protected void btnFind_Click(object sender, EventArgs e)
        {
            if (IsSelect)
            {
                GetSelectedValue();
                this.Close();
            }
            else
            {
                string s = SetFilterString();
                if (s != "")
                {
                    baseBindingSource.Filter = s;
                    baseDataGridView.DataSource = baseBindingSource;
                }
            }

        }

        /// <summary>
        /// 取得过滤字符串
        /// </summary>
        /// <returns>过滤字符串</returns>
        protected virtual string SetFilterString()
        {
            return "";
        }


        private void btDisplayAll_Click(object sender, EventArgs e)
        {
            baseBindingSource.Filter = "";
            baseDataGridView.DataSource = baseBindingSource;
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (SetFilterString() != "")
            {
                baseBindingSource.Filter = SetFilterString();
                baseDataGridView.DataSource = baseBindingSource;
                SetCountToolStripStatusLabel();
            }

        }

        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.Down)
            {
                baseBindingSource.MoveNext();
            }
            if (e.KeyCode == Keys.Up)
            {
                baseBindingSource.MovePrevious();
            }
        }



        private void baseDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                Clipboard.SetData("Text", Clipboard.GetText());
            }


        }

        /// <summary>
        /// 取得当前GridView所在指针下的Id值
        /// </summary>
        virtual protected void GetSelectedValue()
        {
            SelectedValue = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
        }

        virtual protected void baseDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        virtual protected void SetCountToolStripStatusLabel()
        {
            if (baseDataGridView.RowCount == 0)
            {
                countToolStripStatusLabel.Text = "总共有0条记录";
            }
            else
            {
                countToolStripStatusLabel.Text = "总共有" + baseDataGridView.RowCount.ToString() + "条记录";
            }
        }
        virtual protected void baseDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        //protected void setBaseBindingsource(DataSet ds, string s)
        //{
        //    baseBindingSource.DataSource = ds;
        //    baseBindingSource.DataMember = s;
        //}
    }
}
