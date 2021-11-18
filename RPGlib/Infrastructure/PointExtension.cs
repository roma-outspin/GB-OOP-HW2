using System;
using System.Drawing;

namespace RPGlib
{
    public static class PointExtension
    {
        public static int Distance(this Point point1, Point point2)
        {
            return (int)Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}
