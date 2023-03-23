using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Game
    {
        int score;
        int valuePlayer;
        int valueBot;
        void Start()
        {

        }
        public bool WhoWon()
        {
            Random random = new Random();
            valueBot = random.Next(1,3);
            Console.WriteLine(valueBot);
            return valuePlayer == valueBot;
        }
    }
}
