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
        mePlayer.Source = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "/"+Core.CMenuContainer.videoCollection.Where(x => x.ID == value).FirstOrDefault().VideoPath);
        mediaPlayerIsPlaying = true;
        //mePlayer.Play();
      }
    }
    public PlayerWindow()
    {
      InitializeComponent();

      mePlayer.SourceUpdated += mePlayer_SourceUpdated;
    
      InitplayList();
    }
    public void InitplayList()
    {
      Core.CMenuContainer.LoadFromConfig();
      currentVideoID = 0;
    }

    private void mePlayer_SourceUpdated(object e, DataTransferEventArgs args)
    {
      mediaPlayerIsPlaying = true;
      mePlayer.Play();
    }


    private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = (mePlayer != null) && (mePlayer.Source != null);
    }

    private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
    {

      mePlayer.Play();
      mediaPlayerIsPlaying = true;
    }

    //Продолжение после окончания
    private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
    {
      mePlayer.Position = TimeSpan.FromMilliseconds(1);
    }

    public void RecievePlayID(int ID)
    {
      currentVideoID = ID;
    }
  }
}
