using System;

namespace MileToKmConverter
{
    class Program
    {
        static double MileToKm(double distance, string mileType)
        {

            double km = 0;

            if (mileType == "морская")
            {
                km = distance * 1.852;
            }
            else if (mileType == "сухопутная")
            {
                km = distance * 1.609;
            }
            else
            {
                Console.WriteLine("Неверный тип миль");
            }

            return km;
        }

        static void Main(string[] args)
        {
            double distance = 10;
            string mileType = "сухопутная";

            double km = MileToKm(distance, mileType);

            if (km > 0)
            {
                Console.WriteLine("{0} миль ({1}) = {2:F2} км", distance, mileType, km);
            }

            Console.ReadKey();
        }
    }
}
