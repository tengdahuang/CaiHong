namespace XSolo.Common
{
	using System;
	using System.Xml;
	using System.IO;
	using System.Windows.Forms;

	/// <summary>
	/// versionCompare 的摘要说明。
	/// </summary>
	public class VersionCompare
	{
		private bool isVersionExpired = false;

		public bool IsConfigFileExist {get {return GetConfigFile();}}

		public bool IsVersionExpired {get {return NeedToUpdate();}}


		//判断配置文件是否存在
		private bool GetConfigFile()
		{
			XmlDocument xmlDoc=new XmlDocument();

			if (!File.Exists("config.xml"))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		//读取升级服务器地址
		private string GetServerPath()
		{
			string path="";

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
						path = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath错误:找不到客户端config.xml文件或该文件格式不正确！");
			}

			path = path + "config.xml";

			return path;
		}

		//获取升级服务器上面配置文件里面的版本信息
		private string GetServerVersion()
		{
			string version="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load(GetServerPath());
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点


				foreach(XmlNode eachXmlNode in nodeList)
				{
					XmlElement eachElement = (XmlElement)eachXmlNode;
					if(eachElement.Name=="CurrentVersion")
					{
						version = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath错误:找不到服务器端config.xml文件或该文件格式不正确！");
			}

			return version;
		}

		//获取当前客户端上面配置文件里面的版本信息
		private string GetClientVersion()
		{
			string version="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//获取MyConfig节点的所有子节点


				foreach(XmlNode eachXmlNode in nodeList)
				{
					XmlElement eachElement = (XmlElement)eachXmlNode;
					if(eachElement.Name=="CurrentVersion")
					{
						version = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath错误:找不到客户端config.xml文件或该文件格式不正确！");
			}

			return version;
		}

        
		//将版本信息转成浮点数，对比：
		//如果服务器端的版本号大于客户端的版本号
		//返回真假
		private bool NeedToUpdate()
		{
			float serverSideVersion = float.Parse(GetServerVersion()); 
			float clientSideVersion = float.Parse(GetClientVersion());
			if (serverSideVersion > clientSideVersion)
			{
				isVersionExpired = true;
				return isVersionExpired;
			}
			else
			{
				return false;
			}

   
		}
	}


}
