﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopingArrays
{
    class DisplayArray
    {
        public void PrintArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
