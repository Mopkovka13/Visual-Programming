using System;

namespace Lab3._3
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double sideA, double sideB, double angle) : base(sideA, sideB, angle) { }

        public override double Perimeter()
        {
            double angleInRadians = _angle * Math.PI / 180;
            double sideC = Math.Sqrt(_sideA * _sideA + _sideB * _sideB - 2 * _sideA * _sideB * Math.Cos(angleInRadians));
            return Math.Round(_sideA + _sideB + sideC, 5);
        }

        public override double Square()
        {
            double angleInRadians = _angle * Math.PI / 180;
            return Math.Round(0.5 * _sideA * _sideA * Math.Sin(angleInRadians), 5);
        }
    }
}