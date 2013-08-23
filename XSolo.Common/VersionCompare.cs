namespace XSolo.Common
{
	using System;
	using System.Xml;
	using System.IO;
	using System.Windows.Forms;

	/// <summary>
	/// versionCompare ��ժҪ˵����
	/// </summary>
	public class VersionCompare
	{
		private bool isVersionExpired = false;

		public bool IsConfigFileExist {get {return GetConfigFile();}}

		public bool IsVersionExpired {get {return NeedToUpdate();}}


		//�ж������ļ��Ƿ����
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

		//��ȡ������������ַ
		private string GetServerPath()
		{
			string path="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//��ȡMyConfig�ڵ�������ӽڵ�


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
				MessageBox.Show("ReadServerPath����:�Ҳ����ͻ���config.xml�ļ�����ļ���ʽ����ȷ��");
			}

			path = path + "config.xml";

			return path;
		}

		//��ȡ�������������������ļ�����İ汾��Ϣ
		private string GetServerVersion()
		{
			string version="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load(GetServerPath());
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//��ȡMyConfig�ڵ�������ӽڵ�


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
				MessageBox.Show("ReadServerPath����:�Ҳ�����������config.xml�ļ�����ļ���ʽ����ȷ��");
			}

			return version;
		}

		//��ȡ��ǰ�ͻ������������ļ�����İ汾��Ϣ
		private string GetClientVersion()
		{
			string version="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//��ȡMyConfig�ڵ�������ӽڵ�


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
				MessageBox.Show("ReadServerPath����:�Ҳ����ͻ���config.xml�ļ�����ļ���ʽ����ȷ��");
			}

			return version;
		}

        
		//���汾��Ϣת�ɸ��������Աȣ�
		//����������˵İ汾�Ŵ��ڿͻ��˵İ汾��
		//�������
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
