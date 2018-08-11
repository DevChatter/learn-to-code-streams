using System;

namespace _2018_08_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.LitterBoxLocation = "Basement";
            GreetUsingName(myCat);

            Dog myDog = new Dog();
            GreetUsingName(myDog);
            TakeForWalk(myDog);

            Baby myBaby = new Baby();
            myBaby.Birthdate = new DateTime(1902, 8, 10);
            GreetUsingName(myBaby);
            TakeForWalk(myBaby);
            Console.WriteLine(myBaby.Birthdate.ToShortDateString());
        }

        static void GreetUsingName(INameable nameable)
        {
            Console.WriteLine($"Hello, {nameable.GetName()}!");
        }

        static void TakeForWalk(IWalkable walkable)
        {
            walkable.GoForWalk();
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
        public DateTime Birthdate { get; set; }
        public int HeightInInches { get; set; }
        public int HeightInCentimeters { get; set; }

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
