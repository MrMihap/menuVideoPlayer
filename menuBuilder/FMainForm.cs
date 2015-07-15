using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace menuBuilder
{
  public partial class FMainForm : Form
  {
    private XmlDocument xmlDoc;
    private AppController appController = new AppController();
    public FMainForm()
    {
      InitializeComponent();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "xml | *.xml";
      dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.OK:
          appController.LoadFromFile(dialog.FileName);
          break;
        case System.Windows.Forms.DialogResult.Cancel:
          break;
      }
    }
    private void UpdateItemsList()
    {

      foreach (MenuItem item in appController.menuItemsCollection)
      {

      }
    }
  }
}
