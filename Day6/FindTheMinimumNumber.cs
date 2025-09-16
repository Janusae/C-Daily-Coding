namespace Reverse_String.Day6
{
    public class FindTheMinimumNumber
    {
        public static int Find(List<int> numbers)
        {
            if (numbers.Count == 0)
                throw new ArgumentException("Input list cannot be empty", nameof(numbers));

            int min = numbers[0];
            for(int i = 1; i< numbers.Count;i++)
            {
                if(min > numbers[i]) 
                    min = numbers[i];
            }
            return min;
        }
    }
}
