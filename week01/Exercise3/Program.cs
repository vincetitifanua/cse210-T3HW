using System;

class Program
{
    static void Main(string[] args)
    {
        // In the below we are going to use a do-while loop to repeat the game if the user wants to play again.
        string playAgain;
        do
        {
            // In the below block we have created the random number generator to generate the magic number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);// here we are going to generate number between 1-100

            // this block is to track how many guesses the user makes
            int guessCount = 0;

            // This block us to guess variable outside the loop
            int guess = -1;

            // here we will keep looping until the correct number is guessed
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());  // this is to read and parse user's guess
                guessCount++;  // We will increase the the guess counter

                // The below block we will provide feedback based on the guess
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // the block will ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Do come again"); // I added the "Do come again" :)
    }
}