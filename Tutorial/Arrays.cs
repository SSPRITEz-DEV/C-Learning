using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Arrays
    {
        public static void Run()
        {
            //String a[5] = {"a", "b", "c", "d", "e"};
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            x[1] = 10;

            /// D array
            List<String> friendname = new List<String>();
            friendname.Add("Por");
            friendname.Add("Folk");

            // Loop Oldschool
            for (int i = 0; i < friendname.Count; i++)
            {
                Console.WriteLine(friendname[i]);
            }

            // NewLoop
            foreach (String name in friendname){Console.WriteLine(name);}



            List<String> DogName = new List<String>() { "Taro", "Chaos" ,"Too"};
            DogName.Remove("Taro");
            DogName.RemoveAt(1);

            //Console.WriteLine(DogName[0]);
        }
    }
}
