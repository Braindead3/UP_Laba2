using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //Console.WriteLine("Матрица:");
            //Matrix matrix = new Matrix(3, 4, 2,random);
            //matrix.Output();

            //Console.WriteLine(matrix.NaxojdenieMinProizvodStolba());

            //Massiv massiv = new Massiv(10);
            //Console.WriteLine("Массив с отриц:");
            //Console.WriteLine(massiv);

            //Console.WriteLine("Изм массив:");
            //massiv.UvelichenieKajdogoOtricNaPredposlOtric();
            //Console.WriteLine(massiv);

            //Zadanie4(random);

            int[,] array = 
            {
               {1,  2,    3,    15},
               {6,  5,    4,    23},
               {7,  8,    9,    11},
               {12, 11,   10,   34}
            };

            int asd = array.GetLength(0);

            MatrixMaxPath matrixMaxPath = new MatrixMaxPath(array);
            int count=0, sumVes=0;
            bool[,] matrixPath1 = new bool[array.GetLength(0), array.GetLength(1)];
            matrixMaxPath.Path(0,array.GetLength(1)-1,sumVes,count, matrixPath1);

            foreach (var item in matrixMaxPath.pathInfo)
            {
                Console.WriteLine(item);
                Console.WriteLine("\\\\\\\\\\\\\\\\");
            }

            Console.ReadLine();
        }

        private static void Zadanie4(Random random)
        {
            Console.WriteLine("Матрицы:");
            Matrix[] matrices = new Matrix[10];

            for (int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = new Matrix(3, 3, 1, random);
                matrices[i].Output();
            }

            int[] masSedlTochek = new int[matrices.Length];

            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                var matr = matrices[i].matrix;
                int[] col = new int[matr.GetLength(1)];
                int[] str = new int[matr.GetLength(0)];
                int indexCol = 0, indexRow = 0;

                for (int k = 0; k < matr.GetLength(0); k++)
                {
                    int min = matr[k, 0];
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (min > matr[k, j])
                        {
                            min = matr[k, j];
                            indexCol = j;
                        }
                    }
                    col[k] = indexCol;
                }

                for (int k = 0; k < matr.GetLength(0); k++)
                {
                    int max = matr[k, 0];
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (max < matr[j, k])
                        {
                            max = matr[j, k];
                            indexRow = j;
                        }
                    }
                    str[k] = indexRow;
                }

                for (int k = 0; k < matr.GetLength(0); k++)
                {
                    if (str[col[k]] == k)
                    {
                        masSedlTochek[i] = matr[str[col[k]], col[k]];
                    }
                }
            }
            Console.WriteLine("Массив седловых точек:");
            Console.WriteLine(string.Join(" ", masSedlTochek));
        }
    }
}
