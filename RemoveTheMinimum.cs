﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IsTheStringUppercase
{
    /*The museum of incredible dull things
The museum of incredible dull things wants to get rid of some exhibitions. Miriam, the interior architect, comes up with a plan to remove the most boring exhibitions. She gives them a rating, and then removes the one with the lowest rating.

However, just as she finished rating all exhibitions, she's off to an important fair, so she asks you to write a program that tells her the ratings of the items after one removed the lowest one. Fair enough.

Task
Given an array of integers, remove the smallest value. Do not mutate the original array/list. If there are multiple elements with the same value, remove the one with a lower index. If you get an empty array/list, return an empty array/list.

Don't change the order of the elements that are left.

Examples
* Input: [1,2,3,4,5], output = [2,3,4,5]
* Input: [5,3,2,1,4], output = [5,3,2,4]
* Input: [2,2,1,2,1], output = [2,2,2,1]*/

    //My solution
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0) return numbers;

            int[] arr = numbers.ToArray();
            int smallestIdx = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (smallestIdx > arr[i])
                    smallestIdx = arr[i];
            }

            var cloneList = new List<int>(numbers);
            Console.WriteLine(smallestIdx);
            cloneList.Remove(smallestIdx);
            return cloneList;
        }
    }
}
