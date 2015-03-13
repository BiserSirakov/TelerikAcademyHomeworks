namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        // Fields
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        private static GSM iPhone4S;

        private List<Call> callHistory;

        // Constructors
        public GSM()
            : this("iPhone 5", "Apple", 1200, "Me", new Battery(), new Display(), new List<Call>()) // those are the parameters by default
        {

        }

        public GSM(string model, string manifacturer) // Holding only the two mandatory parameters
            : this(model, manifacturer, 1200, "Me", new Battery(), new Display(), new List<Call>())
        {
            this.model = model;
            this.manifacturer = manifacturer;
        }

        public GSM(string model, string manifacturer, decimal price, string owner, Battery battery, Display display, List<Call> callHistory) // Holding all parameters
        {
            this.manifacturer = manifacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = callHistory;
        }

        public static GSM()
        {
            IPhone4S = new GSM("iPhone4s", "Apple", 800, "Ivan", new Battery(), new Display(), new List<Call>());
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

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            private set
            {
                this.manifacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get 
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get 
            {
                return iPhone4S;
            }
            private set 
            { 
                iPhone4S = value; 
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set 
            {
                this.callHistory = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return String.Format("Manifacturer: {0}\n" +
                                 "Model: {1}\n" +
                                 "Price: {2}\n" +
                                 "Owner: {3}\n" +
                                 "Battery: {4}\n" +
                                 "Display: {5}\n",
                                 this.Manifacturer, this.Model, this.Price, this.Owner, this.Battery, this.Display);
        }

        public void AddCalls(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateAndPrintTotalPrice(decimal price)
        {
            int durationOfAllCalls = 0;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                durationOfAllCalls += callHistory[i].Duration;
            }

            return durationOfAllCalls * price;
        }

        public string PrintCallHistory()
        {
            return string.Format(@"Calls history :
{0}", 
            string.Join("\n", this.callHistory));
        }
    }
}
