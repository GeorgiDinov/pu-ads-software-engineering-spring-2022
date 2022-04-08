using System;
using ExerciseUtil;

namespace MinAndMax
{
    internal class MinAndMax
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int min = GetMinValueInSingleDimentionalArray(array);
            int max = GetMaxValueInSingleDimentionalArray(array);
            string message = "Array " + MyUtil.GetArrayAsString(array) + " has min=" + min + " and max=" + max + " values";
            Console.WriteLine(message);
        }

        private static int GetMinValueInSingleDimentionalArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static int GetMaxValueInSingleDimentionalArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
