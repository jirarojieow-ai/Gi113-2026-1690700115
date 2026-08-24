/*
 * Student ID : 1690700115
 * Name       : jiraroj Ieowsuwan
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");

            //ตัวละครที่ 1: อัศวิน
            string p1Name = "Arthur";
            int p1Hp = 500;
            float p1Armor = 75.5f;
            char p1Grade = 'A';
            bool p1IsAlive = true;

            Console.WriteLine($"Name: {p1Name}");
            Console.WriteLine($"HP: {p1Hp}");
            Console.WriteLine($"Armor: {p1Armor}");
            Console.WriteLine($"Grade: {p1Grade}");
            Console.WriteLine($"Is Alive: {p1IsAlive}");

            //ตัวละครที่ 2: นักเวช
            string p2Name = "Elena";
            int p2Mana = 300;
            double p2MaqicPower = 150.85;
            char p2Element = 'F'; // F = Fire
            bool p2IsAlive = true;

            Console.WriteLine($"Name: {p2Name}");
            Console.WriteLine($"Mana: {p2Mana}");
            Console.WriteLine($"Magic Power: {p2MaqicPower}");
            Console.WriteLine($"Element: {p2Element}");
            Console.WriteLine($"Is Alive: {p2IsAlive}");

            //ตัวละครที่ 3: นักธนู
            string p3Name = "Robin";
            int p3Arrows = 45;
            float p3speed = 12.8f;
            double p3Accuracy = 98.75;
            bool p3IsStealth = false;

            Console.WriteLine($"Name: {p3Name}");
            Console.WriteLine($"Arrows: {p3Arrows}");
            Console.WriteLine($"speed: {p3speed}");
            Console.WriteLine($"Accuracy: {p3Accuracy}");
            Console.WriteLine($"Is Stealth: {p3IsStealth}");

            //ตัวละครที่4: นักบวช
            string p4Name = "Sophia";
            int p4HealPower = 90;
            float p4ReqenRate = 4.5f;
            char p4Rank = 'S';
            bool p4IsActive = true;

            Console.WriteLine($"Name: {p4Name}");
            Console.WriteLine($"HealPower: {p4HealPower}");
            Console.WriteLine($"ReqenRate: {p4ReqenRate}");
            Console.WriteLine($"Rank: {p4Rank}");
            Console.WriteLine($"Is Active: {p4IsActive}");
        }
    }
}
