using System.Text;
namespace Reverse_String.Day2
{
    public class Palindrome
    {
        public static bool Palindromer(string text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            if (text is "")
                return false;

            var reversed = new StringBuilder(text.Length);
            for(int i = text.Length -1; i>=0; i--)
            {
                reversed.Append(text[i]);
            }
            return string.Equals(reversed.ToString(), text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
