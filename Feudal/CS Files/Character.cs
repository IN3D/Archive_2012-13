using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class character
    {
        #region variables
        private int[] owns;
		private int ID;
		private double wealth;
        private double piety;
        private double prestiege;
		private object Religion;
        #endregion

        Belief belief = new Belief();

        #region constructors
        public character()
		{
            owns = new int[0];
			this.ID = 0;
			this.wealth = 0.0;
            this.piety = 0.0;
            this.prestiege = 0.0;
			//Religion religion = new Religion (belief.setCatholic());
			Religion religion = new Religion (belief.setCatholic ());
        }
        #endregion
    }
}