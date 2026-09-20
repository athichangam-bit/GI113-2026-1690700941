/*
* Student ID : 1690700941
* Name       : อธิชา งามงอน
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Tinybound: Threads of Fate";

            const string CharactersClass = "The Dreamweaver";

            var character = "Ari";
            var rankName = "B";
            int charLevel = 1;
            float critChance = 0.25f;
            double playfulness = 60.7;
            bool isPlayable = true;

            Console.WriteLine("+------------------------------------+");
            Console.WriteLine($"|     {GameTitle}     |");
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine();
            Console.WriteLine($"Character   : {character}");
            Console.WriteLine($"Class       : {CharactersClass}");
            Console.WriteLine($"Rank        : {rankName}");
            Console.WriteLine($"Level       : {charLevel}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Playfulness : {playfulness}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine();

            double charLevelAsDouble = charLevel;
            Console.WriteLine($"Level as double (implicit): {charLevelAsDouble}");

            int playfulnessTruncated = (int)playfulness;
            int playfulnessRounded = Convert.ToInt32(playfulness);
            Console.WriteLine($"Playfulness cast (truncates)  : {playfulnessTruncated}");
            Console.WriteLine($"Playfulness Convert (rounds)  : {playfulnessRounded}");
            Console.WriteLine();
            Console.WriteLine("======================================");
        }
    }
}
