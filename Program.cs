using System;

namespace PP01SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This problem simulates a Snake and Ladder Game");

            int[] arr = StartsFromZero.RestartAtZero();
            Console.WriteLine("Number of Dice Roll " + arr[0] + "  Position " + arr[1]);
        }
    }
}