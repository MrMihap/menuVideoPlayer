﻿using System;
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

  //this.Topmost = true;
 this.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;

 // создаем
 playerWindow = new PlayerWindow();
 if (Screen.AllScreens.Count() > 1)
 {
   Screen main = Screen.AllScreens.Where(s => s.Primary).First();
   Screen sub = Screen.AllScreens.Where(s => !s.Primary).First();
   System.Drawing.Rectangle mainRect = main.WorkingArea;
   System.Drawing.Rectangle subRect = sub.WorkingArea;
   this.Left = mainRect.Left;
   this.Top = mainRect.Top;

   playerWindow.Top = subRect.Top;
   playerWindow.Left = subRect.Left - 1;
 }
      CCommndsFlowController.playerWindow = playerWindow;
      CCommndsFlowController.menuWindow = this;
      this.Closed += MainWindow_Closed;
      playerWindow.Closed += playerWindow_Closed;

      this.NameLabel.Content = CMenuContainer.Name;
      foreach (Core.MenuItem menuItem in CMenuContainer.videoCollectionData)
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

          control.Border1.Background = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFe7eaeb"));
          control.Border1.BorderBrush = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFe7eaeb"));
        }
        else
        {
          Uri resourceUri = new Uri("controls/img/playinactiv.png", UriKind.Relative);
          System.Windows.Resources.StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);

          BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
          var brush = new ImageBrush();
          brush.ImageSource = temp;

          control.playButton.Background = brush;
          control.Border1.Background = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFb2b6b9"));
          control.Border1.BorderBrush = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#FFb2b6b9"));
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
      //var hwndSource = PresentationSource.FromVisual(this) as System.Windows.Interop.HwndSource;
      //if (hwndSource != null)
      //{
      //  var hwndTarget = hwndSource.CompositionTarget;
      //  if (hwndTarget != null) hwndTarget.RenderMode = System.Windows.Interop.RenderMode.SoftwareOnly;
      //}
      playerWindow.Show();
      /* PURE EVIL POWER CONDENSED HERE*/
      /* THE MOST TRUE CRUTCH IN THE WORLD WHICH I WRITE */
      if (CMenuContainer.videoCollectionData.Count <= 5)
      {
        scrollView.SetValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
      }
    }

    private void OnManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
    {
      e.Handled = true;
    }
  }
}
