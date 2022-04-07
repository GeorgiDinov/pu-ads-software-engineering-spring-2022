using System;


namespace week_one_06_04_2022
{
    internal class Swap
    {

       private static void Main(string[] args)
        {
            // swap two integer variables using third(temporary) variable
            int a = 5;
            int b = 15;
            Console.WriteLine("a & b Before Swap: a=" + a + ", b=" + b);
            int temporaryVariable = a;
            a = b;
            b = temporaryVariable;
            Console.WriteLine("a & b Before After Swap: a=" + a + ", b=" + b);
        }
    }
}
