using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSolo.Common;

namespace XSolo.BaseForm
{
    public partial class FrmAddEdit : Form
    {
        protected DataRowView bDataRow;

        public FrmAddEdit()
        {
            InitializeComponent();
        }

        #region 私有属性

        public string ItemID { get; set; }

        public bool IsAdd { get; set; }



        #endregion 私有属性结束

        
        protected void FrmAddEdit_Load(object sender, EventArgs e)
        {
            Loading();
            Loaded();

        }

        virtual protected void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        virtual protected void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DefineControlErrors();
                StringBuilder sErrorList = new StringBuilder();

                foreach (Control ctrl in tabPage1.Controls)
                {
                    if (errorProvider.GetError(ctrl).Length > 0)
                        sErrorList.AppendLine(errorProvider.GetError(ctrl));
                }

                if (sErrorList.Length == 0)
                {
                    //BeforeSave();
                    Saving();
                    Saved();
                    AfterSave();
                }
                else
                {
                    MessageBox.Show(sErrorList.ToString());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("保存有错误，请检查输入\n" + ex);
            }

        }

        /// <summary>
        /// 新增的时候可以用这个清除已输入项的内容，刷新控件
        /// </summary>
        protected virtual void ClearControls()
        {
            if (IsAdd)
            {
                FrmAddEditBindComboBoxText.ClearCntrValue(tabControl1);
            }
        }

        /// <summary>
        /// 新增的时候可以用这个重置已输入的数值内容，刷新控件
        /// </summary>
        protected virtual void ResetNumbericUpdown()
        {
            if (IsAdd)
            {
                FrmAddEditBindComboBoxText.ReSetNumbericUpDownValue(tabControl1);
            }
        }

        protected virtual void DefineControlErrors()
        {

        }

        //protected virtual void BeforeSave()
        //{

        //}

        /// <summary>
        /// 用于保存完成后的处理，比如初始化控件
        /// </summary>
        protected  virtual void AfterSave()
        {
            
        }

        virtual protected void Saving()
        {

        }

        virtual protected void Saved()
        {
            MessageBox.Show("已保存!");
        }

        virtual protected void Loading()
        {

        }

        virtual protected void Loaded()
        {

        }

        private void FrmAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

    }
}
