using System;
using System.Linq;

namespace EasyTasks
{
    public class Program
    {
        public static double[] FindMinMax(double[] values)
        {
            double MinVal = values.Min();
            double MaxVal = values.Max();
            double[] MinMaxVal = { MinVal, MaxVal };
            foreach (int i in MinMaxVal)
            {
                Console.WriteLine("{0}", i);
            }

            return MinMaxVal;
        }

        static void Main(string[] args)
        {
            double[] values = { 1, 2, 3, 4, 5 };
            
            Program.FindMinMax(values);
        }



    }
}
