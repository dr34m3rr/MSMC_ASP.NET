using System;

namespace _1209
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("1");
            int n, i, max=0 ;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int j=0;j< n;j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
                if (arr[j] > max)
                    max = arr[j];
            }
            for (i = 1; sb.Length < max; i*= 2)
            {
                sb.Append(Convert.ToString(i * 2, 2));
            }
            for (int j=0;j< n;j++)
            {
                Console.Write((sb[arr[j]-1]));
                Console.Write(" ");
            }
        }
    }
}
