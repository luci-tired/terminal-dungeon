using System;
using Enemy;
using TDMain;
using Player;
using Art;

namespace Battle
{
    public class BattleClass
    {
        public static EnemyClass enemy01 = new EnemyClass();
        public static PlayerClass player01 = MainClass.player01;

        public static void newEnemy()
        {
            Random rnd = new Random();
            int rndClass = rnd.Next(0, 4);

            // 1/3 chance for each class
            if (0 <= rndClass && rndClass <= 1) // Goblin
            {
                enemy01.setClassType(1);
            }
            if (1 <= rndClass && rndClass <= 2) // Zombie
            {
                enemy01.setClassType(2);
            }
            if (2 <= rndClass && rndClass <= 3) // Skeleton
            {
                enemy01.setClassType(3);
            }

            setLvl();
            setStats();

            Console.Clear();

            PxArt.battle(player01.className, enemy01.name);
            mainBattle();

            //Console.WriteLine(enemy01.name);
            //Console.WriteLine("HP = " + enemy01.maxHP + "\nATK = " + enemy01.atk + "\nSpecialATK = " + enemy01.specialAtk + "\nLvl = " + enemy01.lvl);
        }

        public static void mainBattle()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            SelectOpt();
        }

        public static string SelectOpt()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - " 1) Attack   2) Items".Length / 2, Console.CursorTop);
            Console.WriteLine(" 1) Attack   2) Items");
            Console.SetCursorPosition(Console.WindowWidth / 2 - "3) Ability   4) Run".Length / 2, Console.CursorTop);
            Console.WriteLine("3) Ability  4) Run");

            string input = MainClass.SelectNumb();

            if (input == "1")
            {
                return input;
            }

            else if (input == "2")
            {
                return input;
            }

            else if (input == "3")
            {
                return input;
            }

            else if (input == "4")
            {
                return input;
            }

            else
            {
                return SelectOpt();
            }
        }
        
        public static void setLvl()
        {
            Random rnd = new Random();
            int rndChance = rnd.Next(1, 101);

            if (enemy01.name == "Goblin")
            {
                // 35% chance of higher level | can only be 5 levels higher or lower

                if (0 <= rndChance && rndChance <= 35) // 35%
                {
                    int lvlRand = rnd.Next(1,6);

                    enemy01.lvl = player01.lvl + lvlRand;
                }

                    
                if (35 <= rndChance && rndChance <= 100) // 65%
                {
                    int lvlRand = rnd.Next(1,6);

                    if (lvlRand > player01.lvl)
                    {
                        setLvl();
                    }
                    else if (lvlRand == player01.lvl)
                    {
                        enemy01.lvl = player01.lvl;
                    }
                    else if (lvlRand < player01.lvl)
                    {
                        enemy01.lvl = player01.lvl - lvlRand;
                    }
                }
            }
            if (enemy01.name == "Zombie")
            {
                // 55% chance of higher level | can only be 3 levels higher and 5 levels lower

                if (0 <= rndChance && rndChance <= 55) // 55%
                {
                    int lvlRand = rnd.Next(1,4);

                    enemy01.lvl = player01.lvl + lvlRand;
                }

                    
                if (55 <= rndChance && rndChance <= 100) // 45%
                {
                    int lvlRand = rnd.Next(1,6);

                    if (lvlRand > player01.lvl)
                    {
                        setLvl();
                    }
                    else if (lvlRand == player01.lvl)
                    {
                        enemy01.lvl = player01.lvl;
                    }
                    else if (lvlRand < player01.lvl)
                    {
                        enemy01.lvl = player01.lvl - lvlRand;
                    }
                }
            }
            if (enemy01.name == "Skeleton")
            {
                // 45% chance of higher level | can only be 2 levels higher or lower

                if (0 <= rndChance && rndChance <= 45) // 45%
                {
                    int lvlRand = rnd.Next(1,3);

                    enemy01.lvl = player01.lvl + lvlRand;
                }

                    
                if (45 <= rndChance && rndChance <= 100) // 55%
                {
                    int lvlRand = rnd.Next(1,3);

                    if (lvlRand > player01.lvl)
                    {
                        setLvl();
                    }
                    else if (lvlRand == player01.lvl)
                    {
                        enemy01.lvl = player01.lvl;
                    }
                    else if (lvlRand < player01.lvl)
                    {
                        enemy01.lvl = player01.lvl - lvlRand;
                    }
                }
            }
        }

        public static void setStats()
        {
            double baseHp = player01.maxHP;
            double baseAtk = player01.atk;
            double baseSpecialAtk = player01.specialAtk;

            int lvlDif = enemy01.lvl - player01.lvl;

            // If enemyLvl = playerLvl, use lower stats
            if (enemy01.name == "Goblin")
            {
                // If lower level, 45% of player hp and 75% of player atk
                // If higher level, 65% of player hp and 90% of player atk 

                if (enemy01.lvl <= player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.45;
                    enemy01.atk = baseAtk * 0.75;
                    enemy01.specialAtk = baseSpecialAtk * 0.75;

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP;
                }

                if (enemy01.lvl > player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.65;
                    enemy01.atk = baseAtk * 0.90;
                    enemy01.specialAtk = baseSpecialAtk * 0.90; 

                    // +0.3 for every lvl

                    for (int i = 0; i < lvlDif; i++)
                    {
                        enemy01.maxHP = enemy01.maxHP + 0.3;
                        enemy01.atk = enemy01.atk + 0.3;
                        enemy01.specialAtk = enemy01.specialAtk + 0.3;
                    }

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP;
                }
            }
            if (enemy01.name == "Zombie")
            {
                // If lower level, 30% of player hp and 30% of player atk
                // If higher level, 50% of player hp and 50% of player atk 

                if (enemy01.lvl <= player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.30;
                    enemy01.atk = baseAtk * 0.30;
                    enemy01.specialAtk = baseSpecialAtk * 0.30;

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP;
                }

                if (enemy01.lvl > player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.50;
                    enemy01.hp = enemy01.maxHP;
                    enemy01.atk = baseAtk * 0.50;
                    enemy01.specialAtk = baseSpecialAtk * 0.50;

                    // +0.3 for every lvl

                    for (int i = 0; i < lvlDif; i++)
                    {
                        enemy01.maxHP = enemy01.maxHP + 0.3;
                        enemy01.atk = enemy01.atk + 0.3;
                        enemy01.specialAtk = enemy01.specialAtk + 0.3;
                    }

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP;
                }
            }
            if (enemy01.name == "Skeleton")
            {
                // If lower level, 65% of player hp and 40% of player atk
                // If higher level, 75% of player hp and 55% of player atk 

                if (enemy01.lvl <= player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.65;
                    enemy01.atk = baseAtk * 0.40;
                    enemy01.specialAtk = baseSpecialAtk * 0.40;

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP;
                }

                if (enemy01.lvl > player01.lvl)
                {
                    enemy01.maxHP = baseHp * 0.75;
                    enemy01.hp = enemy01.maxHP;
                    enemy01.atk = baseAtk * 0.55;
                    enemy01.specialAtk = baseSpecialAtk * 0.55;

                    // +0.3 for every lvl

                    for (int i = 0; i < lvlDif; i++)
                    {
                        enemy01.maxHP = enemy01.maxHP + 0.3;
                        enemy01.atk = enemy01.atk + 0.3;
                        enemy01.specialAtk = enemy01.specialAtk + 0.3;
                    }

                    enemy01.maxHP = Math.Round(enemy01.maxHP, 2);
                    enemy01.atk = Math.Round(enemy01.atk, 2);
                    enemy01.specialAtk = Math.Round(enemy01.specialAtk, 2);

                    enemy01.hp = enemy01.maxHP; 
                }
            }
        }
    }
}