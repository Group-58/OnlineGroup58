//CONFIRMED from dimitar.v
namespace Problem3
{   
    using System;

    public class StartUp
    {
        public static void Main()
        { 
            // We read miles from the console.
            double inputMiles = double.Parse(Console.ReadLine());
            // After this we set how much is 1 mile to kilometers.
            double calculateKM = inputMiles * 1.60934;
            // We print the result.
            Console.WriteLine($"{calculateKM:f2}");
        }
    }
}
