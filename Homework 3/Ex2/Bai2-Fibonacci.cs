using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Fibonacci of {0} is: {1}", n, Fibonacci(n));
            Console.ReadKey();

        }

        private static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
