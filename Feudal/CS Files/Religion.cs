using System;
using System.Windows;
using System.Drawing;

namespace Feudal
{
    public abstract class ReligBonuses
    {
        #region variables
        private double bonusTax;
        private double bonusTrade;
        private double bonusStability;
        private double bonusTech;
        #endregion

        #region accessors
        public double BonusTax
        {
            get { return bonusTax; }
            set { bonusTax = value; }
        }
        public double BonusTrade
        {
            get { return bonusTrade; }
            set { bonusTrade = value; }
        }
        public double BonusStability
        {
            get { return bonusStability; }
            set { bonusStability = value; }
        }
        public double BonusTech
        {
            get { return bonusTech; }
            set { bonusTech = value; }

        }
        #endregion

    }

    public class Religion : ReligBonuses
    {
        #region variables
            private string name;
            private string family;
            private int maxRange;//maybe not use these, but for now they
            private int minRange;//were part of the original 
            private double tolerance;
            private object ReligBonuses;
            private string fileLoc;
            private Image icon;
            //maybe make a bonuses class
            //to have religion extend?
            /*
            private double bonusTax;
            private double bonusTrade;
            private double bonusStability;
            private double bonusTech;
            */
            #endregion

        #region constructors
            //don't use default
            public Religion()
            {
                name = "Not a religion";
                family = "NULL";
                maxRange = 10;
                minRange = 1;
                tolerance = 3.0;
                BonusTax = 0.0;
                BonusTrade = 0.0;
                BonusTech = 0.0;
                BonusStability = 0.0;
                icon = Image.FromFile("..\\Resources\\religIcons\\Other\\Question_mark.png");
                //var bonuses = ReligBonuses(0.0, 0.0, 0.0, 0.0) as ReligBonuses;
            }

            //actually use this one
            public Religion(string name, string family, int maxRange, int minRange,
                           double tolerance, double bonusTax, double bonusTrade, double bonusStability,
                           double bonusTech, string fileLoc)
            {
                this.name = name;
                this.family = family;
                this.maxRange = maxRange;
                this.minRange = minRange;
                this.tolerance = tolerance;
                //ReligBonuses
                this.BonusTrade = bonusTrade;
                this.BonusTax = bonusTax;
                this.BonusTech = bonusTech;
                this.BonusStability = bonusStability;
                //Image
                try
                {
                    this.Icon = Image.FromFile(fileLoc);
                }
                catch
                {
                    Console.WriteLine("Could not find " + fileLoc);
                }
            }
            //deep copy constructor
            public Religion(Religion e)
            {
                this.name = e.Name;
                this.family = e.Family;
                this.maxRange = e.MaxRange;
                this.minRange = e.MinRange;
                this.tolerance = e.Tolerance;
                //ReligBonuses
                this.BonusTax = e.BonusTax;
                this.BonusTrade = e.BonusTrade;
                this.BonusTech = e.BonusTech;
                this.BonusStability = e.BonusStability;
            }
            #endregion

        #region accessors
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Family
            {
                get { return family; }
                set { family = value; }
            }

            public int MaxRange
            {
                get { return maxRange; }
                set { maxRange = value; }
            }

            public int MinRange
            {
                get { return minRange; }
                set { minRange = value; }
            }

            public double Tolerance
            {
                get { return tolerance; }
                set { tolerance = value; }
            }
            public Image Icon//This doesn't seem to WAD
            {
                get { return icon; }
                set { icon = value; }
            }
            public string FileLoc
            {
                get { return fileLoc; }
                set { fileLoc = value; }
            }
            public void ChangeIcon(Religion r)
            {
                try
                {
                    this.Icon = Image.FromFile(r.fileLoc);
                }
                catch
                {
                    Console.WriteLine("Could not find object's " + r.fileLoc);
                }
            }
            public double getBonusTax
            {
                get { return this.BonusTax; }
                set { this.BonusTax = value; }
            }
            #endregion
    }
}