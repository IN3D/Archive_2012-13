using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class Character
    {
        /*Rather than having to come up with a unique id for each
         *characer this personCount int should increment in every constructor
         *and every id should be set to personCount.*/
        private long personCount = 0;
        #region variables
		private long ID;
		private double wealth;
        private double piety;
        private double prestiege;
		private Religion religion;
        #endregion

        Belief belief = new Belief();

        #region constructors
		//default constructor
		public Character()
		{
			this.ID = personCount;
			this.wealth = 0.0;
            this.piety = 0.0;
            this.prestiege = 0.0;
			this.religion = belief.setCatholic;
            //increment the counter
            personCount++;
        }
        public Character(double wealth, double piety, double prestiege, Religion religion)
        {
            this.ID = personCount;
            this.wealth = wealth;
            this.piety = piety;
            this.prestiege = prestiege;
            this.religion = religion;
            //increment the counter
            personCount++;
        }
        //use this when person is born
        public Character(Character parent)
        {
            this.ID = personCount;
            this.wealth = 0.0;//characters aren't born with money
            this.piety = (parent.Piety) / 4;//children get a quarter of their parents piety
            this.prestiege = (parent.Prestiege) / 4;//and prestige
            this.religion = parent.Religion;
        }
        #endregion

        #region accessors
        public long getID
        {
            get { return ID; }
            //id should never be set
        }
        public double Wealth
        {
            get { return wealth; }
            set { wealth = value; }
        }
        public double Piety
        {
            get { return piety; }
            set { piety = value; }
        }
        public double Prestiege
        {
            get { return prestiege; }
            set { prestiege = value; }
        }
        public Religion Religion
        {
            get { return religion; }
            //no set
        }
        #endregion
    }
}