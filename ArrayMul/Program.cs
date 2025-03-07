using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {

            float args1 = float.Parse(args[0]);
            float args2 = float.Parse(args[1]);
            float args3 = float.Parse(args[2]);
            float args4 = float.Parse(args[3]);
            float args5 = float.Parse(args[4]);
            float args6 = float.Parse(args[5]);

            float[,] A = { { args1, args2 }, { args3, args4 } };

            float[] b = { args5, args6 };

            float[] Ab = new float[2];
    
            for (int i = 0; i < 2; i++)
            {
                Ab[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    Ab[i] += A[i,j] * b[j];
                }
            }
             
             for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {Ab[i],7:F2} |");
            }
        }
    }
}
