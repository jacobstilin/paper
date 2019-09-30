using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            Console.ReadLine();
        }
    }
}


// todo
// make names list
// clean up console display?
// make sure gesture is valid
// display round on eve
