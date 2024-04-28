using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess;
        int attempts = 0;

        Console.WriteLine("Welcome to Guess My Number!");
        Console.WriteLine("I've picked a number between 1 and 100. Try to guess it!");

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

        Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");
        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine();

        if (playAgain.ToLower() == "yes")
        {
            Main(null); // Restart the game
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
