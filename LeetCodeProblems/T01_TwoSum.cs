﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class T01_TwoSum
    {
        /*
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         You may assume that each input would have exactly one solution, and you may not use the same element twice.
         You can return the answer in any order.
        */

        /*
         Example 01

         Input: nums = [2,7,11,15], target = 9
         Output: [0,1]
         Output: Because nums[0] + nums[1] == 9, we return [0, 1].
         */

        /*
         Example 02
         Input: nums = [3,2,4], target = 6
         Output: [1,2]
         */

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }

    }
}
