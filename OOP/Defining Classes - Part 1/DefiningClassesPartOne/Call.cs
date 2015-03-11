using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Call
    {
        // Fields 
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        // Properties
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                this.dateAndTime = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            private set
            {
                this.dialedPhone = value;
            }
        }

        // Constructor
        public Call(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        // Method
        public override string ToString()
        {
            return string.Format(@"Date and time : {0}
Dialed phone : {1}
Duration : {2} seconds
",
                this.DateAndTime, this.DialedPhone, this.Duration);
        }
    }
}
