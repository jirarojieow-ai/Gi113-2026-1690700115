/*
* Student ID : 1690700115
* Name       : jiraroj Ieowsuwan
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

using System;

class Program
{
    static void Main()
    {
        // ✅ เพิ่มบรรทัดนี้ก่อนอื่น เพื่อให้แสดงภาษาไทยได้
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ========== 1. ตรวจสอบชีวิต ==========
        Console.WriteLine("===== 1. ตรวจสอบชีวิต =====\n");
        int lives = 0;
        if (lives <= 0)
        {
            Console.WriteLine("Game Over");
        }
        Console.WriteLine("Continue Running\n");

        // ========== 2. ตรวจสอบเหรียญกับราคา ==========
        Console.WriteLine("===== 2. ตรวจสอบการซื้อ =====\n");
        int coins = 110;
        int price = 100;
        if (coins >= price)
        {
            Console.WriteLine("Purchased");
        }
        else
        {
            Console.WriteLine("Not enough coin.");
        }
        Console.WriteLine();

        // ========== 3. จัดอันดับคะแนน ==========
        Console.WriteLine("===== 3. จัดอันดับคะแนน =====\n");
        int score = 75;
        if (score >= 90)
        {
            Console.WriteLine("Rank S");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Rank A");
        }
        else
        {
            Console.WriteLine("Rank B");
        }
        Console.WriteLine();

        // ========== 4. ตรวจสอบระดับ ==========
        Console.WriteLine("===== 4. ตรวจสอบระดับ =====\n");
        Console.Write("your level (1-99): ");
        bool ok = int.TryParse(Console.ReadLine(), out int level);

        if (!ok || level < 1 || level > 99)
        {
            Console.WriteLine("Invalid Level, please try again.");
        }
        else if (level >= 10)
        {
            Console.WriteLine("Boss floor unlocked.");
        }
        else if (level >= 5)
        {
            Console.WriteLine("The door opens.");
        }
        else
        {
            Console.WriteLine("The door stays shut.");
        }
        Console.WriteLine();

        // ========== 5. ผจญภัยของ Brian ==========
        Console.WriteLine("===== 5. ผจญภัยของ Brian =====\n");

        int heroHP = 100;
        int monHp = 100;
        int atk = 30;

        Console.WriteLine("Adventure of Brian");
        Console.WriteLine("=== Monster Encounter 1 <===");
        Console.WriteLine("ACTION A: ATTACK");
        Console.WriteLine("ACTION B: FLEE\n");

        Console.Write("Choose your action: ");
        bool inputOk = char.TryParse(Console.ReadLine(), out char choice);

        if (!inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B'))
        {
            Console.WriteLine("Invalid input, Please choose between a, b");
        }
        else if (choice == 'a' || choice == 'A')
        {
            monHp -= atk;
            if (monHp <= 0)
            {
                Console.WriteLine($"Player attack monster with {atk} points, Monster defeated!!!");
            }
            else
            {
                Console.WriteLine($"Player attack monster with {atk} points, Monster HP has {monHp} HP left.");
            }
        }
        else if (choice == 'b' || choice == 'B')
        {
            heroHP -= 30;
            Console.WriteLine($"You run away but the monster hits you for 30. Hero HP is now {heroHP}.");
        }
        else
        {
            Console.WriteLine("Timeout: You ran out of time");
        }
    }
}