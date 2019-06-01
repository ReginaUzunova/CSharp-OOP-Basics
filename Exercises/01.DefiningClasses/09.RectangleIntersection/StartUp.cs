using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            int[] input = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            int rectanglesNumber = input[0];
            int intersectionChecks = input[1];

            for (int i = 0; i < rectanglesNumber; i++)
            {
                string[] rectangleData = Console.ReadLine().Split();

                string id = rectangleData[0];
                double width = double.Parse(rectangleData[1]);
                double height = double.Parse(rectangleData[2]);
                double x = double.Parse(rectangleData[3]);
                double y = double.Parse(rectangleData[4]);

                Rectangle rectangle = new Rectangle(id, width, height, x, y);

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] pairsOfIds = Console.ReadLine().Split();
                string firstId = pairsOfIds[0];
                string secondId = pairsOfIds[1];

                Rectangle firstRectangle = rectangles.Where(r => r.Id == firstId).FirstOrDefault();
                Rectangle secondRectangle = rectangles.Where(r => r.Id == secondId).FirstOrDefault();

                if (firstRectangle.IsIntersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

