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
      menuItemsCollection = CMenuContainer.BuildCollectionFromPath(FilePath, false);
      MainHeader = CMenuContainer.Name;
    }
    public void AddItem(string Header, string info, string filePath)
    {
      Core.MenuItem item = new MenuItem(Header, info, filePath); 

    }
    public void AddItem(Core.MenuItem item)
    {
      menuItemsCollection.Add(item);
      this.ReIndexItems();
    }
    public void saveFile(string filePath)
    {
      CMenuContainer.WriteToFile(filePath, menuItemsCollection, MainHeader);
      //doc = new XmlDocument();
      //XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

      //XmlElement root = doc.DocumentElement;
      //doc.InsertBefore(xmlDeclaration, root);

      //XmlElement config = doc.CreateElement(string.Empty, "config", string.Empty);
      //doc.AppendChild(config);

      //XmlText mainHeader = doc.CreateTextNode(MainHeader);

      //XmlNode exhibName = doc.CreateElement("exhibitionName");
      //exhibName.AppendChild(mainHeader);
      //config.AppendChild(exhibName);

      //XmlElement menu =  (XmlElement)config.AppendChild(doc.CreateElement("menu"));
      //foreach (MenuItem item in menuItemsCollection)
      //{
      //  XmlElement menuitem = (XmlElement) menu.AppendChild(doc.CreateElement("menuItem"));
      //  ((XmlElement)menuitem.AppendChild(doc.CreateElement("header"))).AppendChild(doc.CreateTextNode(item.Header));
      //  ((XmlElement)menuitem.AppendChild(doc.CreateElement("info"))).AppendChild(doc.CreateTextNode(item.Info));
      //  ((XmlElement)menuitem.AppendChild(doc.CreateElement("videoPath"))).AppendChild(doc.CreateTextNode(item.VideoPath));
      //}
      
      //doc.Save(filePath);
    }

    public void RemoveElemByID(int ID)
    {
      menuItemsCollection.Remove(menuItemsCollection.Where(x => x.ID == ID).First());
      ReIndexItems();
    }
    public void EditElementByID(int ID, MenuItem value)
    {
      menuItemsCollection.Where(x => x.ID == ID).First().Info = value.Info;
      menuItemsCollection.Where(x => x.ID == ID).First().VideoPath = value.VideoPath;
      menuItemsCollection.Where(x => x.ID == ID).First().Header = value.Header;
    }
    private void ReIndexItems()
    {
      for (int i = 0; i < menuItemsCollection.Count; i++)
      {
        menuItemsCollection[i].ID = i;
      }
    }
  }
}

