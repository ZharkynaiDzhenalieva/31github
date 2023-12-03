using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace codewars_practice;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        //Create a function which answers the question "Are you playing banjo?".
        //If your name starts with the letter "R" or lower case "r", you are playing banjo!

        //The function takes a name as its only argument, and returns one of the following strings:

        //name + " plays banjo" 
        //name + " does not play banjo"
        //Names given are always valid strings.

        //My solution
        if (name.StartsWith('R') || name.StartsWith('r'))
        {
            return name + " plays banjo";
        }
        else
        {
            return name + " does not play banjo";
        }
    }

    //    Your task is to find the first element of an array that is not consecutive.
    //By not consecutive we mean not exactly 1 larger than the previous element of the array.
    //E.g.If we have an array[1, 2, 3, 4, 6, 7, 8] then 1 then 2 then 3 then 4 are all consecutive but 6 is not, so that's the first non-consecutive number.
    //If the whole array is consecutive then return null2.
    //The array will always have at least 2 elements1 and all elements will be numbers.The numbers will also all be unique and in ascending order. The numbers could be positive or negative and the first non-consecutive could be either too!
    //If you like this Kata, maybe try this one next: https://www.codewars.com/kata/represent-array-of-numbers-as-ranges
    //1 Can you write a solution that will return null2 for both[] and [x] though? (This is an empty array and one with a single number and is not tested for, but you can write your own example test. )


    //My solution
    public static object FirstNonConsecutive(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i + 1] - arr[i] != 1) return arr[i + 1];
        return null;
    }

    //    Given an array of integers your solution should find the smallest integer.
    //For example:
    //Given[34, 15, 88, 2] your solution will return 2
    //Given[34, -345, -1, 100] your solution will return -345
    //You can assume, for the purpose of this kata, that the supplied array will not be empty.

    //My solution
      public static int FindSmallestInt(int[] args)
      {
            int smallestNumber = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (smallestNumber > args[i])
                    smallestNumber = args[i];
            }
            return smallestNumber;
      }
    

}
