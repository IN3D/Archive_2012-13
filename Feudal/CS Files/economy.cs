using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal.CS_Files
{
    public class Economy : province
    {
        #region variables
        private
        double money;
        double income;
        double industry;
        double commerce;
        double taxes;
        #endregion

        #region constructor
		public Economy()
        {
            this.money = 1000000;
            this.industry = 500;
            this.commerce = 250;
            //taxes based on quality/population
            this.taxes = (Quality * Population);
            //income should be the total of industry/commerce/taxes
            this.income = (industry+commerce+taxes);
        }
	    #endregion
        
        

    }
}
