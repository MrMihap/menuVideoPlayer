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
    private int currentVideoID
    {
      set
      {
        string filename = Core.CMenuContainer.videoCollectionData.Where(x => x.ID == value).FirstOrDefault().VideoPath;

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

    }
    public void InitplayList()
    {
     // Core.CMenuContainer.LoadFromConfig();
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
      mePlayer.Position = TimeSpan.FromMilliseconds(1);
    }

    private void Player_Loaded(object sender, RoutedEventArgs e)
    {
      //var hwndSource = PresentationSource.FromVisual(this) as System.Windows.Interop.HwndSource;
      //if (hwndSource != null)
      //{
      //  var hwndTarget = hwndSource.CompositionTarget;
      //  if (hwndTarget != null) hwndTarget.RenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
      //}
      this.WindowState = System.Windows.WindowState.Maximized;


      InitplayList();
    }

    public void RecievePlayID(int ID)
    {
      currentVideoID = ID;
      mePlayer.Stop();
      mePlayer.Play();
    }
  }
}
