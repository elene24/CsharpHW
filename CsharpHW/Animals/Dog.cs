using System;

namespace CsharpHW.Animals
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");     
        }
    }
}