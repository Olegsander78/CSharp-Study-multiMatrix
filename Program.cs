using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiMatrix
{
    class Program
    {
        /// <summary>
        /// Создание рандомной матрицы 
        /// </summary>
        /// <param name="Str">Кол-во строк</param>
        /// <param name="Col">Кол-во колонок</param>
        /// <returns></returns>
        static int[,] GetRandomMatrix(int Str, int Col)
        {
            Random r = new Random();
            int[,] tempArr = new int[Str, Col];
            for (int i = 0; i < Str; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    tempArr[i, j] = r.Next(100);
                }
            }
            return tempArr;
        }
        /// <summary>
        /// Произведение множителя на матрицу
        /// </summary>
        /// <param name="Prod">Множитель матрицы</param>
        /// <param name="Arr">Матрица</param>
        static void GetProductMatrix(int Prod, int[,] Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] *= Prod;
                }
            }
        }
        /// <summary>
        /// Метод перемножения разноразмерных матриц , с созданием матрицы размерностью
        /// по максимальным значениям строк и колонок входных матриц.
        /// </summary>
        /// <param name="Arr1">Матрица первая</param>
        /// <param name="Arr2">Матрица вторая</param>
        /// <returns></returns>
        static int[,] GetProductMatrixOnMatrix(int[,] Arr1, int[,] Arr2)
        {
            int x, y;
            if (Arr1.GetLength(0) >= Arr2.GetLength(0))
            {
                if (Arr1.GetLength(1) >= Arr2.GetLength(1))
                {
                    x = Arr1.GetLength(0);
                    y = Arr1.GetLength(1);
                }
                else
                {
                    x = Arr1.GetLength(0);
                    y = Arr2.GetLength(1);
                }
            }
            else
            {
                if (Arr1.GetLength(1) >= Arr2.GetLength(1))
                {
                    x = Arr2.GetLength(0);
                    y = Arr1.GetLength(1);

                }
                else
                {
                    x = Arr2.GetLength(0);
                    y = Arr2.GetLength(1);
                }

            }
            int[,] arrTemp = new int[x, y];

            if (Arr1.GetLength(0) >= Arr2.GetLength(0))

            {
                for (int i = 0; i < Arr1.GetLength(0); i++)
                {
                    if (i >= Arr2.GetLength(0)) continue;
                    if (Arr1.GetLength(1) >= Arr2.GetLength(1))

                    {
                        for (int j = 0; j < Arr1.GetLength(1); j++)
                        {
                            if (j >= Arr2.GetLength(1)) break;
                            arrTemp[i, j] = Arr1[i, j] * Arr2[i, j];
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Arr2.GetLength(1); j++)
                        {
                            if (j >= Arr1.GetLength(1)) continue;
                            arrTemp[i, j] = Arr1[i, j] * Arr2[i, j];
                        }
                    }
                }
            }
            else
            {

                for (int i = 0; i < Arr2.GetLength(0); i++)
                {
                    if (i >= Arr1.GetLength(0)) continue;
                    if (Arr1.GetLength(1) >= Arr2.GetLength(1))
                    {
                        for (int j = 0; j < Arr1.GetLength(1); j++)
                        {
                            if (j >= Arr2.GetLength(1)) continue;
                            arrTemp[i, j] = Arr1[i, j] * Arr2[i, j];
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Arr2.GetLength(1); j++)
                        {
                            if (j >= Arr1.GetLength(1)) continue;
                            arrTemp[i, j] = Arr1[i, j] * Arr2[i, j];
                        }
                    }
                }
            }

            return arrTemp;
        }
        static void PrintMatrix(int[,] Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write($"{Arr[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
        static void Space()
        {
            Console.WriteLine();
        }
        static void Delay()
        {
            Console.ReadKey();
        }




        static void Main(string[] args)
        {
            int[,] matrix1, matrix2, matrix3;

            Console.Write("Введите количество строк в 1 матрице: ");
            int str = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в 1 матрице: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк в 2 матрице: ");
            int str2 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в 2 матрице: ");
            int col2 = int.Parse(Console.ReadLine());
            Console.Write("Введите множитель: ");
            int num = int.Parse(Console.ReadLine());
            matrix1 = GetRandomMatrix(str, col);
            matrix2 = GetRandomMatrix(str2, col2);
            Console.WriteLine("\nМатрица 1 : ");
            Space();
            PrintMatrix(matrix1);
            Console.WriteLine("\nМатрица 2 : ");
            Space();
            PrintMatrix(matrix2);

            matrix3 = GetProductMatrixOnMatrix(matrix1, matrix2);
            Console.WriteLine("\nМатрица 3 состоящяя из умножения матрицы 1 на матрицу 2: ");
            Space();
            PrintMatrix(matrix3);
            Space();
            Console.WriteLine($"\nМатрица 1 умноженная на множитель {num}: ");
            Space();
            GetProductMatrix(num, matrix1);
            PrintMatrix(matrix1);
            Delay();
        }
    }
}
