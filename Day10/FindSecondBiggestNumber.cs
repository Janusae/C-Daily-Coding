using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day10
{
    public class FindSecondBiggestNumber
    {
        public static int Find(int[] numbers)
        {
            if (numbers.Length < 2 )
                throw new ArgumentException("Array must have more than 1 elements");

            var list = new List<int> {};
            var biggest = 0; 
            foreach(var iteme in numbers)
            {
                if(biggest < iteme)
                {
                    list.Add(iteme);
                    biggest = iteme;
                }
                   

            }
            return 0;
        }
    }
}
