using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("请输入矩阵的大小(M×N)");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入{0}个数组元素", M * N);

            int[,] MyMatrix;
            MyMatrix = new int[M,N];

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    MyMatrix[i, j] = int.Parse(Console.ReadLine());
            if (IsToeplitzMatrix(MyMatrix) == true) { Console.WriteLine("该数组是托普利茨矩阵"); }
            else {Console.WriteLine("该数组不是托普利茨矩阵");}
            Console.ReadKey();
        }

        
        static bool IsToeplitzMatrix(int[,] Matrix)
        {
            int m = Matrix.GetLength(0);
            int n = Matrix.GetLength(1);
            for(int i = 1; i < m; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    if (Matrix[i,j] != Matrix[i-1 , j-1])
                        return false;
                }
            }
            return true;
        }

    }
}