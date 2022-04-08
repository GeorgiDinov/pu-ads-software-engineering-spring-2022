using System;

namespace ExerciseUtil
{
    public class MyUtil
    {

        private MyUtil()
        { }

        static void Main(string[] args) { }

        public static void PrintSingleDimentionalArray(int[] array)
        {
            Console.WriteLine("Array " + GetArrayAsString(array));
        }

        public static string GetArrayAsString(int[] array)
        {
            string arrayString = "[";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += (i < array.Length - 1) ? array[i] + ", " : array[i] + "]";
            }
            return arrayString;
        }
    }
}
