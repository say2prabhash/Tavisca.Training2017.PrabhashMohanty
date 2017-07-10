using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.CharStack
{
    public class CharStacks
    {
        private char[] stack;
        int top;
        public CharStacks(int dim)
        {
            stack = new char[dim];
            top = -1;
        }
        public void Push(char pushval)
        {
            if (this.top >= stack.Length - 1)
            {
                throw new Exception("Stack is full,push action cannot be performed");
            }
            this.stack[++this.top] = pushval;
        }
        public char Pop()
        {
            if (top <= -1)
            {
                throw new Exception("Can't be popped as stack is empty");
            }
            return (this.stack[top--]);
        }
    }
}
