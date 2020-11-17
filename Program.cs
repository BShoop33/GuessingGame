using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            int allowedAttempts = 0;
            Random r = new Random();
            int secretNumber = r.Next(1,101);
            Console.Write("Which difficulty (easy, medium, or hard) would you like to play? ");
            string difficulty = Console.ReadLine().ToLower();
            
            switch(difficulty)
            {
                case ("easy"):
                    allowedAttempts = 8;
                    break;
                case ("medium"):
                    allowedAttempts = 6;
                    break;
                case ("hard"):
                    allowedAttempts = 4;
                    break;
                case ("cheater"):
                    allowedAttempts = int.MaxValue;
                    break;
                default:
                    break;
            }

            while(attempts < allowedAttempts)
            {
            Console.Write("Please guess a secret number . . . ");
            string guessResponse = Console.ReadLine();
            int guess = int.Parse(guessResponse);
            
            if(secretNumber == guess){
                Console.WriteLine("You guessed correctly");
                break;
            }
            else {
                Console.WriteLine($"you guessed incorrectly:  attempt# {attempts + 1}");
                if(guess > secretNumber)
                {
                    Console.WriteLine("too high");
                }
                else {
                    Console.WriteLine("too low");
                }
                Console.WriteLine($"Number of guesses remaining:  {allowedAttempts - attempts - 1}");
            }
            attempts = attempts + 1;
            }
        }
    }
}