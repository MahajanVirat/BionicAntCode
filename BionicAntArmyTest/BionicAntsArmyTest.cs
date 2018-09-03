using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BionicAntsArmy;
namespace BionicAntArmyTest
{
    [TestClass]
    public class BionicAntsArmyTest
    {
        [TestMethod]
        public void BionicAntTestOutput()
        {
            //Arrange
            int intMaxx = 5;
            int intMaxy = 5;
            int intXCord =3;
            int intYCord = 3;
            char chDirection = 'E';
            string strNavString= "MMRMMRMRRM";
            string strExpectedoutput = "5 1 E";
            string strActualoutput = "";

            //Act
            BionicAnt bionicAnt = new BionicAnt(intMaxx, intMaxy);
            strActualoutput = bionicAnt.NavigateToPlateu(intXCord, intYCord, chDirection, strNavString);

            //Assert
            Assert.AreEqual(strExpectedoutput, strActualoutput);
        }

        [TestMethod]
        public void BionicAntTestInvalidOutput()
        {
            //Arrange
            int intMaxx = 5;
            int intMaxy = 5;
            int intXCord = 3;
            int intYCord = 3;
            char chDirection = 'E';
            string strNavString = "MMRMMRMRRRRRRMMMMMMM";
            string strExpectedoutput = "5 1 E";
            string strActualoutput = "";

            //Act
            BionicAnt bionicAnt = new BionicAnt(intMaxx, intMaxy);
            strActualoutput = bionicAnt.NavigateToPlateu(intXCord, intYCord, chDirection, strNavString);

            //Assert
            Assert.AreNotEqual(strExpectedoutput, strActualoutput);
        }
        [TestMethod]
        public void BionicAntTestInvalidCoordinates()
        {
            //Arrange
            int intMaxx = 5;
            int intMaxy = 5;
            int intXCord = 7; //Input coordinates are bigger than max, so invalid input
            int intYCord = 3;
            char chDirection = 'E';
            string strNavString = "MMRMMRMRRM";
            string strExpectedoutput = "5 1 E";
            string strActualoutput = "";

            //Act
            BionicAnt bionicAnt = new BionicAnt(intMaxx, intMaxy);
            strActualoutput = bionicAnt.NavigateToPlateu(intXCord, intYCord, chDirection, strNavString);

            //Assert
            Assert.AreNotEqual(strExpectedoutput, strActualoutput);
        }

        [TestMethod]
        public void BionicAntTestInvalidNavString()
        {
            //Arrange
            int intMaxx = 5;
            int intMaxy = 5;
            int intXCord = 7; //Input coordinates are bigger than max, so invalid input
            int intYCord = 3;
            char chDirection = 'E';
            string strNavString = "12312312";
            string strExpectedoutput = "5 1 E";
            string strActualoutput = "";

            //Act
            BionicAnt bionicAnt = new BionicAnt(intMaxx, intMaxy);
            strActualoutput = bionicAnt.NavigateToPlateu(intXCord, intYCord, chDirection, strNavString);

            //Assert
            Assert.AreNotEqual(strExpectedoutput, strActualoutput);
        } 

    }
}
