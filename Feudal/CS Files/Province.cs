using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class Province
    {
        Belief belief = new Belief();
        #region variables
        private //set all variables as private
        string provinceName;
		private Color provinceColor;
		private double quality;
		private double stability;
		private double population;
		private double wealth;
        private Religion provReligion;
		//private int techMilitary;//implement tech later
        //private int techEconomy;
		//private int techGovernment;
        #endregion

        #region constructor
        //default constructor: this probably shouldn't be used, it's here just incase
        public Province()
		{
			this.provinceName = "Name Me!";
			this.quality = .5;
			this.population = 1000.00;
			this.wealth = 0.25;
			this.stability = 1;
            this.provReligion = belief.setProtestantC;
		}
        public Province(string provinceName)
        {
            this.provinceName = provinceName;
            this.quality = .5;
            this.population = 1000.00;
            this.wealth = 0.25;
            this.stability = 1;
            this.provReligion = belief.setProtestantL;
        }

        public Province(string provinceName, double quality, double stability, double population, double wealth, Color provinceColor)
        {
            this.provinceName = provinceName;
            this.quality = quality;
            this.stability = stability;
            this.population = population;
            this.wealth = wealth;
            this.provinceColor = provinceColor;
        }

		public Province(string provinceName, double quality, double stability, double population, double wealth, Color provinceColor, Religion provReligion)
		{
			this.provinceName = provinceName;
			this.quality = quality;
			this.stability = stability;
			this.population = population;
			this.wealth = wealth;
            this.provinceColor = provinceColor;
            this.provReligion = provReligion;
		}
        #endregion


        #region accessors
		public string ProvinceName
		{
			get { return provinceName; }
			set { provinceName = value; }
		}

		public double Quality
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

		public double Stability
		{
			get { return stability; }
			set { stability = value; }
		}
        public string ProvReligionName
        {
            get { return provReligion.Name; }
            private set { provReligion.Name = value; }
        }
        public Image ProvReligionIcon
        {
            get { return provReligion.Icon; }
        }
        public void provReligionConvert(Religion r)
        {
            this.provReligion.Name = r.Name;
            this.provReligion.Family = r.Family;
            this.provReligion.MaxRange = r.MaxRange;
            this.provReligion.MinRange = r.MinRange;
            this.provReligion.Tolerance = r.Tolerance;
            this.provReligion.BonusTax = r.BonusTax;
            this.provReligion.BonusTrade = r.BonusTrade;
            this.provReligion.BonusStability = r.BonusStability;
            this.provReligion.ChangeIcon(r);
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
