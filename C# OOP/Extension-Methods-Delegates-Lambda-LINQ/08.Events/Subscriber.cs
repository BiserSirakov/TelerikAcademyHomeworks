namespace _08.Events
{
    using System;

    public class Subscriber
    {
        private readonly string id;

        public Subscriber(string ID, Publisher pub)
        {
            this.id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }
}
