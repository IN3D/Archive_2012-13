using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
    class Turns
    {
        //fuction that handles the turn button
        //Eric 09-12-2013
        public static int TurnFuction(int counter)
        {
            string[] months = new string[] {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            var fm = feudalMainForm.ActiveForm as feudalMainForm;
             fm.lblMonthDate.Text = months[counter];

            return counter;
        }
    }
}
