using System;

namespace Player
{
    public class PlayerClass
    {
        public int xp;
        public int lvl;
        public int atk;
        public int specialAtk;
        public int hp;
        public int cash;
        public int lvlLmt = 10;
        public int maxHP;
        public int classType;
        public int abiltiytype;

        public string normalATK;
        public string specialATK;
        public string name;

        public PlayerClass(string _name, int _classType, int _atk, int _hp, int _cash, int _xp, int _lvl, int _specialAtk, int _maxHP)
        {
            // Incomplete
            name = _name;
            xp = _xp;
            hp = _hp;
            atk = _atk;
            cash = _cash;
            lvl = _lvl;
            specialAtk = _specialAtk;
            maxHP = _maxHP;
            classType = _classType;

            if (classType == 1) // Wizard
            {
                normalATK = "Fireball";
                specialATK = "Lightning Bolt";
                abiltiytype = 2; // Heal
            }
            else if (classType == 2) // Knight
            {
                normalATK = "Swing";
                specialATK = "Spin";
                abiltiytype = 1; // Block
            }
        }

        public void addXp(int _xp)
        {
            xp += _xp;
            if (lvlLmt <= xp)
            {
                xp = 0;
                lvlLmt += 10;
                lvl++;
            }
        }

        public void addCash(int _cash)
        {
            cash += _cash;
        }
    }
}