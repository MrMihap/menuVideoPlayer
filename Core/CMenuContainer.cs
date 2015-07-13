using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
namespace Core
{
    public class CMenuContainer
    {
      public static List<MenuItem> videoCollection = new List<MenuItem>();
      public static string Name;
      public static int AddItem(MenuItem item)
      {
        item.ID = videoCollection.Count();
        videoCollection.Add(item);
        return item.ID;
      }
      public static void LoadFromConfig()
      {
        LoadFromConfig(Properties.Resources.ConfigPath);
      }
      public static void LoadFromConfig(string Path)
      {
        XmlDocument doc = new XmlDocument();
        doc.Load(Path);
        Name = doc.GetElementsByTagName("exhibitionName")[0].InnerText;
        foreach (XmlElement elem in doc.GetElementsByTagName("menuItem"))
        {
          MenuItem menuItem = new MenuItem();
          try
          {
            menuItem.Header = elem.GetElementsByTagName("header")[0].InnerText;
            menuItem.Info = elem.GetElementsByTagName("info")[0].InnerText;
            menuItem.VideoPath = elem.GetElementsByTagName("videoPath")[0].InnerText;
            menuItem.ID = videoCollection.Count();
            if (File.Exists(menuItem.VideoPath)) 
              videoCollection.Add(menuItem);
            else 
              MessageBox.Show("Ошибка загрузки данных: \n" + 
              "Для элемента" + menuItem.Header + 
              "\nНе удалось найти видео файл :" + menuItem.VideoPath);
          }
          catch (Exception e)
          {
            MessageBox.Show("Элемент меню не загружен, ошибка чтения файла конфигурации :" + e.Message);
            continue;
          }
        }
      }
    }
}
