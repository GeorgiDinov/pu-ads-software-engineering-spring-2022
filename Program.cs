using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pu_ads_software_engineering_spring_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int left = 5;
            //int right = 10;
            //Console.WriteLine("left=" + left + " right=" + right);
            //Console.WriteLine("Swap with temp");
            ////swap with temp variable
            //int temp = left;
            //left = right;
            //right = temp;
            //Console.WriteLine("left=" + left + " right=" + right);
            //Console.WriteLine("**********************");
            //left = 5;
            //right = 10;
            //Console.WriteLine("left=" + left + " right=" + right);
            ////swap with aritmetic operation
            //Console.WriteLine("Swap with aritmetic operation");
            //left = left + right;
            //right = left - right;
            //left = left - right;
            //Console.WriteLine("left=" + left + " right=" + right);
            //int value = 5;
            //Console.WriteLine(++value);
            //Console.WriteLine(value);

            //int[] array2 = new int[5];
            //int[] array1 = new int[] { };

            //RotateSingleDimentionalArray(array);
            //PrintSingleDimentionAlarray(array);

            //Console.WriteLine("Sum = " + SumOfAllElements(array));
            //Console.WriteLine("Average = " + AverageOfAllElementsInArray(array));
            //Console.WriteLine("Average = " + AverageOfAllElementsInArrayWithCallToSumMethod(array));

            //Console.WriteLine("Array Has Equal Sums At Index [" + EqualSumCheck(array) + "]");

            int[] array = new int[] { 7, 2, 3, 4, 5 };
            PrintSingleDimentionalArray(array);
            array = CopyArrayAndDoubleLenght(array);
            PrintSingleDimentionalArray(array);


        }

        private static void PrintSingleDimentionalArray(int[] array)
        {
            Console.Write("Array = [");
            for (int i = 0; i < array.Length; i++)
            {
                string element = (i < array.Length - 1) ? array[i] + ", " : array[i] + "]\n";
                Console.Write(element);
            }
        }

        private static void RotateSingleDimentionalArray(int[] array)
        {
            int right = array.Length - 1;
            for (int left = 0; left < array.Length / 2; left++)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right--] = temp;
            }
        }

        private static int SumOfAllElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //sum = sum + array[i];
                sum += array[i];
            }
            return sum;
        }

        private static double AverageOfAllElementsInArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //sum = sum + array[i];
                sum += array[i];
            }
            return sum / array.Length;
        }

        private static double AverageOfAllElementsInArrayWithCallToSumMethod(int[] array)
        {
            return SumOfAllElements(array) / array.Length;
        }

        private static int[] EqualSumCheck(int[] array)
        {
            int counter = 0;
            int[] indices = new int[1];

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int left = i - 1; left >= 0; left--)
                {
                    leftSum += array[left];
                }

                int rightSum = 0;
                for (int right = i + 1; right < array.Length; right++)
                {
                    rightSum += array[right];
                }

                if (leftSum == rightSum)
                {
                    indices[counter++] = i;
                    if (counter == indices.Length)
                    {
                        indices = CopyArrayAndDoubleLenght(indices);
                    }
                }
            }

            return indices;
        }

        private static int[] CopyArrayAndDoubleLenght(int[] array)
        {
            int[] copy = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }
    }
}
