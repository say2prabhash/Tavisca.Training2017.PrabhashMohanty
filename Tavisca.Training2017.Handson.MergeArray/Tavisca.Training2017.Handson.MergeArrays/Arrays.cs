using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Training2017.Handson.MergeArrays
{
    public class Arrays
    {
        internal int[] arr;
        public Arrays(int n)
        {
            this.arr = new int[n];
        }
         void Merge(int[] array, int left, int mid, int right)
         {
             int i, j, k;
             int n1 = mid - left + 1;
             int n2 = right - mid;


             int[] leftArray = new int[n1];
             int[] rightArray = new int[n2];


             for (i = 0; i < n1; i++)
                 leftArray[i] = array[left + i];
             for (j = 0; j < n2; j++)
                 rightArray[j] = array[mid + 1 + j];


             i = 0;
             j = 0;
             k = left;
             while (i < n1 && j < n2)
             {
                 if (leftArray[i] <= rightArray[j])
                 {
                     array[k] = leftArray[i];
                     i++;
                 }
                 else
                 {
                     array[k] = rightArray[j];
                     j++;
                 }
                 k++;
             }
             while (i < n1)
             {
                 array[k] = leftArray[i];
                 i++;
                 k++;
             }
             while (j < n2)
             {
                 array[k] = rightArray[j];
                 j++;
                 k++;
             }
         }

          public int[] MergeSort(int[] array, int left, int right)
         {
             if (left < right)
             {

                 int mid = left + (right - left) / 2;
                 MergeSort(array, left, mid);
                 MergeSort(array, mid + 1, right);

                 Merge(array, left, mid, right);
                 //return array;
             }
             return array;
         }
          public  void Print()
         {

             for (int i = 0; i < arr1.Length; i++)
             {
                 Console.WriteLine(arr1[i]);
             }
         }
    }
}

