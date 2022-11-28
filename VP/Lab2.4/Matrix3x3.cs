using System;

namespace Lab2._4
{
    public class Matrix3x3
    {
        public int[,] matrix;
        int det;
        int mainDiagSum;
        int sideDiagSum;

        public Matrix3x3()
        {
            matrix = new int[3, 3];
        }

        public object this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = Convert.ToInt32(value); }
        }
        public int GetDet() //По правилу Саррюса
        {
            return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                       matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                       matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
                       matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                       matrix[0, 0] * matrix[1, 2] * matrix[2, 1] -
                       matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
        }

        public int getMainDiagSum()
        {
            int res = 0;
            for (int i = 0; i < 3; i++)
                res += matrix[i, i];
            return res;
        }

        public int GetSideDiagSum()
        {
            int res = 0;
            for (int i = 0; i < 3; i++)
                res += matrix[i, 2 - i];
            return res;
        }

        public static Matrix3x3 operator +(Matrix3x3 m1, Matrix3x3 m2)
        {
            Matrix3x3 temp_matrix = new Matrix3x3();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp_matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
                }
            }
            return temp_matrix;
        }

        public static Matrix3x3 operator *(Matrix3x3 m1, Matrix3x3 m2)
        {
            Matrix3x3 temp_matrix = new Matrix3x3();
            int item = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        item += m1.matrix[k, j] * m2.matrix[j, i];
                    }
                    temp_matrix[k, i] = item;
                    item = 0;
                }
            }
            return temp_matrix;
        }
    }
}
