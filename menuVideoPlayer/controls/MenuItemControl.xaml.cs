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
        headerTextBox.Text = value;
        _Header = value;
      }
    }
    public MenuItemControl()
    {
      InitializeComponent();
    }
    public MenuItemControl(Core.MenuItem menuData)
    {
      this.ID = menuData.ID;
      this.Info = menuData.Info;
      this.Header = menuData.Header;
    }

  }
}
