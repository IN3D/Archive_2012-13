using System;
using System.Drawing;

namespace Feudal
{
	public class Belief
    {
        #region denomination_declarations
        //When declaring new Religions this is the format of the constructor
        //(Name of the religion, family of the religion, max zeal range, min zeal range, tolerance, bonusTax, bonusTrade, bonusStability, bonusTech)

        //TODO: Note, I honestly just threw some numbers in there that seemed sorta right. Right now my goal is to just have them usable.
        //not necessarily fully featured and balanced (yet).
        //TODO: if there is a way these can be relative the should eventually be

        #region christian_denominations
        private Religion catholic = new Religion("Catholic", "Christian", 10, 1, 1.0, 0.5, -0.35, 0.35, -0.1, 
        "C:\\Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Catholic.png");
        private Religion orthodox = new Religion("Orthodox", "Christian", 10, 1, 1.0, 0.5, -0.25, 0.35, 0.0,
        "C:\\Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Orthodox.png");
        private Religion protestant_Lib = new Religion("Liberal Protestant", "Christian", 6, 1, 1.25, 0.0, 0.25, 0.25, 0.15,
        "C:\\Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Protestant_Liberal.png");
        private Religion protestant_Con = new Religion("Conservative Protestant", "Christian", 7, 4, 0.85, 0.25, 0.35, 0.40, -0.20,
        "C:Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Protestant_Conservative.png");
        private Religion fundamentalist = new Religion("Fundamentalist", "Christian", 10, 7, 0.25, 0.75, 0.25, 0.75, -0.7,
        "C:\\Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Fundamentalism.png");
        private Religion mormanism = new Religion("Mormonism", "Christian", 10, 4, 0.75, 0.60, -0.20, 0.50, -0.35,
        "C:\\Users\\Eric\\Documents\\GitHub\\Feudal\\Feudal\\Resources\\religIcons\\Christian\\Religion_Christianity_Mormanism.png");
        #endregion
        /*UNDO
        #region muslim_denominations
        private Religion shiite = new Religion("Shiite", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0,
        "..\\Resources\\religIcons\\Islam\\Religion_Islam_Shiite.png");
        private Religion sunni = new Religion("Sunni", "Islam", 10, 4, 1.0, 0.35, 0.1, 0.25, 0.0,
        "..\\Resources\\religIcons\\Islam\\Religion_Islam_Sunni.png");
        private Religion mutazila = new Religion("Mu'tazila", "Islam", 4, 1, 1.25, 0.0, 0.25, 0.15, 0.35,
        "..\\Resources\\religIcons\\Islam\\Religion_Islam_Mu'tazila.png");
        #endregion

        #region judaism_denominations
        private Religion judaism = new Religion("Judaism", "Judaism", 10, 1, 1.0, 0.25, 0.35, 0.75, 0.2,
        "..\\Resources\\religIcons\\Other\\Religion_Judaism.png");
        #endregion

        #region buddhism_denominations
        private Religion theravada = new Religion("Theravada", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0,
        "..\\Resources\\religIcons\\Buddhism\\Religion_Buddhism_Theravada.png");
        private Religion mahayana = new Religion("Mahayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0,
        "..\\Resources\\religIcons\\Buddhism\\Religion_Buddhism_Mahayana.png");
        private Religion vajrayana = new Religion("Vajrayana", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0,
        "..\\Resources\\religIcons\\Buddhism\\Religion_Buddhism_Vajrayana.png");
        private Religion zen = new Religion("Zen", "Buddhism", 6, 1, 1.5, 0.0, 0.0, 0.75, 0.0,
        "..\\Resources\\religIcons\\Buddhism\\Religion_Buddhism_Zen.png");
        #endregion

        #region indian_denominations
        private Religion hinduism = new Religion("Hinduism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.50, 0.0,
        "..\\Resources\\religIcons\\Indian\\Religion_Hinduism.png");
        private Religion sikhism = new Religion("Sikhism", "Indian", 7, 1, 1.0, 0.0, 0.25, 0.60, 0.1,
        "..\\Resources\\religIcons\\Indian\\Religion_Sikhism.png");
        private Religion zoroastrianism = new Religion("Zoroastrianism", "Indian", 7, 1, 1.0, 0.0, 0.3, 0.2, 0.1,
        "..\\Resources\\religIcons\\Other\\Religion_Zoroastrianism.png");
        #endregion

        #region eastern_denominations
        private Religion taoism = new Religion("Taoism", "Eastern", 5, 1, 1.35, 0.0, 0.0, 0.3, 0.25,
        "..\\Resources\\religIcons\\Eastern\\Religion_Eastern_Taoism.png");
        private Religion confucian = new Religion("Confucian", "Eastern", 5, 1, 1.0, 0.25, 0.2, 0.8, 0.0,
        "..\\Resources\\religIcons\\Eastern\\Religion_Eastern_Confucian.png");
        private Religion shinto = new Religion("Shinto", "Eastern", 6, 1, 1.0, 0.2, 0.0, 0.65, 0.15,
        "..\\Resources\\religIcons\\Eastern\\Religion_Eastern_Shinto.png");
        #endregion

        #region pagan_denominations
        //TODO: Add pagan religions
        #endregion

        #region irreligion_denominations
        private Religion irreligion = new Religion("Irreligion", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00,
        "..\\Resources\\religIcons\\Other\\Religion_Irreligion_Humanism.png");
        private Religion atheism = new Religion("Atheism", "Irreligion", 0, 0, 1.75, 0.0, 0.0, -0.05, 1.00,
        "..\\Resources\\religIcons\\Irreligion\\Religion_Irreligion_Atheism.png");
        #endregion

        #endregion
        UNDO*/
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
        /*UNDO
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
        UNDO*/
        #endregion
        #endregion//KILL ME LATER
    }
}