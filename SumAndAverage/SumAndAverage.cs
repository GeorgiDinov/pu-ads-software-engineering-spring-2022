using System;
using ExersiseUtil;

namespace SumAndAverage
{
    internal class SumAndAverage
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int sum = SumAllElementsInSingleDimentionalArray(array);
            double avg = GetAverageOfSingleDimentionalArray(array);
            Console.WriteLine(MyUtil.GetArrayAsString(array) + " has sum=" + sum + " and  avg= " + avg);
        }


        private static int SumAllElementsInSingleDimentionalArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static double GetAverageOfSingleDimentionalArray(int[] array)
        {
            int sum = SumAllElementsInSingleDimentionalArray(array);
            return sum / array.Length;
        }

    }
}
