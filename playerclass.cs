using System;

namespace Player
{
    public class PlayerClass
    {
        public int xp;
        public int lvl;
        public double atk;
        public double specialAtk;
        public double hp;
        public double cash;
        public int xpLmt = 100;
        public double maxHP;
        public int abiltiytype;

        public string normalATK;
        public string specialATK;
        public string name;
        public string className;

        public PlayerClass(double _atk, double _hp, double _cash, int _xp, int _lvl, double _specialAtk, double _maxHP)
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