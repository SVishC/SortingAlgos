using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/* C# program for Merge Sort */
public class MergeSort
{
  // Merges two subarrays of arr[].
  // First subarray is arr[l..m]
  // Second subarray is arr[m+1..r]
  void merge(int[] arr, int l, int m, int r)
  {
    // Find sizes of two subarrays to be merged
    int n1 = m - l + 1;
    int n2 = r - m;

    /* Create temp arrays */
    int[] L = new int[n1+1];
    int[] R = new int[n2+1];

    /*Copy data to temp arrays*/
    for (int counti = 0; counti < n1; ++counti)
      L[counti] = arr[l + counti];
    for (int countj = 0; countj < n2; ++countj)
      R[countj] = arr[m + 1 + countj];

    L[n1]=Int32.MaxValue;
    R[n2] = Int32.MaxValue;
    /* Merge the temp arrays */

    // Initial indexes of first and second subarrays
    int i = 0, j = 0;

    // Initial index of merged subarry array
    int k = l;
    //while (i < n1 && j < n2)
    //{
    //  if (L[i] <= R[j])
    //  {
    //    arr[k] = L[i];
    //    i++;
    //  }
    //  else
    //  {
    //    arr[k] = R[j];
    //    j++;
    //  }
    //  k++;
    //}

    for (int countk = l; countk <= r; countk++)
    {

      if (L[i] <= R[j])
      {
        arr[countk] = L[i];
        i++;
      }
      else
      {
        arr[countk] = R[j];
        j++;
      }
    }

    /* Copy remaining elements of L[] if any */
   // while (i < n1)
    //{
    //  arr[k] = L[i];
    //  i++;
    //  k++;
    //}

    ///* Copy remaining elements of R[] if any */
    //while (j < n2)
    //{
    //  arr[k] = R[j];
    //  j++;
    //  k++;
    //}
  }

  // Main function that sorts arr[l..r] using
  // merge()
  void sort(int[] arr, int l, int r)
  {
    if (l < r)
    {
      // Find the middle point
      int m = (l + r) / 2;

      // Sort first and second halves
      sort(arr, l, m);
      sort(arr, m + 1, r);

      // Merge the sorted halves
      merge(arr, l, m, r);
    }
  }

  /* A utility function to print array of size n */
  static void printArray(int[] arr)
  {
    int n = arr.Length;
    for (int i = 0; i < n; ++i)
      Console.WriteLine(arr[i] + " ");
    Console.WriteLine();
    ;
  }

  // Driver method
  public static void Main(string[] args)
  {
    int[] arr = { 12, 11, 13, 13, 6, 7 ,5};

    Console.WriteLine("Given Array");
    printArray(arr);

    MergeSort ob = new MergeSort();
    ob.sort(arr, 0, arr.Length - 1);

    Console.WriteLine("\nSorted array");
    printArray(arr);
  }
}
/* This code is contributed by Rajat Mishra */


