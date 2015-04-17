namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;
        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }
        
        
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("name: {0}, age: not specified", this.Name);
            }

            return string.Format("name: {0}, age: {1}", this.Name, this.Age);
        }
    }
}
