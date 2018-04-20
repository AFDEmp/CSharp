using System;

namespace structuring_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuManager menu = new MenuManager();
            UserRepository userRepository = UserRepository.Instance;

            MainMenuOptions mainMenuChoice = menu.MainMenu();
            switch (mainMenuChoice)
            {
                case MainMenuOptions.StartGame:
                    bool success;
                    do {
                        menu.LoginMenu(out string username, out string password);
                        success = userRepository.Login(username, password);
                    } while(!success);
                    DifficultyOptions difficultyChoice = menu.ChooseDifficulty();
                    // Rest of logic continues here
                    break;
                case MainMenuOptions.Options:
                    // Menu.OptionsMenu();
                    break;
                case MainMenuOptions.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
