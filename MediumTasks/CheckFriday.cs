using System;
namespace MediumTasks
{
    public class CheckFriday
    {
        public static bool Friday(int month, int year)
        {
            var dt = new DateTime(year, month, 13);
            if (dt.DayOfWeek == DayOfWeek.Friday)
                return true;

            else
                return false;
        }

        static void Main(string[] args)
        {
            int month = 1, year = 1985;
            Console.WriteLine(Friday(month,year));
        }

    }
}
