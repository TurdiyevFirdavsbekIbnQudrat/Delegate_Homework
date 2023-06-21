using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulKursi
{
    internal class Dollar
    {
        public static float dollarToSum(float dollar, float bozordagiNarxiBirEuroni)
        {
            Console.WriteLine($"{dollar} dollar : {dollar * bozordagiNarxiBirEuroni} so'm");
            return dollar * bozordagiNarxiBirEuroni;
        }
    }
}
