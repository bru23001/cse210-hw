using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "Y";

        while (playAgain == "Y")
        {
        
            Random randomMagicNumber = new Random();
            int intRandomMagicNumber = randomMagicNumber.Next(1,101);
        
            string guessed = "no";
            int counter = 0;


                while (guessed == "no")
                {
                    
                    Console.WriteLine("--------------------------------");    
                    Console.Write("Guess the magic number (1-100): ");
                    string guessMagicNumber = Console.ReadLine();
                    int intGuessMagicNumber = int.Parse(guessMagicNumber);

                    if (intGuessMagicNumber < intRandomMagicNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You need to guess higher ...");
                        Console.WriteLine();
                    }

                    else if (intGuessMagicNumber > intRandomMagicNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have to guess lower ...");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You guessed the magic number!!!");
                        Console.WriteLine();

                        guessed = "yes";
                        counter = counter + 1;

                        Console.WriteLine();
                        Console.WriteLine($"You tried {counter} times to guess it.");
                    
                    }

                    counter = counter + 1;
                }

                Console.WriteLine();
                Console.WriteLine("=================================");    
                Console.Write("Do you want to play again? Y/N: ");
                playAgain = Console.ReadLine();    
        }
    }
}