using System;
using System.Net.Security;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int pupets = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double priceAll = puzzels * 2.60 + pupets * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            priceAll = priceAll - priceAll * 0.10;
            double quntity = puzzels + pupets + bears + minions + trucks;
            if (quntity >= 50)
            {
                priceAll = priceAll - priceAll * 0.25;
            }
            if (priceAll >= tripPrice)
            {
                double remainingMoney = tripPrice - priceAll;
                remainingMoney = Math.Abs(remainingMoney);
                Console.WriteLine($"Yes! {remainingMoney:f2} lv left.");
            }
            else
            {
                double neededMoney = priceAll - tripPrice;
                neededMoney = Math.Abs(neededMoney);
                Console.WriteLine($"Not enough money! {neededMoney} lv needed.");
            }


        }
    }
}
