using System;

namespace Lab3._3
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double sideA, double sideB, double angle) : base(sideA, sideB, angle) { }

        public override double Perimeter()
        {
            return Math.Round(_sideA * 3, 5);
        }

        public override double Square()
        {
            return Math.Round(_sideA * _sideA * Math.Sqrt(3) / 4, 5);
        }
    }
}