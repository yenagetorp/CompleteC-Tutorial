using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<string> collection = new Collection<string>();
            collection.Add("Yen"); // 0
            collection.Add("Håkan"); // 1
            collection.Add("Bo"); // 2
            collection.Add("Li"); // 3
            collection.Add("An"); // 4

            collection.Add("FAn"); // 4

            collection.Add("BAn"); // 4
            collection.Add("GAn"); // 4
            collection.Add("An2"); // 4


            Console.WriteLine(collection.count);
            collection.RemoveAt(5);
            string s = collection[2];
            Console.WriteLine(s);
            Console.WriteLine(collection[0]);//get; ctrl f10, debug härifrån och kolla på get;
            Console.WriteLine(collection.count);
        }
    }
}
