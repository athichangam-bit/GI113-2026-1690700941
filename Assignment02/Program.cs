/*
* Student ID : 1690700941
* Name       : อธิชา งามงอน
* Section    : 129A
* No.        : 33
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------
            // Constant Variables
            // -----------------------------

            const string MaterialName = "Cystal";

            const double SmeltRate = 0.15;     // Ore -> Ingot
            const double SalvageRate = 0.20;   // Ingot -> Ore

            const double MaxBatch = 500;


            // -----------------------------
            // Program Header
            // -----------------------------

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--       Welcome to the Forge        --");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine(
                $"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");

            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.WriteLine();


            // -----------------------------
            // Read Menu
            // -----------------------------

            Console.Write("=> Choose Menu: ");

            string? menuText = Console.ReadLine();

            char menu;


            // ตรวจว่า menu เป็นตัวอักษรเดียวหรือไม่
            if (char.TryParse(menuText, out menu))
            {
                // -----------------------------
                // Read Amount
                // -----------------------------

                Console.Write("=> How much would you like: ");

                string? amountText = Console.ReadLine();

                double amount;

                // ตรวจว่าแปลงเป็นตัวเลขได้หรือไม่
                if (double.TryParse(amountText, out amount))
                {
                    // -----------------------------
                    // Check Amount Range
                    // -----------------------------

                    if (amount > 0 && amount <= MaxBatch)
                    {
                        // ================
                        // Smelt
                        // ================

                        if (menu == 'S' || menu == 's')
                        {
                            double result;

                            result = amount * SmeltRate;

                            Console.WriteLine();

                            Console.WriteLine(
                                $"=> {amount:F2} {MaterialName} Ore = " +
                                $"{result:F2} {MaterialName} Ingot");
                        }

                        // ======================
                        // Breakdown
                        // ======================

                        else if (menu == 'B' || menu == 'b')
                        {
                            double result;

                            result = amount / SalvageRate;

                            Console.WriteLine();

                            Console.WriteLine(
                                $"=> {amount:F2} {MaterialName} Ingot = " +
                                $"{result:F2} {MaterialName} Ore");
                        }

                        // ======================
                        // Invalid Menu
                        // ======================

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("error: menu");
                        }
                    }

                    // Amount not in range
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("error: amount");
                    }
                }

                // Parse amount failed
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("error: amount");
                }
            }

            // Parse menu failed
            else
            {
                Console.WriteLine();
                Console.WriteLine("error: menu");
            }
        }
    }
}
