using System;

namespace structuring_01 {
    public class MenuManager {

        public MainMenuOptions MainMenu() {
            do {
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Options");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();
                switch(choice) {
                    case "1":
                        return MainMenuOptions.StartGame;
                    case "2":
                        return MainMenuOptions.Options;
                    case "3":
                        return MainMenuOptions.Exit;
                    default:
                        Console.Clear();
                        break;
                }
            } while(true);
        }

        // public (string, string) LoginMenu() {
        //     Console.Write("Enter your username: ");
        //     string username = Console.ReadLine();
        //     Console.Write("Enter your password: ");
        //     string password = Console.ReadLine();
        //     return (username, password);
        // } 

        public void LoginMenu(out string username, out string password) {
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
        }

        public DifficultyOptions ChooseDifficulty() {
            do {
                Console.WriteLine("Choose Difficulty");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hard");
                Console.WriteLine("4. Nightmare");
                string choice = Console.ReadLine();
                switch(choice) {
                    case "1":
                        return DifficultyOptions.Easy;
                    case "2":
                        return DifficultyOptions.Medium;
                    case "3":
                        return DifficultyOptions.Hard;
                    case "4":
                        return DifficultyOptions.Nightmare;
                    default: 
                        Console.Clear();
                        break;
                }
            } while(true);
            
        }    
    }
}
