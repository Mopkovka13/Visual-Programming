using System;

namespace Lab3._1
{
    abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // переопределение получения периметра
        public override double GetPerimeter() => Width * 2 + Height * 2;
        // переопрелеление получения площади
        public override double GetArea() => Width * Height;
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }


        // переопределение получения периметра
        public override double GetPerimeter() => Radius * 2 * 3.14;
        // переопрелеление получения площади
        public override double GetArea() => Radius * Radius * 3.14;
    }

    class Trapezium : Shape
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double Height { get; set; }
        public Trapezium(double baseA, double baseB, double height)
        {
            BaseA = baseA;
            BaseB = baseB;
            Height = height;
        }


        // переопределение получения периметра
        public override double GetPerimeter()
        {
            return Math.Sqrt(Math.Pow((Math.Abs(BaseB - BaseA) / 2), 2) + Math.Pow(Height, 2));
        }
        // переопрелеление получения площади
        public override double GetArea() => (BaseA+BaseB) / 2 * Height;
    }
}
