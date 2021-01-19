using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 4;
            int index = 0;
            List<int> list = new List<int>();
            Random random = new Random();
            int[,] arr2 = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr2[i, j] = random.Next(1, 10);

                    Console.Write(" " + arr2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Rekursiya(arr2, size, size, list);
            // минимальное число, и значение его  jго индекса
            foreach (var VARIABLE in list)
            {
                for (int i = list.Count - 1; i > 0; i--)
                {
                    if (list[i] < VARIABLE)
                    {
                        index = i;
                    }
                }
            }

            Console.WriteLine("Кратчайший путь ");

            for (int i = 0; i < size; i++)
            {
                for (int j = (list.Count - 1 - index); j == list.Count - 1 - index; j--)
                {
                    Console.WriteLine(arr2[i, j] + " " + i + "," + j);
                }
            }
            Console.ReadLine();
        }
        // Собственно сама рекурсия.
        static void Rekursiya(int[,] arr, int x, int y, List<int> list)
        {
            int temp;

            temp = 0;

            for (int i = 0; i < y; i++)
            {
                for (int j = x - 1; j >= 0; j--)
                {
                    temp += arr[i, j];

                    break;
                }
            }
            if (list.Count < y)
            {
                list.Add(temp);
            }

            if (x > 1)
            {
                x--;
                Rekursiya(arr, x, y, list);
            }
        }
    }
}
