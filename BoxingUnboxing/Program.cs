using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Boxing*/
            int num = 2020;

            // boxing 
            object obj = num;

            // value of num to be change 
            num = 100;

            System.Console.WriteLine
            ("Value - type value of num is : {0}", num);
            System.Console.WriteLine
            ("Object - type value of obj is : {0}", obj);

            /*Unboxing*/
            // assigned int value 
            // 23 to num 
            int num1 = 23;

            // boxing 
            object obj1 = num1;

            // unboxing 
            int i = (int)obj1;

            // Display result 
            Console.WriteLine("Value of ob object is : " + obj1);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}
