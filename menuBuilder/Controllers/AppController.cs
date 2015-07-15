using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Core;
namespace menuBuilder
{
  class AppController
  {

    XmlDocument doc;
    public List<MenuItem> menuItemsCollection = new List<MenuItem>();
    public string MainHeader;
    public void LoadFromFile(string FilePath)
    {
      menuItemsCollection = CMenuContainer.BuildCollectionFromPath(FilePath);
      MainHeader = CMenuContainer.Name;
    }
    public void AddItem(string Header, string info, string filePath)
    {

    }
    public void saveFile(string filePath)
    {
      doc = new XmlDocument();
      XmlElement config = doc.CreateElement("config");
      ((XmlElement)config.AppendChild(doc.CreateElement("exhibitionName"))).Value = MainHeader;
      XmlElement menu =  (XmlElement)config.AppendChild(doc.CreateElement("exhibitionName"));
      foreach (MenuItem item in menuItemsCollection)
      {
        XmlElement menuitem = (XmlElement) menu.AppendChild(doc.CreateElement("menuItem"));
        ((XmlElement)menuitem.AppendChild(doc.CreateElement("header"))).Value = item.Header;
        ((XmlElement)menuitem.AppendChild(doc.CreateElement("info"))).Value = item.Header;
        ((XmlElement)menuitem.AppendChild(doc.CreateElement("videoPath"))).Value = item.Header;
      }
      doc.AppendChild(config);

    }
  }
}
