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

namespace menuVideoPlayer.controls
{
    /// <summary>
    /// Логика взаимодействия для AboutItem.xaml
    /// </summary>
    public partial class AboutItem : Window
    {
        public AboutItem()
        {
            InitializeComponent();
        }
        public AboutItem(string Header, string About)
        {
          InitializeComponent();
          this.About.Text = About;
          this.Header.Content = Header;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
        }

        private void Info_Loaded(object sender, RoutedEventArgs e)
        {
          this.WindowState = System.Windows.WindowState.Maximized;
        }

    }

      
}
