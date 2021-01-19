using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba2
{
    class MatrixMaxPath
    {
        int[,] matrix;
        public bool[,] matrixPath;
        public List<Sklad> pathInfo = new List<Sklad>();

        public MatrixMaxPath(int[,] matrix)
        {
            this.matrix = matrix;
            matrixPath = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrixPath.GetLength(0); i++)
            {
                for (int j = 0; j < matrixPath.GetLength(1); j++)
                {
                    matrixPath[i, j] = true;
                }
            }
        }


        public void Path(int i,int j, int sumVes, int count, bool[,] matrixPath1)
        {
            if (i==matrix.GetLength(0)-1 && j == 0)
            {
                pathInfo.Add(new Sklad(matrixPath1, count,sumVes));
                return;
            }
            else
            {
                sumVes += matrix[i, j];
                count++;
                matrixPath[i, j] = false;
                matrixPath1[i, j] = true;
                if (i < matrix.GetLength(0) - 1)
                {
                    if (matrixPath[i + 1, j] == true && i < matrix.GetLength(0) - 1)
                    {
                        Path(i + 1, j,  sumVes,  count, matrixPath1);
                    }
                }
                if (j > 0)
                {
                  if (matrixPath[i, j - 1] == true)
                  {
                      Path(i, j - 1,  sumVes,  count, matrixPath1);
                  }
                }
            }
            matrixPath1[i, j] = false;
            count--;
            sumVes -= matrix[i, j];
        }
    }
}
