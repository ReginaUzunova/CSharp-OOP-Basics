using System;
using System.Linq;

namespace JediGalaxy
{
    class StartUp
    {
        static long sum;

        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = dimestions[0];
            int cols = dimestions[1];

            int[,] matrix = new int[rows, cols];

            GetMatrix(matrix, rows, cols);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] ivoS = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int[] evil = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int evilRow = evil[0];
                int evilCol = evil[1];

                EvilMoving(evilRow, evilCol, matrix);

                int ivoRow = ivoS[0];
                int ivoCol = ivoS[1];

                IvoMoving(ivoRow, ivoCol, matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static long IvoMoving(int ivoRow, int ivoCol, int[,] matrix)
        {
            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (IsOnDiagonal(ivoRow, ivoCol, matrix))
                {
                    sum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }

            return sum;
        }

        private static void EvilMoving(int evilRow, int evilCol, int[,] matrix)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (IsOnDiagonal(evilRow, evilCol, matrix))
                {
                    matrix[evilRow, evilCol] = 0;
                }

                evilRow--;
                evilCol--;
            }
        }

        private static bool IsOnDiagonal(int row, int col, int[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void GetMatrix(int[,] matrix, int rows, int cols)
        {
            int value = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }
    }
}
