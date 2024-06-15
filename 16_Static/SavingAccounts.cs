using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_Static
{
    public class SavingAccounts
    {
        public static double currInterestRate = 0.4;
        public static double bondRate;
        public SavingAccounts()
        {
            currInterestRate = 0.4;
        }

        public static void AddBondRate() {
            currInterestRate = bondRate + 0.1;
        }
    }
}