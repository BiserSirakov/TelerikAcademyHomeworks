namespace _08.Events
{
    using System;

    public class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            Console.WriteLine("Because I`m happy !");

            OnRaiseCustomEvent(new CustomEventArgs("Did something"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            //if (handler != null)
            //{
            //    e.Message += String.Format(" at {0}", DateTime.Now.ToString());

            //    handler(this, e);
            //}
        }
    }
}
