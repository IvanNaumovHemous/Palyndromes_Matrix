using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var r = int.Parse(input[0]);
            var c = int.Parse(input[1]);

            var matrix = GetMatrixOfPalyndromes(r, c);
            printMatrix(matrix);
        }

        private static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static string[,] GetMatrixOfPalyndromes(int r, int c)
        {
            var matrix = new string[r, c];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToList(); 

            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                {
                    var FirstAndLast = alphabet[0].ToString();
                    var middle = alphabet[j].ToString();

                    matrix[i, j] = FirstAndLast + middle + FirstAndLast;
                }

                alphabet.RemoveAt(0);
            }

            return matrix;
        }
    }
}
