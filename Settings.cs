using System;
using System.Xml;

namespace Nahravadlo
{
	public class Settings
	{
		public static string default_filename = "config.xml";
		private static Settings settings = null;

		private XmlDocument xmlDoc;
		private string filename = default_filename;

		public static Settings getInstance()
		{
			if (settings == null) settings = new Settings();
			return settings;
		}

		private Settings(string filename)
		{
			xmlDoc = new XmlDocument();
			Load(filename);
		}

		private Settings() : this(default_filename)
		{
		}

		public void Load(string filename)
		{
			try
			{
				xmlDoc.Load(filename);
			} catch
			{
			}
		}

		public void Load()
		{
			Load(filename);
		}

		public void Save(string filename)
		{
			if (!xmlDoc.OuterXml.Contains("<?xml"))
				xmlDoc.InsertBefore(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null), xmlDoc.DocumentElement);
			xmlDoc.Save(filename);
		}

		public void Save()
		{
			Save(filename);
		}

		public string getString(string name, string default_value)
		{
			try
			{
				return xmlDoc.SelectSingleNode(name).InnerText;
			} catch(Exception)
			{
				return default_value;
			}
		}

		public int getInt(string name, int default_value)
		{
			try
			{
				return int.Parse(xmlDoc.SelectSingleNode(name).InnerText);
			} catch(Exception)
			{
				return default_value;
			}
		}

		public bool getBool(string name, bool default_value)
		{
			try
			{
				return bool.Parse(xmlDoc.SelectSingleNode(name).InnerText);
			} catch(Exception)
			{
				return default_value;
			}
		}

		public float getFloat(string name, float default_value)
		{
			try
			{
				return float.Parse(xmlDoc.SelectSingleNode(name).InnerText);
			} catch(Exception)
			{
				return default_value;
			}
		}

		public void setString(string name, string value)
		{
			//try
			//{
			createSelectNodes(xmlDoc, name).InnerText = value;
			//} catch(Exception)
			{
			}
		}

		public void setInt(string name, int value)
		{
			try
			{
				createSelectNodes(xmlDoc, name).InnerText = value.ToString();
			} catch(Exception)
			{
			}
		}

		public void setBool(string name, bool value)
		{
			try
			{
				createSelectNodes(xmlDoc, name).InnerText = value.ToString();
			} catch(Exception)
			{
			}
		}

		public void setFloat(string name, float value)
		{
			try
			{
				createSelectNodes(xmlDoc, name).InnerText = value.ToString();
			} catch(Exception)
			{
			}
		}

		public XmlNode createSelectNodes(XmlDocument xmlDoc, string path)
		{
			if (path.Substring(0, 2) == "//") path = path.Substring(2);

			if (xmlDoc.SelectNodes(path).Count != 0)
			{
				return xmlDoc.SelectSingleNode(path);
			}

			if (path.IndexOf("/") == -1)
			{
				return xmlDoc.AppendChild(xmlDoc.CreateElement(path));
			} else
			{
				String[] path_items = path.Split('/');
				XmlNode node = xmlDoc;
				for (int i = 0; i < path_items.Length; i++)
				{
					if (node.SelectNodes(path_items[i]).Count != 0)
						node = node.SelectSingleNode(path_items[i]);
					else
						node = node.AppendChild(xmlDoc.CreateElement(path_items[i]));
				}
				return node;
			}
		}

		public XmlNode getNode(string name)
		{
			return xmlDoc.SelectSingleNode(name);
		}

		public XmlNodeList getNodes(string name)
		{
			return xmlDoc.SelectNodes(name);
		}

		public XmlDocument getXMLDocument()
		{
			return xmlDoc;
		}
	}
}