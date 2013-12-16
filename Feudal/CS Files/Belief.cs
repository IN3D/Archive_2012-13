using System;
namespace Feudal
{
	public class Belief
    {
        #region denomination_declarations
        //When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)

        //TODO: Note, I honestly just threw some numbers in there that seemed sorta right. Right now my goal is to just have them usable.
        //not necessarily fully featured and balanced (yet).
        //TODO: also, for best practice these should be private, and have accessors to them, not be public. So fix this later.

        #region christian_denominations
        private Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.35, 0.35, -0.1);
        private Religion orthodox = new Religion("Orthodox", "Christian", 10, 1, 1.0, 0.5, -0.25, 0.35, 0.0);
        private Religion protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.25, 0.0, 0.25, 0.25, 0.15);
        private Religion protestant_Con = new Religion("Conservative Protestant", "Christian", 7, 4, 0.85, 0.25, 0.35, 0.40, -0.20);
        private Religion fundamentalist = new Religion("Fundamentalist", "Christian", 10, 7, 0.25, 0.75, 0.25, 0.75, -0.7);
        private Religion mormanism = new Religion("Mormonism", "Christian", 10, 4, 0.75, 0.60, -0.20, 0.50, -0.35);
        #endregion

        #region muslim_denominations
        private Religion shiite = new Religion("Shiite", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        private Religion sunni = new Religion("Sunni", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0);
        private Religion mutazila = new Religion("Mu'tazila", "Islam", 4, 1, 1.25, 0.0, 0.25, 0.15, 0.35);
        #endregion

        #region judaism_denominations
        private Religion judaism = new Religion("Judaism", "Judaism", 10, 1, 1.0, 0.25, 0.35, 0.75, 0.2);
        #endregion

        #region buddhism_denominations
        private Religion theravada = new Religion("Theravada", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion mahayana = new Religion("Mahayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion vajrayana = new Religion("Vajrayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        private Religion zen = new Religion("Zen", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0);
        #endregion

        #region indian_denominations
        private Religion hinduism = new Religion("Hinduism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.50, 0.0);
        private Religion sikhism = new Religion("Sikhism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.60, 0.1);
        private Religion zoroastrianism = new Religion("Zoroastrianism", "Indian", 7, 1, 1.0, 0.0, 0.3, 0.2, 0.1);
        #endregion

        #region eastern_denominations
        private Religion taoism = new Religion("Taoism", "Eastern", 5, 1, 1.35, 0.0, 0.0, 0.3, 0.25);
        private Religion confucian = new Religion("Confucian", "Eastern", 5, 1, 1.0, 0.25, 0.2, 0.8, 0.0);
        private Religion shinto = new Religion("Shinto", "Eastern", 6, 1, 1.0, 0.2, 0.0, 0.65, 0.15);
        #endregion

        #region pagan_denominations
        //TODO: Add pagan religions
        #endregion

        #region irreligion_denominations
        private Religion irreligion = new Religion("Irreligion", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);
        private Religion atheism = new Religion("Atheism", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00);
        #endregion

        #endregion

        public Belief ()
		{
            //...the answers to life
		}
        //!!--Accessors for Religions--!!//
        //TODO: in the future it will probably pay to have two sets of accessors for initially setting the religion,
		//and for conversions their mechanics will likely be different.
        #region accessors

        #region christian_accessors
        public Religion setCatholic
        {
			get { return catholic; }
        }
        public Religion setOrthodox
        {
			get { return orthodox; }
        }
        public Religion setProtestantL
        {
			get { return protestant_Lib; }
        }
        public Religion setProtestantC
        {
			get { return protestant_Con; }
        }
        public Religion setFundamentalist
        {
			get { return fundamentalist; }
        }
        public Religion setMormon
        {
			get { return mormanism; }
        }
        #endregion

        #region muslim_accessors
        public Religion setShiite
		{
			get { return shiite; }
		}
        public Religion setSunni
		{
			get { return sunni; }
		}
        public Religion setMutazila
		{
			get { return mutazila; }
		}
        #endregion

        #region jewish_accessors
        public Religion setJewish
		{
			get { return judaism; }
		}
        #endregion

        #region buddhism_accessors
        public Religion setTheravada
		{
			get { return theravada; }
		}
        public Religion setMahayana
		{
			get { return mahayana; }
		}
        public Religion setVajrayana
		{
			get { return vajrayana; }
		}
        public Religion setZen
		{
			get { return zen; }
		}
        #endregion

        #region indian_accessors
        public Religion setHinduism
		{
			get { return hinduism; }
		}
        public Religion setSikhism
		{
			get { return sikhism; }
		}
        public Religion setZoroastrianism
		{
			get { return zoroastrianism; }
		}
        #endregion

        #region eastern_accessors
        public Religion setTaoism
		{
			get { return taoism; }
		}
        public Religion setConfucian
		{
			get { return confucian; }
		}
        public Religion setShinto
		{
			get { return shinto; }
		}
        #endregion

        #region pagan_accessors
        //TODO:add Pagan Accessors
        #endregion

        #region irreligion_accessors
        public Religion setIrreligious
		{
			get { return irreligion; }
		}
        public Religion setAtheist
		{
			get { return atheism; }
		}
        #endregion

        #endregion
    }
}