using System;
using System.Text;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("Hello world!");
            //for (int i = 0; i < sb.Length; i++)
            //{
            //    Console.WriteLine(sb[i]);
            //}
            string s = "Hello World";
            char[] c = s.ToCharArray(2, 7);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
