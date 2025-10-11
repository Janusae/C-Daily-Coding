using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day15
{
    public class FindTwoNumberCloseToTargetNumber
    {
        public static (int, int) Find(int[] numbers, int target)
        {
            var min = int.MaxValue;
            (int, int) minDiff = (0, 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    int diff = Math.Abs(sum - target);
                    if (diff < min && i != j)
                    {
                        minDiff = (numbers[i], numbers[j]);
                        min = Math.Abs(target - (numbers[i] + numbers[j]));
                    }
                }
            }
            return minDiff;
        }
    }
}
