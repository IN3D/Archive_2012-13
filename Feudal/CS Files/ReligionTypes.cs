using System;
namespace Feudal
{
	public class ReligionTypes
	{
        //When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)

        //TODO: Note, I honestly just threw some numbers in there that seemed sorta right. Right now my goal is to just have them usable.
        //not necessarily fully featured and balanced (yet).
        //TODO: also, for best practice these should be private, and have accessors to them, not be public. So fix this later.

        //Christian Denominations//
        public Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.35, 0.35, -0.1);
        public Religion orthodox = new Religion("Orthodox", "Christian", 10, 1, 1.0, 0.5, -0.25, 0.35, 0.0);
        public Religion protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.25, 0.0, 0.25, 0.25, 0.15);
        public Religion protestant_Con = new Religion("Conservative Protestant", "Christian", 7, 4, 0.85, 0.25, 0.35, 0.40, -0.20);
        public Religion fundamentalist = new Religion("Fundamentalist", "Christian", 10, 7, 0.25, 0.75, 0.25, 0.75, -0.7);
        public Religion mormanism = new Religion("Mormonism", "Christian", 10, 4, 0.75, 0.60, -0.20, 0.50, -0.35);

        //Islam Denominations//
        public Religion shiite = new Religion("Shiite", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        public Religion sunni = new Religion("Sunni", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        public Religion mutazila = new Religion("Mu'tazila", "Islam", 4, 1, 1.25, 0.0, 0.25, 0.15, 0.35);

        //Judaism//
        public Religion judaism = new Religion("Judaism", "Judaism", 10, 1, 1.0, 0.25, 0.35, 0.75, 0.2);

        //Buddhism//
        public Religion theravada = new Religion("Theravada", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        public Religion mahayana = new Religion("Mahayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        public Religion vajrayana = new Religion("Vajrayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        public Religion zen = new Religion("Zen", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);

        //Indian Religions//
        public Religion hinduism = new Religion("Hinduism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.50, 0.0);
        public Religion sikhism = new Religion("Sikhism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.60, 0.1);
        public Religion zoroastrianism = new Religion("Zoroastrianism", "Indian", 7, 1, 1.0, 0.0, 0.3, 0.2, 0.1);

        //Eastern Philosophy//
        public Religion taoism = new Religion("Taoism", "Eastern", 5, 1, 1.35, 0.0, 0.0, 0.3, 0.25);
        public Religion confucian = new Religion("Confucian", "Eastern", 5, 1, 1.0, 0.25, 0.2, 0.8, 0.0);
        public Religion shinto = new Religion("Shinto", "Eastern", 6, 1, 1.0, 0.2, 0.0, 0.65, 0.15);

        //Pagan Religions//
        //TODO: Add pagan religions

        //Irreligion//
        public Religion irreligion = new Religion("Irreligion", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);
        public Religion atheism = new Religion("Atheism", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);


		public ReligionTypes ()
		{
            //...the answers to life
		}
	}
}

