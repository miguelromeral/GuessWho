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

            game.Play();
        }
    }
}
