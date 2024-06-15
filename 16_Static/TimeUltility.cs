using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_Static
{
    public static class TimeUltility
    {
        public static void PrintTime() => System.Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}