using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the next two rows, we get the length of the sides "a" and "b" of the rectangle from the console
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            // We calculate area of rectangle.
            var sum = a * b;

            // We print to the console the result rounded up to two marks after the decimal point.
            Console.WriteLine("{0:f2}",sum);
           
        }
    }
}
