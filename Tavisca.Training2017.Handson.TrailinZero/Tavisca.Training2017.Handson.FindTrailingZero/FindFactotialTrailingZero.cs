using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Handson.FindTrailingZero
{
    public class FindFactotialTrailingZero
    {
        public int TrailingZeroBaseTen(int num)
        {
            int count = 0;
            for (int i = 5; num / i >= 1; i *= 5)
            {
                count += num / i;
            }
            return count;
        }
        public bool IsPrime(int num)
        {
            int flag = 0;
            if (num == 1)
            {
                return false;
            }
            else

            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        flag++;
                    }


                }
                if (flag == 0)
                {
                    return true;
                }
            }
            return false;

        }
        public int TrailingZeroes(int num, int bas)
        {

            int count = 0, min = 1;
            int flag_count = 0;
            for (int i = 2; i <= bas; i++)
            {
                if (IsPrime(i))
                {


                    if (bas % i == 0)
                    {
                        int temp = num;
                        count = 0;
                        flag_count++;
                        for (int k = i; temp / k >= 1;)
                        {

                            count += (temp / k);
                            temp = temp / k;


                        }


                    }
                    if (flag_count == 1)
                    {
                        min = count;
                    }
                    else
                    {
                        min = Math.Min(min, count);
                        // Console.WriteLine("min=" + min);
                    }
                }

            }

            return min;
        }
    }
}
