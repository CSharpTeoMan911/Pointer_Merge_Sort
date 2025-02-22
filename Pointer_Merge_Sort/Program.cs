using System;

namespace Pointer_Merge_Sort
{
    internal class Program
    {


        ////////////////////////////////////////////////////////////////////////////
        ///                 Copyright (c) Teodor Mihail 2022                     ///
        ///                                                                      ///
        ///     DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER     ///
        ///                                                                      ///
        ///                                                                      ///
        /// This code is free software; you can redistribute it and/or modify it ///
        /// under the terms of the GNU General Public License version 2 only, as ///
        /// This code is free software; you can redistribute it and/or modify it ///
        ///                                                                      ///
        ////////////////////////////////////////////////////////////////////////////

        private static int number_of_elements = 10;
        private static int max_recursion = 10;
        private static int recursion = 0;
        private static Random rng = new Random();


        private static unsafe void Merge_Sort(int* arr, int arr_length)
        {
            if (arr_length > 1)
            {
                // SORTING PROCEDURE


                // THE NUMBER OF ELEMENTS IN THE LEFT HALF OF THE MAIN POINTER "arr"
                int l_arr_length = arr_length / 2;

                // THE NUMBER OF ELEMENTS IN THE RIGHT HALF OF THE MAIN POINTER "arr"
                int r_arr_length = arr_length - (arr_length / 2);





                // HANDLE THAT IS ALLOCATING AT A MEMORY ADDRESS THE NUMBER OF INTEGERS OF THE LEFT HALF OF THE MAIN POINTER TO A DESIGNATED POINTER
                System.Runtime.InteropServices.GCHandle l_arr_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[l_arr_length], System.Runtime.InteropServices.GCHandleType.Pinned);

                // LEFT POINTER HAS ASSIGNED THE INTEGERS ALLOCATED BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int* l_arr = (int*)l_arr_p_handle.AddrOfPinnedObject();



                // HANDLE THAT IS ALLOCATING AT A MEMORY ADDRESS THE NUMBER OF INTEGERS OF THE RIGHT HALF OF THE MAIN POINTER TO A DESIGNATED POINTER
                System.Runtime.InteropServices.GCHandle r_arr_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[r_arr_length], System.Runtime.InteropServices.GCHandleType.Pinned);

                // RIGHT POINTER HAS ASSIGNED THE INTEGERS ALLOCATED BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int* r_arr = (int*)r_arr_p_handle.AddrOfPinnedObject();




                // INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE LEFT HALF OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int l_arr_sort_index = 0;


                // INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE RIGHT HALF OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int r_arr_sort_index = 0;


                // INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int arr_sort_index = 0;






                // HANDLE THAT IS ALLOCATING AT A MEMORY ADDRESS AN INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE LEFT HALF OF THE MAIN POINTER DURING THE MERGING PROCEDURE
                System.Runtime.InteropServices.GCHandle l_arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);

                // POINTER THAT HAS ALLOCATED THE INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE LEFT HALF OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int* l_arr_merge_index = (int*)l_arr_merge_index_p_handle.AddrOfPinnedObject();



                // HANDLE THAT IS ALLOCATING AT A MEMORY ADDRESS AN INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE RIGHT HALF OF THE MAIN POINTER DURING THE MERGING PROCEDURE
                System.Runtime.InteropServices.GCHandle r_arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);

                // POINTER THAT HAS ALLOCATED THE INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE RIGHT HALF OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int* r_arr_merge_index = (int*)r_arr_merge_index_p_handle.AddrOfPinnedObject();



                // HANDLE THAT IS ALLOCATING AT A MEMORY ADDRESS AN INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE MAIN POINTER DURING THE MERGING PROCEDURE
                System.Runtime.InteropServices.GCHandle arr_merge_index_p_handle = System.Runtime.InteropServices.GCHandle.Alloc(0, System.Runtime.InteropServices.GCHandleType.Pinned);

                // POINTER THAT HAS ALLOCATED THE INTEGER THAT IS USED TO TRAVERSE THE ELEMENTS OF THE MAIN POINTER BY THE HANDLE AT A MEMORY ADDRESS, AND THAT IS USED FOR ACCESSING THEM
                int* arr_merge_index = (int*)arr_merge_index_p_handle.AddrOfPinnedObject();




                // MERGING PROCEDURE

                while (l_arr_sort_index < l_arr_length)
                {
                    l_arr[l_arr_sort_index] = arr[arr_sort_index];
                   l_arr_sort_index++;
                   arr_sort_index++;
                }


                while (r_arr_sort_index < r_arr_length)
                {
                    r_arr[r_arr_sort_index] = arr[arr_sort_index];
                    r_arr_sort_index++;
                    arr_sort_index++;
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




                // DEALLOCATE THE HANDLE OBJECTS AND THEIR CONTENT FROM MEMORY

                l_arr_p_handle.Free();
                r_arr_p_handle.Free();

                l_arr_merge_index_p_handle.Free();
                r_arr_merge_index_p_handle.Free();
                arr_merge_index_p_handle.Free();
            }
        }







        private static unsafe void Operation(double[] millisecond_results)
        {
            if (recursion < max_recursion)
            {
                // HANDLE THAT IS ALLOCATING A NUMBER OF ELEMENTS THAT CAN BE STORED WITHIN THE MAIN POINTER
                System.Runtime.InteropServices.GCHandle arr_handle = System.Runtime.InteropServices.GCHandle.Alloc(new int[number_of_elements], System.Runtime.InteropServices.GCHandleType.Pinned);

                // POINTER THAT IS STORING THE NUMBER OF ELEMENTS THAT CAN BE STORED WITHIN THE MAIN POINTER, ALLOCATED AT A MEMORY ADDRESS
                int* arr = (int*)arr_handle.AddrOfPinnedObject();



                Console.WriteLine("\n\n[ BEGIN RANDOM NUMBER GENERATION ]");

                for (int i = 0; i < number_of_elements; i++)
                {
                    int rn = rng.Next(0, 10000000);
                    arr[i] = rn;
                }

                Console.WriteLine("[ ENDING RANDOM NUMBER GENERATION ]\n\n");

                DateTime start = DateTime.UtcNow;


                Merge_Sort(arr, number_of_elements);


                double elapssed = (DateTime.UtcNow - start).TotalMilliseconds;

                Console.WriteLine($"\n\nTIME TOOK TO SORT {number_of_elements} RANDOM INTEGERS: {elapssed} MILLISECONDS");
                millisecond_results[recursion] = elapssed;


                // DEALLOCATING THE HANDLES AND THEIR CONTENT FROM MEMORY
                arr_handle.Free();


                recursion++;
                Operation(millisecond_results);
            }
        }


        public static void Implementation(double[] millisecond_results)
        {
            Operation(millisecond_results);

            double sum = 0;
            double fastest = double.MaxValue;
            double slowest = 0;

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


            Console.WriteLine($"\nThe calculated average time is: {sum / millisecond_results.Length} MILLISECONDS\n");

            Console.WriteLine($"The fastest time is: {fastest} MILLISECONDS\n");

            Console.WriteLine($"The slowest time is: {slowest} MILLISECONDS\n");

            Console.ReadLine();


        }

        public static void Main(String[] args)
        {
            Console.Write("\n Enter the number of sorting operations: ");
            max_recursion = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter the number of elements to sort: ");
            number_of_elements = Convert.ToInt32(Console.ReadLine());

            double[] millisecond_results = new double[max_recursion];

            Implementation(millisecond_results);
        }
    }
}
