namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, 'M')
        {

        }

        public override string MakeSound()
        {
            return string.Format("Meow yo");
        }
    }
}
