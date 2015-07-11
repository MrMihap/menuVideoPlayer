using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuVideoPlayer
{
  class CCommndsFlowController
  {
    public MainWindow menuWindow = null;
    public PlayerWindow playerWindow = null;


    void SendPlayID(int ID)
    {
      if (playerWindow != null) playerWindow.RecievePlayID(ID);
    }
  }
}
