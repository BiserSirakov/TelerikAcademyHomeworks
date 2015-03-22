namespace _03.FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
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
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, age : {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
