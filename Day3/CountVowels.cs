namespace Reverse_String.Day3
{
    public class CountVowels
    {
        public static int Count(string text)
        {
            if(text is null)
                throw new ArgumentNullException("text");

            if (text.Length == 0)
                return 0;

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u'};
            var count = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(char.ToLower(text[i]))) count++;
            }
            return count;
        }
    }
}
