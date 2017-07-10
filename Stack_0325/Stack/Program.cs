using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
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
                if(this.top>=arr.Length-1)
                {
                    return 1;
                }
                else
                {
                   
                    return 2;
                }
            }
            public void push(int k)
            {
                if (IsFull()== 2)
                {
                    arr[++this.top] = k;
                    Console.WriteLine(top);
                }
                else
                {
                    Console.WriteLine("Stack is full");
                }
                
              
            }
            public int IsEmpty()
            {
                if(this.top<0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public void pop()
            {


                if (IsEmpty() == 0)
                {
                    int l = arr[this.top--];
                    Console.WriteLine("Popped out elmenent is" + " " + l);
                }
                else
                {

                    Console.WriteLine("No elment to pop");
                }

            }

            public void display()
            {
                for (int i = 0; i <= this.top; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            Int32 n = 1;
            while (n == 1)
            {
                Console.WriteLine("Enter 1.to push into stack.... 2.to pop from stack 3...To display 4... to exit" );
            Int32 o = Convert.ToInt32(Console.ReadLine());
         
           
                switch (o)
                {
                    case 1:
                        Console.WriteLine("Enter the element to push");
                        int k = Convert.ToInt32(Console.ReadLine());
                      s.push(k);
                       
                        break;
                    case 2:
                        s.pop();
                        break;
                    case 3:
                        s.display();
                        break;
                    case 4:
                        n = 2;
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            }
        }
    }
}
