using Models;
using System.Xml.Linq;

namespace AnimalSounds.Models
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof!");
        }
    }
}