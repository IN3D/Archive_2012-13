using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/***
Documentation:
TODO:
this will need a revamp. I'm mostly unsure of how owns[] should be implemented.
Because on end turn each characrer will need to have money added or deducted from their account
based on the provinces they own. It might make more sense to manage this through provinces, and then finding THEIR
owner and giving them money rather than stepping through every character, checking if they have ownership, 
finding what they own and then giving them money.
-Eric 12-03-2013
***/

namespace Feudal
{
	public class character
	{
		private int[] owns;
		private int ID;
		private double wealth;
		private object Religion;

		//TODO: should we declare religions up here? like this?
		Religion christianity_catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.5, 0.35, -0.1);
		//or this?
		Religions religions = new Religions();

		public character()
		{
            owns = new int[0];
			this.ID = 0;
			this.wealth = 0.0;
			//option 1
			//Religion religion = new Religions (christianity_catholic);
			//option 2
			//Religion religion = new Religions (religions.catholic);
		}
	}
}