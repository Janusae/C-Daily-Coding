using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day8
{
    public class FindHowManyWordWeHave
    {
        public static int Find(string letters)
        {
            if (letters == null)
                throw new ArgumentNullException("String is null");
            if (letters.Length == 0)
                throw new ArgumentException("String is empty");


            var list = new List<char>();
            var count = 0;
            var trace = 0;
            for(int i = 0; i < letters.Length; i++)
            {
                if(i != letters.Length - 1)
                {
                    if (letters[i] != ' ' )
                    {
                        if (letters[i + 1] != ' ')
                        {
                            trace = 1;
                        }
                        else
                        {
                            if(trace == 1)
                            {
                                count++;
                                trace = 0;
                            }
                            
                        }
                        
                    }
                }
                if(i == letters.Length -1 && trace == 1)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
