namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // output แสดงตัวแปล
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}");
            Console.WriteLine($"\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            // ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; //Int ->> Double แปลงค่าแบบไม่ Cast ใส่ค่าได้เลย
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // ทำ Implicit หลังการคำนวณเปอร์เซ็นต์ ที่ผลลัพธ์ทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp; //int หาร int จากนั้นแปลงผลลัพธ์คำนวณเป็นdouble
            Console.WriteLine($"HP Percent: (exct):{hpPercent}%");

            // ทำ Explicit โดยการ Casting (float) Attackpower ->> Int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;  // แปลงข้อมูลโดยการ Cast Syntax: (ชนิดที่ต้องแปลง)ชื่อตัวแปลที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine($"\n----- Cast vs Convert: (int)critMultiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);

            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
            Console.WriteLine($"\n----- Cast vs Convert: Crit Multiplier -----");
        }
    }
}