using System;

namespace HanoiTower
{
    class Program
    {
        private static void Tower(int n, char a, char b, char c)
        {
            if (n == 1)
            {
                Console.WriteLine("{0}------------>{1}",a,c);
                return;
            }
            Tower(n - 1, a, c, b);
            Tower(1, a, b, c);
            Tower(n - 1, b, a, c);

        }
        static void Main(string[] args)
        {
            char a = Convert.ToChar("A");
            char b = Convert.ToChar("B");
            char c = Convert.ToChar("C");
            Console.Write("Enter the number of disks: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Tower(n, a, b, c);

            Console.ReadKey();

        }
    }
}
