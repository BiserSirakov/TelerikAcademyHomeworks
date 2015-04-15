namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(int age, string name, char sex) 
            : base(age, name, sex)
        {

        }

        public override string MakeSound()
        {
            return "Froggy frog";
        } 
    }
}
