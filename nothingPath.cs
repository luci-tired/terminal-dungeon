using System;

namespace Nothing
{
    class NothingClass
    {
        static public int nothingPath()
        {
            // Picks a random line from a array
            string[] lines = {"You trip on a rock.", "You find and open a door, behind it is a wall.", "goop", "You hear distant voices.", "No bitches???", "WYDŮPIEJ", "-_-", "You step on an ant.", "You wonder if you will ever get out of this cave.", "Im am getting closer to your current location."};
            Random rnd = new Random();
            int index = rnd.Next(lines.Length); // Generates a random index less than the size of the array
            Console.WriteLine(lines[index]);

            // Gives 2-3 xp to the player
            int xp = rnd.Next(2, 4);
            Console.WriteLine(xp + "+ XP");
            return xp;
        }
    }
}