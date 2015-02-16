//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class Gravitation
{
    static void Main()
    {
        Console.WriteLine("The gravitational field of the Moon is approximately 17% of that on the Earth.");
        Console.Write("Enter the weight on Earth : ");
        double weightEarth = double.Parse(Console.ReadLine());

        double weightMoon = weightEarth * 0.17;
        Console.WriteLine("The weight on Moon will be : " + weightMoon);

        Console.ReadLine();
    }
}
