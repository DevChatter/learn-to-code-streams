using System;

namespace _2018_06_30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {                
                if (i == 4)
                {
                    Console.WriteLine("This one is four!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Random rand = new Random();
            // int number = rand.Next(1, 100);
            // Console.WriteLine("I've chosen a number between 1 and 1,000! Can you guess it?!?!");

            // int guess;
            // do
            // {
            //     Console.WriteLine("What's your guess?!");
            //     string guessString = Console.ReadLine();
            //     int.TryParse(guessString, out guess);
            //     if (guess < number)
            //     {
            //         Console.WriteLine("You guessed too low. Guess higher next time.");
            //     }
            //     if (guess > number)
            //     {
            //         Console.WriteLine("You guessed too high. Guess lower next time.");
            //     }

            // } while (guess != number);

            // Console.WriteLine("You got it!");
        }
    }
}
