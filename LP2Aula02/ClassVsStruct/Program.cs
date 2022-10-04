using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(){Health = 90, Armor = 20};
            Player player2 = player1;

            Console.WriteLine($"Player1 Health:{player1.Health} Player1 Armor:{player1.Armor}");
            Console.WriteLine($"Player2 Health:{player2.Health} Player2 Armor:{player2.Armor}");

            Console.WriteLine("-----------");

            DoubleHealth(player1);

            Console.WriteLine($"Player1 Health:{player1.Health} Player1 Armor:{player1.Armor}");
            Console.WriteLine($"Player2 Health:{player2.Health} Player2 Armor:{player2.Armor}");

        }

        private static void DoubleHealth(Player p1)
        {
            p1.Health *= 2;
        }
    }
}
