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
    public FEditMenuElem()
    {
      InitializeComponent();
    }

    private void OpenFileButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.OK:

          MessageBox.Show("Файл успешно выбран");
          break;
        case System.Windows.Forms.DialogResult.Cancel:
          break;
      }
    }
  }
}
