using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String.Day11
{
    // Version 1.1
    public class FindFirstCharThatNotRepeated
    {
        public static char? Find(string letters)
        {
            if (letters == null)
                throw new ArgumentNullException(nameof(letters));
            if (letters.Length < 1)
                throw new Exception("Input can not be empty!");

            char? result = null;
            for (int i = 0; i < letters.Length; i++)
            {
                var cout = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    if (char.ToLower(letters[i]) == char.ToLower(letters[j]))
                    {
                        cout++;
                    }
                }
                if (cout == 1)
                {
                    result = letters[i];
                    break;
                }
            }
            return result == null ? null : result;
        }

    // Version 1.0
    //public static char? Find(string letters)
    //{
    //    if (letters == null)
    //        throw new ArgumentNullException(nameof(letters));
    //    if (letters.Length < 1)
    //        throw new Exception("Input can not be empty!");

    //    Dictionary<char , int> dict = new Dictionary<char, int>();
    //    var lowerText = letters.ToLower();
    //    for (int i = 0; i < lowerText.Length; i++)
    //    {
    //        var count = 0;
    //        for (int j = 0; j < lowerText.Length; j++)
    //        {
    //            if (lowerText[i] == lowerText[j]) count++;
    //        }
    //        if (!dict.ContainsKey((char)lowerText[i]))
    //        {
    //            dict.Add(lowerText[i], count);
    //        }
    //    }
    //    int min = dict.GetValueOrDefault(lowerText[0]);
    //    char? letter = null;
    //    foreach(var iteme in dict)
    //    {
    //        if (iteme.Value < min)
    //        {
    //            min = iteme.Value;
    //            letter = iteme.Key;
    //        }
    //    }
    //    return letter ?? null;
    //}/*
}
}
