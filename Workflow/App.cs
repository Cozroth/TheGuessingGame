using TheGuessGame.Actions;
using TheGuessGame.DTOs;

namespace TheGuessGame.Workflow
{
    public static class App
    {
        public static void Run()
        {
            GuessHandler _handler = new GuessHandler();
            bool keepPlaying;
            do
            {
                _handler.NewGame();

                keepPlaying = ConsoleIO.GetRequiredBool("Would you like to play again? (yes/no): ");
            } while (keepPlaying);

        }
    }
}

