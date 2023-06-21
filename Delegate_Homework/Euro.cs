using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulKursi
{
    internal static class Euro
    {
        
        public static float EuroToSum(float euro, float bozordagiNarxiBirEuroni)
        {
            Console.WriteLine($"{euro} Euro : {euro * bozordagiNarxiBirEuroni} so'm");
            return euro * bozordagiNarxiBirEuroni;
        }
    }
}
