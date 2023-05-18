using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int timeEp = int.Parse(Console.ReadLine());
            int timeFree = int.Parse(Console.ReadLine());

            double lunch = (double)timeFree * 3 / 8;
            double all = timeFree - lunch;

            if (timeEp <= all)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(all - timeEp)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Ceiling(timeEp - all)} more minutes.");
            }

        }
    }
}
