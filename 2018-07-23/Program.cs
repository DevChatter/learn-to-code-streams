using System;
using System.Collections.Generic;
using System.Linq;

namespace _2018_07_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DevChatter!");

            int countOfNumbersToAdd = GetIntegerFromUser("How many numbers should we add?");
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < countOfNumbersToAdd; i++)
            {
                listOfNumbers.Add(GetIntegerFromUser($"I need number {i}:"));
            }
            
            int sum = Calculator.CalculateSum(listOfNumbers);
            Console.WriteLine($"The sum is {sum}.");

            double avg = Calculator.CalculateAvg(sum, countOfNumbersToAdd);
            Console.WriteLine($"The average is {avg}.");

            int max = int.MinValue;
            foreach (int number in listOfNumbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is {max}.");

            int min = int.MaxValue;
            foreach (int number in listOfNumbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"The smallest number is {min}.");
        }

        static int GetIntegerFromUser(string message)
        {
            bool succeeded = false;
            int intFromUser;
            do
            {
                Console.WriteLine(message);
                string rawInput = Console.ReadLine();
                succeeded = int.TryParse(rawInput, out intFromUser);
                if (!succeeded)
                {
                    Console.WriteLine("That wasn't a number.");
                }
            } while (!succeeded);
            return intFromUser;
        }
    }
}
