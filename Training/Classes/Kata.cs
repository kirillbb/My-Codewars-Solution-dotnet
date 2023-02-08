namespace Training.Classes
{
    public class Kata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString()
                .OrderByDescending(x => x)));
        }

        public static string GetMiddle(string s)
        {
            return s.Length % 2 != 0
                ? s[s.Length / 2].ToString()
                : s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
        }
        public static string ToCamelCase(string str)
        {
            return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        }

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }

        public static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int x = i + 1; x < arr.Length; x++)
                    {
                        if (arr[x] != 0)
                        {
                            arr[i] = arr[x];
                            arr[x] = 0;
                            break;
                        }
                    }
                }
            }

            return arr;
        }
    }
}