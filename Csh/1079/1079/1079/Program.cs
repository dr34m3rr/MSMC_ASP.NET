using System;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100010];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 1; i <= 50000; i++)
            {
                arr[i * 2] = arr[i];
                arr[i * 2 + 1] = arr[i] + arr[i + 1];
            }
            int n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                int max = 0;
                for (int i = 0; i <= n; i++)
                    max = Math.Max(max, arr[i]);
                Console.WriteLine(max);
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
