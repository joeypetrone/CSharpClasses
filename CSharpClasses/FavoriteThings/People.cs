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

        public void PlayVideoGame(VideoGame newGame)
        {
            Console.WriteLine($"You started playing {newGame.Title} on {newGame.GamingSystem} with {_friend}");
        }

    }
}
