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
        public void Start()
        {
            Console.WriteLine("1 - Камень\n2 - Ножницы\n3 - Бумага");
            Console.Write("Ваш ход - ");
            valuePlayer = Convert.ToInt32(Console.ReadLine());
            PrintWhoWon();
            PrintScore();
        }
        void PrintWhoWon()
        {
            Console.Clear();
            if (valuePlayer < 1 || valuePlayer > 3)
                Console.WriteLine("Вы проиграли, потому что не можете ввести число от 1 до 3");
            else
            {
                int result = WhoWon();
                if (result == 0)
                    Console.WriteLine("Ничья");
                else if (result == 1)
                    Console.WriteLine("Вы проиграли");
                else if (result == -1)
                    Console.WriteLine("Вы победили"); 
            }
        }
        public void PrintScore()
        {
            Console.WriteLine($"Ход бота - {valueBot}\nВаш ход - {valuePlayer}");
            Console.WriteLine("Счет :" + score);
        }
        // -1 - бот проиграл
        // 0 - ничья
        // 1 - проиграл пользователь
        int WhoWon()
        {
            Random random = new Random();
            valueBot = random.Next(1,4);
            if (valueBot == valuePlayer)
                return 0;
            if (valuePlayer == 1)
                if (valueBot == 3)
                    return 1;
            if (valuePlayer == 2)
                if (valueBot == 1)
                    return 1;
            if (valuePlayer == 3)
                if(valueBot == 2)
                    return 1;
            score++;
            return -1;
        }
    }
}
