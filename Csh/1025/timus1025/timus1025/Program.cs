using System;

namespace timus1025
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0;
            int n = int.Parse(Console.ReadLine());
            string[] temp = new string[n];
            int[] arr = new int[n];
            temp = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }
            Array.Sort(arr);
            double groups = Math.Ceiling(arr.Length / 2.0);
            for (int i = 0; i < groups; ++i)
            {
                answer += (Math.Ceiling(arr[i] / 2.0));
            }
            Console.WriteLine(answer);
            Console.ReadLine();
        }

    }
}
