using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
    public class Economy
    {
        #region variables
        private
        Province prov;
        double money;
        double income;
        double industry;
        double commerce;//placeholder for trade class
        double taxes;
        #endregion

        #region constructor
		public Economy()
        {
            this.money = 1000000;
            this.industry = 500;
            this.commerce = 250;
            //taxes based on quality/population
            this.taxes = (prov.Quality* prov.Population);
            //income should be the total of industry/commerce/taxes
            this.income = (industry+commerce+taxes);
        }
	    #endregion
        
        

    }
}
