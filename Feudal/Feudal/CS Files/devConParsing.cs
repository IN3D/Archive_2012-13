using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Feudal
{
    class devConParsing
    {
        #region grab command
        public void parseCommand(string command)
        {
            feudalMainForm fmf = new feudalMainForm();
            if (command.Substring(0, 1) == "$")
            {
                fmf.lblMoney.Text="MONEY!!!!!";
                //System.Windows.Forms.MessageBox.Show("WORKED");//not needed
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(command);
            }
        }
        #endregion
    }
}
