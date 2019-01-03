using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    //An extension  method is actually a special kind of static method 
    //defined in a static class. To define an extension method,
    //first of all, define a static class.
    public static class SortExtensions
    {
        public static void SortGenericArray<T>(this T[] arr, Func<T, T, bool> IsLessThan)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsLessThan(arr[j], arr[index]))
                        index = j;
                }
                T tmp = arr[i];
                arr[i] = arr[index];
                arr[index] = tmp;
            }
        }

        public static string[] SortArray(string[] arrString)
        {
            for (int i = 0; i < arrString.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arrString.Length; j++)
                {
                    if (string.Compare(arrString[j], arrString[index]) < 0)
                        index = j;
                }

                string tmp = arrString[i];
                arrString[i] = arrString[index];
                arrString[index] = tmp;
            }
            return arrString;
        }

        public static void SortIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int index = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]<arr[index])
                        index = j;
                }

                int myInt = arr[i];
                arr[i] = arr[index];
                arr[index] = myInt;
            }
        }

    }

}

