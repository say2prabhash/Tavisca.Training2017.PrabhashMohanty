using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingOfNumbers
{
    class Input
    {
        private int []number=new int[2];
        public void InputNumbers()
        {
            Console.WriteLine("Enter both the numbers");
            int.TryParse(Console.ReadLine(), out number[0]);
            int.TryParse(Console.ReadLine(), out number[1]);
        }
        public int[] GetNumbers()
        {
            return number;
        }
    }
}
