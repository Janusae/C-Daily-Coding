using System.Text;

namespace ReverseString
{
    public class StringReverser
    {
        public static string ReverseString(string text)
        {
            if(text is null)
                throw new ArgumentNullException(nameof(text));

            if (text.Length == 0)
                return string.Empty;

            StringBuilder result = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }
            return result.ToString();
        }
    }
}
