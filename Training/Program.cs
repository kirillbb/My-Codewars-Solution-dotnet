namespace Training
{
    public static class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string GetMiddle(string s)
        {
            return s.Length % 2 != 0 ? s[s.Length / 2].ToString() : s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
        }

        public static double FindAverage(double[] array)
        {
            double result = 0;
            if (array.Length != 0)
            {
                foreach (var item in array)
                    result+= item;

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