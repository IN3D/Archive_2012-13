using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Feudal
{
    public class Maps
    {
        public static Belief belief = new Belief();

        #region ArrayDeclaration
        Province[] provinces= {
        new Province("Province 1", .9, 1, 1000, .25, Color.Maroon, belief.setProtestantC),
        new Province("Province 2", .8, 1, 1005, .35, Color.Red, belief.setProtestantC),
        new Province("Province 3", .75, .9, 995, .15, Color.Brown, belief.setFundamentalist),
        new Province("Province 4", .8, 1, 1020, .3, Color.Firebrick, belief.setProtestantC),
        new Province("Province 5", .85, .9, 1010, .3, Color.IndianRed, belief.setProtestantL),
        new Province("Province 6", .9, 1, 1050, .45, Color.DarkGoldenrod, belief.setProtestantL),
        new Province("Province 7", .8, .9, 990, .2, Color.Goldenrod, belief.setProtestantC),
        new Province("Province 8", .9, 1, 1065, .35, Color.Gold, belief.setProtestantL),
        new Province("Province 9", .85, .9, 1000, .3, Color.Khaki, belief.setProtestantL),
        new Province("Province 10", .8, .9, 1015, .4, Color.Yellow, belief.setProtestantC),
        new Province("Province 11", .75, 1, 1010, .25, Color.DarkOliveGreen, belief.setProtestantC),
        new Province("Province 12", .85, .95, 1005, .2, Color.OliveDrab, belief.setProtestantC),
        new Province("Province 13", .8, .95, 1095, .15, Color.YellowGreen, belief.setFundamentalist),
        new Province("Province 14", .85, .9, 1010, .2, Color.LimeGreen, belief.setFundamentalist),
        new Province("Province 15", .8, .9, 1020, .15, Color.PaleGreen, belief.setFundamentalist),
        new Province("Province 16", .8, .85, 1025, .2, Color.DarkSlateGray, belief.setProtestantL),
        new Province("Province 17", .85, .9, 1010, .3, Color.Teal, belief.setProtestantL),
        new Province("Province 18", .8, .9, 1015, .35, Color.LightSeaGreen, belief.setCatholic),
        new Province("Province 19", .9, 1, 1000, .4, Color.MediumSeaGreen, belief.setCatholic),
        new Province("Province 20", .8, .9, 1010, .3, Color.MediumTurquoise, belief.setCatholic),
        new Province("Province 21", .85, .9, 1005, .25, Color.Indigo, belief.setOrthodox),
        new Province("Province 22", .9, .9, 1055, .45, Color.DarkViolet, belief.setOrthodox),
        new Province("Province 23", .8, .85, 1025, .35, Color.DarkOrchid, belief.setOrthodox),
        new Province("Province 24", .8, .85, 1010, .3, Color.MediumPurple, belief.setCatholic),
        new Province("Province 25", .85, .9, 1015, .35, Color.Thistle, belief.setCatholic)};
        #endregion

        #region accessors
        public string getProvinceName(int i)
        {
            return provinces[i].ProvinceName;
        }
        public double getProvinceQuality(int i)
        {
            return provinces[i].Quality;
        }
        public double getProvinceStability(int i)
        {
            return provinces[i].Stability;
        }
        public double getProvincePopulation(int i)
        {
            return provinces[i].Population;
        }
        public double getProvinceWealth(int i)
        {
            return provinces[i].Wealth;
        }
        public Color getProvinceColor(int i)
        {
            return provinces[i].Color;
        }
        #endregion

        #region modifiers
        public void setProvinceName(int i, String s)
        {
            provinces[i].ProvinceName = s;
        }
        public void setProvinceQuality(int i, double d)
        {
            provinces[i].Quality = d;
        }
        public void setProvinceStability(int i, double d)
        {
            provinces[i].Stability = d;
        }
        public void setProvincePopulation(int i, double d)
        {
            provinces[i].Population = d;
        }
        public void setProvinceWealth(int i, double d)
        {
            provinces[i].Wealth = d;
        }
        #endregion
    }
}
