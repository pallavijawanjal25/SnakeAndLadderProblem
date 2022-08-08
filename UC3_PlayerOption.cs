using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    static class PlayerOption
    {
        public const int Ladder = 1;   
        public const int Snake = 2;    

        public static void UC3_PlayerMoves()
        {
            int position = 0;

            int number;

            int currentPosition = 0;
            Console.WriteLine("Start Game:  ");
            Console.WriteLine("Current Position:  {0}\n\n", currentPosition);

            Random random = new Random();
            int options = random.Next(0, 3);

            switch (options)
            {
                case Ladder:
                    Console.WriteLine("Option 1: Ladder");
                    number = RollingDice.UC2_DiceNumber();
                    position = position + number;
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;
                case Snake:
                    Console.WriteLine("Option 2: Snake");
                    number = RollingDice.UC2_DiceNumber();
                    if (position <= number || position == 0)
                    {
                        position = 0;
                        Console.WriteLine("Start Again");
                    }
                    else
                    {
                        position = position - number;
                        Console.WriteLine("Moves backward");
                    }
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;
                default:
                    Console.WriteLine("Option 0: No Play");
                    number = 0;
                    position = position + number;
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;

            }
        }
    }
}
