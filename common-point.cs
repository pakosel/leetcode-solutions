using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2) => new(p1.X + p2.X, p1.Y + p2.Y);
        public static Point operator -(Point p1, Point p2) => new(p1.X - p2.X, p1.Y - p2.Y);
        public static bool operator ==(Point p1, Point p2) => p1.X == p2.X && p1.Y == p2.Y;
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);

        public override bool Equals(object p) => p is Point && ((Point)p).X == X && ((Point)p).Y == Y;

        public override int GetHashCode() => X ^ Y;
    }
}