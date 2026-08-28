/*
 * Student ID : 1690700941
 * Name       : อธิชา งามงอน
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Pawdy";
            char rank = 'F';
            int level = 1;
            int maxHp = 70;
            int currentHp = 43;
            float attackPower = 12.5f;
            double critMultiplier = 0.75;
            bool isBoss = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}%");
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Uai takes 15 damage!");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======");
            Console.WriteLine($"HP: {currentHp} / {maxHp}%");
            Console.WriteLine($"HP Percent: 37%");

            string bossName = "Drabby";
            char rank = 'C';
            int level = 3;
            int maxHp = 180;
            int currentHp = 67;
            float attackPower = 27.5f;
            double critMultiplier = 1.25;
            bool isBoss = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}%");
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Uai takes 15 damage!");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======");
            Console.WriteLine($"HP: {currentHp} / {maxHp}%");
            Console.WriteLine($"HP Percent: 48%");
        }
    }
}
