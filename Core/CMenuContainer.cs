using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Core
{
  public class CMenuContainer
  {
    public static List<MenuItem> videoCollectionData = new List<MenuItem>();
    public static string Name;
    public static int AddItem(MenuItem item)
    {
      item.ID = videoCollectionData.Count();
      videoCollectionData.Add(item);
      return item.ID;
    }
    public static void LoadFromConfig()
    {

      LoadFromConfig(Properties.Resources.ConfigPath);
    }

    public static void LoadFromConfig(string Path)
    {
      videoCollection data = ReadFromFile(Path);
      videoCollectionData = data.videos;
      Name = data.Header;
      List<MenuItem> videoCollectionData2 = new List<MenuItem>();


      foreach (MenuItem menuItem in videoCollectionData)
      {
        if (File.Exists(menuItem.VideoPath))
          videoCollectionData2.Add(menuItem);
        else
          MessageBox.Show("Ошибка загрузки данных: \n" +
         "Для элемента" + menuItem.Header +
          "\nНе удалось найти видео файл :" + menuItem.VideoPath);
      }
      videoCollectionData = videoCollectionData2;
      //XmlDocument doc = new XmlDocument();
      //doc.Load(Path);
      //Name = doc.GetElementsByTagName("exhibitionName")[0].InnerText;
      //foreach (XmlElement elem in doc.GetElementsByTagName("menuItem"))
      //{
      //  MenuItem menuItem = new MenuItem();
      //  try
      //  {
      //    menuItem.Header = elem.GetElementsByTagName("header")[0].InnerText;
      //    menuItem.Info = elem.GetElementsByTagName("info")[0].InnerText;
      //    menuItem.VideoPath = elem.GetElementsByTagName("videoPath")[0].InnerText;
      //    menuItem.ID = videoCollection.Count();
      //    if (File.Exists(menuItem.VideoPath))
      //      videoCollection.Add(menuItem);
      //    else
      //      MessageBox.Show("Ошибка загрузки данных: \n" +
      //      "Для элемента" + menuItem.Header +
      //      "\nНе удалось найти видео файл :" + menuItem.VideoPath);
      //  }
      //  catch (Exception e)
      //  {
      //    MessageBox.Show("Элемент меню не загружен, ошибка чтения файла конфигурации :" + e.Message);
      //    continue;
      //  }
      //}
    }


    static public videoCollection ReadFromFile(string Path)
    {
      BinaryFormatter formatter = new BinaryFormatter();
      using (Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None))
      {
        return (videoCollection)formatter.Deserialize(fStream);
      }
    }
    static public void WriteToFile(string Path, List<MenuItem> data, string Header)
    {
      videoCollection videos = new videoCollection();
      videos.videos = data;
      videos.Header = Header;
      WriteToFile(Path, videos);
    }
    static public void WriteToFile(string Path, videoCollection data)
    {
      BinaryFormatter formatter = new BinaryFormatter();
      using (Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.None))
      {
        formatter.Serialize(fStream, data);
      }
    }

    public static List<MenuItem> BuildCollectionFromPath(string FileName)
    {
      LoadFromConfig(FileName);
      return videoCollectionData;
    }
  }
}
