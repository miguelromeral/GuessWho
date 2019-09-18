using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Miguel", "Javi");
            game.MakeQuestion(game.Players[0], Core.Question.Man);
        }
    }
}
