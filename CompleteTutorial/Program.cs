using System;

namespace Ploymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(3, 5);
            Console.WriteLine(sum);
            Sum(3.9f, 9.9f);

        }



        /*In function overloading, a function works differently based on parameters. 
         *A single function can have different nature based on a number of parameters 
         * and types of parameters. For example, you have a function Sum() that accepts
         * values as a parameter and print their addition. You can write multiple functions
         * with name Sum() but the parameter signature must be different.
         */
         public static int Sum(int a, int b)
        {
            int sum;
            return 
                 sum = a + b;
        }

        public static void Sum(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine("the sum of a and b is {0}", sum);
        }

    }
}
