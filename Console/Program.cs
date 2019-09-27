using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var u1 = game.AddPlayer("Miguel", Core.AICategory.Random);
            var u2 = game.AddPlayer("Javi", Core.AICategory.Random);
            
            game.Start();
            while(game.Winner == null)
            {
                game.Play_Step();
                System.Console.ReadKey();
            }
            System.Console.WriteLine("The game has been finished: {0} is the winner.", game.Winner);
        }
    }
}
