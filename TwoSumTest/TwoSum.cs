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

            for (var i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i, nums[i]);
                        result.Add(j, nums[j]);
                    }
                }
            }

            return result.Keys.ToArray();
        }
    }
}