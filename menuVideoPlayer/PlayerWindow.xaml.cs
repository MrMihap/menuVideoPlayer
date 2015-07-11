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

namespace menuVideoPlayer
{
  /// <summary>
  /// Логика взаимодействия для PlayerWindow.xaml
  /// </summary>
  public partial class PlayerWindow : Window
  {
    private List<int> playList = new List<int>();
    private int currentVideoID
    {
      set
      {
        throw new NotImplementedException("Change CurrentVideo");
      }
    }
    public PlayerWindow()
    {
      InitializeComponent();
    }
    public void InitplayList()
    { 

    }
    public void RecievePlayID(int ID)
    {
    }
  }
}
