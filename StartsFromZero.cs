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
        /// </summary>
        /// <returns></returns>
        public static int RestartAtZero(int roll, int Position)
        {
            int counter = 0;
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
            
            return Position;
        }
    }
}
