﻿using System;

namespace PP01SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This problem simulates a Snake and Ladder Game");
            int StartPositon = StartPosition.StartPositionInitialisation();
            Console.WriteLine("Start Position " + StartPositon);
        }
    }
}