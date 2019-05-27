using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    class Program
    {
        static void create()
        {
            long stepen;
            int lenght;
            lenght = Convert.ToInt32(Console.ReadLine());
            stepen = Convert.ToInt64(Console.ReadLine());

            int[] arr = new int[lenght];
            int[] copy_arr =  new int[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                copy_arr[i] = i;
            }
            perest_pow(ref arr, stepen, ref copy_arr);


        }
        static void perest_pow(ref int[] arr, long n, ref int[] copy_arr)
        {
            

            int j = 0;
            while (j < arr.Length - 1)
            {
                if (arr[j] == j)
                {
                    j++;
                    continue;
                }
                for (long i = 1; i < n; i++)
                {
                    arr = multiply(ref arr, ref copy_arr);
                }
                break;
            }
           
        }

        static int[] multiply(ref int[] arr, ref int[] copy_arr)
        {
            int[] answ_arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                answ_arr[i] = arr[copy_arr[i]];
                
            }
            return answ_arr;
        }
        static void Main(string[] args)
        {
            create();
            Console.ReadKey();
        }
    }
}
