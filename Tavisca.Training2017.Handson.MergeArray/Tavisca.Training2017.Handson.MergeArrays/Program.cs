using System;

namespace Tavisca.Training2017.Handson.MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.WriteLine("Enter the number of arrays");
            int numArrays = Convert.ToInt32(Console.ReadLine());
            Arrays []a = new Arrays[numArrays];
            Arrays[] result2 = new Arrays[numArrays];
            for (int i = 0; i < numArrays; i++)
            {
                Console.WriteLine("Enter the dimension of Array {0} ", i);
                int num = Convert.ToInt32(Console.ReadLine());
                a[i] = new Arrays(num);
                result2[i] = new Arrays(num);

            }
            for (int i = 0; i < numArrays - 1; i++)
            {
                length = length + a[i].arr.Length + a[i + 1].arr.Length;
            }
            Arrays result = new Arrays(length);
            for (int i = 0; i < numArrays; i++)
            { 
                Console.WriteLine("Enter the elements for Array {0}", i);
                for(int j=0;j<a[i].arr.Length;j++)
                {
                    a[i].arr[j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            
            int count = 0;
            for(int i=0;i<numArrays;i++)
            {
                for (int j=0;j<a[i].arr.Length;j++)
                {
                    result.arr[count++] = a[i].arr[j];
                }
            }
            result.MergeSort(result.arr, 0, result.arr.Length-1);
            Console.WriteLine("Sorted array is");
            result.Print();
            Console.ReadLine();  
        }
    }
}