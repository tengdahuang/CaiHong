using System;
using System.Xml;
using System.Windows.Forms;

namespace XSolo.Common
{
	/// <summary>
	/// 用来处理config.xml文件的类
	/// 待优化，把取得连接的方法做成一个，这样只需要读取config.xml文件一次
	/// </summary>
	public class ConfigManagement
	{

		//获取升级服务器地址
		public string GetUpdatePath()
		{
			string a="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点


				foreach(XmlNode eachXmlNode in nodeList)
				{
					XmlElement eachElement = (XmlElement)eachXmlNode;
					if(eachElement.Name=="UpdatePath")
					{
						a = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath错误:找不到客户端config.xml文件或该文件格式不正确！");
			}

			a = a + "config.xml";

			return a;
		}

		//获取数据库连接地址
		public string GetConnectionString()
		{
			string a="",b="",c="",d="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点


				foreach(XmlNode eachXmlNode in nodeList)
				{
					XmlElement eachElement = (XmlElement)eachXmlNode;
					if(eachElement.Name=="DatabaseAddress")
					{
						a = eachElement.InnerText;
					}
					if(eachElement.Name=="DatabaseName")
					{
						b = eachElement.InnerText;
					}
					if(eachElement.Name=="UserName")
					{
						c = eachElement.InnerText;
					}
					if(eachElement.Name=="UserPassword")
					{
						d = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath错误:找不到客户端config.xml文件或该文件格式不正确！");
			}

			string connectStr="Data Source="+a+";Initial Catalog="+b+";User ID="+c+";Pwd="+d+";";
			return connectStr;

		}

	}
}
