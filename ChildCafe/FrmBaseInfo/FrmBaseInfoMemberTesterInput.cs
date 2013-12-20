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
using DotNetSpeech;

namespace ChildCafe
{
    public partial class FrmBaseInfoMemberTesterInput : Form
    {
        SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
        SpVoice sp = new SpVoice();

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
            string text = "";
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    text = bimt[i].Name + ",手机: " + bimt[i].Mobile + "\n 体验时间已到！请及时告知";
                    MessageBox.Show(text);
                    sp.Volume = 40;
                    sp.Speak(text, spFlags);
                    bimt[i].Status = "1";
                    bimt[i].Save();
                }
            }
            dgvTester.DataSource = null;
            dgvTester.DataSource = BllBaseInfoMemberTester.ReturnFinishedTester(UserStatics.OptrType);
        }

        private void FrmBaseInfoMemberTesterInput_Load(object sender, EventArgs e)
        {
            //sp.Volume = 40;
            //sp.Rate = -4;
            //sp.Speak("彩虹乐园欢迎您!黄腾达,手机:1 3 5 5 6 4 2 6 4 9 6 体验时间已到！", spFlags);
            dgvTester.DataSource = BllBaseInfoMemberTester.ReturnFinishedTester(UserStatics.OptrType);
            timerWarning.Enabled = true;
        }

    }
}
