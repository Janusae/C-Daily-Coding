using System.Text;

namespace Reverse_String.Day4
{
    public class RemoveDuplicates
    {
        public static string Remove(string text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));
            if (text.Length is 0)
                return "";

            var result = new StringBuilder();
            var repeatedIteme = new HashSet<char>();
            for(int i = 0; i < text.Length; i++)
            {
                if (!repeatedIteme.Contains(text.ToLower()[i]))
                {
                    repeatedIteme.Add(text.ToLower()[i]);
                    result.Append(text[i]);
                }
            }
            return result.ToString();
        }
    }
}
