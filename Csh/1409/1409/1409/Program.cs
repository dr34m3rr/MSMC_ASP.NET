using System;

namespace _1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp;
            int[] hit, didnthit;
            hit = new int[2];
            didnthit = new int[2];
            temp = Console.ReadLine().Split(' ');
            for(int i=0;i<2;i++)
            {
                hit[i] = int.Parse(temp[i]);
            }
            didnthit[1] = hit[0] - 1;
            didnthit[0] = hit[1] - 1;
            Console.Write("{0} {1}", didnthit[0], didnthit[1]);
        }
    }
}
