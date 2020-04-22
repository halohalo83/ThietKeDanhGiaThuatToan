using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace BinarySearch
{
    class Program
    {
        public static int binarySearch(int[] array, int left, int right, int x)
        {
            // find x
            if (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == x)
                    return mid;
                if (array[mid] > x)
                    return binarySearch(array, left, mid - 1, x);
                return binarySearch(array, mid + 1, right, x);

            }

            return -1;
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
            // Sort Array
            Array.Sort(array);
            Console.Write("Sorted Array: ");
            foreach (int item in array)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            // Enter x
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            // print result
            int result = binarySearch(array, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
            {
                Console.WriteLine("Element is present at index {0}", result);
            }

            Console.ReadKey();

        }
    }
}
