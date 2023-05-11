using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deteminantOFMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[3, 3] { { 3,2,-3  },
                                                {7,-1,0 },
                                                {2,-4,5 } };
//{3[ (-1 * 5) - (0  * -4) ] + 2[ (7 * 5) - (0 * 2) ] + -3[ (7 * -4) - (-1 * 2) ] }
//3(-5) - (2(35) )  + (-3-26) )
//-15-70+78
//-7
            double det = Determinant(matrix);
            Console.WriteLine(det);
            Console.ReadKey();

        }
        public static double Determinant(double[,] matrix)
            {
                int n = (int)Math.Sqrt(matrix.Length);
                if (n == 1) return matrix[0, 0];
                if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

                double det = 0.0;
                for (int i = 0; i < n; i++)
                {
                    double[,] subMatrix = new double[n - 1, n - 1];
                    for (int j = 1; j < n; j++)
                        for (int k = 0; k < n; k++)
                            if (k < i) subMatrix[j - 1, k] = matrix[j, k];
                            else if (k > i) subMatrix[j - 1, k - 1] = matrix[j, k];
                    det += Math.Pow(-1, i) * matrix[0, i] * Determinant(subMatrix);
                }
                return det;
            }
    }
}
