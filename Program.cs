using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What difficult level (easy, medium, or hard) would you like to play?");
            string difficulty = Console.ReadLine();

            if(difficulty.ToLower() == "easy")
            {
                Random r = new Random();
                int genRand = r.Next(1,100);
                Console.WriteLine($"The secret number is:  {genRand}");
                Console.WriteLine("Please guess a secret number . . .");
                string guessOne = Console.ReadLine();
                int firstGuess = int.Parse(guessOne);
                
                Console.WriteLine("Your guess (1)");
                    if(firstGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have seven guesses remaining . . .");
                    if(firstGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                        Console.WriteLine("You have six guesses remaining . . .");
                    if(secondGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                        Console.WriteLine("You have five guesses remaining . . .");
                        if(thirdGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
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
                        Console.WriteLine("You have four guesses remaining . . .");
                        if(fourthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (5)");
                    string guessFive = Console.ReadLine();
                    int fifthGuess = int.Parse(guessFive);
                    if(fifthGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have three guesses remaining . . .");
                        if(fifthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (6)");
                    string guessSix = Console.ReadLine();
                    int sixthGuess = int.Parse(guessSix);
                    if(sixthGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have two guesses remaining . . .");
                        if(sixthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (7)");
                    string guessSeven = Console.ReadLine();
                    int seventhGuess = int.Parse(guessSeven);
                    if(seventhGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have one more guess . . .");
                        if(seventhGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (8)");
                    string guessEight = Console.ReadLine();
                    int eighthGuess = int.Parse(guessEight);
                    if(eighthGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have no more guesses . . .");
                        if(eighthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }





            }

            if(difficulty.ToLower() == "medium")
            {
                Random r = new Random();
                int genRand = r.Next(1,100);
                // Console.WriteLine($"The secret number is:  {genRand}");
                Console.WriteLine("Please guess a secret number . . .");
                string guessOne = Console.ReadLine();
                int firstGuess = int.Parse(guessOne);
                
                
                Console.WriteLine("Your guess (1)");
                    if(firstGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have five guesses remaining . . .");
                    if(firstGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                        Console.WriteLine("You have four guesses remaining . . .");
                    if(secondGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                        Console.WriteLine("You have three guesses remaining . . .");
                        if(thirdGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
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
                        Console.WriteLine("You have two guesses remaining . . .");
                        if(fourthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (5)");
                    string guessFive = Console.ReadLine();
                    int fifthGuess = int.Parse(guessFive);
                    if(fifthGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have one more guess . . .");
                        if(fifthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

                Console.WriteLine("Your guess (6)");
                    string guessSix = Console.ReadLine();
                    int sixthGuess = int.Parse(guessSix);
                    if(sixthGuess == genRand)
                    {
                        Console.WriteLine("You guessed it correctly! Great job!");
                        Environment.Exit(0);
                    }
                    else 
                    {
                        Console.WriteLine("You guessed it incorrectly.");
                        Console.WriteLine("You have no more guesses . . .");
                        if(sixthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }

            }

            if(difficulty.ToLower() == "hard")
            {
                Random r = new Random();
                int genRand = r.Next(1,100);
                // Console.WriteLine($"The secret number is:  {genRand}");
                Console.WriteLine("Please guess a secret number . . .");
                string guessOne = Console.ReadLine();
                int firstGuess = int.Parse(guessOne);
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
                    if(firstGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                    if(secondGuess > genRand)
                    {
                        Console.WriteLine("Hint:  Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Hint:  Your guess was too low!");
                    }
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
                        if(thirdGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
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
                        if(fourthGuess > genRand)
                        {
                            Console.WriteLine("Hint:  Your guess was too high!");
                        }
                        else
                        {
                            Console.WriteLine("Hint:  Your guess was too low!");
                        }
                        Console.WriteLine("--------------------------------------------");
                    }
            }
        }
    }
}
