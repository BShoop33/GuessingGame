using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a secret number . . .");
            string guess = Console.ReadLine();
            Console.WriteLine(guess);
        }
    }
}
