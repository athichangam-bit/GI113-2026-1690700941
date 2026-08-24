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
            string bossName = "Uia";
            char rank = 'F';
            int level = 1;
            int maxHp = 70;
            int currentHp = 27;
            float attackPower = 17.5f;
            double critMultiplier = 1.5;
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
        }
    }
}
