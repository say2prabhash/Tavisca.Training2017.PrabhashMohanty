using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.Handson.FindTrailingZero;
using Tavisca.Training2017.Handson.TrailingZeroTest;

namespace Tavisca.Training2017.Handson.TrailinZero
{
    class FindNumberofZeroes
    {

      
       
        static void Main(string[] args)
        {
            FindFactotialTrailingZero find = new FindFactotialTrailingZero();
           FactorialTrailingZero test = new FactorialTrailingZero();
           Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the base");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Result");
            int zeroes = Convert.ToInt32(Console.ReadLine());
            if (bas == 10)
            {
                int result = find.TrailingZeroBaseTen(num);
                test.TrailingZero_Test(zeroes,result);
                Console.WriteLine("NUMBER OF ZEROES IN NUMBER {0} BASE {1} is", num, bas);
                Console.WriteLine(result);
            }
            else
            {
                int result = find.TrailingZeroes(num, bas);
                test.TrailingZero_Test(zeroes,result );
                Console.WriteLine("NUMBER OF ZEROES IN NUMBER {0} BASE {1} is", num, bas);
                Console.WriteLine(result);

            }
            Console.ReadLine();
        }
    }
}
