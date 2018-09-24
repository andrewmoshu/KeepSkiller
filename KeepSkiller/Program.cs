using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static KeepSkiller.Task2;
using static KeepSkiller.Task3;

namespace KeepSkiller
{
    class Program
    {
        static void Main(string[] args)
        {
            int task;
            Console.Write("Please, provide a task number: ");
            task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    //All code for Task 1 is present below:
                    var pattern = new Regex("(\\d)[-+*/](\\d)");
                    string command;

                    Console.Write("Enter your command: ");
                    command = Console.ReadLine();
                    if (command.Contains("Date") == true)
                    {
                        Console.Write("Current date is:");
                        DateTime today = DateTime.Now;
                        Console.Write(today);
                        Console.Write("\n");
                    }
                    else if (pattern.IsMatch(command))
                    {
                        Console.WriteLine("I'm not a calculator");
                    }
                    else
                    {
                        Console.WriteLine("Hi!");
                    }
                    break;
                case 2:
                    //Task 2 Main
                    Dog dog1 = new Dog() { Number = 1 };
                    Dog dog2 = new Dog() { Number = 2 };
                    Dog dog3 = new Dog() { Number = 3 };

                    Cat cat1 = new Cat() { Number = 1 };
                    Cat cat2 = new Cat() { Number = 2 };
                    Cat cat3 = new Cat() { Number = 3 };
                    dog1.PrintNrInPopulation();
                    cat2.PrintNrInPopulation();
                    break;
                case 3:
                    //Task 3 Main
                    List<Person> list = new List<Person>();
                    Person pers1 = new Person() { Name = "Johnny", Age = 20 };
                    Person pers2 = new Person() { Name = "Cash", Age = 32 };
                    Person pers3 = new Person() { Name = "Michael", Age = 12 };
                    list.Add(pers1);
                    list.Add(pers2);
                    list.Add(pers3);
                    Person.PrintAscending(list);
                    Person.PrintOccurrenceOfGivenAge(list, 42);
                    break;

            }
        }
    }
}