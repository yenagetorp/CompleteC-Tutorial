using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintOutGrid(4);
            // PowerCal();
            EquilateralTraigle(9);
        }


        public static void PrintOutGrid(int a)
        {


            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i + 2; j++)
                {
                    Console.Write(i + 2);
                }
                // Console.WriteLine();
                Console.Write("\n");
            }
            Console.ReadLine();
        }


        public static void PowerCal()
        {
            ConsoleKeyInfo keyEnter;

            do

            {
                Console.WriteLine("Enter a number please:");

                string input = Console.ReadLine();
                double convertStringToDouble;
                if (double.TryParse(input, out convertStringToDouble))
                {


                    Console.WriteLine(Math.Pow(convertStringToDouble, 2));

                }
                else
                {
                    Console.WriteLine("Invalid input...");
                }

                Console.WriteLine("Continue? Y/n");
                keyEnter = Console.ReadKey();
                Console.WriteLine();


            } while (keyEnter.Key == ConsoleKey.Y);

        }

        public static void EquilateralTraigle(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row-i; j++)
                {
                    Console.Write(" ");
                }
                int k = 1;
                while (k<=i)
                {
                    Console.Write(k);
                    k++;
                }
                int s = i + 1;
                while (s > i && s < 2 * i)
                {
                    Console.Write(2 * i - s);
                    s++;
                }
                Console.WriteLine("");
                
            }

            for (int a = 1; a < row; a++)
            {
                for (int m = 1; m < a + 1; m++)
                {
                    Console.Write(" ");
                }
                int n = 1;
                while (n <= (row - a))
                {
                    Console.Write(n);
                    n++;
                }
                int q =1;
                while (q<row-a)
                {
                    Console.Write(row - a - q);
                    q++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
