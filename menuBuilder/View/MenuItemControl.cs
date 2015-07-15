using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
namespace menuBuilder
{
  public delegate void OnMenuItemDelDelegate(object sender, int delID);
  public partial class MenuItemControl : UserControl
  {
    public event OnMenuItemDelDelegate OnMenuItemDel;
    private int ID = -1;
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
    public MenuItemControl(Core.MenuItem menuItem)
    {
      InitializeComponent();
      this.Header.Text = menuItem.Header;
      this.Info.Text = menuItem.Info;
      this.FilePath.Text = menuItem.VideoPath;
      this.ID = menuItem.ID;
    }

    private void remove_Click(object sender, EventArgs e)
    {
      if (OnMenuItemDel != null) OnMenuItemDel(this, this.ID);
    } 
  }
}
