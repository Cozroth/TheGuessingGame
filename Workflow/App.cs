using TheGuessGame.Actions;
using TheGuessGame.DTOs;

namespace TheGuessGame.Workflow
{
    public static class App
    {
        public static GuessHandler _handler = new GuessHandler();
        public static void Run()
        {
            ConsoleIO.Welcome();
            
            _handler.NewGame();

        }
    }
}
