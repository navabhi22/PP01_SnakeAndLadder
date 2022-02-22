using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01SnakeAndLadder
{
    public class CheckOption
    {
        /// <summary>
        /// Updated for Play again at Ladder
        /// Takes input roll value and Position.
        /// Generate Options Snake, Ladder and NoPlay and Changes Postion accordingly.
        /// Return the Position
        /// </summary>
        /// <param name="roll">The roll.</param>
        /// <param name="Position">The position.</param>
        /// <returns></returns>
        public static int Option(int roll, int Position)
        {
            int Snake = 0;
            int Ladder = 2;
            Random random = new Random();
            int option = random.Next(0, 3);
            if (option == Snake)
            {
                Console.WriteLine("option - snake");
                Position -= roll;
                
            }
            else if (option == Ladder)
            {
                Console.WriteLine("option -Ladder");
                Position += roll;
                //Console.WriteLine("player" + Position);
                //int roll1 = DiceRoll.DiceRollValue();
                //Position = ExactWin.ExactWinningPossition(Position, roll1);
                //Position = Option(roll1, Position);

            }
            else
            {
                Console.WriteLine("option -NoPlay");
                Position += 0;
                
            }
            return Position;
        }
    }
}
