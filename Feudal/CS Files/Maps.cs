﻿using System;
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

        #region provNeighborArrays
        //unfortunately, I can't think of a better way to do this as it stands
        //I feel like there ought to be a better way to pass arrays into the constructor
        //but atm, this is the best I could find -Eric
        public static int[] prov1 = {2, 6, 7};
        public static int[] prov2 = {1, 6, 7, 8, 3};
        public static int[] prov3 = {2, 7, 8, 9, 4};
        public static int[] prov4 = {3, 8, 9, 10, 5};
        public static int[] prov5 = {4, 9, 10};
        public static int[] prov6 = {1, 2, 7, 11, 12};
        public static int[] prov7 = {1, 2, 3, 6, 8, 11, 12, 13};
        public static int[] prov8 = {2, 3, 4, 7, 9, 12, 13, 14};
        public static int[] prov9 = {3, 4, 5, 8, 10, 13, 14, 15};
        public static int[] prov10 = {4, 5, 9, 14, 15};
        public static int[] prov11 = {6, 7, 12, 16, 17};
        public static int[] prov12 = {6, 7, 8, 11, 13, 16, 17, 18};
        public static int[] prov13 = {7, 8, 9, 12, 14, 17, 18, 19};
        public static int[] prov14 = {8, 9, 10, 13, 15, 18, 19, 20};
        public static int[] prov15 = {9, 10, 14, 19, 20};
        public static int[] prov16 = {11, 12, 17, 21, 22};
        public static int[] prov17 = {11, 12, 13, 16, 18, 21, 22, 23};
        public static int[] prov18 = {12, 13, 14, 17, 19, 22, 23, 24};
        public static int[] prov19 = {13, 14, 15, 18, 20, 23, 24, 25};
        public static int[] prov20 = {14, 15, 19, 24, 25};
        public static int[] prov21 = {16, 17, 22};
        public static int[] prov22 = {21, 16, 17, 18, 23};
        public static int[] prov23 = {22, 17, 18, 19, 24};
        public static int[] prov24 = {23, 18, 19, 20, 25};
        public static int[] prov25 = {24, 19, 20};
        #endregion

        #region ArrayDeclaration
        static Province p1 = new Province("Province 1", .9, 1, 1000, .25, Color.Maroon, belief.setProtestantC);
        static Province p2 = new Province("Province 2", .8, 1, 1005, .35, Color.Red, belief.setProtestantC);
        static Province p3 = new Province("Province 3", .75, .9, 995, .15, Color.Brown, belief.setFundamentalist);
        static Province p4 = new Province("Province 4", .8, 1, 1020, .3, Color.Firebrick, belief.setProtestantC);
        static Province p5 = new Province("Province 5", .85, .9, 1010, .3, Color.IndianRed, belief.setProtestantL);
        static Province p6 = new Province("Province 6", .9, 1, 1050, .45, Color.DarkGoldenrod, belief.setProtestantL);
        static Province p7 = new Province("Province 7", .8, .9, 990, .2, Color.Goldenrod, belief.setProtestantC);
        static Province p8 = new Province("Province 8", .9, 1, 1065, .35, Color.Gold, belief.setProtestantL);
        static Province p9 = new Province("Province 9", .85, .9, 1000, .3, Color.Khaki, belief.setProtestantL);
        static Province p10 = new Province("Province 10", .8, .9, 1015, .4, Color.Yellow, belief.setProtestantC);
        static Province p11 = new Province("Province 11", .75, 1, 1010, .25, Color.DarkOliveGreen, belief.setProtestantC);
        static Province p12 = new Province("Province 12", .85, .95, 1005, .2, Color.OliveDrab, belief.setProtestantC);
        static Province p13 = new Province("Province 13", .8, .95, 1095, .15, Color.YellowGreen, belief.setFundamentalist);
        static Province p14 = new Province("Province 14", .85, .9, 1010, .2, Color.LimeGreen, belief.setFundamentalist);
        static Province p15 = new Province("Province 15", .8, .9, 1020, .15, Color.PaleGreen, belief.setFundamentalist);
        static Province p16 = new Province("Province 16", .8, .85, 1025, .2, Color.DarkSlateGray, belief.setProtestantL);
        static Province p17 = new Province("Province 17", .85, .9, 1010, .3, Color.Teal, belief.setProtestantL);
        static Province p18 = new Province("Province 18", .8, .9, 1015, .35, Color.LightSeaGreen, belief.setCatholic);
        static Province p19 = new Province("Province 19", .9, 1, 1000, .4, Color.MediumSeaGreen, belief.setCatholic);
        static Province p20 = new Province("Province 20", .8, .9, 1010, .3, Color.MediumTurquoise, belief.setCatholic);
        static Province p21 = new Province("Province 21", .85, .9, 1005, .25, Color.Indigo, belief.setOrthodox);
        static Province p22 = new Province("Province 22", .9, .9, 1055, .45, Color.DarkViolet, belief.setOrthodox);
        static Province p23 = new Province("Province 23", .8, .85, 1025, .35, Color.DarkOrchid, belief.setOrthodox);
        static Province p24 = new Province("Province 24", .8, .85, 1010, .3, Color.MediumPurple, belief.setCatholic);
        static Province p25 = new Province("Province 25", .85, .9, 1015, .35, Color.Thistle, belief.setCatholic);
        #endregion

        Province[] provinces = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20,
                               p21, p22, p23, p24, p25};

        public Maps()
        {
            

        }

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
        public long getProvinceOwnerID(int i)
        {
            return provinces[i].OwnerID;
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
        public void setProvinceOwnerID(int provID, long charID)
        {
            provinces[provID].OwnerID = charID;
        }
        public void setProvinceColor(int provToChange, Character lord)
        {
            provinces[provToChange].Color = provinces[lord.CapitalProvID].Color;
        }
        #endregion

    }
}
