using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Handson.Stack;

namespace Tavisca.Training2017.Handson.ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the stack length you want");
            int len = Convert.ToInt32(Console.ReadLine());
            IntStack stack = new IntStack(len);
            
            Console.WriteLine("Enter the length of the array");
            int num= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the numbers in the array");
            for(int i=0;i<num;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int k = j; k < arr.Length; k++)
                {
                    if (arr[j] > arr[k])
                    {
                        stack.Push(arr[j]);
                        arr[j] = arr[k];
                        arr[k] = stack.Pop();

                    }
                }
            }
            for(int k=0;k<arr.Length;k++)
            {
                Console.WriteLine(arr[k]);
            }
            String s=Console.ReadLine();
            
        }
    }
}
