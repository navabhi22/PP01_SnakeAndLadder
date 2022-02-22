using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01SnakeAndLadder
{
    public class TwoPlayerGame
    {
        /// <summary>
        /// Snake and Ladder for Two players.
        /// </summary>
        public static void TwoPlayersGame()
        {
            int Player1Position = 0;
            int Player2Position = 0;

            while (Player1Position < 100 && Player2Position < 100) 
            {
                int roll = DiceRoll.DiceRollValue();
                Player1Position=ExactWin.ExactWinningPossition(Player1Position,roll);
                Console.WriteLine("Player 1 position " + Player1Position);
                

                Player2Position=ExactWin.ExactWinningPossition(Player2Position,roll);
                Console.WriteLine("Player 2 position " + Player2Position);
            }
            if (Player1Position == 100 )
            {
                Console.WriteLine("Player1 has won");
            }
            else if (Player2Position == 100)
            {
                Console.WriteLine("Player2 has won");
            }
        }
    }
}
