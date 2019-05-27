using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp8
{
    class Program
    {
        static void generate()
        {
            Random rng = new Random(5);
            const int n = 10000000;
            int[] theArray =  new int[n];
            for (int i = 0; i < n; i++)
            {
                theArray[i] = rng.Next(10);
            }
            serch(ref theArray);
        }
        static void serch(ref int[] arr)
        {
            Stopwatch stopWatch = new Stopwatch();
            int pos = 2 ;
            pos = int.Parse(Console.ReadLine());
            if(pos < 88)
            {

                stopWatch.Start();
                SelectionSort(ref arr, pos);
                stopWatch.Stop();
            }
            else
            {
                int l = 0;
                int r = arr.Length-1;
                stopWatch.Start();
                sort(arr, l, r);
                stopWatch.Stop();
            }
          
            Console.WriteLine(arr[pos]);
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
        static void insertsort(ref int[] arr)
        {
            int x, i, j;
            for (i = 0; i < arr.Length; i++)
            {
                x = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > x; j--)
                    arr[j + 1] = arr[j];

                arr[j + 1] = x;
            }

        }
        static void merge( int[] arr, int l, int m, int r)
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
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }

                else
                {
                    arr[k] = R[j];
                    j++;
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
        static void sort( int[] arr, int l, int r)
        {
            
            if (l < r)
            {
                int m = (l + r) / 2;
                sort( arr, l, m);
                sort( arr, m + 1, r);
                merge( arr, l, m, r);
            }
        }
        static void SelectionSort(ref int[] arr, int pos)
        {
            int min, temp;
            int length = arr.Length;

            for (int i = 0; i < pos+1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            generate();
            Console.ReadKey();


        }
    }
}
