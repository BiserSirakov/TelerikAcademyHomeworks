namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Class> classes;

        public School(string name)
        {
            this.Name = name;
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.classes = value;
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

        public void AddClass(Class course)
        {
            this.classes.Add(course);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}