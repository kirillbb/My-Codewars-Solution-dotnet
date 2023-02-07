namespace Training
{
    public static class Program
    {
        private static void Main(string[] args)
        {

        }

        public static string MakeComplement(string dna)
        {
            return dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();
        }

        private static string ToCamelCase(string str)
        {
            return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        }

        public static int Persistence(long num)
        {
            int result = 0;
            while (num > 9)
            {
                long mul = 1;

                while (num > 0)
                {
                    mul *= num % 10;
                    num /= 10;
                }

                num = mul;
                result++;
            }

            return result;
        }

        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString()
                .OrderByDescending(x => x)));
        }

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers
                .OrderBy(i => i)
                .Take(2)
                .Sum();
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();

            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    result.Add((int)item);
                }
            }

            return result;
        }

        public static string GetMiddle(string s)
        {
            return s.Length % 2 != 0
                ? s[s.Length / 2].ToString()
                : s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
        }

        public static double FindAverage(double[] array)
        {
            double result = 0;
            if (array.Length != 0)
            {
                foreach (var item in array)
                    result += item;

                return result / array.Length;
            }

            return result;
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