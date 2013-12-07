using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
	public class character
	{
		private int[] owns;
		private int ID;
		private double wealth;
		private object Religion;

		ReligionTypes belief = new ReligionTypes();

		public character()
		{
            owns = new int[0];
			this.ID = 0;
			this.wealth = 0.0;
			Religion religion = new Religion (belief.catholic);
		}
	}
}