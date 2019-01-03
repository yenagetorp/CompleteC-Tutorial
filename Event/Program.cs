using System;
/*About event:
 * An Event is created using event keyword.
An Event has no return type and it is always void.
All events are based on delegates.
All the published events must have a listening object.
All Events should be defined starting with “On” keyword.
 */
 /*
  step1: define a delegate
  step 2: define an event with the same name as the delegate
  step 3: define an eventHandlerthat respond when event raised.
  step 4: you must have method ready for delegates.
  */
namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Attendence attendence = new Attendence();
            attendence.forbiddenAttendence += Attendence_forbiddenAttendence;
            attendence.CallAttendence();
        }

        private static void Attendence_forbiddenAttendence()
        {
            Console.WriteLine("Fire...");
        }
    }
}
