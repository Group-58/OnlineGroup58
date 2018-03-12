using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the next two rows, we get the length of the sides "a" and "b" of the rectangle from the console
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            // We calculate area of rectangle.
            var rectangleArea = sideA * sideB;

            // We print to the console the result rounded up to two marks after the decimal point.
            Console.WriteLine("{0:f2}",rectangleArea);
      
        }
    }
}
