using System;
using System.Runtime.InteropServices;

namespace Lab3._3
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double sideA, double sideB, double angle) : base(sideA, sideB, angle) { }

        public override double Perimeter()
        {
            double hypotenuse = Math.Sqrt(_sideA * _sideA + _sideB * _sideB);
            return Math.Round(_sideA + _sideB + hypotenuse, 5);
        }

        public override double Square()
        {
            return Math.Round(_sideA * _sideB / 2, 5);
        }
    }
}
