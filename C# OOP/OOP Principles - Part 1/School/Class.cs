namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private string identifier;
        private List<Teacher> teachers;

        public Class(string text)
        {
            this.Identifier = text;
            this.Teachers = new List<Teacher>();
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.teachers = value;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.identifier = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Identifier);
        }
    }
}
