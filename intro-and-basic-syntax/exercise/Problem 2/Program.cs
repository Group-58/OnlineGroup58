//CONFIRMED from s-tdrv

using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the next two rows, we get the length of the sides "a" and "b" of the rectangle from the console
            double wight = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            // We calculate area of rectangle.
            var area = wight * hight;

            // We print to the console the result rounded up to two marks after the decimal point.
            Console.WriteLine("{0:f2}",area);
      
        }
    }
}
