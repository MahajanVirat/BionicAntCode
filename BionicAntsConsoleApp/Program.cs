using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BionicAntsArmy;

namespace BionicAntTest
{
    class Program
    {
        static void Main(string[] args)
        {       
            int intMaxx = 5;
            int intMaxy = 5;

            int intXCord = 1;
            int intYCord = 3;
            char chDirection = 'e';
            string strNavString = "MMRMMRMRRM";
          
            BionicAnt bionic = new BionicAnt(intMaxx, intMaxy);

            Console.WriteLine(bionic.NavigateToPlateu(intXCord,intYCord,chDirection,strNavString));

            Console.ReadKey();               
        }
    }
}
