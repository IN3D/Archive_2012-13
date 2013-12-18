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
        double grossIncome;
        double actualIncome;
        double industry;
        double commerce;//placeholder for trade class
        double taxes;
        double expenses;
        double buildingUpkeep;
        double armyUpkeep;
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
            this.grossIncome = (industry+commerce+taxes);
            this.expenses = (buildingUpkeep+armyUpkeep);
            this.actualIncome = (grossIncome-expenses);
        }
	    #endregion
        
        

    }
}
