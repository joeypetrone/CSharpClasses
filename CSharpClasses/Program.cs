using CSharpClasses.FavoriteThings;
using System;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool allDone = false;
            do
            {
                string userResponse = "";

                // Favorite Things //
                Console.WriteLine("Would you like to play around with your favorite things?");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() != "n" && userResponse.ToLower() != "no")
                {
                    var playFavThings = new FavoriteThings.FavoriteThings();

                    playFavThings.Run();
                }

                Console.WriteLine("Are you done with the C# Classes program?");
                userResponse = Console.ReadLine();
                if (userResponse.ToLower() != "y" && userResponse.ToLower() != "yes")
                {
                    allDone = false;
                }
                else
                {
                    allDone = true;
                }

            } while (allDone == false);
        
        }
    }
}
