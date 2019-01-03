using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class AddTwoNumbers
    {
        //Declare built in delegates
        public event Action<int, int> ev_OddNumber;

        //Raise event
        public void Add(int a, int b)
        {
            int sum= 0;
            sum = a + b;
            if (sum/2==0)
            {

            }
        }
    }
}
