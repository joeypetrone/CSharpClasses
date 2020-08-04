using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    class Puppy
    {
        //properties
        public string Name { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }

        public void Play(string activity)
        {
            switch (activity)
            {
                case "ball":
                    Console.WriteLine($"You kick the ball towards {Name} and it hops on the ball.");
                    break;
                case "stick":
                    Console.WriteLine($"You throw stick and {Name} jumps and catches it.");
                    break;
                case "chew toy":
                    Console.WriteLine($"{Name} tears the chew toy to shreds.");
                    break;
                default:
                    Console.WriteLine($"{Name} stares idly waiting for you to play.");
                    break;
            }
        }
    }
}
