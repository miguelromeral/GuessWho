using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Game
    {
        public List<User> Players { get; set; }


        public Game(string player1, string player2)
        {
            Players = new List<User>();
            Players.Add(new User(player1));
            Players.Add(new User(player2));
        }

        public bool MakeQuestion(User player, Question q)
        {
            if (!player.Questions.Contains(q))
                return false;

            User rival = GetRivalByPlayer(player);
            
            bool answer = rival.Answer(q);
            bool result = player.MakeMove(q, answer);
            player.Questions.Remove(q);
            return result;
        }


        private User GetRivalByPlayer(User player)
        {
            foreach (var p in Players)
                if (p != player)
                    return p;
            return null;
        }
    }
}
