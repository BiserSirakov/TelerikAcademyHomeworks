namespace School
{
    using System;

    public class Discipline : Person
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int lec, int ex)
        {
            this.Name = name;
            this.NumberOfLectures = lec;
            this.NumberOfExercises = ex;
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, number of lectures : {1}, number of exercises : {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}