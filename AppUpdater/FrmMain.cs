using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AppUpdater
{
    public partial class frmMain : Form
    {
        private String serverPath = "";
        private String targetPath = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //下载更新列表
            serverPath = GetServerPath();
            try
            {
                lbMessage.Text = "正在获取更新列表";
                this.GetConfigFile(serverPath);
            }
            catch (Exception)
            {
                lbMessage.Text = "获取更新列表失败，请联系管理员"; 
                throw;
            }
            
            
            pbFiles.Value = 0;
            pbFiles.Maximum = this.GetFileCount();

            if (DownLoadFiles())
            {
                MessageBox.Show("程序升级完毕，请重新运行软件！");
            }
            else
            {
                MessageBox.Show("升级出现问题，请稍后再试！");
            }

            this.Dispose();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private string GetServerPath()
        {
            string path = "";

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Config.xml");
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点


                foreach (XmlNode eachXmlNode in nodeList)
                {
                    XmlElement eachElement = (XmlElement)eachXmlNode;
                    if (eachElement.Name == "UpdatePath")
                    {
                        path = eachElement.InnerText;
                    }
                }


            }
            catch
            {
                lbMessage.Text = "ReadServerPath错误:找不到config.xml文件或该文件格式不正确！";
            }

            return path;
        }

        private void GetConfigFile(string svrPath)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(svrPath + "Config.xml","ConfigU.xml");
        }

        private bool DownLoadFiles()
        {
            WebClient myWebClient = new WebClient();
            string fileName = "";
            string sServerPath = ""; //欲下载文件的最终源目录

            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("ConfigU.xml");

                XmlNodeList nodeList1 = xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点
                foreach (XmlNode eachXmlNode1 in nodeList1)
                {
                    XmlElement eachElement1 = (XmlElement)eachXmlNode1;

                    if (eachElement1.Name == "FilesToDownload")
                    {

                        XmlNodeList nodeList2 = eachElement1.ChildNodes;//继续获取子节点的所有子节点
                        foreach (XmlNode eachXmlNode2 in nodeList2)
                        {
                            XmlElement eachElement2 = (XmlElement)eachXmlNode2;
                            if (eachElement2.Name == "SourcePath")
                            {
                                sServerPath = serverPath + eachElement2.InnerText;
                            }
                            if (eachElement2.Name == "TargetPath")
                            {
                                targetPath = eachElement2.InnerText;
                                lbMessage.Text = targetPath;
                            }
                            if (eachElement2.Name == "File")
                            {
                                fileName = eachElement2.InnerText;
                                sServerPath = sServerPath + fileName;

                                //MessageBox.Show("正在拷贝" + sServerPath);
            
                                myWebClient.DownloadFile(sServerPath, fileName);

                                if (!Directory.Exists(targetPath))
                                {
                                    //lbMessage.Text = "目标路径不存在，将自动创建。";
                                    Directory.CreateDirectory(targetPath);
                                }
                                //else
                                //{
                                //lbMessage.Text = "该目录已经存在，略过创建。";
                                //}

                                targetPath += fileName;

                                File.Move(fileName, targetPath);
                                pbFiles.Value += 1;

                            }

                        }
                    }
                }
                lbMessage.Text = "升级完毕！";

            }
            catch
            {
                lbMessage.Text = "DownLoadFiles错误:config.xml文件格式不正确或没有待下载文件！";
                return false;
            }
            return true;

        }
        private int GetFileCount()
        {
            int count = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ConfigU.xml");

            XmlNodeList nodeList1 = xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点
            foreach (XmlNode eachXmlNode1 in nodeList1)
            {
                XmlElement eachElement1 = (XmlElement)eachXmlNode1;

                if (eachElement1.Name == "FilesToDownload")
                {

                    XmlNodeList nodeList2 = eachElement1.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode eachXmlNode2 in nodeList2)
                    {
                        XmlElement eachElement2 = (XmlElement)eachXmlNode2;
                        if (eachElement2.Name == "File")
                        {
                            count++;

                        }
                    }
                }
            }
            return count;

        }
    }
}
