using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class province
    {
        #region variables
        private //set all variables as private
        string provinceName;
		//private color provinceColor;//not sure if color should be attached to a province or a person yet.
		int quality;
		int stability;
		double population;
		double wealth;
		//private int techMilitary;//implement tech later
        //private int techEconomy;
		//private int techGovernment;
        #endregion

        #region constructor
        //default constructor
        //this probably shouldn't be used, it's here just incase
        public province()
		{
			this.provinceName = "Name Me!";
			this.quality = 3;
			this.population = 1000.00;
			this.wealth = 0.25;
			this.stability = 1;
		}

		public province(string provinceName, int quality, int stability, double population, double wealth)
		{
			this.provinceName = provinceName;
			this.quality = quality;
			this.stability = stability;
			this.population = population;
			this.wealth = wealth;
		}
        #endregion


        #region accessors
		public string ProvinceName
		{
			get { return provinceName; }
			set { provinceName = value; }
		}

		public int Quality
		{
			get { return quality; }
			set { quality = value; }
		}

		public double Population
		{
			get { return population; }
			set { population = value; }
		}

		public double Wealth
		{
			get { return wealth; }
			set { wealth = value; }
		}

		public int Stability
		{
			get { return stability; }
			set { stability = value; }
		}
        #endregion
    }
}
			#region uglyComment
			/******************************************************************
			*Q: What the hell is this??										  *
			*A: This was me working out exactly how characters should recieve *
			* money based on province ownership. It's crap, but it's left here*
			* for reference.												  *
			* -Eric															  *
			******************************************************************/
            //!!!!!!!!!All of this should be moved!!!!!!!!!!!//
            ////province is booming
            //if (int_provinceQuality == 1)
            //{
            //    dbl_provIncome += 1.00;
            //}
            ////province is wealthy
            //else if (int_provinceQuality == 2)
            //{
            //    dbl_provIncome += .75;
            //}
            ////province is average
            //else if (int_provinceQuality == 3)
            //{
            //    dbl_provIncome += .50;
            //}
            ////province is poor
            //else if (int_provinceQuality == 4)
            //{
            //    dbl_provIncome += .25;
            //}
            ////province is damaged
            //else
            //{
            //    dbl_provIncome += 0.00;
            //}
			#endregion
