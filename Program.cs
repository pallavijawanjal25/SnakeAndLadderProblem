using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--***Snake And Ladder***--");
            SinglePlayer.UC1_SinglePlayer();

            RollingDice.UC2_DiceNumber();
            PlayerOption.UC3_PlayerMoves();
            ReapeateTill100.UC4_WinningPosition();
            CountExact_WinningPosition_Hundred.UC5_WinningPosition();
            Count_NumberOfTimes_DiceRolled.UC6_CountNumberDice();

            Console.ReadKey();
        }
    }
}
