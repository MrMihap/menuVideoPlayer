using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuVideoPlayer
{
  static class CCommndsFlowController
  {
    static public MainWindow menuWindow = null;
    //static public PlayerWindow playerWindow = null;


    static public void SendPlayID(int ID)
    {
      //if (playerWindow != null) playerWindow.RecievePlayID(ID);
      if (menuWindow != null) menuWindow.refresh_Buttons(ID);
    }
  }
}
