using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSumTest
{
    public class TwoSum
    {
        public int[] GetResult(int[] nums, int target)
        {
            var list = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        list.Add(Array.IndexOf(nums, nums[i]));
                        list.Add(Array.IndexOf(nums, nums[j]));
                    }
                }
            }

            //var candidateNumbers = from num in nums
            //     where num <= target
            //     select new CandidateNumber
            //     {
            //         Number = num,
            //         Index = Array.IndexOf(nums, num)
            //     };

            //var array = nums.ToArray();
            //var indexOf = Array.IndexOf(nums, nums[0]);

            //for (int i = 0; i < candidateNumbers.Count(); i++)
            //{

            //}

            //var candidateNumber = int.MinValue;
            //var firstEnumerator = candidateNumbers.GetEnumerator();
            //var secondEnumerator = candidateNumbers.GetEnumerator();
            //while (firstEnumerator.MoveNext())
            //{
            //    candidateNumber = firstEnumerator.Current.Number;
            //    if (firstEnumerator.MoveNext())
            //    {

            //    }
            //}


            //var tmp = from num in nums
            //          where target > num
            //          select num;

            return list.ToArray();
        }
    }

    public class CandidateNumber
    {
        public int Index { get; set; }
        public int Number { get; set; }
    }
}