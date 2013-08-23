using System;
using System.Xml;
using System.Windows.Forms;

namespace XSolo.Common
{
	/// <summary>
	/// ��������config.xml�ļ�����
	/// ���Ż�����ȡ�����ӵķ�������һ��������ֻ��Ҫ��ȡconfig.xml�ļ�һ��
	/// </summary>
	public class ConfigManagement
	{

		//��ȡ������������ַ
		public string GetUpdatePath()
		{
			string a="";

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
						a = eachElement.InnerText;
					}
				}


			}
			catch
			{
				MessageBox.Show("ReadServerPath����:�Ҳ����ͻ���config.xml�ļ�����ļ���ʽ����ȷ��");
			}

			a = a + "config.xml";

			return a;
		}

		//��ȡ���ݿ����ӵ�ַ
		public string GetConnectionString()
		{
			string a="",b="",c="",d="";

			try
			{
				XmlDocument xmlDoc=new XmlDocument();
				xmlDoc.Load("config.xml");
				XmlNodeList nodeList=xmlDoc.SelectSingleNode("MyConfig").ChildNodes;//��ȡMyConfig�ڵ�������ӽڵ�


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
				MessageBox.Show("ReadServerPath����:�Ҳ����ͻ���config.xml�ļ�����ļ���ʽ����ȷ��");
			}

			string connectStr="Data Source="+a+";Initial Catalog="+b+";User ID="+c+";Pwd="+d+";";
			return connectStr;

		}

	}
}
