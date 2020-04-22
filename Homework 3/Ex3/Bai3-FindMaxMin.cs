using System;
namespace FindMaxMinFromArray
{
    class Program
    {
        public static int findMax(int[] array, int start, int stop)
        {
            int left, right;

            if (start == stop)
                return array[start];

            left = findMax(array, start, (start + stop) / 2);
            right = findMax(array, ((start + stop) / 2) + 1, stop);

            if (left > right)
                return left;
            return right;
        }
        public static int findMin(int[] array, int start, int stop)
        {
            int left, right;

            if (start == stop)
                return array[start];

            left = findMin(array, start, (start + stop) / 2);
            right = findMin(array, ((start + stop) / 2) + 1, stop);

            if (left < right)
                return left;
            return right;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Print Array
            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            // print result
            int maxResult = findMax(array, 0, n - 1);
            int minResult = findMin(array, 0, n - 1);
            Console.WriteLine("Maximum number in the array is {0}", maxResult);
            Console.WriteLine("Minimum number in the array is {0}", minResult);

            Console.ReadKey();

        }
    }
}
