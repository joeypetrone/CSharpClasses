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
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public void Play(Activity activity)
        {
            switch (activity)
            {
                case Activity.Ball:
                    Console.WriteLine($"You kick the ball towards {Name} and {(Gender == Gender.Male ? "he" : "she")} hops on the ball.");
                    break;
                case Activity.Stick:
                    Console.WriteLine($"You throw stick and {Name} jumps and catches it.");
                    break;
                case Activity.ChewToy:
                    Console.WriteLine($"{Name} tears the chew toy to shreds.");
                    break;
                default:
                    Console.WriteLine($"{Name} stares idly waiting for you to play.");
                    break;
            }
        }

        public void Train(Trick trick)
        {
            switch (trick)
            {
                case Trick.Sit:
                    if (Age > 1)
                    {
                        Console.WriteLine($"{Name} sits.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} nibbles your hand.");
                    }
                    break;
                case Trick.RollOver:
                    if (Age > 2)
                    {
                        Console.WriteLine($"{Name} rolls over.");
                    }
                    else if (Age > 1)
                    {
                        Console.WriteLine($"{Name} just sits there.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} is too young for this trick.");
                    }
                    break;
                case Trick.PlayDead:
                    if (Age > 3)
                    {
                        Console.WriteLine($"{Name} plays dead.");
                    }
                    else if (Age > 1)
                    {
                        Console.WriteLine($"{Name} begs for a treat.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} looks at you with puppy eyes.");
                    }
                    break;
                default:
                    Console.WriteLine($"{Name} chews on your shoe.");
                    break;
            }
        }
    }

    enum Trick
    {
        NoTrickSelected,
        Sit,
        RollOver,
        PlayDead
    }

    enum Activity
    {
        NoActivitySelected,
        Ball,
        Stick,
        ChewToy
    }

    enum Gender
    {
        NoGenderSelected,
        Male,
        Female
    }
}
