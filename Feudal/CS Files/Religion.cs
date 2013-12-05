using System;

namespace Feudal
{
	public class ReligBonuses
	{
		private double bonusTax;
		private double bonusTrade;
		private double bonusStability;
		private double bonusTech;

		//default constructor because reasons
		public ReligBonuses()
		{
			//These would make really terrible bonuses
			this.bonusTax = 0.0;
			this.bonusTrade = 0.0;
			this.bonusStability = 0.0;
			this.bonusTech = 0.0;
		}

		//USE ME
		public ReligBonuses(double bonusTax, double bonusTrade, double bonusStability, double bonusTech)
		{
			this.bonusTax = bonusTax;
			this.bonusTrade = bonusTrade;
			this.bonusStability = bonusStability;
			this.bonusTech = bonusTech;
		}

		/**Accessors**/
		public double getBonusTax()
		{
			return this.bonusTax;
		}

		public double getBonusTrade()
		{
			return this.bonusTrade;
		}

		public double getBonusStability()
		{
			return this.bonusStability;
		}

		public double getBonusTech()
		{
			return this.bonusTech;
		}

		/**Modifiers**/
		public void setBonusTax(double bonusTax)
		{
			this.bonusTax = bonusTax;
		}

		public void setBonusTrade(double bonusTrade)
		{
			this.bonusTrade = bonusTrade;
		}

		public void setBonusStability(double bonusStability)
		{
			this.bonusStability = bonusStability;
		}

		public void setBonusTech(double bonusTech)
		{
			this.bonusTech = bonusTech;
		}
	}

	public class Religion : ReligBonuses
	{
		private string name;
		private int maxRange;//maybe not use these, but for now they
		private int minRange;//were part of the original 
		private double tolerance;
		private object ReligBonuses;//TODO: Agree on this
		//maybe make a bonuses class
		//to have religion extend?
		/*
		private double bonusTax;
		private double bonusTrade;
		private double bonusStability;
		private double bonusTech;
		*/


		//don't use default
		public Religion ()
		{
			name = "Not a religion";
			maxRange = 10;
			minRange = 1;
			tolerance = 3.0;
			ReligBonuses bonuses = new ReligBonuses (0.0, 0.0, 0.0, 0.0);
			//var bonuses = ReligBonuses(0.0, 0.0, 0.0, 0.0) as ReligBonuses;
		}

		//actually use this one
		public Religion (string name, int maxRange, int minRange, 
		               double tolerance, object ReligBonuses, double bonusTax, double bonusTrade, double bonusStability,
		               double bonusTech)
		{
			this.name = name;
			this.maxRange = maxRange;
			this.minRange = minRange;
			this.tolerance = tolerance;
			ReligBonuses
			bonuses = new ReligBonuses (bonusTax, bonusTrade, bonusStability, bonusTech);
		}

		/**Accessors**/
		public string getName()
		{
			return this.name;
		}

		public int getMaxRange()
		{
			return this.maxRange;
		}

		public int getMinRange()
		{
			return this.minRange;
		}

		public double getTolerance()
		{
			return this.tolerance;
		}

		public object getBonuses()
		{
			return ReligBonuses;
		}

		/**Modifiers**/
		public void setName(string name)
		{
			this.name = name;
		}

		public void setMaxRange(int maxRange)
		{
			this.maxRange = maxRange;
		}

		public void setMinRange(int minRange)
		{
			this.minRange = minRange;
		}

		public void setTolerance(double tolerance)
		{
			this.tolerance = tolerance;
		}

		//these modifiers exist in the ReligBonuses, but are in Religion for convenience
		public void setBonusTax(double bonus)
		{
			this.setBonusTax = bonus;
		}

		public void setBonusTrade(double bonus)
		{
			this.setBonusTrade = bonus;
		}

		public void setBonusStability(double bonus)
		{
			this.setBonusStability = bonus;
		}

		public void setBonusTech(double bonus)
		{
			this.setBonusTech = bonus;
		}
	}
}

