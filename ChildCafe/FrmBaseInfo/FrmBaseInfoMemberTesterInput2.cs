﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Common;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoMemberTesterInput2 : Form
    {
        public string Mobile { get; set; }
        private string _pinyin;

        public FrmBaseInfoMemberTesterInput2()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            string name = textBox1.Text;
            string description = textBox2.Text;
            if (name == "")
            {
                MessageBox.Show("姓名不能为空!");
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }
            BaseInfoMemberTester bimt = BaseInfoMemberTester.New;
            bimt.Name = name;
            if (description == "")
            {
                bimt.Description = "无";
            }
            else
            {
                bimt.Description = description;
            }
            bimt.PinYin = AutoPinYin.GetPinYin(name);
            bimt.Mobile = Mobile;
            bimt.TestDate = nowTime;
            bimt.FinishedDate = nowTime.AddHours(1);
            bimt.Status = "0";
            bimt.OptrType = UserStatics.OptrType;
            bimt.Save();
            MessageBox.Show("录入完成，请您入园体验！");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
