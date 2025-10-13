﻿using Models;
using System.Xml.Linq;

namespace AnimalSounds.Models
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows: Meow!");
        }
    }
}