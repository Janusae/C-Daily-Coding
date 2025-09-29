namespace Reverse_String.Day10
{
    public class FindSecondBiggestNumber
    {
        public static int? Find(int[] numbers)
        {
            if (numbers.Length < 2 )
                throw new ArgumentException("Array must have more than 1 elements");

            var list = new List<int> { numbers[0] };
            for(int i = 0; i< numbers.Length; i++)
            {
                if (list.Contains(numbers[i])) continue;
                for (int j = 0; j < list.Count(); j++)
                {
                    if (!list.Contains(numbers[i]) && list[j] < numbers[i])
                    {
                        list.Insert(j , numbers[i]);
                        break;

                    }
                }
                if (!list.Contains(numbers[i]))
                {
                    list.Add(numbers[i]);
                }
            }
            if(list.Count() > 1) return list[1];
            return null;
        }
    }
}
