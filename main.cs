using System;
using System.IO;
using Player;
using Nothing;
using Battle;


namespace TDMain
{
    class MainClass
    {
        public static PlayerClass player01 = new PlayerClass(2, 15, 50, 0, 1, 5, 15);

        static void Main(string []args)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - "Terminal Dungeon".Length / 2, Console.CursorTop); //Center text on screen
            Console.WriteLine("Terminal Dungeon");

            Console.SetCursorPosition(Console.WindowWidth / 2 - "Press Enter to begin...".Length / 2, Console.CursorTop + 1);
            Console.WriteLine("Press Enter to begin...");

            WaitForKey(ConsoleKey.Enter);

            Console.Clear();

            string name = InputName(); // Gets player name, will be used later for leaderboard
            
            GameSetup(name);
            
        }

        static void GameSetup(string _name)
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
                PathSelect(_name,1,1);
                
            }
            else if (input == "1")
            {
                // Select knight class
                Console.ResetColor();
                Console.Clear();
                PathSelect(_name,2,1);
            }
            else
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Invalid Input!");
                GameSetup(_name);
            }

        }

        static void PathSelect(string _name, int _classNum, int _firstSetup)
        {
            if (_firstSetup == 1)
            {
                if (_classNum == 1)
                {
                    player01.setClassType(1);
                }
                else if (_classNum == 2)
                {
                    player01.setClassType(2);
                }
                player01.setName(_name);
            }
    
            Random rnd = new Random();
            int rndChance = rnd.Next(1, 101);

            if (0 <= rndChance && rndChance <= 6) // 6%
            {
                Console.Clear();
                int _addXp = NothingClass.nothingPath();
                player01.addXp(_addXp);
            }

            if (6 <= rndChance && rndChance <= 20) // 14%
            {
                Console.Clear();
                BattleClass.newEnemy();
            }

            if (20 <= rndChance && rndChance <= 40) // 20%
            {
                Console.Clear();
                BattleClass.newEnemy();
            }

            if (40 <= rndChance && rndChance <= 70) // 30%
            {
                Console.Clear();
                BattleClass.newEnemy();
            }

            if (70 <= rndChance && rndChance <= 100) // 30%
            {
                Console.Clear();
                BattleClass.newEnemy();
            }

            Console.WriteLine("\nPress Enter to continue. Press K to view your stats.");
            int optKey = WaitForKeyDual(ConsoleKey.Enter, ConsoleKey.K);
            
            if (optKey == 1)
            {
                PathSelect(_name,1,0);
            }
            else if (optKey == 2)
            {
                Console.Clear();
                Console.ResetColor();
                Console.Write("Name : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.name);
                Console.ResetColor();

                Console.Write("Class Type : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.className);
                Console.ResetColor();

                Console.Write("Money : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.cash);
                Console.ResetColor();

                Console.Write("Level : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.lvl);
                Console.ResetColor();

                Console.Write("XP : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.xp + "/" + player01.xpLmt);
                Console.ResetColor();


                Console.WriteLine();
                Console.Write("NormalAtk | " + player01.normalATK + " : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.atk);
                Console.ResetColor();

                Console.Write("SpecialAtk | " + player01.specialATK + " : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(player01.specialAtk);
                Console.ResetColor();
                
                if (player01.abiltiytype == 1)
                {
                    Console.Write("Ability | Block" + " : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HIGHLVL 75% | LOWLVL 25%");
                    Console.ResetColor();
                }
                if (player01.abiltiytype == 2)
                {
                    Console.Write("Ability | Heal" + " : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2HP");
                    Console.ResetColor();
                }

                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                PathSelect(_name,1,0);
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

        public static string SelectNumb()
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