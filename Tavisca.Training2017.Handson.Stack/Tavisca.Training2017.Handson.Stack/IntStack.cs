using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.Stack
{
    public class IntStack
    {
        private int[] arr;
        private int top;
        public IntStack(int dim)
        {
            arr = new int[dim];
            top = -1;
        }
        public void Push(int pushval)
        {
            if (this.top >= arr.Length - 1)
            {
                throw new Exception("IntStack is full,push action cannot be performed");
            }
            this.arr[++this.top] = pushval;
        }
        public int Pop()
        {
            if (top <= -1)
            {
                throw new Exception("Can't be popped as stack is empty");
            }
            return (this.arr[top--]);
        }
    }
}
