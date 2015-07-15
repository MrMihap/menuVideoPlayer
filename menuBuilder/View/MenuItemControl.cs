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
using menuBuilder.View;
namespace menuBuilder
{
  public delegate void OnMenuItemDelDelegate(object sender, int delID);
  public delegate void OnMenuItemChangedDelegate(object sender, Core.MenuItem value);
  public partial class MenuItemControl : UserControl
  {
    public event OnMenuItemDelDelegate OnMenuItemDel;
    public event OnMenuItemChangedDelegate OnMenuItemChange;
    private int ID = -1;
    private Core.MenuItem menuItem;
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
    public MenuItemControl(Core.MenuItem _menuItem)
    {
      InitializeComponent();
      this.menuItem = _menuItem;
      this.Header.Text = menuItem.Header;
      this.Info.Text = menuItem.Info;
      this.FilePath.Text = menuItem.VideoPath;
      this.ID = menuItem.ID;
    }

    private void remove_Click(object sender, EventArgs e)
    {
      if (OnMenuItemDel != null) OnMenuItemDel(this, this.ID);
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
      FEditMenuElem form = new FEditMenuElem(menuItem);
      switch (form.ShowDialog())
      {
        case DialogResult.OK:
          form.menuItem.ID = menuItem.ID;
          if (OnMenuItemChange != null) OnMenuItemChange(this, form.menuItem);
          break;
        case DialogResult.Cancel:
          break;
      }
    } 
  }
}
