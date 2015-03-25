namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string first, string last, double grade) 
            : base(first, last)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, grade : {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
