using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a horizontal dimension of an array: ");
            int horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a vertical dimension of an array: ");
            int vertical = Convert.ToInt32(Console.ReadLine());

            float[,] matrix = new float[horizontal, vertical];
            float[] sums_line = new float[vertical];
            float[] sums_column = new float[horizontal];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Give me a float number : ");
                    matrix[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sums_line[i] = sums_line[i] + matrix[i, j];
                }
                Console.WriteLine("The sum up of line " + (i+1) + " = " + sums_line[i].ToString());
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sums_column[j] = sums_column[j] + matrix[i, j];
                }
                Console.WriteLine("The sum up of column " + (j+1) + " = " + sums_column[j].ToString());
            }
        }
    }
}
