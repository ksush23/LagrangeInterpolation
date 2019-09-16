using System;

namespace InterpolationL
{
    class Program
    {
        static int n = 5;
        static double[] x = new double[n];
        static double[] y = new double[n];
        static double[] h = new double[n];

        static void Main(string[] args)
        {
            function();
            CalculateH();

            Console.WriteLine("Function = ");
            for (int i = 0; i < n; i++)
            {
                if (y[i] != 0)
                {
                    if (i != 0)
                        Console.Write(" + ");
                    Console.Write(y[i]);

                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            Console.Write(" * (x - " + x[j] + ")");
                    }

                    Console.Write(" / " + (h[i]));
                }
            }

            Console.ReadKey();
        }

        static void function()
        {
            for (int i = 0; i < n; i++)
            {
                x[i] = i + 1;
                y[i] = Math.Log10(x[i]);
            }
        }

        static void CalculateH()
        {
            for (int i = 0; i < n; i++)
            {
                h[i] = 1;

                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        h[i] *= x[i] - x[j];
                    }
                }
            }
        }
    }
}
