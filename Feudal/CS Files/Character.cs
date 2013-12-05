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

namespace feudal
{
	public class character
	{
		private int[] owns;
		private int ID;
		private double wealth;
	}
}