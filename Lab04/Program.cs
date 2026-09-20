/*
* Student ID : 1690700941
* Name       : อธิชา งามงอน
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=============");
            //Console.WriteLine("NEW ADVETURE");  //Print ธรรมดา Title
            //Console.WriteLine("=============\n");
            //Console.Write("Name your hero: "); //Writeline พิมพ์บรรรทัดใหม่, Wire พิมพ์ต่อจากบรรทัดเดิม

            //string playerName = Console.ReadLine();  //เมื่อผู้เล่นกรอกชื่อจากนั้นชื่อจะเข้าไปเก็บใน PlayerName


            //Console.WriteLine($"\nWelcome, {playerName}. Your journey begins...");

            //Console.WriteLine("\n======================" + 
            //                  "\nDifficulty Selection" + 
            //                  "\n======================\n");
            //Console.Write("Choose difficulty (1-3): ");
            //string choice = Console.ReadLine(); //รับ Input และเก็บใส่ Choice
            
            //int difficulty = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Difficulty set to {difficulty}");

            //Console.WriteLine("+-----------------------------+");
            //Console.WriteLine("           ITEM SHOP           ");
            //Console.WriteLine("+-----------------------------+");
            //Console.Write("How many potion? ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            //Console.WriteLine($"Valid input: {isValid}");
            //Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|        CHARACTER CREATION        |");
            Console.WriteLine("+----------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classValid = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Staring luck (0.0-10.0): ");
            bool luckValid = double.TryParse(Console.ReadLine(), out double luckNum);
            Console.WriteLine("======================================================");
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer  enters the dungeon. Luck:{luckNum}");
            Console.WriteLine("\n======================================================\n");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine();

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine("==================");
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
            Console.WriteLine("==================");
        }
    }
}
