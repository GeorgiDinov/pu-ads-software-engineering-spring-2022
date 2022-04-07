using System;
using ExersiseUtil;

namespace InterviewTaskExample
{
    internal class TaskExample
    {
        // Write a program that determines if there exists an element in the array
        // such that the sum of the elements on its left is equal to the sum of the elements on its right.
        // If there are no elements to the left/right, their sum is considered to be 0.
        // Print the index that satisfies the required condition or "no" if there is no such index.

        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 32, 2, 10 };
            int[] array2 = new int[] { 1, 0, 0, 0, 0, 1 };
            EqualSumCheck(array);
            EqualSumCheckAllPositions(array);
            EqualSumCheckAllPositions(array2);
            Console.WriteLine("Corner cases tests");
            int[] tstArray = null;
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[0];
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[] { };
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[] { 5 };
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[] { 5, 5 };
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[] { 0, 5 };
            EqualSumCheck(tstArray);
            Console.WriteLine("**************************");
            tstArray = new int[] { 5, 0 };
            EqualSumCheck(tstArray);
        }

        private static void EqualSumCheck(int[] array)
        {
            int index = GetIndexInArrayThatDividesItIntoTwoEqualSums(array);
            string result;
            if (index != -1)
            {
                result = "At position [" + index + "] equal sums to the left and right were found";
            }
            else
            {
                result = "Position dividing the array in two equal sums Not Found!";
            }

            Console.WriteLine(result);
        }

        private static int GetIndexInArrayThatDividesItIntoTwoEqualSums(int[] array)
        {
            if (array == null)
            {
                return -1; // process with custom exception or other logic
            }

            if (array.Length == 0)
            {
                return -1; // process with custom exception or other logic
            }

            if (array.Length == 1) // If there are no elements to the left/right, their sum is considered to be 0.
            {
                return 0;
            }

            if (array.Length == 2)
            {
                if (array[0] == 0) // If there are no elements to the left/right, their sum is considered to be 0.
                {
                    return 1;
                }
                if (array[1] == 0) // If there are no elements to the left/right, their sum is considered to be 0.
                {
                    return 0;
                }
            }

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
                    return i;
                }
            }

            return -1;
        }


        private static void EqualSumCheckAllPositions(int[] array)
        {
            int[] positions = GetAllIndicesInArrayThatDividesItIntoTwoEqualSums(array);
            string result;
            if (positions == null)
            {
                result = "Positions dividing the array in two equal sums Not Found!";
            }
            else
            {
                string positionsString = MyUtil.GetArrayAsString(positions);
                string sentenceStart = (positions.Length == 1) ? "At position " + positionsString : "At positions " + positionsString;
                result = sentenceStart + " equal sums to the left and right were found";
            }
            Console.WriteLine(result);
        }


        private static int[] GetAllIndicesInArrayThatDividesItIntoTwoEqualSums(int[] array)
        {
            int counter = 0;
            int[] indices = null;

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
                    if (indices == null)
                    {
                        indices = new int[1];
                    }

                    if (counter == indices.Length)
                    {
                        indices = CopyArrayAndIncrementLenght(indices);
                    }

                    indices[counter++] = i;
                }
            }

            return indices;
        }


        private static int[] CopyArrayAndIncrementLenght(int[] array)
        {
            int newLenght = array.Length + 1;
            int[] copy = new int[newLenght];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
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
