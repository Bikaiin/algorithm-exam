using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ex2
{
    class Program
    {
        static void generate()
        {
            Random rng = new Random();
            const int n = 10000000;
            int[] theArray =  new int[n]; 
            /*
            for (int i = 0; i < theArray.Length; i++)
            {
                i++;
                Console.Write(i + " ");
                i--;
                if (i < 9)
                    Console.Write(" ");
            }*/
            Console.WriteLine();
            for (int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = rng.Next(89)+10;
                //Console.Write(theArray[i] + " ");

            }
            Console.WriteLine();
            serch(ref theArray);
            Console.WriteLine();
            
        }
        static void serch(ref int[] arr)
        {
            
            long answ2 = 0;
            
            
            
            


            int l = 0;
            int r = arr.Length -1;

            
            
           

            
            Console.WriteLine("начинаем считать");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            sort(arr, l, r, ref answ2);
            
            TimeSpan ts2 = sw2.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);
            Console.WriteLine(answ2 + "--->>>" + elapsedTime);

        }

        static void Main(string[] args)
        {
            generate();

            Console.ReadKey();
        }
        static void merge(int[] arr, int l, int m, int r, ref long answ2)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];

            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];
            int z = i ;
            i = 0;
            j = 0;
            int k = l;
            int zopa = 0;
            
            while (i < n1 && j < n2)
            {
                
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                    z--;
                }

                else
                {
                    arr[k] = R[j];
                    j++;
                    answ2 =answ2+z;
                    
                }
                
                k++;
                
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
                
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static void sort(int[] arr, int l, int r, ref long answ2)
        {

            if (l < r)
            {
                int m = (l + r) / 2;
                sort(arr, l, m, ref answ2);
                sort(arr, m + 1, r, ref answ2);
                merge(arr, l, m, r, ref answ2);
            }
        }
    }
}
