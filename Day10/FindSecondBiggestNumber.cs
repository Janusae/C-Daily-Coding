namespace Reverse_String.Day10
{
    public class FindSecondBiggestNumber
    {
        public static int? Find(int[] numbers)
        {
            if (numbers.Length < 2 )
                throw new ArgumentException("Array must have more than 1 elements");

            var list = new List<int?> { numbers[0] };
            var biggest = 0; 

            for(int i = 0; i< numbers.Length; i++)
            {
                for(int j = 0; j < list.Count(); j++)
                {
                    if (!list.Contains(numbers[i]) && list[j] < numbers[i])
                    {
                        list.Insert(j , numbers[i]);
                        continue;

                    }
                }
                if (!list.Contains(numbers[i]))
                {
                    list.Add(numbers[i]);
                }
            }
            return list.Count > 1 ? list[1] : null;
        }
    }
}
