namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string first, string last, int weekSalary, int workHoursPerDay) : base(first, last)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, week salary : {2}, workhours per day : {3}",
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}