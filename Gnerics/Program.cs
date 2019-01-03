using System;
/*Advantages of Generics:
1:Increases the reusability of the code.
2:Generic are type safe. You get compile time errors if you try to use a different type of data than the one specified in the definition.
3:Generic has a performance advantage because it removes the possibilities of boxing and unboxing.
4:Generics performs faster by not doing boxing & unboxing.
*/
namespace Gnerics
{
    class Program
    {
        /*Generic Delegate: 
         * the delegate defines the signature of the method which it can invoke. 
         * A generic delegate can be defined the same way as delegate but with generic type.*/

        public delegate T add<T>(T param1, T param2);

        public static int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concate(string str1, string str2)
        {
            return str1+ str2;
        }


        static void Main(string[] args)
        {
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            intGenericClass.GenericProperty = 5;
            Console.WriteLine(intGenericClass.GenericProperty);

            int i = intGenericClass.GenericMethod(200);
            Console.WriteLine(i);


            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("hello");
            stringGenericClass.GenericProperty = "world";
            Console.WriteLine(stringGenericClass.GenericProperty);

            string s = stringGenericClass.GenericMethod("HiHi");
            Console.WriteLine(s);


            /*Generic Delegate*/
            add<int> sum = AddNumber;
            Console.WriteLine(sum(2, 5));
            Console.WriteLine();

            add<string> concate = Concate;
            Console.WriteLine(concate("Hello", "World"));
            /*In the above example, add delegate is generic. In the Main() method, it has defined
             * add delegate of int type variable sum. So it can point to the AddNumber() method which has
             * int type parameters. Another variable of add delegate uses string type, 
             * so it can point to the Concate method. In this way, you can use generic
             * delegates for different methods of different types of parameters.*/

        }
    }
}
