using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = FactorialAsync().Result;

            Console.WriteLine("Main закончил работу");
            Console.ReadKey();
        }
        static int Factorial()
        {
            Console.WriteLine("Factorial начал работу");
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Console.WriteLine($"{i}! = {f}");
                Thread.Sleep(100);
            }
            Console.WriteLine("Factorial закончил работу");
            return f;
        }
        static async Task<int> FactorialAsync()
        {
            Console.WriteLine("FactorialAsync начал работу");
            int factorial = await Task.Run(() => Factorial());
            Console.WriteLine("FactorialAsync закончил работу");
            return factorial;
        }
    }
}
