using System;

class HomeWork2_2
{
    static void Main(string[] args)
    {
        // Dãy số nguyên ngẫu nhiên a
        int[] a = new int[100];
        Random r = new Random();

        Console.WriteLine("Mang a: ");

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = r.Next(100);
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        //Nhập giá trị của v
        Console.WriteLine("Nhap gia tri v: ");
        int v = Convert.ToInt32(Console.ReadLine());
        // Thuật toán xác định vị trí của v
        int vitri = 0;
        while (vitri < a.Length && a[vitri] != v)
            vitri++;
        if (vitri < a.Length)
            Console.WriteLine("{0} nam o vi tri {1}", v, vitri.ToString());
        else
            Console.WriteLine("0");

        Console.ReadKey();

    }
}
