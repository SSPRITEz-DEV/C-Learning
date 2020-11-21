using System;

namespace Tutorial
{
    class Variables
    {
       public static void Run()
        {
            Console.WriteLine("Hello World!");

            //  Variables //
            char a = 'a', b = 'b';
            int i = 10;
            String x = "Test text string variable";
            float c = 1.2f;
            Boolean y = true;
            var zz = false;
            ///////////////

            Console.WriteLine("Text is : " + a + b + " and number is : " + i);
            Console.WriteLine($"Test {y} ");
        }
    }
}
