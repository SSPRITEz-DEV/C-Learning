using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Structs
    {
        struct Person
        {
            public string firstname;
            public string Lastname;
            public int age;
        }

        struct SuperPerson
        {
            public string firstname;
            public string Lastname;
            public int age;

            public void SetData(string a, string b, int c)
            {
                firstname = a;
                Lastname = b;
                age = c;
            }

            public void GetData()
            {
                Console.WriteLine(firstname);
                Console.WriteLine(Lastname);
                Console.WriteLine(age);
            }

        }

        public static void Run()
        {
            Person por;
            por.firstname = "Thiti";
            por.Lastname = "Mahawannakit";
            por.age = 22;

            //Console.WriteLine(por);


            SuperPerson prite = new SuperPerson();
            prite.SetData("Tanawatt", "Jituthai", 22);
            prite.GetData();
        }
    }
}
