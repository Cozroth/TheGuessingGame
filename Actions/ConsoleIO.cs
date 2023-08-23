using TheGuessGame.DTOs;

namespace TheGuessGame.Actions
{
    public static class ConsoleIO
    {

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Guessing Game!");
        }

        public static void StartGame(Guesses guess)
        {
            Console.WriteLine($"I'm thinking of a number between 1 and {guess.FindThisNumber}. Can you guess it?");
        }

        public static void GuessStatistics(Guesses guess)
        {
            Console.WriteLine("============================");
            Console.WriteLine($"I was thinking of: {guess.FindThisNumber}.");
            Console.WriteLine($"Total amount of guesses: {guess.AmountOfGuesses}.");
            Console.WriteLine($"Amount of too high guesses: {guess.HighGuesses}");
            Console.WriteLine($"Amount of too low guesses: {guess.LowGuesses}");
            Console.WriteLine("============================");
        }
        public static string GetRequiredString(string prompt)
        {
            string validString;
            do
            {
                Console.Write(prompt);
                validString = Console.ReadLine();
                if (!string.IsNullOrEmpty(validString.Trim()))
                {
                    return validString;
                }

                Console.WriteLine("You must enter atleast one character.");

            } while (true);
        }
        public static int GetRequiredRange(string prompt, int min, int max)
        {
            int validRange;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validRange))
                {
                    if (validRange >= min && validRange <= max)
                    {
                        return validRange;
                    }
                }
                Console.WriteLine($"You must enter a numerical value in the range of {min} and {max}.");

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
