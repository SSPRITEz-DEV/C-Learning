using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Dictionarys
    {

        public static void Run()
        {
            var RGB = new Dictionary<string, int>()
           {
               {"R", 255 },
               {"G", 0 },
               {"B", 0 }
           };

            Console.WriteLine(RGB["R"]);
        }
    }
}
