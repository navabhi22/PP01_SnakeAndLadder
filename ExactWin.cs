using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP01SnakeAndLadder
{
    public class ExactWin
    {
        /// <summary>
        /// Updated for Two Player Game
        /// Get the exact winning pssition and number of dice rolls to reach the position 
        /// </summary>
        public static int ExactWinningPossition(int Position, int roll)
        {


            //int roll = DiceRoll.DiceRollValue();
            Console.WriteLine("Dice roll value is " + roll);
            if (Position == 99 && roll == 1)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);
            }
            else if (Position == 98 && roll <= 2)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);

            }
            else if (Position == 97 && roll <= 3)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);
            }
            else if (Position == 96 && roll <= 4)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);
            }
            else if (Position == 95 && roll <= 5)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);
            }
            else if (Position < 95)
            {
                Position = StartsFromZero.RestartAtZero(roll, Position);
            }
           
                return Position;
            
        }   
    }
}
