using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    class FavoriteThings
    {
        public void Run()
        {
            bool doneWithFavoriteThings = false;
            do
            {
                //Puppy class
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

                //JunkFood class
                var pizza = new JunkFood(FoodType.Pizza)
                {
                    Name = "Deep Dish"
                };

                pizza.Eat();
                pizza.Eat();
                pizza.Eat();
                pizza.Eat();
                pizza.Eat();
                pizza.Regret();
                pizza.Eat();
                pizza.Eat();
                pizza.Eat();


                var iceCream = new JunkFood(FoodType.IceCream)
                {
                    Name = "Tonight Dough"
                };

                iceCream.Eat();

                var candy = new JunkFood(FoodType.Candy)
                {
                    Name = "Reese's Peanut Butter Cup"
                };

                candy.Eat();

                var nachos = new JunkFood(FoodType.Nachos)
                {
                    Name = "Doritos"
                };

                nachos.Eat();

                //VideoGame class
                var pcGame = new VideoGame(GamingSystem.PC, "Solitare");

                pcGame.LoadGame();

                pcGame.Play();

                var nintendoGame = new VideoGame(GamingSystem.Nintendo, "Zelda");

                nintendoGame.LoadGame();

                nintendoGame.Play();

                //People class
                var friends = new People();

                friends.AddNewFriend("Mao");

                friends.PlayVideoGame(GamingSystem.PlayStation, "Resident Evil 7");

                Console.WriteLine("Would you like to run the Favorite Things console app again?");
                var runAgain = Console.ReadLine();
                if (runAgain.ToLower() != "n" || runAgain.ToLower() != "no")
                {
                    doneWithFavoriteThings = false;
                }
                else
                {
                    doneWithFavoriteThings = true;
                }
            } while (doneWithFavoriteThings == true);
        }
    }
}
