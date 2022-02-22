using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01SnakeAndLadder
{
    public class DiceRoll
    {
        /// <summary>
        /// Dice rolls and roll value is returned.
        /// </summary>
        /// <returns></returns>
        public static int DiceRollValue()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }
    }
}
