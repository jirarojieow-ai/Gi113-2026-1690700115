/*
* Student ID : 1690700115
* Name       : jiraroj Ieowsuwan
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

using System;

namespace Assignment02
{
    class Program
    {
        // ค่าคงที่ — PascalCase
        const double SmeltRate = 0.2500;
        const double SalvageRate = 0.3000;
        const double MaxBatch = 500.00;

        static void Main(string[] args)
        {
            // ส่วนหัว — ตรงตัวอย่าง
            Console.WriteLine("--------------------------");
            Console.WriteLine("--- Welcome to the Forge ---");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"=> Iron Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            // รับเมนู
            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            char menuChar = '\0';
            bool menuOk = false;

            if (char.TryParse(menuInput, out menuChar))
            {
                char m = char.ToLower(menuChar);
                if (m == 's' || m == 'b')
                {
                    menuOk = true;
                }
            }

            if (!menuOk)
            {
                Console.WriteLine("error: menu");
                return;
            }

            // รับจำนวน
            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            double amount = 0;
            bool amountOk = false;

            if (double.TryParse(amountInput, out amount))
            {
                // Nested if + && ตรวจสอบช่วงค่า
                if (amount > 0 && amount <= MaxBatch)
                {
                    amountOk = true;
                }
                else
                {
                    if (amount <= 0)
                    {
                        Console.WriteLine("error: amount (ไม่มากกว่า 0)");
                    }
                    else
                    {
                        Console.WriteLine("error: amount (เกินขอบเขต)");
                    }
                }
            }
            else
            {
                Console.WriteLine("error: amount (parse ไม่ได้)");
            }

            if (!amountOk)
            {
                return;
            }

            // คำนวณและแสดงผล
            char menu = char.ToLower(menuChar);
            if (menu == 's')
            {
                double result = amount * SmeltRate;
                Console.WriteLine($"=> {amount:F2} Iron Ore = {result:F2} Iron Ingot");
            }
            else if (menu == 'b')
            {
                double result = amount / SalvageRate;
                Console.WriteLine($"=> {amount:F2} Iron Ingot = {result:F2} Iron Ore");
            }
            else
            {
                Console.WriteLine("error: menu");
            }
        }
    }
}