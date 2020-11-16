using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a secret number . . .");
            string guess = Console.ReadLine();
            string secretNumber = "42";
            if(guess == secretNumber)
            {
                Console.WriteLine("You guessed it correctly!");
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
            }
        }
    }
}
