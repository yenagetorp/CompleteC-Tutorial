using System;

namespace Static
{
    class Program
    {
        /*a static member can only contain or access other static members, 
         * because static members are invoked without creating an instance 
         * and so they cannot access non-static members.
         *Static classes cannot be instantiated using the new keyword*/

        /*A static or non-static class can have a static
         * constructor without any access modifiers like public, private, protected, etc.*/

        /*
         A static constructor in a static class runs only once when any of its static members
         accessed for the first time.*/
        static void Main(string[] args)
        {

            MyStaticClass.myStaticVariable = 100;

            MyStaticClass.MyStaticProperty = 200;

            MyStaticClass.myStaticVariable = 300;

            MyStaticClass.MyStaticProperty = 400;
            /*In the above example, the static members was accessed multiple times. 
             * However, static constructor got called only once when any of its static 
             * members was accessed for the first time.*/
            // output: Inside static constructor.


            /*A static constructor in a non-static class runs only once when the class is instantiated for the first time.*/
            MyNonStaticClass mnsObj1 = new MyNonStaticClass();
            MyNonStaticClass mnsObj2 = new MyNonStaticClass();
            MyNonStaticClass mnsObj3 = new MyNonStaticClass();
            /*In the above example, we instantiate MyNonStaticClass three times but the static constructor 
             * got called only once when it instantiated for the first time.*/
            // output: Inside static constructor.
        }
    }


    public static class MyStaticClass
    {
        static MyStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }
        public static int myStaticVariable = 0;

        public static void myStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public static int MyStaticProperty { get; set; }

    }

    public class MyNonStaticClass
    {
        static MyNonStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }
}
