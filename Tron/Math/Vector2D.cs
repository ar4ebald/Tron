using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Tron.Math
{
    struct Vector2D
    {
        public static readonly Vector2D Zero = new Vector2D(0, 0);
        public static readonly Vector2D One = new Vector2D(1, 1);
        public static readonly Vector2D UnitX = new Vector2D(1, 0);
        public static readonly Vector2D UnitY = new Vector2D(0, 1);

        public double X;
        public double Y;

        public Vector2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Length => Sqrt(X * X + Y * Y);
        public double LengthSquare => X * X + Y * Y;

        public Vector2D Rotate(double angle)
        {
            var cos = Cos(angle);
            var sin = Sin(angle);

            return new Vector2D(cos * X - sin * Y, sin * X + cos * Y);
        }

        public static Vector2D operator -(Vector2D a)
        {
            return new Vector2D(-a.X, -a.Y);
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2D operator *(Vector2D a, double b)
        {
            return new Vector2D(a.X * b, a.Y * b);
        }
        public static Vector2D operator /(Vector2D a, double b)
        {
            return new Vector2D(a.X / b, a.Y / b);
        }

        public static implicit operator Vector2D(Point point)
        {
            return new Vector2D(point.X, point.Y);
        }
        public static explicit operator Point(Vector2D vector)
        {
            return new Point((int)vector.X, (int)vector.Y);
        }

        public static double Dot(Vector2D a, Vector2D b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public static double Cross(Vector2D a, Vector2D b)
        {
            return a.X * b.Y - b.X * a.Y;
        }
    }
}
