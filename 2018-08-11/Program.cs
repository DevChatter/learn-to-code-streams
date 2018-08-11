using System;
using System.Collections.Generic;

namespace _2018_08_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose what to record:");
            Console.WriteLine("1) Cat");
            Console.WriteLine("2) Dog");
            Console.WriteLine("3) Baby");

            int selection = int.Parse(Console.ReadLine());

            Console.WriteLine($"You chose {selection}.");
            
            List<INameable> nameables = new List<INameable>();
            switch (selection)
            {
                case 1:
                    var cat = new Cat();
                    nameables.Add(cat);
                    break;
                case 2:
                    var dog = new Dog();
                    nameables.Add(dog);
                    break;
                case 3:
                    var baby = new Baby();
                    nameables.Add(baby);
                    break;
                default:
                    throw new Exception();
            }

            foreach (INameable named in nameables)
            {
                Console.WriteLine($"Hello, {named.GetName()}!");
            }
        }
    }

    public interface INameable
    {
        string GetName();
    }

    public interface IPet
    {
    }

    public interface IWalkable
    {
        void GoForWalk();
    }

    public class Cat : IPet, INameable
    {
        public string LitterBoxLocation { get; set; }
        public string GetName()
        {
            return "Kitty";
        }
    }
    public class Dog : IPet, IWalkable, INameable
    {
        public string GetName()
        {
            return "Mr. Barkers";
        }

        public void GoForWalk()
        {
            Console.WriteLine("Woof woof! We're going on a walk! Yay!");
        }
    }

    public class Baby : IWalkable, INameable
    {
        public void GoForWalk()
        {
            Console.WriteLine("Goo goo! Gaa gaa! I'm in a stroller!");
        }

        public string GetName()
        {
            return "Elliot";
        }
    }
}
