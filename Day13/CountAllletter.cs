using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day13
{
    public class CountAllletter
    {
        public static StringBuilder Count(string letters)
        {
            var letter = new Dictionary<char , int>();
            var result = new StringBuilder();
            for (int i = 0; i<letters.Count(); i++)
            {
                if (letter.ContainsKey(letters[i]))
                {
                    letter[letters[i]]++;
                    continue;
                }
                letter.Add(letters[i], 1);
            }
            foreach(var iteme in letter) result.AppendLine($"{iteme.Key}:{iteme.Value}");
            return result;
        }
    }
}
