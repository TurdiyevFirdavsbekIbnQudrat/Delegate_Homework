using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulKursi
{
    public static class Rubl
    {
        
        public static float RublToSum(float rubl, float bozordagiNarxiBirRublni)
        {
            Console.WriteLine($"{rubl} Rubl : {rubl * bozordagiNarxiBirRublni} so'm");
            return rubl * bozordagiNarxiBirRublni;
        }
    }
}
