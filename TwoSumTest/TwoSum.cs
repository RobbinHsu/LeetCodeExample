using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSumTest
{
    public class TwoSum
    {
        public int[] GetResult(int[] nums, int target)
        {
            var result = new Dictionary<int, int>();
            int candicateNumber;

            for (var i = 0; i < nums.Length; i++)
            {
                candicateNumber = target - nums[i];
                if (result.ContainsKey(candicateNumber))
                {
                    return new int[] {result[candicateNumber], i};
                }

                if (!result.ContainsKey(nums[i]))
                {
                    result.Add(nums[i], i);
                }
            }

            return result.Keys.ToArray();
        }
    }
}