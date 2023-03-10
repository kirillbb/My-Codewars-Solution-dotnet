using System.Text.RegularExpressions;

namespace Training.Classes
{
    public class Kata
    {
        public static string ToWeirdCase(string input)
        {
            string result = "";
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] symbols = words[i].ToCharArray();
                for (int n = 0; n < symbols.Length; n++)
                {
                    result += n % 2 == 0 ? char.ToUpper(symbols[n]) : char.ToLower(symbols[n]);
                }
                
                result += i != words.Length - 1 ? " " : "";
            }

            return result;
        }

        public static bool ValidatePin(string pin)
        {
            string result = Regex.Match(pin, @"\d+").Value;
            return pin == result && (result.Length == 4 || result.Length == 6);
        }

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