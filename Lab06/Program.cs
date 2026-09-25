/*
* Student ID : 1690700941
* Name       : อธิชา งามงอน
* Section    : 129A
* No.        : 33
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            ////ถ้าใช้เป็น hp ลด ใช้เป็น </>=0 จะ Save กว่า
            //if (lives == 0) //ด้านในวงเล็บต้องมีค่าเป็น Boolean ([อะไรก็ตามไม่เท่ากับ0] != 0 เป็นจริง)
            //{
            //    Console.WriteLine("Game Over"); //โค้ดจะรัน เมื่อ if เป็นจริงเท่านั้น
            //}

            //Console.WriteLine("Continew Running");

            ////2
            //int coins = 110;
            //int price = 100;

            //if (coins >= price)
            //{
            //    Console.WriteLine("Purchased"); //รันเมื่อเป็นจริง
            //}
            //else
            //{
            //    Console.WriteLine("Not enough coin."); //รันเมื่อเป็นเท็จ
            //}

            ////3
            //int score = 75;

            //if (score >= 90) //ลำดับ 1 เช็ค = เท็จ
            //{
            //    Console.WriteLine("Rank S"); // โค้ด ไม่รัน ไม่อ่าน
            //}
            //else if (score >= 60) // ลำดับ 2 เช็ค = จริง
            //{
            //    Console.WriteLine("Rank A"); //โค้ดรัน
            //}
            //else //เป็นกรณีที่ไม่ตรงกับทั้งสอง ลำดับด้านบน มีเป็นจริงแล้ว ส่วนนี้ไม่รัน
            //{
            //    Console.WriteLine("Rank B");
            //}

            ////4
            //bool haskey = true; // ผู้เล่นมีกุญแจ หรือไม่
            //Console.WriteLine("your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99) //เช็ค กรณี user ใส่ผิด
            //{
            //    Console.WriteLine("Invalid Level, Please try again.");
            //}
            //else if (level >= 10 && haskey) //ใส่เงื่อนไขกุญแจ
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //    Console.WriteLine("The door opens.");
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|  Tinybound: Threads of Fate  |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine();

            Console.WriteLine("| Threadborn Encounter: Drabby |");
            Console.WriteLine();

            Console.WriteLine("+===============================+");
            Console.WriteLine("||  ACTION 1: Starlit Stitch   ||");
            Console.WriteLine("||  ACTION 2: Moonlit Lullaby  ||");
            Console.WriteLine("||  ACTION 3: Wishful Embrace  ||");
            Console.WriteLine("||  ACTION 4: Dreamfall        ||");
            Console.WriteLine("+===============================+");
            Console.WriteLine();

            int monHp = 130;
            int atk = 25;
            int sleep = 0;
            int charHp = 100;
            int healHp = 20;
            int ult = 75;

            Console.Write("Choose your action: ");
            bool inputOk = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputOk || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input, Please choose between 1-4");
            }

            else if (choice == 1)
            {
                monHp -= atk;
                Console.WriteLine("You used Starlit Stitch attack the Drabby!");
            }
            else if (choice == 2)
            {
                monHp -= sleep;
                Console.WriteLine("You used Moonlit Lullaby the moonlight lulled the Drabby to sleep!");
            }
            else if (choice == 3)
            {
                charHp += healHp;
                Console.WriteLine("You used Wishful Embrace Threads stitched your wounds back together!");
            }
            else if (choice == 4)
            {
                monHp -= ult;
                Console.WriteLine("You used Dreamfall the Ultimate dream power descends upon Drabby!");
            }
            else
            {
                Console.WriteLine("THREAD BROKEN: Your thread has been unraveled...");
            }
        }
    }
}
