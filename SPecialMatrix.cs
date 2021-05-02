
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{

    class Program
    {
        static void Solve(int[,] a, int n)
        {
            bool isSquareMatrix = true;
            int maxSum = Int32.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                int colSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += a[i, j];
                    colSum += a[j, i];
                }
                if (rowSum != colSum)
                {
                    isSquareMatrix = false;
                    break;
                }
                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxIndex = i+1;
                }

            }
            if (isSquareMatrix && maxIndex != -1)
            {
                Console.WriteLine(maxIndex + " " + maxSum);
            }
            else
            {
                Console.WriteLine("Not a square matrix");
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var items = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(items[j]);
                }
            }
            Solve(a, n);

            Console.ReadKey();
        }
    }


}
