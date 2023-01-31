using System;
using System.Collections.Generic;
using System.Linq;
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
            FactorialAsync(n);
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
            Console.WriteLine($"Факториал = {factorial}");
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
