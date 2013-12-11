using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Dal;
using Lephone.Data;

namespace ChildCafe
{
    public partial class FrmBaseInfoMemberTesterInput : Form
    {
        public FrmBaseInfoMemberTesterInput()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string mobile = textBox1.Text;
            long number;
            bool result = long.TryParse(mobile, out number);
            long count = BaseInfoMemberTester.GetCount(CK.K["Mobile"] == mobile);

            if (result)
            {
                if (count == 0)
                {
                    FrmBaseInfoMemberTesterInput2 fbimti2 = new FrmBaseInfoMemberTesterInput2();
                    fbimti2.Mobile = mobile;
                    fbimti2.StartPosition = FormStartPosition.CenterParent;
                    fbimti2.ShowDialog();
                    fbimti2.Dispose();
                    textBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("该手机号客户已于" + BaseInfoMemberTester.FindOne(CK.K["Mobile"] == mobile).TestDate +
                                    "进行过体验!");
                }
            }
            else
            {
                MessageBox.Show("手机号只能为数字！");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
