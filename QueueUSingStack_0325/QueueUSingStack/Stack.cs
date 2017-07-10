using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.QueueUSingStack

{
    public class Stack
    {
        internal int[] arr = new int[5];
       internal int top;
        public Stack()
        {
            this.top = -1;
        }
        public bool IsFull()
        {
            if (this.top < this.arr.Length - 1)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public void Push(int k)
        {
            if (IsFull() == true)
            {
                arr[++this.top] = k;
                // Console.WriteLine(top);
            }
            else
            {
                Console.WriteLine("Queue is full");
            }


        }
        public int Empty()
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


            if (Empty() == 0)
            {

                return (arr[this.top--]);
            }

            return -1;

        }
    }
}
