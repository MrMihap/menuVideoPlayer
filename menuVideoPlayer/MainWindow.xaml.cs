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

namespace menuVideoPlayer
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private CCommndsFlowController commandsController = new CCommndsFlowController();
    private PlayerWindow playerWindow;
    public MainWindow()
    {
      InitializeComponent();
      playerWindow = new PlayerWindow();
      commandsController.playerWindow = playerWindow;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      playerWindow.Show();
    }
  }
}
