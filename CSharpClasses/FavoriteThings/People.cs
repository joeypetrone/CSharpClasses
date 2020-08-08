using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    class People
    {
        //properties
        public bool IsHappy { get; set; }

        //fields 
        private string _friend { get; set; }

        public void AddNewFriend(string friendName)
        {
            _friend = friendName;
            Console.WriteLine($"{_friend} is now your friend!");
        }

        public void PlayVideoGame(GamingSystem gamingSystem, string gameTitle)
        {
            var newGame = new VideoGame(gamingSystem, gameTitle);

            Console.WriteLine($"You started playing {gameTitle} on {gamingSystem} with {_friend}");
        }

    }
}
