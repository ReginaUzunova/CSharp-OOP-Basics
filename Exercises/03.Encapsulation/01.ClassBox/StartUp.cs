﻿using System;

namespace ClassBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            
            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}" +
                $"\nLateral Surface Area - {box.CalculateLateralSurfaceArea():F2}" +
                $"\nVolume - {box.CalculateVolume():F2}");
        }
    }
}
