using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IsTheStringUppercase
{
   /* Complete the function that takes two integers(a, b, where a < b) and return an array of all integers between the input parameters, including them.

For example:

a = 1
b = 4
-- > [1, 2, 3, 4]*/


    //My solution
    public class Kata1
    {
        public static int[] Between(int a, int b)
        {
            // your code here
            int[] arr = new int[b - a + 1];
            for (int i = 0; a <= b; i++, a++)
            {
                arr[i] = a;
            }
            return arr;
        }
    }
}
