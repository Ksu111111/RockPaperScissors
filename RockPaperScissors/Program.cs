using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вы проиграли, потому что не можете ввести число от 1 до 3
            Game game = new Game();
            game.Start();
        }
    }
}
