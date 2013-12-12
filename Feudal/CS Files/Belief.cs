using System;
namespace Feudal
{
	public class Belief
	{
        //When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)

        //TODO: Note, I honestly just threw some numbers in there that seemed sorta right. Right now my goal is to just have them usable.
        //not necessarily fully featured and balanced (yet).
        //TODO: also, for best practice these should be private, and have accessors to them, not be public. So fix this later.

        //Christian Denominations//
        private Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.35, 0.35, -0.1);
        private Religion orthodox = new Religion("Orthodox", "Christian", 10, 1, 1.0, 0.5, -0.25, 0.35, 0.0);
        private Religion protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.25, 0.0, 0.25, 0.25, 0.15);
        private Religion protestant_Con = new Religion("Conservative Protestant", "Christian", 7, 4, 0.85, 0.25, 0.35, 0.40, -0.20);
        private Religion fundamentalist = new Religion("Fundamentalist", "Christian", 10, 7, 0.25, 0.75, 0.25, 0.75, -0.7);
        private Religion mormanism = new Religion("Mormonism", "Christian", 10, 4, 0.75, 0.60, -0.20, 0.50, -0.35);

        //Islam Denominations//
        private Religion shiite = new Religion("Shiite", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        private Religion sunni = new Religion("Sunni", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        private Religion mutazila = new Religion("Mu'tazila", "Islam", 4, 1, 1.25, 0.0, 0.25, 0.15, 0.35);

        //Judaism//
        private Religion judaism = new Religion("Judaism", "Judaism", 10, 1, 1.0, 0.25, 0.35, 0.75, 0.2);

        //Buddhism//
        private Religion theravada = new Religion("Theravada", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion mahayana = new Religion("Mahayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion vajrayana = new Religion("Vajrayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion zen = new Religion("Zen", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);

        //Indian Religions//
        private Religion hinduism = new Religion("Hinduism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.50, 0.0);
        private Religion sikhism = new Religion("Sikhism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.60, 0.1);
        private Religion zoroastrianism = new Religion("Zoroastrianism", "Indian", 7, 1, 1.0, 0.0, 0.3, 0.2, 0.1);

        //Eastern Philosophy//
        private Religion taoism = new Religion("Taoism", "Eastern", 5, 1, 1.35, 0.0, 0.0, 0.3, 0.25);
        private Religion confucian = new Religion("Confucian", "Eastern", 5, 1, 1.0, 0.25, 0.2, 0.8, 0.0);
        private Religion shinto = new Religion("Shinto", "Eastern", 6, 1, 1.0, 0.2, 0.0, 0.65, 0.15);

        //Pagan Religions//
        //TODO: Add pagan religions

        //Irreligion//
        private Religion irreligion = new Religion("Irreligion", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);
        private Religion atheism = new Religion("Atheism", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);


		public Belief ()
		{
            //...the answers to life
		}
        //!!--Accessors for Religions--!!//
        //TODO: in the future it will probably pay to have two sets of accessors for initially setting the religion, and for conversions
        //their mechanics will likely be different.

        //Christian accessors
        public Religion setCatholic()
        {
            return catholic;
        }
        public Religion setOrthodox()
        {
            return orthodox;
        }
        public Religion setProtestantL()
        {
            return protestant_Lib;
        }
        public Religion setProtestantC()
        {
            return protestant_Con;
        }
        public Religion setFundamentalist()
        {
            return fundamentalist;
        }
        public Religion setMormon()
        {
            return mormanism;
        }

        //Muslim accessors
        public Religion setShiite()
        {
            return shiite;
        }
        public Religion setSunni()
        {
            return sunni;
        }
        public Religion setMutazila()
        {
            return mutazila;
        }

        //Jewish accessor(s?) //maybe there should be more?
        public Religion setJewish()
        {
            return judaism;
        }

        //Buddhism accessors
        public Religion setTheravada()
        {
            return theravada;
        }
        public Religion setMahayana()
        {
            return mahayana;
        }
        public Religion setVajrayana()
        {
            return vajrayana;
        }
        public Religion setZen()
        {
            return zen;
        }

        //Indian accessors
        public Religion setHinduism()
        {
            return hinduism;
        }
        public Religion setSikhism()
        {
            return sikhism;
        }
        public Religion setZoroastrianism()
        {
            return zoroastrianism;
        }

        //Eastern accessors
        public Religion setTaoism()
        {
            return taoism;
        }
        public Religion setConfucian()
        {
            return confucian;
        }
        public Religion setShinto()
        {
            return shinto;
        }

        //Pagan accessors
        //TODO:add Pagan Accessors

        //Irreligion accessors
        public Religion setIrreligious()
        {
            return irreligion;
        }
        public Religion setAtheist()
        {
            return atheism;
        }
	}
}

