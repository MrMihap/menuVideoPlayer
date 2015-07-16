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
using menuBuilder.View;
namespace menuBuilder
{
  public partial class FMainForm : Form
  {
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
          this.UpdateItemsList();
          break;
        case System.Windows.Forms.DialogResult.Cancel:
          break;
      }
    }
    private void UpdateItemsList()
    {
      menuElemsPanel.Controls.Clear();
      this.HeaderText.Text = appController.MainHeader;
      for (int i = 0; i < appController.menuItemsCollection.Count; i++ )
      {
        Core.MenuItem menuItem = appController.menuItemsCollection[i];
        MenuItemControl itemControll = new MenuItemControl(menuItem);
        itemControll.OnMenuItemDel += itemControll_OnMenuItemDel;
        itemControll.OnMenuItemChange += itemControll_OnMenuItemChange;
        itemControll.Location = new Point(0, (itemControll.Height + 15) * i);
        menuElemsPanel.Controls.Add(itemControll);
      }
    }

    void itemControll_OnMenuItemChange(object sender, Core.MenuItem value)
    {
      appController.EditElementByID(value.ID, value);
      this.UpdateItemsList();
    }

    void itemControll_OnMenuItemDel(object sender, int delID)
    {
      appController.RemoveElemByID(delID);
      this.UpdateItemsList();
    }
    private void FMainForm_Load(object sender, EventArgs e)
    {
      if (File.Exists("menuConfig.xml"))
      {
        try
        {
          appController.LoadFromFile("menuConfig.xml");
          this.UpdateItemsList();
        }
        catch(Exception ex)
        {
          MessageBox.Show("Файл данных поврежден");
        }
      }
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
      appController = new AppController();
      this.UpdateItemsList();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      appController.saveFile("menuConfig.xml");

    }

    private void addElem_Click(object sender, EventArgs e)
    {
      FEditMenuElem form = new FEditMenuElem();
      switch (form.ShowDialog())
      {
        case DialogResult.OK:
          appController.AddItem(form.menuItem);
          this.UpdateItemsList();
          break;
        case DialogResult.Cancel:
          break;
      }
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void HeaderText_TextChanged(object sender, EventArgs e)
    {
      appController.MainHeader = HeaderText.Text;
    }
  }
}
