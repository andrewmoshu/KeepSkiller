using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepSkiller
{
    class Task2
    {
        public interface IAnimal
        {


            void Speak();
            void PrintNrInPopulation();

        }
        public class Dog : IAnimal
        {
            public static int counter = 0;
            public Dog()
            {
                counter++;

            }
            public int Number { get; set; }
            public void Speak()
            {
                Console.WriteLine("Woof");
            }
            public void PrintNrInPopulation()
            {
                Console.WriteLine("Population of Dogs: " + counter.ToString());
                Console.WriteLine("This dog's number: " + this.Number);
                Console.Write("Dog says: ");
                this.Speak();
            }

        }

        public class Cat : IAnimal
        {
            public static int counter = 0;
            public Cat()
            {
                counter++;

            }
            public int Number { get; set; }
            public void Speak()
            {
                Console.WriteLine("Meow");
            }
            public void PrintNrInPopulation()
            {
                Console.WriteLine("Population of Cats: " + counter.ToString());
                Console.WriteLine("This cat's number: " + this.Number);
                Console.Write("Cat says: ");
                this.Speak();
            }

        }

    }
}
