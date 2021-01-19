using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba2
{
    class Sklad
    {
        public bool[,] matrixPath;
        public int count;
        public int sumVes;

        public Sklad(bool[,] matrixPath, int count, int sumVes)
        {
            this.matrixPath = matrixPath;
            this.count = count;
            this.sumVes = sumVes;
        }

        public override string ToString()
        {
            for (int i = 0; i < matrixPath.GetLength(0); i++)
            {
                for (int j = 0; j < matrixPath.GetLength(1); j++)
                {
                    Console.Write(matrixPath[i, j] + " ");
                }
                Console.WriteLine();
            }
            return $"Кол-во шагов {count}, сумма весов {sumVes}";
        }
    }
}
