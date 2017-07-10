using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Handson.CharStack;

namespace Tavisca.Training2017.HandsOn.SubStringUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, flag1 = 0; 
            Console.WriteLine("Enter the String");
            String mainString = Console.ReadLine();
            Console.WriteLine("Enter the Substring");
            String subString = Console.ReadLine();
            CharStacks charstack = new CharStacks(mainString.Length);
            for(int i=0;i<mainString.Length-2;i++)
            {
                for(int j=i;j<=i+subString.Length-1;j++)
                {
                    charstack.Push(mainString[j]);

                }
                for(int k=subString.Length-1;k>=0;k--)
                {
                    
                   if(charstack.Pop().Equals(subString[k]))
                    {
                        flag++;
                    }
                }
                if(flag==subString.Length)
                {
                    Console.WriteLine(subString + " " + "is present in" + " " + mainString + ".");
                    flag1 = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if(flag1==0)
            {
                Console.WriteLine(subString + " " + "is not present in" + " " + mainString + ".");
            }
            Console.ReadKey(true);
        }
    }
}
