using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5,101,7,420,10,1};
            int[] arr = {4,99,76,42,01,07,7,4,0,-1,-7 };

            Console.WriteLine("Given Array");
            printArray(arr);

            InsertionSort ob = new InsertionSort();
            ob.sort(arr);

            Console.WriteLine("\nSorted array");
            printArray(arr);
        }

        private void sort(int[] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];
                int i = j - 1;

                while (i>=0 && arr[i]>key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();
            ;
        }
    }
    
}
