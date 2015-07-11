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
<<<<<<< HEAD
    private bool mediaPlayerIsPlaying = false;
=======
>>>>>>> origin/videowindowdev
    private int _currentVideoId=-1;
    private int currentVideoID
    {
      set
      {
<<<<<<< HEAD
        mePlayer.Source = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "/"+Core.CMenuContainer.videoCollection.Where(x => x.ID == value).FirstOrDefault().VideoPath);
        mediaPlayerIsPlaying = true;
        //mePlayer.Play();
=======
        Uri Source = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "/"+Core.CMenuContainer.videoCollection.Where(x => x.ID == value).FirstOrDefault().VideoPath);
        if (Source != null)
        {
          mePlayer.Source = Source;
        }

>>>>>>> origin/videowindowdev
      }
    }
    public PlayerWindow()
    {
      InitializeComponent();

<<<<<<< HEAD
      mePlayer.SourceUpdated += mePlayer_SourceUpdated;
=======
>>>>>>> origin/videowindowdev
    
      InitplayList();
    }
    public void InitplayList()
    {
      Core.CMenuContainer.LoadFromConfig();
      currentVideoID = 0;
    }
<<<<<<< HEAD

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
=======

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
      
>>>>>>> origin/videowindowdev
    }

    public void RecievePlayID(int ID)
    {
      currentVideoID = ID;
    }
  }
}
