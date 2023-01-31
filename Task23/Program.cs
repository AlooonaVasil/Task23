using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            FactorialAsync(n);

            Console.WriteLine("Факториал последовательность");
            for (int i = 0; i < n; i++)
            {
                sum += 1;
                if (i == n - 1)
                {
                    Console.Write($"{sum}");
                }
                else
                {
                    Console.Write($"{sum} * ");
                }

            }
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine($" = {factorial}");
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
