using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Handson.QueueUSingStack; 

namespace Tavisca.Training2017.Handson.QueueUSingStack

{
    class Program
    {
             static void Main(string[] args)
             {
                Stack s1 = new Stack();
                Stack s2 = new Stack();
                int n = 1;
                while (n == 1)
                {
                    Console.WriteLine("1.To enqueue...2..to dequque...3....to exit");
                    int o = Convert.ToInt32(Console.ReadLine());
                    switch (o)
                    {
                        case 1:
                            Console.WriteLine("Enter the element to enter");
                            int k = Convert.ToInt32(Console.ReadLine());

                            s1.Push(k);
                            break;
                        case 2:
                            for (int i = s1.top; i >= 0; i--)
                            {
                                s2.Push(s1.Pop());

                            }
                            s1.top = -1;
                            Console.WriteLine("Dequed element is" + " " + s2.Pop());
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
    
    
