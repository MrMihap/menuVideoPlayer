using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Core;
using System.IO;
namespace menuVideoPlayer
{
  /// <summary>
  /// Логика взаимодействия для PlayerWindow.xaml
  /// </summary>
  public partial class PlayerWindow : Window
  {
    private bool mediaPlayerIsPlaying = false;

    private int _currentVideoId=-1;
    private int currentVideoID
    {
      set
      {
        string filename = Core.CMenuContainer.videoCollection.Where(x => x.ID == value).FirstOrDefault().VideoPath;

        Uri Source = new Uri(filename, UriKind.Relative);
        if (Source != null)
        {
          mePlayer.Source = Source;
        }
      }
    }
    public PlayerWindow()
    {
      InitializeComponent();

    
      InitplayList();
    }
    public void InitplayList()
    {
      Core.CMenuContainer.LoadFromConfig();
      currentVideoID = 0;
    }

      private void mePlayer_SourceUpdated(object e, DataTransferEventArgs args)
    {
      mePlayer.Play();
    }


    private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = (mePlayer != null) && (mePlayer.Source != null);
    }

    private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
    {
      mePlayer.Play();
    }

    //Продолжение после окончания
    private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
    {
      currentVideoID = Core.CMenuContainer.videoCollection.Count - 1;
      mePlayer.Position = TimeSpan.FromMilliseconds(1);
    }

    public void RecievePlayID(int ID)
    {
      currentVideoID = ID;
    }
  }
}
