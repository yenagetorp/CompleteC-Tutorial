using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Attendence
    {
        public event Action forbiddenAttendence;

        public void CallAttendence()
        {
            Console.WriteLine("Please enter your name: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower()=="jack"||userInput.ToLower()=="Steven"||userInput.ToLower()=="Mathew")
                forbiddenAttendence();
            else
                Console.WriteLine("Welcome{0}", userInput);

        }

    }
}
