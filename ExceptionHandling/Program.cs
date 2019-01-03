using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:
            int[] heltalsVektor = new int[5] { 3, 4, 1, 5, 2 };
            try
            {
                for (int i = 0; i < 6; i++)
                    Console.WriteLine("{0}: {1}", i, heltalsVektor[i]);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }


            //exercise 2:
            int numb1, numb2;
            byte result1;

            numb1 = 30;
            numb2 = 60;
           // Console.WriteLine("{0} x {1} = {2}", numb1, numb2, result1);

            Console.ReadLine();
            try
            {
                result1 = Convert.ToByte(numb1 * numb2);
                Console.WriteLine("{0} x {1} = {2}", numb1, numb2, result1);
            }
            catch (OverflowException ofex)
            {

                Console.WriteLine(ofex.Message); 
            }

            //exercise 3:
            Console.Write("Enter Student Name: ");

            string studentName = Console.ReadLine();

            try
            {
                IList<string> studentList = FindAllStudentFromDatabase(studentName);

                Console.WriteLine("Total {0}: {1}", studentName, studentList.Count);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString() + "No Students exists for the specified name.");
            }

            Console.ReadKey();


        //example 1: try, catch, finally
        label:
            // Try block: The code which may raise exception at runtime
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Divide Program. You Enter 2 number and we return result");
                Console.WriteLine("Enter 1st Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Divide : " + result.ToString());
                Console.ReadLine();
            }

            //Multiple Catch block to handle exception

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("You have Entered 0");
                Console.WriteLine("More Details about Error: \n\n" + dex.ToString() + "\n\n");
                goto label;
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("More Details about Error: \n\n" + fex.ToString() + "\n\n");
                goto label;
            }

            //Parent Exception: Catch all type of exception

            catch (Exception ex)
            {
                Console.WriteLine("Othe Exception raised" + ex.ToString() + "\n\n");
                goto label;
            }

            //Finally block: it always executes

            finally
            {
                Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                Console.ReadLine();
            }
            //Example 2: throw
            /* keyword “throw” in exception handling. This keyword 
             * is used for creating custom exception class or creating
             * user-defined exception class.
             * While creating custom exception class it is best practice
             * to keep class name with the end of Exception word.
             * For example, OutofStockException, 
             * NumberNotFoundException, IamHeroException etc.*/
            int acceptorder;
            Console.WriteLine("Welcome to Shopping Site:\nHow many headphone you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (acceptorder==10||acceptorder<11)
                {
                    Console.WriteLine("Congratulations! You have bought {0} headphones", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw new OutOFStockException("OutofStockException Generated: The number of item you want to buy is out of stock. Please enter total item number within stock.");
                }
            }
            catch (OutOFStockException oex)
            {

                Console.WriteLine(oex.Message.ToString()); 
            }
        }



        private static IList<string> FindAllStudentFromDatabase(string studentName)
        {
            IList<string> studentList = null;
            // find all students with same name from the database 
            return studentList;
        }
    }

    //Create a custom exception calss OutOfStockException.
    //which is catches by catch block when user enter larger 
    //number than the stock available. All the user defined exception class
    //must be derived from its base class Exception.

    public class OutOFStockException: Exception
    {
        //all the exception calss must have a contructor, however, we may define 
        //numbers of constructors based on my won requirement. 
        //Here we have only created one constructor, that takes one string inparameter,
        //which will later throw astring message. 
        public OutOFStockException(string message): base(message)
        {
        }

        //System Exception is predefined Exception class in C# that is ready to use in programming.
        //Just choose which exception may occur in your code and use it in a catch block.
        /*https://www.completecsharptutorial.com/basic/complete-system-exception.php */
    }
}
