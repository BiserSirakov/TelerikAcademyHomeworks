namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student // Problem 9
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int fn, string tel, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.lastName = value;
            }
        }

        public int Fn
        {
            get
            {
                return this.fn;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name : {0} {1}\nFN   : {2}\nTel  : {3}\nEmail: {4}\nMarks: {5}\nGroup: {6}",
                this.FirstName, this.LastName, this.Fn, this.Tel, this.Email, string.Join(", ", this.Marks), this.GroupNumber);
        }
    }
}
