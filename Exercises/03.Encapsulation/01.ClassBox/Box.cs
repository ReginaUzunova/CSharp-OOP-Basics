﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double CalculateSurfaceArea()
        {
            double surfaceArea = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

            return surfaceArea;
        }

        public double CalculateLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;

            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {
            double volume = width * length * height;

            return volume;
        }

        
       
    }
}
