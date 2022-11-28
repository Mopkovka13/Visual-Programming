using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9._2
{
    class Matrix
    {
        int[,] mass;
        public int maxDimension = 1;
        public int m;
        public int n;
        Random R = new Random();
        public Matrix(int _m, int _n, int[,] array)
        {
            mass = new int[_m, _n];
            if (_m < _n) maxDimension = _m;
            if (_n <= _m) maxDimension = _n;
            n = _n;
            m = _m;

            mass = array;
        }

        public int[] searchMax(int dimensionI, int dimensionJ)
        {
            int maxSum = 0;
            int coordinateI = 0;
            int coordinateY = 0;
            bool check = true;
            int sum = 0;
            for (int i = 0; i < m - dimensionI + 1; i++)
            {
                for (int j = 0; j < n - dimensionJ + 1; j++)
                {
                    for (int k = i; k < i + dimensionI; k++)
                    {
                        for (int g = j; g < j + dimensionJ; g++)
                        {
                            sum += mass[k, g];
                        }
                    }
                    if (check)
                    {
                        maxSum = sum;
                        coordinateI = i;
                        coordinateY = j;
                        check = false;
                    }
                    else
                    {
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            coordinateI = i;
                            coordinateY = j;
                        }
                    }
                    sum = 0;
                }
            }
            int[] customArr = { maxSum, dimensionI, dimensionJ, coordinateI, coordinateY };
            return customArr;
        }
    }
}
