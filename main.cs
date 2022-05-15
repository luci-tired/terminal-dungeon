using System;
using System.IO;
using Wizard;
using Knight;
using Nothing;


namespace TerminalDungeonMain
{
    class MainClass
    {
        static void Main(string []args)
        {
            Console.SetCursorPosition(Console.WindowHeight - "Terminal Dungeon".Length / 2, Console.CursorTop); //Center text on screen
            Console.WriteLine("Terminal Dungeon");

            Console.SetCursorPosition(Console.WindowHeight - "Press Enter to begin...".Length / 2, Console.CursorTop + 1);
            Console.WriteLine("Press Enter to begin...");

            WaitForKey(ConsoleKey.Enter);

            Console.Clear();

            string name = InputName(); // Gets player name, will be used later for leaderboard


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
                WizardClass player01 = new WizardClass(2, 5, 50, 0, 1, 5);
                Console.Clear();
                
                // Testing code
                // Console.WriteLine("Lvl = " + player01.lvl + ", Xp = " + player01.xp + " of " + player01.lvlLmt);
                // player01.addXp(5);
                // Console.WriteLine("Lvl = " + player01.lvl + ", Xp = " + player01.xp + " of " + player01.lvlLmt);
                // player01.addXp(5);
                // Console.WriteLine("Lvl = " + player01.lvl + ", Xp = " + player01.xp + " of " + player01.lvlLmt);
                //
                
            }
            else if (input == "1")
            {
                // Select knight class
                KnightClass player01 = new KnightClass(2, 5, 50, 0, 1, 5);
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
                return;
            }
            else
            {
                WaitForKey(key);
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
                    return "Fail";
                break;
            }
        }
    }
}