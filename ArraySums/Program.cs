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
            //matrix[vertical] = new int[horizontal];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Give me a float number : ");
                    matrix[i,j] = float.Parse(Console.ReadLine());
                }
                

            }
        }
    }
}
