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
                Age = "2 Months"
            };

            puppy.Play("ball");
            puppy.Play("stick");
            puppy.Play("chew toy");
            puppy.Play("");

        }
    }
}
