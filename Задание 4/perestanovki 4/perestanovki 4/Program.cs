using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int l = 3;
            int[] a = new int[l];
            int z =0;
            set(a, 0, l,ref z);
            Console.Write(z);
            Console.ReadKey(true);
        }
        static void set(int[] a, int n, int l,ref int z)
        {
            for (int i = 0; i < l; i++)
            {


                a[n] = i + 1;
                if (n < l - 1) set(a, n + 1, l,ref z);
                else
                {
                    for (int k = 0; k < l; k++) Console.Write(a[k]);
                    Console.WriteLine();
                    z++;
                }

            }
        }

    }
}
