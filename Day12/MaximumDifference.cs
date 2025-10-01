using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day12
{
    public class MaximumDifference
    {
        public static int Find(int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("The lenght of list is not enought");

            int min = numbers[0];
            for(int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }
            int max= numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
            }
            return max - min;
        }
    }
}
