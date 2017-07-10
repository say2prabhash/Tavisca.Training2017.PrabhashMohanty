using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingQueue
{
    class Program
    {
        public class Queue
        {
            int[] arr = new int[5];
            public int rear;
           public int front;
            public Queue()
            {
                rear = -1;
                front = -1;
            }
            internal void Enque(int k)
            {
                if(this.rear<this.arr.Length-1)
                {
                    this.arr[++rear] = k;
                }
                else
                {
                    Console.WriteLine("Stack is full");
                }
            }
            internal void Print()
            {
                for(int i=this.front+1;i<this.rear;i++)
                {
                    Console.WriteLine(this.arr[i]);
                }
            }
            internal int Deque()
            {
                if(this.front<this.rear)
                {
                    return this.arr[++front];
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            Queue q2 = new Queue();
            int n = 1;
            while(n==1)
            {
                Console.WriteLine("Enter 1...to push...2..to pop..3...to exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        Console.WriteLine("Enter the value");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        q1.Enque(n1);
                        break;
                    case 2:
                        
                        for(int i=q1.front+1;i<=q1.rear;i++)
                        {
                            int ret;
                            if ((ret = q1.Deque()) != -1)
                            {
                                q2.enque(ret);
                            }

                        }
                        
                        q1.rear = -1;
                        q1.front = -1;
                        for (int j=0;j<q2.rear;j++ )
                        {
                            q1.enque(q2.Deque());
                            
                        }
                        
                        q2.front = -1;
                        q2.rear = -1;
                        break;
                    case 3:
                        n = 2;
                        break;
                    default:
                        Console.WriteLine("Invalid Option Entry");
                        break;
                }
            }
        }
    }
}
