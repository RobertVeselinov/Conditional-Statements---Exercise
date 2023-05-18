using System;

namespace P03.Time__15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = hours * 60 + minutes + 15;
            double hours1 = sum / 60;
            double minutes1 = sum % 60;

            if (hours1 == 24)
            {
                hours1 = hours1 - 24;
            }
            if (minutes1 < 10)
            {
                Console.WriteLine($"{hours1}:0{minutes1}");
            }
            else
            {
                Console.WriteLine($"{hours1}:{minutes1}");
            }
        }
    }
}
