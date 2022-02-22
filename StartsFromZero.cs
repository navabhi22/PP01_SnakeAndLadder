using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01SnakeAndLadder
{
    public class StartsFromZero
    {
        /// <summary>
        /// Restart at zero if position is less than zero
        /// returns num of dice roll and poition.
        /// </summary>
        /// <returns></returns>
        public static int[] RestartAtZero()
        {
            int Position = 0;
            int counter = 0;
            while (Position <= 100)

            {
                int roll = DiceRoll.DiceRollValue();
                if (Position <= 0)
                {
                    Position = 0;
                    Position = CheckOption.Option(roll, Position);
                }
                else
                {
                    Position = CheckOption.Option(roll, Position);
                }
                counter++;
            }
            int[] arr = new int[2];
            arr[0] = counter;
            arr[1] = Position;
            return arr;
        }
    }
}
