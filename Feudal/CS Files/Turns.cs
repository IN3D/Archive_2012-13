using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feudal
{
    class Turns
    {
        //HERE FOR DEV
        public class Province
        {
            public int Quality; //prosperity of province
            public int Population;  //population of province
            public int Stability; //stability of the province
            public int Tech_Military; //
            public int Tech_Economy; //
            public int Tech_Gov; //


            public Province(int Q, int P, int S, int tM, int tE, int tG) //constructor
            {
                Quality = Q;
                Population = P;
                Stability = S;
                Tech_Military = tM;
                Tech_Economy = tE;
                Tech_Gov = tG;
            }

        }
        public class Vassal
        {
            public static int Owns; //number of provinces owned
            public double Wealth; //vassals wealth
            public static int ID = 0; //ids the character

            public Vassal(int o, double w, int i)  //constructor
            {
                Owns = o;
                Wealth = w;
                ID = i;
            }

        }
        
        //fuction that handles the turn button
        //Eric 09-12-2013
        public static int TurnFuction(int counter)
        {
            string[] months = new string[] {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            var fm = feudalMainForm.ActiveForm as feudalMainForm;

             fm.lblMonthDate.Text = months[counter];



            return counter;
        }

        //handle how income is decided
        private static void IncomeFunction()
        {
            int int_provinceQuality;
            double dbl_provIncome= 0;

            Vassal Tom = new Vassal(2, 0.00, 1);
            Vassal Dick = new Vassal (1, 10.00, 2);    //he's a rich dick
            Vassal Harry = new Vassal(1, 2.00, 3);


            for (int i = 1; i <= 3; i++)
            {
                Vassal.ID = i;


                int count = Vassal.Owns;    //count is set equal to the number of provinces the vassal owns
                for (int x = 1; x <= count; x++)
                {
                    Random rand = new Random();
                    //for testing random province quality
                    int QualForMonth = rand.Next(1, 5);
                    int_provinceQuality = QualForMonth;
                }

            }

            ////province is booming
            //if (int_provinceQuality == 1)
            //{
            //    dbl_provIncome += 1.00;
            //}
            ////province is wealthy
            //else if (int_provinceQuality == 2)
            //{
            //    dbl_provIncome += .75;
            //}
            ////province is average
            //else if (int_provinceQuality == 3)
            //{
            //    dbl_provIncome += .50;
            //}
            ////province is poor
            //else if (int_provinceQuality == 4)
            //{
            //    dbl_provIncome += .25;
            //}
            ////province is damaged
            //else
            //{
            //    dbl_provIncome += 0.00;
            //}
                
        }
    }
}
