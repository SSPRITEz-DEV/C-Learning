using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Functions
    {
        private static int checkInputNumber(int x)
        {
            if (x % 4 == 0) return 2;
            else return 1;
        }
        public static void Run()
        {
            int testyear = 1997;
            int resultx = checkInputNumber(testyear);
            Console.WriteLine(resultx);
        }


    }


}
