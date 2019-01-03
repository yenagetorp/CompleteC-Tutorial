using System;

namespace indexer

/*An Indexer is a special type of property that allows a class or structure to be accessed
 * the same way as array for its internal collection. It is same as property except that it 
 * defined with this keyword with square bracket and parameters.*/
{
    class StringDataStore
    {

        private string[] strArr = new string[10]; // internal data storage

        public StringDataStore()
        {

        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
        }
    }



    class StringDataStore1
    {

        private string[] strArr = new string[10]; // internal data storage

        public StringDataStore1()
        {
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";
            /*You can override an indexer by having different index types.
             * The following example shows how an indexer can be of int 
             * type as well as string type.*/
            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["FOUR"]);


            StringDataStore1 strStore1 = new StringDataStore1();
            /*In the above example, StringDataStore class implements
             * an indexer for its internal string array. So now, object of StringDataStore 
             * can be used like an array to add or retrive string data.*/
            strStore1[0] = "One";
            strStore1[1] = "Two";
            strStore1[2] = "Three";
            strStore1[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore1[i]);

        }
    }
}
