using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите количесство строк в матрице: ");
            int str = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Введите множитель: ");
            int num = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[str, col];
            int[,] matrix2 = new int[str, col];
            int[,] matrix3 = new int[str, col];
            Console.WriteLine("\nМатрица 1: \r");
            Console.WriteLine();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = rnd.Next(20);
                    Console.Write($"| {matrix1[i, j],2} | \t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМатрица 2: \r");
            Console.WriteLine();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {                    
                    matrix2[i, j] = rnd.Next(20);
                    Console.Write($"| {matrix2[i, j],2} | \t");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nМатрица 1 умноженная на множитель {num}:");
            Console.WriteLine();
            int num2, sumNum;

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    num2 = matrix1[i, j];
                    sumNum = num * num2;
                    matrix1[i, j] = sumNum;
                    Console.Write($"|{matrix1[i, j],4} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМатрица 3 состоящяя из умножения изменненной матрицы 1 на матрицу 2: ");
            Console.WriteLine();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = matrix1[i, j] * matrix2[i, j];
                    Console.Write($"|{matrix3[i, j],5} | ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
