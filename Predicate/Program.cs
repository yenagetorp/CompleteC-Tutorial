using System;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("Hello World");
            Console.WriteLine(result);

            //using predicate delegate with anonymous method.

            //Predicate<string> isUpper = (s) => s.Equals(s.ToUpper());

            //which i sthe same as below:
            //Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };

            //bool result = isUpper("hello");
            //Console.WriteLine(result);

        }

        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
