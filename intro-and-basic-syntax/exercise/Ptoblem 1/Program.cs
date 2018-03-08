using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                num[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine($"{num[0]:D4} {num[1]:D4} {num[2]:D4} {num[3]:D4}");
        }
    }
}
