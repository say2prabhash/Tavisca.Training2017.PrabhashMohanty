using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class StringReversal
    {
        public void ReverseOfString(Input input)
        {
            string reversestring = "";
            string originalstring=input.GetString();
            for(int i=originalstring.Length-1;i>=0; i--)
            {
                reversestring += originalstring[i];
            }
            DisplayString display = new DisplayString();
            display.StringDisplay(reversestring);
        }
    }
}
