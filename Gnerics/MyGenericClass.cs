using System;
using System.Collections.Generic;
using System.Text;

namespace Gnerics
{
    /*A generic class can be defined using angle brackets <>. For example, the following is a simple generic class
     * with a generic member variable, generic method and property.*/
    public class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericProperty { get; set; }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type:{0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Parameter Type:{0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable; 
        }

    }
}
