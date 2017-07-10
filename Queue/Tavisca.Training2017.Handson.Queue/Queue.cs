using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.Queue
{
    public class Queue
    {
        int[] arr = new int[10];
        int rear;
        int front;
        public Queue()
        {
            this.rear = 0;
            this.front = -1;
        }
        public void Enque(int k)
        {
            if (this.rear >= 0 && this.rear < 9)
            {
                this.arr[this.rear++] = k;
            }
            else if (this.rear >= 9)
            {
                this.rear = 0;
            }
        }
        public int Deque()
        {
            if (this.front < this.rear)
            {
                return this.arr[++this.front];
            }
            return -1;

        }


    }
}

