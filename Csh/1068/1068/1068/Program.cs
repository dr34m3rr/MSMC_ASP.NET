using System;

namespace _1068
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, result = 0;
            N = int.Parse(Console.ReadLine());
            while (N != 1)
                {
                result += N;
                if (N < 0)
                    N++;
                else
                    if (N == 0)
                    N++;
                else
                    N--;
            }
            Console.WriteLine(result + 1);
        }
    }
}
