using System;

namespace MileToKmConverter
{
    class MileToKm
    {
        public static double solve(double distance, string mileType)
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

        public static void show()
        {
            double distance = 10;
            string mileType = "сухопутная";

            double km = solve(distance, mileType);

            if (km > 0)
            {
                Console.WriteLine("{0} миль ({1}) = {2:F2} км", distance, mileType, km);
            }

        }
    }
}
