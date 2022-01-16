using System;

namespace URI_beecrowd_1177_Array_Fill_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[1000];
            int n, i, j = 0;


            n = int.Parse(Console.ReadLine());

            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, j);
                j++;

                if (j == n) 
                {
                    j = 0;
                }
                
            }

        }
    }
}
