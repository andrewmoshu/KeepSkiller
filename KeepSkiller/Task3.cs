using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepSkiller
{
    class Task3
    {
        public class Person

        {

            public string Name { get; set; }

            public int Age { get; set; }
            public static void PrintAscending(ICollection<Person> collection)
            {
                var sort = from Pers in collection orderby Pers.Age select Pers;
                foreach (Person Per in sort)
                {
                    string output = String.Format("{0} - {1}", Per.Name, Per.Age);
                    Console.WriteLine(output);
                }
            }
            public static void PrintOccurrenceOfGivenAge(ICollection<Person> collection, int age)
            {
                Boolean contains = false;
                foreach (Person Per in collection)
                {
                    if (Per.Age == age)
                    {
                        contains = true;
                    }
                    else
                    {
                        contains = false;
                    }
                }
                Console.WriteLine("Collection contains person with a given age " + age + " - " + contains);
            }



        }


    }
}
