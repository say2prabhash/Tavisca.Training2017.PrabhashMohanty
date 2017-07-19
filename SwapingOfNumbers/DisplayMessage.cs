using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingOfNumbers
{
    class DisplayMessage
    {
        public void DisplaySwappedNumber(int [] number)
        {
            Console.WriteLine("Numbers Before Swapping:" + " number1=  " + number[1] + " " + " number2= " + number[0]);
            Console.WriteLine("Numbers After Swapping:" + " number1=  " + number[0] + " " + " number2= " + number[1]);

        }
    }
}
