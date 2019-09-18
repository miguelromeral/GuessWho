using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Console
{
    public class Game : IGame
    {
        public List<User> Players { get; set; }


        public Game(string player1, string player2)
        {
            Players = new List<User>();
            Players.Add(new User(player1));
            Players.Add(new User(player2));
        }
    }
}
