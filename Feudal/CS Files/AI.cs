using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Feudal
{
    class AI
    {
        #region declarations
        Maps maps = new Maps();
        feudalMainForm fmf = new feudalMainForm();
        #endregion

        //prototype, this should eventually go through a linklist
        public void ComputeMove(Character player)
        {
            //here for reference
            //((Button)fmf.Controls.Find("province1", true)[0]).BackColor = maps.getProvinceColor(player.CapitalProvID);


        }
    }
}
