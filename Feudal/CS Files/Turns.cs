using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
    class Turns
    {
        #region variables
        //fuction that handles the turn button
        //Eric 09-12-2013
        private string[] months = new string[] {"January", "Febuary", "March", 
											    "April", "May", "June", 
											    "July", "August", "September", 
											    "October", "November", "December"};
        #endregion

        #region methods
        public string getMonth(int i)
        {
            return months[i];
        }
        #endregion
    }
}
