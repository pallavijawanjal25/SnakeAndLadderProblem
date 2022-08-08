using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    static class RollingDice
    {
        public static int UC2_DiceNumber()
        {
            Console.WriteLine("Rolling Dice..");
            Random random = new Random();
            int numberOnDice = random.Next(1, 7);
            Console.WriteLine("You got " + numberOnDice);
            return numberOnDice;
        }
    }
}
