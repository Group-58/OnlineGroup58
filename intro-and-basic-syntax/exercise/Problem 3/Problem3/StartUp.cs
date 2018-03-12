namespace Problem3
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
