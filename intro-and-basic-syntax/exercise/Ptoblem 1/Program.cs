using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are declaring an array of 4 integers
            int[] num = { 0, 0, 0, 0 };
            
            //We are receiving from the console 4 integers
            for (int i = 0; i < 4; i++)
            {
                num[i] = int.Parse(Console.ReadLine()); 
            }

            //We are printing the result in 4-digit debit card format
            Console.WriteLine($"{num[0]:D4} {num[1]:D4} {num[2]:D4} {num[3]:D4}");
        }
    }
}
