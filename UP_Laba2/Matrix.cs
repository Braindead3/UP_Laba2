using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba2
{
    class Matrix
    {
        int m;
        int n;
        public int[,] matrix;
        int k;
        Random random;

        public Matrix(int m, int n, int k, Random random)
        {
            this.random = random;
            this.m = m;
            this.n = n;
            K = k;
            matrix = new int[m, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10,11);
                }
            }
        }

        int K
        {
            get { return k; }
            set
            {
                if (k>1 && k<n)
                {
                    k = value;
                }
                else
                {
                    k = 0;
                }

            }
        }

        public void OutputOpredStolba()
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(matrix[i,k]);
            }
            Console.WriteLine("...........................");
        }

        private int ProizvodStolba(int[,] mat,int numStolb)
        {
            int proizv = 1;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                proizv *= mat[i,numStolb];
            }
            return proizv;
        }

        public string NaxojdenieMinProizvodStolba()
        {
            int minProizvod = ProizvodStolba(matrix,0), numStolba=1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (minProizvod> ProizvodStolba(matrix,i))
                {
                    minProizvod = ProizvodStolba(matrix, i);
                    numStolba = i + 1;
                }
            }
            return $"В столбике {numStolba} самое маленькое произведение {minProizvod}";
        }

        public void Output()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
