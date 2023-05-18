using System;
using System.Data;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int quantityPuzzles = int.Parse(Console.ReadLine());
            int quantityPuppets = int.Parse(Console.ReadLine());
            int quantityBears = int.Parse(Console.ReadLine());
            int quantityMinions = int.Parse(Console.ReadLine());
            int quantityTrucks = int.Parse(Console.ReadLine());

            double priceAll = quantityPuzzles * 2.60 + quantityPuppets * 3 + quantityBears * 4.10 + quantityMinions * 8.20 + quantityTrucks * 2;
            int quantityAll = quantityPuzzles + quantityPuppets + quantityBears + quantityMinions + quantityTrucks;
            priceAll -= priceAll * 0.10;

            if (quantityAll >= 50)
            {
                priceAll -= priceAll * 0.25;
            }
            if (priceAll >= tourPrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(priceAll - tourPrice):f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {Math.Abs(tourPrice-priceAll):f2} lv needed.");
            }
        }
    }
}
