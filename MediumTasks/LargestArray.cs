using System;
using System.Collections.Generic;
using System.Linq;

namespace MediumTasks
{
    public class LargestArray
    {

        public static double[] FindLargest(double[][] values)
        {
            var ResultList = new List<double>(); 
            for (int i=0; i < values.Length; i++)
            {
                ResultList.Add(values[i].Max());
                Console.WriteLine(values[i].Max());
                //Result = Result.Concat(new[] { values[i].Max() }).ToArray();
            }
            double[] ResultArray = ResultList.ToArray();
            return ResultArray;

        }

        static void Main(string[] args)
        {
            double[][] values = new double[][]
            {
                new double[] {1,2,3,4,5 },
                new double[] {2,3,1,3,-2},
                new double[] {4,1,2,3,-2}
            };

            FindLargest(values); 
        }
    }
}
