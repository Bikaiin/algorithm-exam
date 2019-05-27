using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinations
{
    class Program
    {
        static bool NextSet(int[] a, int n, int m)
        {
            int j = m - 1;
            while (a[j] == n && j > 0) j--;
           

            if (a[j] >= n)
                j--;
            if (j < 0) return false;
            a[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                a[k] = a[j];
            return true;
        }
        static void Print(int[] a, int n)
        {
            
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        
            
            
        static void Main(string[] args)
        {
            int n, m;
            Console.Write( "N = ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            m = Int32.Parse(Console.ReadLine()); ;
            int h = n > m ? n : m; // размер массива а выбирается как max(n,m)
            int [] arr = new int[h];
            for (int i = 0; i < h; i++)
                arr[i] = 1;
            Print(arr, m);
            while (NextSet(arr, n, m))
                Print(arr, m);
            Console.ReadKey();

        }
    }
}
