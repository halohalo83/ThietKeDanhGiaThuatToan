using System;

    class HomeWork2_1
    {
        
        static void Main(string[] args)
        {
            
            int index = 0;
            int temp = 0;
            int[] randArray = new int[100];
            Random r = new Random();

            Console.WriteLine("Mang ngau nhien: ");

            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = r.Next(100);
                Console.Write(randArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < randArray.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < randArray.Length; j++)
                {
                    if (randArray[j] < randArray[index])
                    {
                        index = j;
                    }
                }
                temp = randArray[index];
                randArray[index] = randArray[i];
                randArray[i] = temp;
            }

            Console.WriteLine("Mang ngau nhien sau khi duoc sap xep: ");
            for (int i = 0; i < randArray.Length; i++)
            {
                Console.Write(randArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
