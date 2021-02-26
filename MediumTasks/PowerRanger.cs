using System;
namespace MediumTasks
{
    public class PowerRanger
    {
        public static int Power(int power, int min, int max)
        {
            var Lower = Math.Ceiling(Math.Pow(min, 1.0 / power));
            var Upper = Math.Floor(Math.Pow(max, 1.0 / power));

            int result = Convert.ToInt32((Upper - Lower)+1);
            
            return result;
        }

        static void Main(string[] args)
        {
            int power = 2, min = 1, max = 100;
            Console.WriteLine(Power(power, min, max));
        }
    }
}
