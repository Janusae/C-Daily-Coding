namespace Reverse_String.Day5
{
    public class FindTheMaximumNumber
    {
        public static int Find(List<int> numbers)
        {
            if(numbers.Count == 0)
                throw new ArgumentException("Input list cannot be empty!");

            int max = numbers[0];
            for(int i = 1; i<numbers.Count; i++)
            {
                if(max < numbers[i])
                    max = numbers[i];
            }
            return max;
        }
    }
}
