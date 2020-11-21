using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class ArrayUtilitys
    {
        public static void Run()
        {
            String[] numbers = new String[] 
            { "one", "two", "pee", "dota", "csgo", "pubg", "valorant", "albion", "gtav" };

            int v = Array.FindIndex(numbers, element => element == "pubg" );
            //Console.WriteLine(v);

            // FindAll like filter
            int[] xnumbers = new int[]
            {1,2,3,4,5,6,7,8,9,10};
            var x = Array.FindAll(xnumbers, e => e > 5);
            foreach (int z in x)
            {
                Console.WriteLine(z);
            }
            
        }
    }
}
