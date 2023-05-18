using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            int quantityVideo = int.Parse(Console.ReadLine());
            int quantityProcessors = int.Parse(Console.ReadLine());
            int quantityRam = int.Parse(Console.ReadLine());

            double priceVideo = quantityVideo * 250;
            double priceProcessors = priceVideo * 0.35 * quantityProcessors;
            double priceRam = priceVideo * 0.10 * quantityRam;
            double sumAll = priceVideo + priceProcessors + priceRam;

            if (quantityVideo > quantityProcessors)
            {
                sumAll -= sumAll * 0.15;
            }


            if (balance >= sumAll)
            {
                Console.WriteLine($"You have {balance - sumAll:f2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {sumAll - balance:f2} leva more!");
            }
        }
    }
}
