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
            int k = 3;//длина строки
            int n = 4; //элементы строки
            int z = 0;
            int[] a = new int[k];
            set(a, 0, k, n, ref z);
            Console.Write(z);
            Console.ReadKey(true);
        }
        static void set(int[] a, int el, int k,int n, ref int z)
        {
            for (int i = 0; i < n; i++)
            {
               
                    a[el] = i + 1;
                    if (el < k - 1) set(a, el + 1, k, n, ref z);
                    else
                    {
                        for (int s = 0; s < k; s++) Console.Write(a[s]);
                        Console.WriteLine();
                    z++;
                    }
                
            }
        }

    }
}
