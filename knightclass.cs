using System;

namespace Knight
{
    class KnightClass
    {
        public int xp;
        public int lvl;
        public int atk;
        public int specialAtk;
        public int hp;
        public int cash;

        public KnightClass(int _atk, int _hp, int _cash, int _xp, int _lvl, int _specialAtk)
        {
            // Incomplete
            xp = _xp;
            hp = _hp;
            atk = _atk;
            cash = _cash;
            lvl = _lvl;
            specialAtk = _specialAtk;
        }

        public void addXp(int _xp)
        {
            xp =+ _xp;
        }
    }
}