using Microsoft.VisualBasic;
using System;
using System.Xml.Linq;

namespace codewars_practice;
//Create a function which answers the question "Are you playing banjo?".
//If your name starts with the letter "R" or lower case "r", you are playing banjo!

//The function takes a name as its only argument, and returns one of the following strings:

//name + " plays banjo" 
//name + " does not play banjo"
//Names given are always valid strings.

//My solution
public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        //Implement me
        if (name.StartsWith('R') || name.StartsWith('r'))
        {
            return name + " plays banjo";
        }
        else
        {
            return name + " does not play banjo";
        }
    }
}
