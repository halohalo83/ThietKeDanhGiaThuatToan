using System;

namespace GreedyAlgorithm
{
    class Program
    {
        public static int harvestDayProcess(int[] harvestDay)
        {
            // Harvest day processing function
            int result = 1;
            for (int i = harvestDay.Length - 1; i >= 0; i--)
            {
                int j = 1;
                harvestDay[i] += j++;
                if (result < harvestDay[i])
                    result = harvestDay[i];

            }
            result++;

            return result;

        }
        static void Main(string[] args)
        {
            // input the number of flowers
            Console.Write("Enter the number of flowers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            // input the number of harvest days
            Console.WriteLine("Enter the number of harvest days: ");

            int[] harvestDay = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Flower {0}: ", i);
                harvestDay[i] = Convert.ToInt32(Console.ReadLine());
            }
            // sort and print harvest day of these flowers
            Array.Sort(harvestDay);
            Array.Reverse(harvestDay);
            Console.Write("Sorted Harvest Days: ");
            foreach (int item in harvestDay)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            // print result
            int bestHarvestDay = harvestDayProcess(harvestDay);

            Console.WriteLine("Result: {0} ", bestHarvestDay);

            Console.ReadKey();
        }
    }
}
