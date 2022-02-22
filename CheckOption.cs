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
                Position -= roll;
                Console.WriteLine("option - snake");
            }
            else if (option == Ladder)
            {
                Position += roll;
                Console.WriteLine("option -Ladder");
            }
            else
            {
                Position += 0;
                Console.WriteLine("option -NoPlay");
            }
            return Position;
        }
    }
}
