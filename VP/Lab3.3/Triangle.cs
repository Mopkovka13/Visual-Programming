namespace Lab3._3
{
    abstract class Triangle
    {
        internal double _sideA;
        internal double _sideB;
        internal double _angle;
        public Triangle(double sideA, double sideB, double angle)
        {
            _sideA = sideA;
            _sideB = sideB;
            _angle = angle;
        }

        public abstract double Square();
        public abstract double Perimeter();

    }
}
