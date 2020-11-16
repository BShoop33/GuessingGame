using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a secret number . . .");
            string guessOne = Console.ReadLine();
            string secretNumber = "42";

            Console.WriteLine("Your guess (1)");
            if(guessOne == secretNumber)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
            }
            
            Console.WriteLine("Your guess (2)");
            string guessTwo = Console.ReadLine();

            if(guessTwo == secretNumber)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
            }
            
            Console.WriteLine("Your guess (3)");
            string guessThree = Console.ReadLine();
            if(guessThree == secretNumber)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
            }
            
            Console.WriteLine("Your guess (4)");
            string guessFour = Console.ReadLine();
            if(guessFour == secretNumber)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
            }
        }
    }
}
