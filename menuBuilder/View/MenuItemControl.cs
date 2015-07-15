using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuBuilder
{
  public partial class MenuItemControl : UserControl
  {
    public MenuItemControl()
    {
      InitializeComponent();
    }
    public MenuItemControl(string Header, string info, string fileName)
    {
      InitializeComponent();
      this.Header.Text = Header;
      this.Info.Text = info;
      this.FilePath.Text = fileName;
    }
  }
}
