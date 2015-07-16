using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
namespace menuBuilder.View
{
  public partial class FEditMenuElem : Form
  {
    public Core.MenuItem menuItem;
    public FEditMenuElem()
    {
      InitializeComponent();
      menuItem = new Core.MenuItem();
    }
    public FEditMenuElem(Core.MenuItem _menuItem)
    {
      InitializeComponent();
      menuItem = _menuItem;
      Header.Text = menuItem.Header;
      filePath.Text = menuItem.VideoPath;
      Info.Text = menuItem.Info;
    }
    private void OpenFileButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
     
      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.OK:
          if (dialog.FileName.Contains(dialog.InitialDirectory))
            filePath.Text = dialog.FileName.Replace(dialog.InitialDirectory, "");
          else
          filePath.Text = dialog.FileName; 
          MessageBox.Show("Файл успешно выбран");
          break;
        case System.Windows.Forms.DialogResult.Cancel:
          break;
      }
    }

    private void Save_Click(object sender, EventArgs e)
    {
      menuItem.Header = Header.Text;
      menuItem.Info = Info.Text;
      menuItem.VideoPath = filePath.Text;
      this.Close();
    }
  }
}
