using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using XSolo.Common;

namespace ChildCafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //这个开关用来debug以及试用web发布，false=不检测升级，true=检测升级
            bool UseUpdate = false;

            //初始化登陆用户
            //AccessSystem or = new AccessSystem();
            //or.AddOptrsAndRoles();

            //调用VersionCompare类判断是否版本过期
            //如果过期则启动升级程序，关闭主程序
            //如果非过期，则启动主程序

            if (UseUpdate)
            {
                VersionCompare v = new VersionCompare();
                Process myProcess = new Process();  //声明并创建新进程

                if (v.IsConfigFileExist)
                {
                    if (v.IsVersionExpired)
                    {

                        try
                        {
                            //设置myProcess进程信息
                            myProcess.StartInfo.FileName = @"AppUpdater.exe";
                            myProcess.StartInfo.CreateNoWindow = true;
                            myProcess.Start(); //打开进程
                        }
                        catch (Win32Exception f)
                        {
                            if (f.NativeErrorCode == 2) MessageBox.Show(f.Message);
                            else if (f.NativeErrorCode == 5) MessageBox.Show(f.Message);
                        }

                        Application.Exit();
                    }
                    else
                    {
                        FrmLogin login = new FrmLogin();
                        login.ShowDialog();
                        if (login.DialogResult.Equals(DialogResult.OK))
                        {
                            login.Dispose();
                            Application.Run(new FrmAppMain());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请检查是否存在软件升级列表或联系系统管理员！");
                    Application.Exit();
                }

            }
            else
            {
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                if (login.DialogResult.Equals(DialogResult.OK))
                {
                    login.Dispose();
                    Application.Run(new FrmAppMain());
                }
            }

        }
    }
}
