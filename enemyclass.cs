using System;
using TDMain;

namespace Enemy
{
    public class EnemyClass
    {
        public int lvl;
        public int atk;
        public int specialAtk;
        public int hp;
        public int maxHP;
        public int abiltiytype;

        public string normalATK;
        public string specialATK;
        public string name;
        
        public EnemyClass(int _atk, int _hp, int _specialAtk, int _maxHP)
        {
            atk = _atk;
            hp = _hp;
            lvl = TDMain.MainClass.player01.lvl;
        }

        public void setClassType(int _num)
        {
            if (_num == 1)
            {
                normalATK = "Wack";
                specialATK = "Acid Spit";
                name = "Goblin";
                abiltiytype = 2; // Block
            }

            if (_num == 2)
            {
                normalATK = "Bite";
                specialATK = "Bite (Poison Damage)";
                name = "Zombie";
                abiltiytype = 3; // None
            }

            if (_num == 3)
            {
                normalATK = "Swing Sword";
                specialATK = "Spin Attack";
                name = "Skeleton";
                abiltiytype = 2; // Block
            }
        }
    }
}