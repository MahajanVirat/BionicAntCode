using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAntsArmy
{
    public class BionicAnt
    {
        #region Class Variables
        private int intXmax, intYmax;
        private int intXcord, intYcord;
        private char chDirection;
        private string strOutput;
        #endregion
        #region Constructors
        public BionicAnt(int XCord, int YCord)
        {
            if (XCord <= 0 || YCord <= 0)
            {
                throw new Exception("Invalid values for upper right coordinates.");
            }
            intXmax = XCord;
            intYmax = YCord;
        }
        #endregion
        #region Private Methods
        private void BeginDeploy(int XCord, int YCord, char Direction)
        {
            try
            {
                if (XCord > intXmax || YCord > intYmax)
                {
                    throw new Exception("Input coordinates out of range");
                }
                else if (XCord < 0 || YCord < 0)
                {
                    throw new Exception("Input coordinates should not be negative");
                }
                else
                {
                    intYcord = YCord;
                    intXcord = XCord;
                    chDirection = char.Parse(Direction.ToString().ToLower());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private char FindCurrentDirection(string Currentpos)
        {
            try
            {
                switch (Currentpos)
                {
                    case "nl":
                        return 'w';

                    case "nr":
                        return 'e';

                    case "sl":
                        return 'e';

                    case "sr":
                        return 'w';

                    case "wl":
                        return 's';

                    case "wr":
                        return 'n';

                    case "el":
                        return 'n';

                    case "er":
                        return 's';

                    default:
                        throw new Exception("Invalid position provided, it could be either nl,nr,sl,sr,wl,wr,el or er");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private string FindCurrentCoordinates(int XCord, int YCord, char CurrentPos)
        {
            try
            {
                switch (CurrentPos)
                {
                    case 'n':
                        {
                            YCord++;                        
                            return $"{XCord.ToString()}{" "}{YCord.ToString()}{" "}{CurrentPos.ToString().ToUpper()}";
                        }
                    case 's':
                        {
                            YCord--;
                            return $"{XCord.ToString()}{" "}{YCord.ToString()}{" "}{CurrentPos.ToString().ToUpper()}";
                        }
                    case 'w':
                        {

                            XCord--;
                            return $"{XCord.ToString()}{" "}{YCord.ToString()}{" "}{CurrentPos.ToString().ToUpper()}";
                        }
                    case 'e':
                        {
                            XCord++;
                            return $"{XCord.ToString()}{" "}{YCord.ToString()}{" "}{CurrentPos.ToString().ToUpper()}";
                        }
                    default:
                        throw new Exception("Invalid direction provided, it should be either n,s,w or e");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
        #region Public Methods
        public string NavigateToPlateu(int XCord, int YCord, char Direction, string NavInstructions)
        {
            try
            {
                //First Line of Input, setting up the current Coordinates and Direction
                BeginDeploy(XCord, YCord, Direction);

                foreach (char chInst in NavInstructions.ToLower())
                {
                    if (chInst == 'l' || chInst == 'r')
                    {       
                        chDirection = FindCurrentDirection($"{chDirection.ToString()}{chInst.ToString()}");
                    }
                    else if (chInst == 'm')
                    {
                        strOutput = FindCurrentCoordinates(intXcord, intYcord, chDirection);
                        intXcord = int.Parse(strOutput.Split(' ')[0]);
                        intYcord = int.Parse(strOutput.Split(' ')[1]);
                    }
                    else
                    {
                        throw new Exception("Invalid instructions provided");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return strOutput;
        }
        #endregion
    }
}
