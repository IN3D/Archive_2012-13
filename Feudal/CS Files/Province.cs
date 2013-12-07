using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class province
	{
		private string provinceName;
		//private color provinceColor;//not sure if color should be attached to a province or a person yet.
		private int quality;
		private int stability;
		private double population;
		private double wealth;
		//private int techMilitary;//implement tech later
		//private int techEconomy;
		//private int techGovernment;

		//default constructor
		//this proobably shouldn't be used, it's here just incase
		public province()
		{
			this.provinceName = "Name Me!";
			this.quality = 3;
			this.population = 1000.00;
			this.wealth = 10.00;
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

		/**Accessors**/
		public string getProvinceName()
		{
			return this.provinceName;
		}

		public int getQuality()
		{
			return this.quality;
		}

		public double getPopulation()
		{
			return this.population;
		}

		public double getWealth()
		{
			return this.wealth;
		}

		public int getStability()
		{
			return this.stability;
		}

		/**Modifiers**/
		public void setProvinceName(string provinceName)
		{
			this.provinceName = provinceName;
		}

		public void setQuality(int quality)
		{
			this.quality = quality;
		}

		public void setPopulation(double population)
		{
			this.population = population;
		}

		public void setWealth(double wealth)
		{
			this.wealth = wealth;
		}
		public void setStability(int stability)
		{
			this.stability = stability;
		}

	}

}
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
