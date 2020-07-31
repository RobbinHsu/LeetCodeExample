using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSumTest
{
    public class TwoSum
    {
        public int[] GetResult(int[] nums, int target)
        {
            var list = new List<CandidateNumber>();
            var result = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                list.Add(new CandidateNumber(
                    i,
                    nums[i]
                ));
            }

            for (var i = 0; i < list.Count(); i++)
            {
                for (var j = i + 1; j < list.Count(); j++)
                {
                    if (list[i].Number + list[j].Number == target)
                    {
                        result.Add(list[i].Index);
                        result.Add(list[j].Index);
                    }
                }
            }

            return result.ToArray();
        }
    }

    public class CandidateNumber
    {
        public int Index { get; set; }
        public int Number { get; set; }

        public CandidateNumber(int index, int number)
        {
            Index = index;
            Number = number;
        }
    }
}