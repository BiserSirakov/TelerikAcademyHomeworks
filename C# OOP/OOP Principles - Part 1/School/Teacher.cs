namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name)
        {
            this.Name = name;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
