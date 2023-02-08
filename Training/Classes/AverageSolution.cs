namespace Training.Classes
{
    public class AverageSolution
    {
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
    }
}