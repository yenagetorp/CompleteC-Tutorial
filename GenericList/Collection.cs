using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    class Collection<T> : ICollection<T>
    {
        private T[] arr;
        private const int MiniumLength = 4;
        int capacitySize;
        int lastIndex = -1;
        public int count => lastIndex+1;

        public Collection()
        {
            capacitySize = MiniumLength;
            arr = new T[MiniumLength];
        }

        public Collection(int arrLength)
        {
            capacitySize = arrLength > MiniumLength ? arrLength:MiniumLength;
            arr = new T[capacitySize];
        }


        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }


        public void Add(T item)
        {
            if (lastIndex + 1 == capacitySize)
                capacitySize *= 2;
                Array.Resize(ref arr, capacitySize);

            arr[++lastIndex] = item;

            //if (arr.Length < 4)
            //{
                //arr = arr.Concat(new T[] { item }).ToArray();
            //}
        }


        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            if (index>lastIndex)
            {
                throw new IndexOutOfRangeException();
            }
            else 
            {
                Array.ConstrainedCopy(arr, index + 1, arr, index, (lastIndex - 1));
                lastIndex--;
                ReduceArrayLength();
            }
        }

        private void ReduceArrayLength()
        {
            if (capacitySize/2>=MiniumLength&&(lastIndex+1)<=capacitySize/2)
            {
                capacitySize /= 2;
                Array.Resize(ref arr, capacitySize);
            }
        }
    }
}
