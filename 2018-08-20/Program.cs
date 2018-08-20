using System;
using System.Collections.Generic;

namespace _2018_08_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string nameToAdd;
            do
            {
                Console.WriteLine("Please enter a name: ");
                nameToAdd = Console.ReadLine();
                names.Add(nameToAdd);
            } while (!string.IsNullOrWhiteSpace(nameToAdd));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("We left the loop");
        }
    }
}
