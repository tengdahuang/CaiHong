using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.Common;

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

        private void timerWarning_Tick(object sender, EventArgs e)
        {
            
            DbObjectList<BaseInfoMemberTester> bimt = BaseInfoMemberTester.Find(CK.K["FinishedDate"] < DateTime.Now && CK.K["Status"] == 0);
            int count = bimt.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    MessageBox.Show(bimt[i].Name + ",手机: " + bimt[i].Mobile + "\n 体验时间已到！请及时告知");
                    bimt[i].Status = "1";
                    bimt[i].Save();
                }
            }
            dgvTester.DataSource = null;
            dgvTester.DataSource = BllBaseInfoMemberTester.ReturnFinishedTester(UserStatics.OptrType);
        }

        private void FrmBaseInfoMemberTesterInput_Load(object sender, EventArgs e)
        {
            dgvTester.DataSource = BllBaseInfoMemberTester.ReturnFinishedTester(UserStatics.OptrType);
            timerWarning.Enabled = true;
        }

    }
}
