using System;
/* Extension methods, as the name suggests, are additional methods.
 * Extension methods allow you to inject additional methods
 * without modifying, deriving or recompiling the original class, 
 * struct or interface. Extension methods
 * can be added to your own custom class, .NET framework classes, 
 * or third party classes or interfaces.*/
namespace ExtensionMethods
{/*The extension methods have a special symbol(with a heart) in intellisense of the visual studio,
    so that you can easily differentiate between class methods and extension methods.*/
    class Program
    {
        static void Main(string[] args)
        {
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




            string[] names = new string[] { "Yen", "Samuel", "Sasha", "Jakob", "Elias", "linnea" };
            string[] sortedNames = SortExtensions.SortArray(names);

            Console.WriteLine("genericSortMethod:");
            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }
            /**/
            Console.WriteLine("extensionmethod:");
            SortExtensions.SortGenericArray<string>(names, IsLessThan);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("extensionmethod using linq to sort string[]:");
            SortExtensions.SortGenericArray(names, (a, b) => string.Compare(a, b, true) < 0);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("extensionmethod using linq to sort int[]:");
            SortExtensions.SortGenericArray(heltalsVektor, (a, b) => a < b);
            foreach (var item in heltalsVektor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("genericmethod to sort int[]:");
            SortExtensions.SortIntArray(heltalsVektor);
            foreach (var item in heltalsVektor)
            {
                Console.WriteLine(item);
            }

        }

        private static bool IsLessThan(string a, string b)
        {
            return string.Compare(a, b, true) < 0;
        }
    }
}
