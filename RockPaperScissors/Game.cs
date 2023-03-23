using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    enum GameValue
    {
        rock = 1, scissors = 2, paper = 3
    }
    internal class Game
    {
        int score;
        int valuePlayer;
        int valueBot;
        public void Start()
        {
            Console.WriteLine("1 - Камень\n2 - Ножницы\n3 - Бумага");
            Console.WriteLine("Ваш ход - ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value < 1 || value > 3)
                Console.WriteLine();
            else if (WhoWon() == 0)
                Console.WriteLine("");
            else if (WhoWon() == 1)
                Console.WriteLine();
            else if (WhoWon() == -1)
                Console.WriteLine();
        }
        // -1 - бот проиграл
        // 0 - ничья
        // 1 - проиграл пользователь
        int WhoWon()
        {
            Random random = new Random();
            valueBot = random.Next(1,3);
          
        }
    }
}
