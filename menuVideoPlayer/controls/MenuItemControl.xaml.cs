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
using winForms = System.Windows.Forms;
using System.Drawing;
using Core;
namespace menuVideoPlayer.controls
{
  /// <summary>
  /// Логика взаимодействия для MenuItemControl.xaml
  /// </summary>
  public partial class MenuItemControl : UserControl
  {
    public int ID;
    private string _Header;
    private string Info;
    public string Header
    {
      get { return _Header;}
      set 
      {
        headerTextBox.Content = value;
        _Header = value;
      }
    }
    public MenuItemControl()
    {
      InitializeComponent();
    }
    public MenuItemControl(Core.MenuItem menuData)
    {
      InitializeComponent();
      ID = menuData.ID;
      Info = menuData.Info;
      Header = menuData.Header;
    }

    private void playButton_Click(object sender, RoutedEventArgs e)
    {
      CCommndsFlowController.SendPlayID(this.ID);
    }

    private void infoButton_Click(object sender, RoutedEventArgs e)
    {
      AboutItem aboutItem = new AboutItem(CMenuContainer.Name, this.Info);
      if (winForms.Screen.AllScreens.Count() > 1)
      {
        winForms.Screen s1 = winForms.Screen.AllScreens.Where(x => x.Primary == true).First();
        System.Drawing.Rectangle r1 = s1.WorkingArea;
        aboutItem.Left = r1.Left;
        aboutItem.Top = r1.Top;
      }
      aboutItem.ShowDialog();
    }

    private void Border1_MouseDown(object sender, MouseButtonEventArgs e)
    {
      CCommndsFlowController.SendPlayID(this.ID);
    }

  }
}
