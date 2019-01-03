using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    internal interface ICollection<T>
    {
        T this[int index] { get; set; }
        int count { get; }
        void Add(T item);
        bool Remove(T item);
        void RemoveAt(int index);

       
    }
}
