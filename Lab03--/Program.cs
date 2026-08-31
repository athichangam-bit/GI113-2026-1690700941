namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Pawdy";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'F';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 3;
            int maxHp = 70;
            int currentHp = 43;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 12.5f;
            double critMultiplier = 0.75;
            bool isBoss = true;
            //output แสดงค่าตัวแปร
            Console.WriteLine("======= PAWDY SAVE CONVERTER =======");
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            //ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // Int ->> Double แปลงแบบไม่ Cast ใส่ค่าได้เลย
            Console.WriteLine($"HP (double): {currentHpDouble}");

            //ทำ

            //ทำ Explicit โดยการ Casting (float) AttackPower ->> Int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;  // แปลงข้อมูลโดยการ Cast Syntax: (ชนิดที่ต้องการแปลง)ชื่อตัวแปรที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");
        }
    }
}
