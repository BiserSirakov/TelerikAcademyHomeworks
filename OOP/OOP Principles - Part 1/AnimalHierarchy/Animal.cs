namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private char sex;

        public Animal(int age, string name, char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public char Sex
        {
            get
            {
                return this.sex;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.sex = value;
            }
        }

        public virtual string MakeSound()
        {
            return "Rarr";
        }

        public static string AverageAge(Animal[] list)
        {
            return string.Format("{0:F2}", list.Average(x => x.Age));
        }

        public override string ToString()
        {
            return string.Format("type : {0}, name : {1},  age : {2}, sex : {3}, sound : {4}", 
                this.GetType().Name, this.Name, this.Age, this.Sex, this.MakeSound());
        }
    }
}
