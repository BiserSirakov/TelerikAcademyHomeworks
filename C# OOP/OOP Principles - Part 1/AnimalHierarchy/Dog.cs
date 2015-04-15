namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(int age, string name, char sex) 
            : base(age, name, sex)
        {

        }

        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
