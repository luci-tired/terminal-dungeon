using System;
using TDMain;

namespace Enemy
{
    public class EnemyClass
    {
        public int lvl;
        public double atk;
        public double specialAtk;
        public double hp;
        public double maxHP;
        public int abiltiytype;

        public string normalATK;
        public string specialATK;
        public string name;
        
        public EnemyClass()
        {
        }

        public void setClassType(int _num)
        {
            if (_num == 1) // Goblin
            {
                normalATK = "Wack";
                specialATK = "Acid Spit";
                name = "Goblin";
                abiltiytype = 2; // Block
            }

            if (_num == 2) // Zombie
            {
                normalATK = "Bite";
                specialATK = "Bite (Poison Damage)";
                name = "Zombie";
                abiltiytype = 3; // None
            }

            if (_num == 3) // Skeleton
            {
                normalATK = "Swing Sword";
                specialATK = "Spin Attack";
                name = "Skeleton";
                abiltiytype = 2; // Block
            }
        }
    }
}