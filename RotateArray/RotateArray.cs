using System;
using ExersiseUtil;


namespace RotateArray
{
    internal class RotateArray
    {
        static void Main(string[] args)
        {
            string arrayMessage = "Array ";

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            MyUtil.PrintSingleDimentionalArray(array);

            RotateSingleDimentionalArrayV1(array);
            Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V1");

            RotateSingleDimentionalArrayV2(array);
            Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V2");

            RotateSingleDimentionalArrayV2_1(array);
            Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V2_1");

            RotateSingleDimentionalArrayV3(array);
            Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V3");

            RotateSingleDimentionalArrayV3_1(array);
            Console.WriteLine(arrayMessage + MyUtil.GetArrayAsString(array) + " rotated with V3_1");
        }


        private static void RotateSingleDimentionalArrayV1(int[] array)
        {
            int last = array.Length - 1;
            for (int first = 0; first < array.Length / 2; first++)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last--] = temp;
            }
        }

        private static void RotateSingleDimentionalArrayV2(int[] array)
        {
            for (int first = 0, last = array.Length - 1; first < array.Length / 2; first++, last--)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last] = temp;
            }
        }

        private static void RotateSingleDimentionalArrayV2_1(int[] array)
        {
            for (int first = 0, last = array.Length - 1; first < array.Length / 2; first++, last--)
            {
                Swap(array, first, last);
            }
        }

        private static void RotateSingleDimentionalArrayV3(int[] array)
        {
            int first = 0, last = array.Length - 1;
            while (first < array.Length / 2)
            {
                int temp = array[first];
                array[first++] = array[last];
                array[last--] = temp;
            }
        }

        private static void RotateSingleDimentionalArrayV3_1(int[] array)
        {
            int first = 0, last = array.Length - 1;
            while (first < array.Length / 2)
            {
                Swap(array, first, last);
                first++;
                last--;
            }
        }


        private static void Swap(int[] array, int left, int right)
        {
            if (left == right)
            {
                return;
            }

            if (IsIndexOutOfBounds(array, left))
            {
                return;//process with custom exception or other logic
            }

            if (IsIndexOutOfBounds(array, right))
            {
                return;//process with custom exception or other logic
            }

            if (array[left] == array[right])
            {
                return;
            }

            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        private static bool IsIndexInBounds(int[] array, int index)
        {
            return index >= 0 && index < array.Length;
        }

        private static bool IsIndexOutOfBounds(int[] array, int index)
        {
            return index < 0 && index >= array.Length;
        }

    }
}
