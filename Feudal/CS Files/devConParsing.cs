﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Feudal.Forms
{
    class devConParsing
    {
        #region grab text
        public void parseCommand(string command)
        {
            feudalMainForm feuFrm = new feudalMainForm();
            if (command.Substring(0, 1) == "$")
            {
                feuFrm.setLabelMoney("MONEY!!!!!");
                System.Windows.Forms.MessageBox.Show("WORKED");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(command);
            }
        }
        #endregion
    }
}
