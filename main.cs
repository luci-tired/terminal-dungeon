using System;
using System.IO;
using Player;
using Nothing;


namespace TerminalDungeonMain
{
    class MainClass
    {
        public PlayerClass wizPlayer01 = new WizardClass(2, 5, 50, 0, 1, 5);
        public PlayerClass kniPlayer01 = new KnightClass(2, 5, 50, 0, 1, 5);

        static void Main(string []args)
        {
            Console.SetCursorPosition(Console.WindowHeight - "Terminal Dungeon".Length / 2, Console.CursorTop); //Center text on screen
            Console.WriteLine("Terminal Dungeon");

            Console.SetCursorPosition(Console.WindowHeight - "Press Enter to begin...".Length / 2, Console.CursorTop + 1);
            Console.WriteLine("Press Enter to begin...");

            WaitForKey(ConsoleKey.Enter);

            Console.Clear();

            string _name = InputName(); // Gets player name, will be used later for leaderboard

            GameSetup();
            
        }

        static void GameSetup()
        {
            Console.Clear();
            Console.Write("\nPlease select a class\n 0) Wizard\n 1) Knight\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            string input = SelectNumb();
            if (input == "0")
            {
                // Select wizard class
                Console.ResetColor();
                Console.Clear();
                PathSelect(1,1);
                
            }
            else if (input == "1")
            {
                // Select knight class
                Console.ResetColor();
                Console.Clear();
                PathSelect(2,1);
            }
            else
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Invalid Input!");
                GameSetup();
            }

        }

        static void PathSelect(int _classNum, int _firstSetup)
        {
            if (_firstSetup == 1)
            {
                if (_classNum == 1)
                {
                    
                }
                else if (_classNum == 2)
                {

                }
            }

            Random rnd = new Random();
            int rndChance = rnd.Next(0,100);

            if (rndChance < 100) // 6.25% chance
            {
                Console.Clear();
                NothingClass.nothingPath();
            }

            Console.WriteLine("\nPress Enter to continue. Press K to view your stats.");
            int optKey = WaitForKeyDual(ConsoleKey.Enter, ConsoleKey.K);
            
            if (optKey == 1)
            {
                
            }
            else if (optKey == 2)
            {
                Console.Clear();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            
            PathSelect(1,0);
        }

        static void WaitForKey(ConsoleKey key)
        {
            if (Console.ReadKey(true).Key == key)
            {
                // Continue to code
                return;
            }
            else
            {
                WaitForKey(key);
            }
        }

        static int WaitForKeyDual(ConsoleKey key1, ConsoleKey key2)
        {
            ConsoleKey _key = Console.ReadKey(true).Key;

            if (_key == key1)
            {
                // Continue to code
                return 1;
            }
            else if (_key == key2)
            {
                // Continue to code
                return 2;
            }
            else
            {
                return WaitForKeyDual(key1, key2);
            }
        }

        static string InputName()
        {
            Console.Clear();
            Console.ResetColor();
            Console.Write("Please enter a name : ");
            Console.ForegroundColor = ConsoleColor.Green;


            string _name = Console.ReadLine();
            if(!string.IsNullOrEmpty(_name))
            {
                Console.ResetColor();
                return _name;
            }
            else
            {
                return InputName();
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
                    return SelectNumb();
                break;
            }
        }
    }
}