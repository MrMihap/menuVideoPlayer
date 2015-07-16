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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Drawing;
using Core;
using menuVideoPlayer.controls;
namespace menuVideoPlayer
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private bool IsClosed = false;
    private PlayerWindow playerWindow;
    public MainWindow()
    {
      CMenuContainer.LoadFromConfig();
      InitializeComponent();


      //this.Topmost = true;
      this.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;

      // создаем
      playerWindow = new PlayerWindow();
      if (Screen.AllScreens.Count() > 1)
      {
        Screen s1 = Screen.AllScreens[1];
        //Screen s2 = Screen.AllScreens[1];
        System.Drawing.Rectangle r1 = s1.WorkingArea;
        //System.Drawing.Rectangle r2 = s2.WorkingArea;
        this.Left = r1.Left;
        this.Top = r1.Top;

        //playerWindow.Top = r2.Top;
        //playerWindow.Left = r2.Left;
      }
      CCommndsFlowController.playerWindow = playerWindow;
      CCommndsFlowController.menuWindow = this;
      this.Closed += MainWindow_Closed;
      playerWindow.Closed += playerWindow_Closed;

      this.NameLabel.Content = CMenuContainer.Name;

      foreach (Core.MenuItem menuItem in CMenuContainer.videoCollection)
      {
        menuItemsListBox.Items.Add(new MenuItemControl(menuItem));
      }
      
      CCommndsFlowController.SendPlayID(0);
    }

    public void refresh_Buttons(int id)
    {
      foreach (MenuItemControl control in menuItemsListBox.Items)
        if (control.ID == id)
        {
          Uri resourceUri = new Uri("controls/img/play.png", UriKind.Relative);
          System.Windows.Resources.StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);

          BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
          var brush = new ImageBrush();
          brush.ImageSource = temp;
          control.playButton.Background = brush;

          control.Border1.Background = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFE7EBEE"));
          control.Border1.BorderBrush = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFE7EBEE"));
        }
        else
        {
          Uri resourceUri = new Uri("controls/img/playinactiv.png", UriKind.Relative);
          System.Windows.Resources.StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);

          BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
          var brush = new ImageBrush();
          brush.ImageSource = temp;

          control.playButton.Background = brush;
          control.Border1.Background = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#7B7A7C"));
          control.Border1.BorderBrush = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#7B7A7C"));
        }
    }

    void MainWindow_Closed(object sender, EventArgs e)
    {
      IsClosed = true;
      playerWindow.Close();
    }



    void playerWindow_Closed(object sender, EventArgs e)
    {
      if (!IsClosed) this.Close();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      this.WindowState = System.Windows.WindowState.Maximized;
      playerWindow.Show();
    }

    private void OnManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
    {
      e.Handled = true;
    }
  }
}
