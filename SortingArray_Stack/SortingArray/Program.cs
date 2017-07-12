using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        public class Stack
        {
            int[] arr = new int[10];
            int top;
            public Stack()
            {
                top = -1;
            }
            public int IsFull()
            {
                if (this.top >= this.arr.Length - 1)
                {
                    return 1;
                }
                else
                {

                    return 2;
                }
            }
            public void Push(int k)
            {
                if (IsFull() == 2)
                {
                    this.arr[++this.top] = k;
                   // Console.WriteLine(top);
                }
                else
                {
                    Console.WriteLine("Stack is full");
                }


            }
            public int IsEmpty()
            {
                if (this.top < 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public int Pop()
            {


                return this.arr[top--];

            }

          
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("Enter the dimension of the array");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[dim];
            Console.WriteLine("Enter the elements of the array");
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=0;j<array.Length-i-1;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        s.Push(array[j]);
                        array[j] = array[j + 1];
                        array[j + 1] = s.Pop();
                    }
                }
            }
            Console.WriteLine("Sorted Array Is:");
                for (int i = 0; i <array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            
            Console.ReadLine();
        }
    }
}
