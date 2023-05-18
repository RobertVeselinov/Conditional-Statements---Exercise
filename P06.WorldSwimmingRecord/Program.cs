using System;

namespace P06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secRecord = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double distancePerMeter = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distanceMeters / 15 ) * 12.5;
            double allDistance = distanceMeters * distancePerMeter + delay;

            if (allDistance < secRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(allDistance):f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(allDistance - secRecord):f2} seconds slower.");
            }
        }
    }
}
