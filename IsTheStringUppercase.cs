using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace IsTheStringUppercase
{
    /* Is the string uppercase?
 Task
 Create a method to see whether the string is ALL CAPS.

 Examples(input -> output)
 "c" -> False
 "C" -> True
 "hello I AM DONALD" -> False
 "HELLO I AM DONALD" -> True
 "ACSKLDFJSgSKLDFJSKLDFJ" -> False
 "ACSKLDFJSGSKLDFJSKLDFJ" -> True
 In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string containing no letters at all is trivially considered to be in ALL CAPS.*/
    
    //My solution
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            // your code here
            if (text == text.ToUpper())
            {
                return true;
            }
            return false;
        }
    }




}
