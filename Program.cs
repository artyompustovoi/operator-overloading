using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int col = 5, row = 6;
            int g = 0;
            int size=30;
            int[,] ar = new int[col, row];
            int[] a = new int[size];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    ar[i, j] = rand.Next(100);
                    Write("{0,-5}", ar[i, j]);
                    a[g] = ar[i, j];
                    g++;
                    
                }
                WriteLine();
            }
            for (int i = 0; i < g; i++)
            {
                Write($"{a[i]} ");
            }
            WriteLine();
            WriteLine(a.Max());
            WriteLine(a.Min());
        }
    }
}
