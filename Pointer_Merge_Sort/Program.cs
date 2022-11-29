using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pointer_Merge_Sort
{
    internal class Program
    {
        private static int recursion = 0;
        private static int[] millisecond_results = new int[100];


        private static unsafe void Merge_Sort(int* arr, int arr_length)
        {


            if (arr_length > 1)
            {
                int l_arr_length = arr_length / 2;
                int r_arr_length = arr_length - (arr_length / 2);






                System.Runtime.InteropServices.GCHandle l_arr_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[l_arr_length], System.Runtime.InteropServices.GCHandleType.Pinned);
                int* l_arr = (int*)l_arr_p_handle.AddrOfPinnedObject();

                System.Runtime.InteropServices.GCHandle r_arr_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[r_arr_length], System.Runtime.InteropServices.GCHandleType.Pinned);
                int* r_arr = (int*)r_arr_p_handle.AddrOfPinnedObject();



                System.Runtime.InteropServices.GCHandle l_arr_sort_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* l_arr_sort_index = (int*)l_arr_sort_index_p_handle.AddrOfPinnedObject();

                System.Runtime.InteropServices.GCHandle r_arr_sort_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* r_arr_sort_index = (int*)r_arr_sort_index_p_handle.AddrOfPinnedObject();

                System.Runtime.InteropServices.GCHandle arr_sort_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* arr_sort_index = (int*)arr_sort_index_p_handle.AddrOfPinnedObject();



                System.Runtime.InteropServices.GCHandle l_arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* l_arr_merge_index = (int*)l_arr_merge_index_p_handle.AddrOfPinnedObject();

                System.Runtime.InteropServices.GCHandle r_arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* r_arr_merge_index = (int*)r_arr_merge_index_p_handle.AddrOfPinnedObject();

                System.Runtime.InteropServices.GCHandle arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);
                int* arr_merge_index = (int*)arr_merge_index_p_handle.AddrOfPinnedObject();






                


            L_ARR_RECURSION:
                l_arr[*l_arr_sort_index] = arr[*arr_sort_index];

                if (*l_arr_sort_index + 1 < l_arr_length)
                {
                    l_arr[*l_arr_sort_index + 1] = arr[*arr_sort_index + 1];
                    ++*l_arr_sort_index;
                    ++*arr_sort_index;
                }

                ++*l_arr_sort_index;
                ++*arr_sort_index;

                if (*l_arr_sort_index < l_arr_length)
                {
                    goto L_ARR_RECURSION;
                }

                


            R_ARR_RECURSION:
                r_arr[*r_arr_sort_index] = arr[*arr_sort_index];

                if (*r_arr_sort_index + 1 < r_arr_length)
                {
                    r_arr[*r_arr_sort_index + 1] = arr[*arr_sort_index + 1];
                    ++*arr_sort_index;
                    ++*r_arr_sort_index;
                }


                ++*arr_sort_index;
                ++*r_arr_sort_index;

                if (*r_arr_sort_index < r_arr_length)
                {
                    goto R_ARR_RECURSION;
                }


                



                Merge_Sort(l_arr, l_arr_length);
                Merge_Sort(r_arr, r_arr_length);


              


                
                

                while (*l_arr_merge_index < l_arr_length && *r_arr_merge_index < r_arr_length)
                {
                    if (l_arr[*l_arr_merge_index] <= r_arr[*r_arr_merge_index])
                    {
                        arr[*arr_merge_index] = l_arr[*l_arr_merge_index];
                        ++*l_arr_merge_index;
                    }
                    else
                    {
                        arr[*arr_merge_index] = r_arr[*r_arr_merge_index];
                        ++*r_arr_merge_index;
                    }

                    ++*arr_merge_index;
                }



                while (*l_arr_merge_index < l_arr_length)
                {
                    arr[*arr_merge_index] = l_arr[*l_arr_merge_index];
                    ++*l_arr_merge_index;
                    ++*arr_merge_index;
                }


                while (*r_arr_merge_index < r_arr_length)
                {
                    arr[*arr_merge_index] = r_arr[*r_arr_merge_index];
                    ++*r_arr_merge_index;
                    ++*arr_merge_index;
                }


                l_arr_p_handle.Free();
                r_arr_p_handle.Free();

                l_arr_merge_index_p_handle.Free();
                r_arr_merge_index_p_handle.Free();
                arr_merge_index_p_handle.Free();


                l_arr_sort_index_p_handle.Free();
                r_arr_sort_index_p_handle.Free();
                arr_sort_index_p_handle.Free();

            }


        }







        private static unsafe Task<bool> Async_Implementation()
        {
            System.Runtime.InteropServices.GCHandle arr_lenght_handle = System.Runtime.InteropServices.GCHandle.Alloc(1000000, System.Runtime.InteropServices.GCHandleType.Pinned);
            int* arr_lenght = (int*)arr_lenght_handle.AddrOfPinnedObject();

            System.Runtime.InteropServices.GCHandle arr_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[*arr_lenght], System.Runtime.InteropServices.GCHandleType.Pinned);
            int* arr = (int*)arr_handle.AddrOfPinnedObject();

            Random r = new Random();



            for (int i = 0; i < *arr_lenght; i++)
            {
                int rn = r.Next(int.MaxValue);

                arr[i] = rn;
            }

          


            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            Merge_Sort(arr, *arr_lenght);
            s.Stop();

            Console.WriteLine("TIME TOOK TO SORT 1000000 RANDOM INTEGERS: " + s.ElapsedMilliseconds + " MILLISECONDS");

            millisecond_results[recursion] = (int)s.ElapsedMilliseconds;
            
            

            arr_handle.Free();
            arr_lenght_handle.Free();



            return Task.FromResult(true);
        }



        public static async void Implementation()
        {
            await Async_Implementation();



            recursion++;

            if (recursion < 100)
            {
                
                Implementation();
            }

            int sum = 0;
            int fastest = int.MaxValue;
            int slowest = 0;

            for (int i = 0; i < millisecond_results.Length; i++)
            {
                if (millisecond_results[i] < fastest)
                {
                    fastest = millisecond_results[i];
                }

                if (millisecond_results[i] > slowest)
                {
                    slowest = millisecond_results[i];
                }

                sum += millisecond_results[i];
            }

            Console.WriteLine("\nThe calculated average time is: " + sum / millisecond_results.Length + " MILLISECONDS\n");

            Console.WriteLine("The fastest time is: " + fastest + " MILLISECONDS\n");

            Console.WriteLine("The slowest time is: " + slowest + " MILLISECONDS\n");

            Console.ReadLine();
        }

        public static void Main(String[] args)
        {
            Implementation();
        }
    }
}
