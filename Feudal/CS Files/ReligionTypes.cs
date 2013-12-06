using System;
//TODO: I don't know if this will work the way I think it will
namespace Feudal
{
	public class ReligionTypes
	{
		//When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)
        private Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.5, 0.35, -0.1);
        private Religion Protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.0, 0.0, 0.25, 0.25, 0.0);

		public ReligionTypes ()
		{

			/*
			Religion christianity_catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.5, 0.35, -0.1);
			Religion christianity_Protestant = new Religion ("Protestant", "Christian", 6, 1, 1.0, 0.0, 0.25, 0.25, 0.0); 
			*/
		}
	}
}

