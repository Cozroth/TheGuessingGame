using TheGuessGame.DTOs;

namespace TheGuessGame.Actions
{
    public static class ConsoleIO
    {

        public static void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Guessing Game!");
        }

        public static void StartGame(Guesses guess)
        {
            bool foundAnswer;

            Console.WriteLine($"\nI'm thinking of a number between 1 and {guess.MaxNumber}. Can you guess it?");
            do
            {
                foundAnswer = FindCorrectAnswer("Enter your guess: ", guess);

            } while (!foundAnswer);

            GuessStatistics(guess);

        }
        public static void GuessStatistics(Guesses guess)
        {
            Console.WriteLine("\n=====================================");
            Console.WriteLine($"I was thinking of: {guess.FindThisNumber}.");
            Console.WriteLine($"Total amount of guesses: {guess.AmountOfGuesses}.");
            Console.WriteLine($"Amount of too high guesses: {guess.HighGuesses}");
            Console.WriteLine($"Amount of too low guesses: {guess.LowGuesses}");
            Console.WriteLine ("=====================================");
        }
        public static bool GetRequiredBool(string prompt)
        {
            string keepPlaying;
            do
            {
                Console.Write(prompt);
                keepPlaying = Console.ReadLine();
                if (keepPlaying.ToLower() == "yes")
                {
                    return true;
                }
                else if (keepPlaying.ToLower() == "no")
                {
                    return false;
                }

                Console.WriteLine("You must enter yes or no.");

            } while (true);
        }

        public static bool FindCorrectAnswer(string prompt, Guesses guess)
        {
            int validGuess;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validGuess))
                {
                    if (validGuess <= guess.MaxNumber)
                    {
                        if (validGuess == guess.FindThisNumber)
                        {
                            Console.WriteLine("You got it!");
                            guess.AmountOfGuesses += 1;
                            return true;
                        }
                        if (validGuess < guess.FindThisNumber)
                        {
                            Console.WriteLine("Higher...\n");
                            guess.AmountOfGuesses += 1;
                            guess.LowGuesses += 1;
                        }
                        if (validGuess > guess.FindThisNumber)
                        {
                            Console.WriteLine("Lower...\n");
                            guess.AmountOfGuesses += 1;
                            guess.HighGuesses += 1;
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"You must enter a number between 1 and {guess.MaxNumber}");
                }

            } while (true);
        }
        public static int GetRequiredPositiveInt(string prompt)
        {
            int validInt;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validInt))
                {
                    if (validInt > 0)
                    {
                        return validInt;
                    }
                }

                Console.WriteLine("You must enter a positive number.");

            } while (true);
        }
    }
}
