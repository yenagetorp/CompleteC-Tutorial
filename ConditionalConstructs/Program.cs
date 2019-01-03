using System;

namespace ConditionalConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.add(); //It is valid, because private add() is in same class
            Console.ReadLine();


            //double totalTax = 0;
            //Console.WriteLine("Enter your salary:");
            //double salary = double.Parse(Console.ReadLine());
            //totalTax = CalculateTotalTax(salary);
            //Console.WriteLine(totalTax);
        }

        private static double CalculateTotalTax(double salary)
        {
            double totalTax = 0;
            if (salary<10000)
            {
                return totalTax = salary * 5 /100;
            }
            else if(salary>=10000&&salary<1000000)
            {
                return totalTax = salary * 8 / 100;
            }
            else if(salary >=1000000)
            {
                return totalTax = salary * 10 / 100;
            }
            else
            {
                return 0;
            }
        }

        private void add()// nonstatc here to to nya upp, instansera.
        {
            int num1, num2, result;
            Console.Write("Enter a number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        }
    }
}
