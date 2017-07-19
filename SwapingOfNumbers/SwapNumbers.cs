using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingOfNumbers
{
    class SwapNumbers
    {
        public void SwapingNumbers(Input input)
        {
            int[] number = input.GetNumbers();
            number[0] = number[0] + number[1];
            number[1] = number[0] - number[1];
            number[0] = number[0] - number[1];
            DisplayMessage display = new DisplayMessage();
            display.DisplaySwappedNumber(number);
        }
    }
}
