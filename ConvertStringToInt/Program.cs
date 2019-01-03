using System;
using System.Collections.Generic;

namespace ConvertStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "2";

            //int int1, int2, int3;

            //int1 = Int32.Parse(s1);
            //Int32.TryParse(s1, out int2);
            //Console.WriteLine(int2);

            //int3 = Convert.ToInt32(s1);
            //Student student = new Student()
            //{ ID = 1, Name = "Fek", Class = 6 };

            //Console.WriteLine("{0}  {1}  {2}", student.Name, student.ID, student.Class);

            //int i = 0, s = 0;
            //Console.WriteLine(i++);
            //Console.WriteLine(i);
            //++s;
            //Console.WriteLine(s);
            //Console.Write("enter alfebet:\t");
            //ConsoleKeyInfo keyEnter = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine(IsVowel(keyEnter.KeyChar));
            double s = CalculateTriangleArea(3, 6);
            Console.WriteLine(s);
        }

        public static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        public static double CalculateTriangleArea(double a, double b)
        {
            double areOfTrangle;
            areOfTrangle =((double)1/2)*(a*b);


            return (areOfTrangle);
        }

        public static double TaxCalculate(double money)
        {
            return 0;
        }
    }
}
/*
 
*1. Decimal – ToDecimal(string)
decimal num1=Convert.ToDecimal("10");
*2. Float – ToSingle(string)
float num1=Convert.ToSingle("10");
*3. double – ToDouble(string)
double num1=Convert.ToDouble("10");
*4. short – ToInt16(string)
short num1=Convert.ToInt16("2");
*5. int – ToInt32(string)
int num1=Convert.ToInt32("10");
*/
