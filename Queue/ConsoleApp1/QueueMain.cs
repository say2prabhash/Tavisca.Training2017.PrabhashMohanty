using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Handson.Queue;

namespace ConsoleApp1
{

    public class QueueMain
    {

        static void Main(string[] args)
        {
            Queue q = new Queue();
            int n = 1;
            while (n == 1)
            {

                Console.WriteLine("Enter 1..to enqueue 2.. to dequeue 3...to exit");
                int o = Convert.ToInt32(Console.ReadLine());

                switch (o)
                {
                    case 1:
                        Console.WriteLine("Enter the element");
                        int k = Convert.ToInt32(Console.ReadLine());
                        q.Enque(k);
                        break;
                    case 2:
                        int result = q.Deque();

                        if (result != -1)
                        {
                            Console.WriteLine("Dequed element is " + result);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }

                        break;
                    case 3:
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

