namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(int age, string name) 
            : base(age, name, 'F')
        {

        }

        public override string MakeSound()
        {
            return "Meeeeoowww";
        }
    }
}
