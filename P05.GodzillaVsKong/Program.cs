using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmPrice = double.Parse(Console.ReadLine());
            int statistQuantity = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorPrice = filmPrice * 0.10;
            clothesPrice = clothesPrice * statistQuantity;

            if (statistQuantity > 150)
            {
                clothesPrice -= clothesPrice * 0.10;
            }
            double allPrice = clothesPrice + decorPrice;

            if (allPrice > filmPrice)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(allPrice - filmPrice):f2} leva more.");
            }
            else 
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(filmPrice - allPrice):f2} leva left.");
            }

        }
    }
}
