using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Input
    {
        private string strreverse;
        public void InputString()
        {
            Console.WriteLine("Enter the string you want to reverse");
            strreverse = Console.ReadLine();
        }
        public string GetString()
        {
            return strreverse;
        }
    }
}
