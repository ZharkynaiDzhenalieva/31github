using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTheStringUppercase
{
    /*Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000*/

    //My solution
    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            //#Happy Coding! ^_^
            int msHours = h * 3600000;
            int msMinutes = m * 60000;
            int msSeconds = s * 1000;

            return msHours + msMinutes + msSeconds;


        }
    }
}
