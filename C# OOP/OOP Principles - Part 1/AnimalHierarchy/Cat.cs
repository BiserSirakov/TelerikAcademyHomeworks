namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(int age, string name, char sex) 
            : base(age, name, sex)
        {

        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
