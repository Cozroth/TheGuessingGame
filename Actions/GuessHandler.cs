using TheGuessGame.DTOs;

namespace TheGuessGame.Actions
{
    public class GuessHandler
    {
        public static Random rnd = new Random();
        public void NewGame()
        {
            ConsoleIO.Welcome();
            int max = ConsoleIO.GetRequiredPositiveInt("Enter the maximum value for the guessing game: ");
            Guesses guess = new Guesses()
            {
                FindThisNumber = rnd.Next(1, max),
                MaxNumber = max,
                AmountOfGuesses = 0,
                HighGuesses = 0,
                LowGuesses = 0
            };
            
            ConsoleIO.StartGame(guess);
        }


    }
}
