using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{

    // link to challenge: https://www.hackerrank.com/challenges/diagonal-difference/problem
    class Program
    {
        private static Random rand = new Random();

        private static int[][] generateMatrix(int size)
        {
            int[][] matrix = new int[size][];
            int[] matrixRow = new int[size];
            int counter = 0;
            while (counter < size)
            {
                matrixRow = new int[size];
                for (int i = 0; i < size; i++)
                {
                    matrixRow[i] = rand.Next(1, 100);
                }
                matrix[counter] = matrixRow;
                counter++;
            }
            return matrix;
        }

        static int diagonalDifference(int[][] arr)
        {
            int diag1 = 0;
            int diag2 = 0;
          
            for (int i = 0; i < arr.Length; i++)
            {
                diag1 += arr[i][i];
                diag2 += arr[i][arr.Length - (i + 1)];
            }

            return Math.Abs(diag1 - diag2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give the size of diagonal matrix:");
            int size = 0;
            int.TryParse(Console.ReadLine(), out size);

            var matrix = generateMatrix(size);

            Console.WriteLine(diagonalDifference(matrix));
            Console.ReadLine();
        }
    }
}
