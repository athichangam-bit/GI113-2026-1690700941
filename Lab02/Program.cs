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
            int level = 3;
            int maxHp = 70;
            int currentHp = 43;
            float attackPower = 12.5f;
            double critMultiplier = 0.75;
            bool isBoss = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======\n");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            int takesDamage = 15;   //โดนดาเมจ
            Console.WriteLine("== !Pawdy takes 15 damage! ==");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======\n");
            int afterHp = currentHp - takesDamage;   //เลือดลด
            Console.WriteLine($"HP: {afterHp} / {maxHp}");
            int afterHpPercent = afterHp * 100 / maxHp;   //Percent หลังจากโดน Damage
            Console.WriteLine($"HP Percent: {afterHpPercent}%");
            Console.WriteLine("\n----------------------------------------------\n\n");

            string bossName01 = "Drabby";
            char rank01 = 'C';
            int level01 = 7;
            int maxHp01 = 130;
            int currentHp01 = 76;
            float attackPower01 = 17.5f;
            double critMultiplier01 = 1.25;
            bool isBoss01 = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======\n");
            Console.WriteLine($"Name: {bossName01}");
            Console.WriteLine($"Rank: {rank01}");
            Console.WriteLine($"Level: {level01}");
            Console.WriteLine($"HP: {currentHp01} / {maxHp01}");
            int hpPercent01 = currentHp01 * 100 / maxHp01;
            Console.WriteLine($"HP Percent: {hpPercent01}%");
            Console.WriteLine();
            int takesDamage01 = 20;   //โดนดาเมจ
            Console.WriteLine("== !Drabby takes 20 damage! ==");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======\n");
            int afterHp01 = currentHp01 - takesDamage01;   //เลือดลด
            Console.WriteLine($"HP: {afterHp01} / {maxHp01}");
            int afterHpPercent01 = afterHp01 * 100 / maxHp01;   //Percent หลังจากโดน Damage
            Console.WriteLine($"HP Percent: {afterHpPercent01}%");
            Console.WriteLine("\n----------------------------------------------\n\n");

            string bossName02 = "Dabagon";
            char rank02 = 'A';
            int level02 = 13;
            int maxHp02 = 175;
            int currentHp02 = 111;
            float attackPower02 = 29.5f;
            double critMultiplier02 = 1.75;
            bool isBoss02 = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======\n");
            Console.WriteLine($"Name: {bossName02}");
            Console.WriteLine($"Rank: {rank02}");
            Console.WriteLine($"Level: {level02}");
            Console.WriteLine($"HP: {currentHp02} / {maxHp02}");
            int hpPercent02 = currentHp02 * 100 / maxHp02;
            Console.WriteLine($"HP Percent: {hpPercent02}%");
            Console.WriteLine();
            int takesDamage02 = 45;   //โดนดาเมจ
            Console.WriteLine("== !Dabagon takes 45 damage! ==");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======\n");
            int afterHp02 = currentHp02 - takesDamage02;   //เลือดลด
            Console.WriteLine($"HP: {afterHp02} / {maxHp02}");
            int afterHpPercent02 = afterHp02 * 100 / maxHp02;   //Percent หลังจากโดน Damage
            Console.WriteLine($"HP Percent: {afterHpPercent02}%");
            Console.WriteLine("\n----------------------------------------------\n\n");

            string bossName03 = "Barloss";
            char rank03 = 'S';
            int level03 = 23;
            int maxHp03 = 250;
            int currentHp03 = 167;
            float attackPower03 = 56.5f;
            double critMultiplier03 = 2.25;
            bool isBos03 = true;

            Console.WriteLine("======= BOSS STATUS: INITIAL =======\n");
            Console.WriteLine($"Name: {bossName03}");
            Console.WriteLine($"Rank: {rank03}");
            Console.WriteLine($"Level: {level03}");
            Console.WriteLine($"HP: {currentHp03} / {maxHp03}");
            int hpPercent03 = currentHp03 * 100 / maxHp03;
            Console.WriteLine($"HP Percent: {hpPercent03}%");
            Console.WriteLine();
            int takesDamage03 = 39;   //โดนดาเมจ
            Console.WriteLine("== !Barloss takes 39 damage! ==");
            Console.WriteLine();
            Console.WriteLine("======= BOSS STATUS: AFTER DAMADE =======\n");
            int afterHp03 = currentHp03 - takesDamage03;   //เลือดลด
            Console.WriteLine($"HP: {afterHp03} / {maxHp03}");
            int afterHpPercent03 = afterHp03 * 100 / maxHp03;   //Percent หลังจากโดน Damage
            Console.WriteLine($"HP Percent: {afterHpPercent03}%");
            Console.WriteLine("\n----------------------------------------------\n\n");
        }
    }
}
