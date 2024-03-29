﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Feudal
{
    public class AI
    {
        public delegate void AdviseParentEventHandler(int chosenProvince, Character player);
        public event AdviseParentEventHandler AdviseParent;
        
        #region declarations
        Maps maps = new Maps();
        //feudalMainForm fmf = new feudalMainForm();
        #endregion

        //declarations
        int bestOption = 0;
        double bestOptionVal = 0.0;
        bool contender = false;
        int contenderOption = 0;
        double contenderOptionVal = 0.0;
        int bestCounter = 0;
        int contenderCounter = 0;

        //prototype, this should eventually go through a linklist
        public void ComputeMove(Character player)
        {
            for (int i = 0; i < maps.provinces.Length; i++)
            {
                if (maps.provinces[i].OwnerID == player.getID)//a province is found that the player owns
                {
                    for (int j = 0; j < maps.provinces[i].neighbors.Length; j++)//go through it's neighbors
                    {
                        int neighboringProv = maps.provinces[i].neighbors[j];
                        if (maps.provinces[neighboringProv].OwnerID != player.getID)//if the player doesn't own that neighboring province
                        {
                            if (maps.provinces[neighboringProv].OwnerID != player.getID)//if the player doesn't already own the province
                            {
                                double initValue = maps.provinces[neighboringProv].Wealth * maps.provinces[neighboringProv].Population;
                                double finalVal = initValue * maps.provinces[neighboringProv].Stability;

                                if (finalVal > bestOptionVal)//if the province evalued is better, replace the values.
                                {
                                    bestOption = neighboringProv;
                                    bestOptionVal = finalVal;

                                    if (bestOptionVal >= contenderOptionVal)//if a newer, better value is found set contender to false.
                                    {
                                        contender = false;
                                    }
                                }
                                else if (finalVal == bestOptionVal)//if the values are even.
                                {
                                    contender = true;
                                    contenderOption = neighboringProv;
                                    contenderOptionVal = finalVal;
                                }
                                else
                                {
                                    //the value was lower so skip it
                                }
                            }
                            else
                            {
                                //the player owns it so skip it
                            }
                        }
                        else
                        {
                            //player owns it so ignore it
                        }
                    }
                }
                else
                {
                    //player doesn't own it so keep going...
                }
            }


            if (contender)//if there was a situation where there was a tie
            {
                for (int a = 0; a < maps.provinces[bestOption].neighbors.Length; a++)//prefer the "blobbiest" option.
                {
                    int evalNum = maps.provinces[bestOption].neighbors[a];


                    if (maps.provinces[evalNum].OwnerID == player.getID)
                    {
                        bestCounter++;
                    }
                    else
                    {
                        //do nothing
                    }
                }

                for (int b = 0; b < maps.provinces[contenderOption].neighbors.Length; b++)
                {
                    int contenderNum = maps.provinces[contenderOption].neighbors[b];

                    if (maps.provinces[contenderNum].OwnerID == player.getID)
                    {
                        contenderCounter++;
                    }
                    else
                    {
                        //do nothing.
                    }
                }

                if (bestCounter >= contenderCounter)
                {
                    maps.setProvinceOwnerID(bestOption, player.getID);
                    updateButton(bestOption, player);

                    resetValues();
                }
                else
                {
                    maps.setProvinceOwnerID(contenderOption, player.getID);
                    updateButton(contenderOption, player);

                    resetValues();
                }
            }
            else//if there was no conflict
            {
                maps.setProvinceOwnerID(bestOption, player.getID);
                updateButton(bestOption, player);
                resetValues();
            }
        }

        public void resetValues()
        {
            //reset the vals
            bestOption = 0;
            bestOptionVal = 0.0;
            contender = false;
            contenderOption = 0;
            contenderOptionVal = 0.0;
            bestCounter = 0;
            contenderCounter = 0;
        }

        public void updateButton(int chosenProvince, Character player)
        {
            if (AdviseParent != null)
            {
                AdviseParent(chosenProvince, player);
            }
            
            //fmf.Controls.Find(maps.provinces[chosenProvince].ButtonName, true).FirstOrDefault().BackColor =
            //    maps.getProvinceColor(player.CapitalProvID);
        }
    }
}
