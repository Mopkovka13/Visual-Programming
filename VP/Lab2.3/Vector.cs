namespace Lab2
{
    internal class Vector
    {
        private double _x, _y, _z;
        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector(v1._x + v2._x, v1._y + v2._y, v1._z + v2._z);
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            return new Vector(v1._x - v2._x, v1._y - v2._y, v1._z - v2._z);
        }

        public static Vector operator * (Vector v1, double number)
        {
            return new Vector(v1._x * number, v1._y * number, v1._z * number);
        }
    }
}
