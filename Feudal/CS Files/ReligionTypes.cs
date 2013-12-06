using System;
//TODO: I don't know if this will work the way I think it will
namespace Feudal
{
	public class ReligionTypes
	{
		//See Religion_WriteUp in resources folder of dropbox for list of religions to implement.
        //When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)

        //Christian Denominations//
        public Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.5, 0.35, -0.1);
        public Religion Protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.0, 0.0, 0.25, 0.25, 0.0);
        //TODO: Finish Christian denominations

        //Islam Denominations//
        //TODO: Finish Islam denominations

        //Judaism//
        //TODO: add Judaism

        //Buddhism//
        //TODO: add Buddhism denominations

        //Indian Religions//
        //TODO: add Indian religions

        //Eastern Philosophy//
        //TODO: add Eastern philosophies

        //Pagan Religions//
        //TODO: Add pagan religions

        //Irreligion//
        //TODO: Add irreligion


		public ReligionTypes ()
		{
            //...the answers to life
		}
	}
}

