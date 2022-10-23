using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game | v1.0.0 | Jakub Skowron (reallySmooll)");

            Console.Write("\nHow many rounds would you like to play: ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the maximum number you would like to guess (basically difficulty level, e.g. 100, 1000, 2137): ");
            int maxNum = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("You will get 3 chances each round. After that you will fail the round.");
            Console.WriteLine("Ready? (press enter to start)");
            Console.ReadLine();

            Console.Clear();

            Random rand = new Random();
            int roundsWon = 0;
            int roundsLost = 0;

            for (int i = 1; i < rounds + 1; i++)
            {
                int numToGuess = rand.Next(0, maxNum);
                Console.WriteLine(numToGuess);

                Console.WriteLine($"Round #{i}");
                Console.Write("Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == numToGuess)
                {
                    Console.WriteLine("\nCongratulations! You guessed right!\n");
                    roundsWon++;
                } else if (num != numToGuess)
                {
                    Console.WriteLine("\n:TrollDespair: You lost.\n");
                    roundsLost++;
                } else
                {
                    Console.WriteLine("HUH?! something went wrong and I don't know what or how to fix it. sorry :)");
                }
            }

            Console.Clear();
        
            Console.WriteLine("Congratulations! You've finished the game. Now let's see how you did.");
            Console.WriteLine($"\nOut of {rounds} rounds, you won {roundsWon} and lost {roundsLost}.");

            Console.WriteLine("\nAnd that's it. Thank you for playing my first project in C#.");
        }
    }
}