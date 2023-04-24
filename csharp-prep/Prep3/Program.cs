using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        // Console.Write("What is your guess? ");
        // int yourGuess = int.Parse(Console.ReadLine());
        // if (magicNumber == yourGuess)
        // {
        //     Console.WriteLine(" You Guess it right! ");
        // }
        // else if (magicNumber < yourGuess)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else
        // {
        //     Console.WriteLine("Higher");
        // }

        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        Console.WriteLine("Guess a number between 1 and 100:");
        int guess = 0;
        int numGuesses = 0;

        while (guess != secretNumber)
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            numGuesses++;
            if (guess < secretNumber)
            {
                Console.WriteLine("Too low. Guess again:");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high. Guess again:");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it in {numGuesses} guesses.");
            }
        }
    }
}