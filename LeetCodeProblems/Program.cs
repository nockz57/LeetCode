using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            T01_TwoSum twoSum = new T01_TwoSum();
            int[] nums = { 3, 3};
            int target = 6;
            int[] results = twoSum.TwoSum(nums, target);

            Console.WriteLine($"Output: [{results[0]},{results[1]}]");
            Console.ReadLine();

        }
    }
}
