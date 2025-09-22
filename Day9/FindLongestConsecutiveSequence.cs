using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day9
{
    public class FindLongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            var count = 1;
            var previous = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length ; j++)
                {
                    if ((nums[i] + 1) == nums[j] && !previous.Contains(nums[i]))
                    {
                        previous.Add(nums[i]);
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
