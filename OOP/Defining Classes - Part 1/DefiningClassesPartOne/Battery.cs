namespace DefiningClassesPartOne
{
    using System;
    using System.Linq;

    public class Battery
    {
        // Fields
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        private BatteryTypes batteryType;

        // Constructors
        public Battery()
        {
        }
        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryTypes batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        // Properties
        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }

            private set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            private set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryTypes BatteryType
        {
            get
            {
                return this.batteryType;
            }

            private set
            {
                this.batteryType = value;
            }
        }

        // Methods

        public override string ToString()
        {
            return string.Format("Model : {0}, Hours idle : {1}, Hours talk : {2}, Type : {3}", 
                this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }
}
