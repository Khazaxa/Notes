using System;

namespace FlightDiscount
{
    internal class Program
    {
        public static double GetDiscount(bool isInfant, bool isYoung, bool isRegular, bool isDomestic, bool isInternational, bool isOffSeason, int advanceBookingMonths)
        {
            double discount = 0;

            if (isInfant)
            {
                if (isDomestic)
                {
                    discount = 0.8;
                }
                else if (isInternational)
                {
                    discount = 0.7;
                }
            }
            else if (isYoung)
            {
                discount = 0.1;
            }
            else if (advanceBookingMonths >= 5)
            {
                discount = 0.1;
            }
            else if (isOffSeason)
            {
                discount = 0.15;
            }
            else if (isRegular)
            {
                discount = 0.15;
            }

            return discount;
        }

        static void Main(string[] args)
        {
            double discount = GetDiscount(isInfant: true, isYoung: false, isRegular: false, isDomestic: true, isInternational: false, isOffSeason: false, advanceBookingMonths: 0);
            Console.WriteLine($"Discount: {discount:P}");
        }
    }
}
