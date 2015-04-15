namespace School
{
    using System;

    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }
    }
}
