using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a secret number . . .");
            string guessOne = Console.ReadLine();
            int firstGuess = int.Parse(guessOne);
            Random r = new Random();
            int genRand = r.Next(1,100);
                
            Console.WriteLine("Your guess (1)");
            if(firstGuess == genRand)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
                Console.WriteLine("You have three guesses remaining . . .");
                Console.WriteLine("--------------------------------------------");
            }
            
            Console.WriteLine("Your guess (2)");
            string guessTwo = Console.ReadLine();
            int secondGuess = int.Parse(guessTwo);
            if(secondGuess == genRand)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
                Console.WriteLine("You have two guesses remaining . . .");
                Console.WriteLine("--------------------------------------------");
            }
            
            Console.WriteLine("Your guess (3)");
            string guessThree = Console.ReadLine();
            int thirdGuess = int.Parse(guessThree);
            if(thirdGuess == genRand)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
                Console.WriteLine("You have one guess remaining . . .");
                Console.WriteLine("--------------------------------------------");
            }
            
            Console.WriteLine("Your guess (4)");
            string guessFour = Console.ReadLine();
            int fourthGuess = int.Parse(guessFour);
            if(fourthGuess == genRand)
            {
                Console.WriteLine("You guessed it correctly! Great job!");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("You guessed it incorrectly.");
                Console.WriteLine("You have no more guesses . . .");
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
