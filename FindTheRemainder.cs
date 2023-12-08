using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IsTheStringUppercase
{
    /* Task:
  Write a function that accepts two integers and returns the remainder of dividing the larger value by the smaller value.

  Divison by zero should throw a DivideByZeroException.

  Examples:
  n = 17
  m = 5
  result = 2(remainder of `17 / 5`)

  n = 13
  m = 72
  result = 7(remainder of `72 / 13`)

  n = 0
  m = -1
  result = 0(remainder of `0 / -1`)

  n = 0
  m = 1
  result - division by zero (refer to the specifications on how to handle this in your language)*/

    //My solution
    public class Kata
    {
        public static int Remainder(int a, int b)
        {
            if (a < b && a == 0 || a > b && b == 0)
            {
                throw new DivideByZeroException();
            }

            if (a > b) return a % b;
            else return b % a;
        }
    }
}
