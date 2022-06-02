using System;

namespace Art
{
    public class PxArt
    {
        public static void battle(string plyType, string eneType)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}