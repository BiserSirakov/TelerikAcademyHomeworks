//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.

namespace _08.Events
{
    using System;

    class MainClass
    {
        public delegate void EventHandler(object sender, EventArgs e);

        static void Main()
        {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub1", pub);
            Subscriber sub2 = new Subscriber("sub2", pub);

            pub.DoSomething();
        }
    }
}
