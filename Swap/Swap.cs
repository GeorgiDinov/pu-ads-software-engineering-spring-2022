using System;

namespace Swap
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            //swap using third(temporary) variable
            int a = 5;
            int b = 10;
            Console.WriteLine("'a' & 'b' before swap with temp variable: a=" + a + ", b=" + b);

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("'a' & 'b'  after swap with temp variable: a=" + a + ", b=" + b);

            Console.WriteLine("****************************************************************");

            //swap using aritmetic operations
            a = 20;
            b = 30;
            Console.WriteLine("'a' & 'b' before swap with aritmetic operation: a=" + a + ", b=" + b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("'a' & 'b'  after swap with aritmetic operation: a=" + a + ", b=" + b);

            Console.WriteLine("****************************************************************");

            //overflow
            a = int.MaxValue;
            b = 1;
            Console.WriteLine("Overflow example: " + a + " + " + b + " = " + (a + b));

            //underflow
            a = int.MinValue;
            b = 1;
            Console.WriteLine("Underflow example: " + a + " - " + b + " = " + (a - b));
            /*
                You can easily toggle the Arithmetic Overflow option within the Advanced Build Settings of your Project.
                Right-click your Project within the Solution Explorer.
                Select Properties.
                Select the Build tab along the left.
                Select the Advanced… button (it should be at the very bottom)
                Within the Advanced Build Settings dialog, check the Check for arithmetic overflow.
             */

           //int compilerTest = 2147483648; // will produce compile time error when literal value greater than the max value of an int
        }
    }
}
