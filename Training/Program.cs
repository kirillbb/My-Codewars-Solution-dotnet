namespace Training
{
    public static class Program
    {
        static void Main(string[] args)
        {

        }

        //FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 });
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

        //MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
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