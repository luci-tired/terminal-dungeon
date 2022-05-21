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
        public int xpLmt = 100;
        public int maxHP;
        public int abiltiytype;

        public string normalATK;
        public string specialATK;
        public string name;
        public string className;

        public PlayerClass(int _atk, int _hp, int _cash, int _xp, int _lvl, int _specialAtk, int _maxHP)
        {
            // Incomplete
            xp = _xp;
            hp = _hp;
            atk = _atk;
            cash = _cash;
            lvl = _lvl;
            specialAtk = _specialAtk;
            maxHP = _maxHP;
        }

        public void setClassType(int _num)
        {
            if (_num == 1) // Wizard
            {
                className = "Wizard";
                normalATK = "Fireball";
                specialATK = "Lightning Bolt";
                abiltiytype = 2; // Heal
            }
            else if (_num == 2) // Knight
            {
                className = "Knight";
                normalATK = "Swing";
                specialATK = "Spin";
                abiltiytype = 1; // Block
            }
        }

        public void setName(string _name)
        {
            name = _name;
        }

        public void addXp(int _xp)
        {
            xp += _xp;
            if (xpLmt <= xp)
            {
                if (xpLmt < xp)
                {
                    xp = xp - xpLmt;
                }
                else
                {
                    xp = 0;
                }
                xpLmt += 100;
                lvl++;
            }
        }

        public void addCash(int _cash)
        {
            cash += _cash;
        }
    }
}