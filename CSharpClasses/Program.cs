using CSharpClasses.FavoriteThings;
using System;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Puppy()
            {
                Name = "DeeDee",
                Type = "Shih Tzu",
                Age = 4,
                Gender = Gender.Female
            };

            puppy.Play(Activity.Ball);
            puppy.Play(Activity.Stick);
            puppy.Play(Activity.ChewToy);
            puppy.Play(Activity.NoActivitySelected);

            puppy.Train(Trick.Sit);
            puppy.Train(Trick.RollOver);
            puppy.Train(Trick.PlayDead);
            puppy.Train(Trick.NoTrickSelected);

        }
    }
}
