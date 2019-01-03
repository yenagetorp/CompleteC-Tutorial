using System;
using System.Collections.Generic;
using System.Text;

namespace Gnerics
{
     class MyDerivedClass : MyGenericClass<int>
    {
        public MyDerivedClass(int value) : base(value)
        {
        }
    }
}
