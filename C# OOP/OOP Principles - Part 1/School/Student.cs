namespace School
{
    using System;

    public class Student : Person
    {
        private int classNumber;

        public Student(string name, int number)
        {
            this.Name = name;
            this.ClassNumber = number;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name : {0}, Class number : {1}", this.Name, this.ClassNumber);
        }
    }
}
