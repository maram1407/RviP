using System;

namespace MatrixClock
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            int[,] M;
            M = new int[2, 2];
            mess(d, M);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Console.Write(M[i, j]);
                }
                Console.WriteLine();
            }
        }


        static int[,] mess(int d, int[,] M)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    d = d + 1;
                    M[i, j] = d;
                    Console.WriteLine("Событие " + d);
                }
            }
            return M;
        }
    }
}