namespace Reverse_String.Day7
{
    public class FindFirstRepeatedNumber
    {
        public static int Find(int[] numbers)
        {
            if (numbers.Length == 0 || numbers == null)
                throw new ArgumentException("Input array cannot be null or empty");

            var seen = new HashSet<int>();
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (!seen.Contains(numbers[i]))
                { 
                    seen.Add(numbers[i]);
                    continue; 
                }
                return numbers[i];

            }
            return -1;
        }
    }
}
