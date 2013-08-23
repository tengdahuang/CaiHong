using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XSolo.BaseForm
{
    public partial class FrmBUserManagement : Form
    {
        public FrmBUserManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生成员工树的函数入口
        /// </summary>
        /// <param name="mTableEmployee">ref DataTable</param>
        protected void CreateFirstTree(ref DataTable mTableEmployee)
        {
            TreeNode tnRoot = null;
            tnRoot = this.tvEmployee.Nodes.Add("员工");
            tnRoot.Tag = "4d248cc4-aa91-4808-9c2a-0aa5d1de84ba";

            TreeNode tnNew = null;
            string tnName;
            bool isOperator = true;

            DataView dv = new DataView(mTableEmployee);


            foreach (DataRow dr in dv.ToTable().Rows)
            {
                isOperator = IsOperator(new Guid(dr["ItemID"].ToString()));

                if (isOperator == false)
                {
                    tnName = dr["Name"].ToString();
                    tnNew = tnRoot.Nodes.Add(tnName);
                    tnNew.Tag = dr["ItemID"].ToString();
                }
            }
                tnRoot.Expand();

        }

        /// <summary>
        /// 生成操作用户树的函数入口
        /// </summary>
        /// <param name="mTableSysUser">ref DataTable</param>
        protected void CreateSecondTree(ref DataTable mTableSysUser)
        {
            TreeNode tnRoot = null;
            tnRoot = this.tvEmployee.Nodes.Add("操作用户");
            tnRoot.Tag = "4d248cc4-aa91-4808-9c2a-0aa5d1de84ba";

            TreeNode tnNew = null;
            string tnName;

            DataView dv = new DataView(mTableSysUser);

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                tnName = dr["Name"].ToString();
                tnNew = tnRoot.Nodes.Add(tnName);
                tnNew.Tag = dr["EmployeeID"].ToString();
            }
            tnRoot.Expand();
        }

        protected void tvEmployee_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode tn = e.Item as TreeNode;
            //根节点不允许拖放操作
            if ((e.Button == MouseButtons.Left) && (tn != null) && (tn.Parent != null))
            {
                this.tvEmployee.DoDragDrop(tn, DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Link);
            }
        }

        protected void tvEmployee_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        protected void tvEmployee_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));

                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);

                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (DestinationNode.Text == "操作用户")
                {
                    //新建一个用户名=当前拖动用户，并且EmployeeID=当前拖动用户的操作用户
                    if (DoOperatorAdding(NewNode))
                    {
                        DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                        DestinationNode.Expand();
                        //删除已经移动的节点
                        NewNode.Remove();
                    }

                }

                if (DestinationNode.Text == "员工")
                {
                    //删除当前拖动用户在SysUser表的记录
                    if (DoOperatorDeleting(NewNode))
                    {   
                        DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                        DestinationNode.Expand();
                        //删除已经移动的节点
                        NewNode.Remove();
                    }

                    
                }
            }
        }

        /// <summary>
        /// first向second拖动节点所做的操作，其中节点本身已经移动，这个是可选的附加操作，比如数据库操作。只有返回true才执行移动操作
        /// </summary>
        /// <param name="nodeName">当前节点</param>
        /// <returns>bool类型</returns>
        protected virtual bool DoOperatorAdding(TreeNode nodeName)
        {
            return false;
        }

        /// <summary>
        /// second向first拖动节点所做的操作，其中节点本身已经移动，这个是可选的附加操作，
        /// 比如数据库操作。只有返回true才执行移动操作
        /// </summary>
        /// <param name="nodeName">当前节点</param>
        /// <returns>bool类型</returns>
        protected virtual bool DoOperatorDeleting(TreeNode nodeName)
        {
            return false;
 
        }

        /// <summary>
        /// 第一次生成节点时的附加操作，只有它为真才添加节点
        /// </summary>
        /// <param name="nodeName"></param>
        /// <returns>true</returns>
        protected virtual bool IsOperator(Guid nodeName)
        {
            return false;

        }

    }
}
