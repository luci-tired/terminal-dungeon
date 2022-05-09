using System;
using System.IO;


namespace terminaldungeon
{
    class Start
    {
        static void Main(string []args)
        {
            Console.SetCursorPosition(Console.WindowHeight - "Terminal Dungeon".Length / 2, Console.CursorTop); //Center text on screen
            Console.WriteLine("Terminal Dungeon");

            Console.SetCursorPosition(Console.WindowHeight - "Press Enter to begin...".Length / 2, Console.CursorTop + 1);
            Console.WriteLine("Press Enter to begin...");
            

            WaitForKey(ConsoleKey.Enter);

            Console.Clear();

            Console.Write("Please enter a name : ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            GameSetup();
            
        }

        static void GameSetup()
        {
            Console.Write("\nPlease select a class\n 0) Wizard\n 1) Knight\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            string input = SelectNumb();
            if (input == "0")
            {
                Console.WriteLine("0");
            }
            else if (input == "1")
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Invalid Input!");
                GameSetup();
            }

        }

        static void WaitForKey(ConsoleKey key)
        {
            if (Console.ReadKey(true).Key == key)
            {
                // Continue to code
            }
            else
            {
                WaitForKey(key);
            }
        }

        static string SelectNumb()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    return "1";
                break;

                case "2":
                    return "2";
                break;

                case "3":
                    return "3";
                break;

                case "4":
                    return "4";
                break;

                case "5":
                    return "5";
                break;

                case "6":
                    return "6";
                break;

                case "7":
                    return "7";
                break;

                case "8":
                    return "8";
                break;

                case "9":
                    return "9";
                break;

                case "0":
                    return "0";
                break;

                default:
                    return "Fail";
                break;
            }
        }
    }
}