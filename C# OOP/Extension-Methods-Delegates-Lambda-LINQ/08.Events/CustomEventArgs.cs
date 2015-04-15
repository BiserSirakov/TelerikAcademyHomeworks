namespace _08.Events
{
    using System;

    public class CustomEventArgs : EventArgs
    {
        private string msg;
    
        public CustomEventArgs(string s)
        {
            this.Message = s;
        }
        
        public string Message
        {
            get 
            { 
                return this.msg; 
            }
            private set
            {
                this.msg = value;
            }
        } 
    }
}
