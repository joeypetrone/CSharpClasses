using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    class JunkFood
    {
        //properties
        public string Name { get; set; }
        public FoodType Type { get; private set; }
        public int SickMeter { get; set; }


        public JunkFood(FoodType type)
        {
            Type = type;
        }

        public void Eat()
        {
            if (SickMeter > 3)
            {
                Console.WriteLine($"You think to yourself \"I may of had too much junk food.\"");
            }
            else
            {
                switch (Type)
                {
                    case FoodType.Pizza:
                        Console.WriteLine($"You take a bite of {Name} pizza");
                        SickMeter++;
                        break;
                    case FoodType.IceCream:
                        Console.WriteLine($"You eat two scoops of {Name} ice-cream");
                        SickMeter++;
                        break;
                    case FoodType.Candy:
                        Console.WriteLine($"You enjoy a {Name}");
                        SickMeter++;
                        break;
                    case FoodType.Nachos:
                        Console.WriteLine($"{Name} Nachos, yummy!");
                        SickMeter++;
                        break;
                    default:
                        Console.WriteLine($"You can hear your stomach growling...");
                        break;
                }
            }
        }

        public void Regret()
        {
            Console.WriteLine($"You regret eating the junk food and drink a glass of water");
            SickMeter--;
        }

    }

    enum FoodType
    {
        NoFoodTypeSelected,
        Pizza,
        IceCream,
        Candy,
        Nachos
    }
}
