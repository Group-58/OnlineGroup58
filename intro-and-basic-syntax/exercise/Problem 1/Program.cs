using System;

namespace _01._Debit_Card_numbersber
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are declaring an array of 4 integers
            int[] numbers = { 0, 0, 0, 0 };
            
            //We are receiving from the console 4 integers
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            //We are printing the result in 4-digit debit card format
            Console.WriteLine($"{numbers[0]:D4} {numbers[1]:D4} {numbers[2]:D4} {numbers[3]:D4}");
        }
    }
}
